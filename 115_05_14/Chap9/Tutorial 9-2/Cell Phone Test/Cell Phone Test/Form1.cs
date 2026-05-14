using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cell_Phone_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // GetPhoneData 方法接收一個 CellPhone 物件作為參數。
        // 此方法會將使用者輸入的資料指定給該物件的屬性。
        private void GetPhoneData(CellPhone phone)
        {
            phone.Brand = brandTextBox.Text;
            phone.Model = modelTextBox.Text;
            if (decimal.TryParse(priceTextBox.Text, out decimal price))
            {
                phone.Price = price;
            }
            else
            {
                MessageBox.Show("請輸入有效的價格。");
                phone.Price = 0;
            }
        }

        private void createObjectButton_Click(object sender, EventArgs e)
        {
            CellPhone myPhone = new CellPhone();

            GetPhoneData(myPhone);

            brandLabel.Text = myPhone.Brand;
            modelLabel.Text = myPhone.Model;
            priceLabel.Text = myPhone.Price.ToString("C");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉視窗。
            this.Close();
        }
    }
}
