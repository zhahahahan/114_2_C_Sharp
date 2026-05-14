using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Account_Simulator
{
    public partial class Form1 : Form
    {
        // 帳戶欄位，使用 $1000 作為初始餘額
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 顯示初始餘額
            
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            // 存款按鈕：將使用者輸入的金額存入帳戶（若實作）
           
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            // 提款按鈕：將使用者輸入的金額從帳戶扣款（若實作）
           
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}
