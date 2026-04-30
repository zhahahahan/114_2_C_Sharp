using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Phonebook
{
    struct PhoneBookEntry
    {
        public string name;
        public string phone;
    }

    public partial class Form1 : Form
    {
        // Field to hold a list of PhoneBookEntry objects.
        private List<PhoneBookEntry> phoneList = 
            new List<PhoneBookEntry>();

        public Form1()
        {
            InitializeComponent();
        }

        // The ReadFile method reads the contents of the
        // PhoneList.txt file and stores it as PhoneBookEntry
        // objects in the phoneList.
        private void ReadFile()
        {
            // Declare a variable of type StreamReader to
            // read from the PhoneList.txt file.
            StreamReader inputFile;

            // Add a using directive for System.IO.

            try
            {
                // Create a new StreamReader instance, using a
                // Stream obtained from the Assembly's ResourceManager.
                // Be sure to use the correct namespace and file name.

                // Phonebook.Properties.Resources.PhoneList is the default location
                // for embedded resources in a C# project. Adjust the path if
                // your file is located elsewhere.

                inputFile = new StreamReader(
                    new MemoryStream(Phonebook.Properties.Resources.PhoneList));

                string line;
                // Read each line of the file until the end is reached.
                while ((line = inputFile.ReadLine()) != null)
                {
                    // Split the line into parts using the comma as a separator.
                    string[] parts = line.Split(',');

                    // Create a new PhoneBookEntry object and populate its fields.
                    PhoneBookEntry entry = new PhoneBookEntry();
                    entry.name = parts[0];
                    entry.phone = parts[1];

                    // Add the new entry to the phoneList.
                    phoneList.Add(entry);
                }

                // Close the file when done.
                inputFile.Close();
            }
            catch (Exception ex)
            {
                // Display an error message if the file cannot be read.
                MessageBox.Show("無法讀取電話簿檔案：" + ex.Message);
            }
        }

        // The DisplayNames method displays the list of names
        // in the namesListBox control.
        private void DisplayNames()
        {
            nameListBox.Items.Clear(); // Clear any existing items.

            // Add each name in the phoneList to the list box.
            foreach (PhoneBookEntry entry in phoneList)
            {
                nameListBox.Items.Add(entry.name);
            }

            // Optionally, select the first item by default.
            if (phoneList.Count > 0)
            {
                nameListBox.SelectedIndex = 0;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ReadFile();   // Read the phone list from the file.
            DisplayNames(); // Display the names in the list box.
        }

        private void nameListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the index of the selected item.
            int selectedIndex = nameListBox.SelectedIndex;

            // Check if the index is valid.
            if (selectedIndex >= 0 && selectedIndex < phoneList.Count)
            {
                // Display the corresponding phone number.
                phoneLabel.Text = phoneList[selectedIndex].phone;
            }
            else
            {
                // Clear the phone label if the selection is invalid.
                phoneLabel.Text = "";
            }   
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
