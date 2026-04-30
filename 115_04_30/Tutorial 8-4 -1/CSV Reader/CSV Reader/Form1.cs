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

namespace CSV_Reader
{
    struct Student
    {
        public string Class;
        public string Id;
        public string name;
        public int[] Score;
    }
    
    public partial class Form1 : Form
    {
        private List<Student> gradeBook = new List<Student>();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void getScoresButton_Click(object sender, EventArgs e)
        {
            try
            {
                gradeBook.Clear();
                averagesListBox.Items.Clear();
                
                char[] delim = { ',' };

                using (StreamReader inputFile = File.OpenText("Grades.csv"))
                {
                    string line;
                    while (!inputFile.EndOfStream)
                    {
                        line = inputFile.ReadLine();
                        string[] fields = line.Split(delim);
                        
                        if (fields.Length == 5)
                        {
                            Student student = new Student();
                            student.Class = fields[0];
                            student.Id = fields[1];
                            student.name = fields[2];
                            
                            int[] scores = new int[2];
                            scores[0] = int.Parse(fields[3]);
                            scores[1] = int.Parse(fields[4]);
                            student.Score = scores;
                            
                            gradeBook.Add(student);
                            
                            int total = scores[0] + scores[1];
                            double average = (double)total / 2;
                            averagesListBox.Items.Add("平均成績:" + average.ToString("F2"));
                        }
                        else
                        {
                            MessageBox.Show("資料格式錯誤: " + line);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("讀取 CSV 檔案時發生錯誤: " + ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
