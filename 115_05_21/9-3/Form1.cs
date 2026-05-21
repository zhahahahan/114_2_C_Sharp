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
        // BankAccount 欄位，稍後在表單載入時初始化為預設帳戶（初始餘額 1000）
        private BankAccount account;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 在表單載入時建立一個範例帳戶，初始餘額設為 1000
            // 帳戶編號與名稱此處使用範例值；實作可依需求擴充 UI 讓使用者輸入
            account = new BankAccount("0001", "使用者", 1000m);

            // 顯示起始餘額
            UpdateBalanceDisplay();
        }

        /// <summary>
        /// 更新畫面上顯示的餘額文字（使用系統貨幣格式）。
        /// </summary>
        private void UpdateBalanceDisplay()
        {
            // balanceLabel 為設計器產生的 Label，顯示帳戶餘額
            if (account != null)
            {
                balanceLabel.Text = account.Balance.ToString("C2");
            }
            else
            {
                balanceLabel.Text = (0m).ToString("C2");
            }
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            // 讀取存款輸入並驗證
            if (decimal.TryParse(depositTextBox.Text, out decimal amount))
            {
                try
                {
                    account.Deposit(amount);
                    UpdateBalanceDisplay();
                    depositTextBox.Clear();
                }
                catch (ArgumentException ex)
                {
                    // 顯示錯誤訊息（繁體中文），告知使用者輸入需大於零
                    MessageBox.Show(ex.Message, "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("請輸入有效的金額。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            // 讀取提款輸入並驗證
            if (decimal.TryParse(withdrawTextBox.Text, out decimal amount))
            {
                try
                {
                    bool success = account.Withdraw(amount);
                    if (success)
                    {
                        UpdateBalanceDisplay();
                        withdrawTextBox.Clear();
                    }
                    else
                    {
                        // 餘額不足，通知使用者
                        MessageBox.Show("餘額不足，無法完成提款。", "提款失敗", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (ArgumentException ex)
                {
                    // 顯示錯誤訊息（繁體中文），告知使用者輸入需大於零
                    MessageBox.Show(ex.Message, "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("請輸入有效的金額。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// 建立帳戶按鈕事件處理器：從表單三個輸入欄位讀取帳號、姓名與開戶金額，
        /// 若金額可解析則建立新的 BankAccount，並更新餘額顯示；否則顯示錯誤訊息。
        /// 另外：建立成功後會清除輸入欄並顯示存/提群組控制項。
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            // 讀取開戶金額並驗證
            if (decimal.TryParse(textBox3.Text, out decimal initialAmount))
            {
                string acctNum = textBox1.Text ?? string.Empty;
                string ownerName = textBox2.Text ?? string.Empty;

                // 建立新的帳戶物件
                account = new BankAccount(acctNum, ownerName, initialAmount);

                // 顯示 帳號、姓名、餘額（以換行分隔）
                balanceLabel.Text = acctNum + Environment.NewLine + ownerName + Environment.NewLine + account.Balance.ToString("C");

                // 清除輸入框
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();

                // 顯示存款與提款的相關控制項（若之前隱藏）
                depositGroupBox.Visible = true;
                groupBox1.Visible = true;

                MessageBox.Show("已成功建立帳戶。", "建立成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("請輸入有效的開戶金額。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }

        private void balanceDescriptionLabel_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
