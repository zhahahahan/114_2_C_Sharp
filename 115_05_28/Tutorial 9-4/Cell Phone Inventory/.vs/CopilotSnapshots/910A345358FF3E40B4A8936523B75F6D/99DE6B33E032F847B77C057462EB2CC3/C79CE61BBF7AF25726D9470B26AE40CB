using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cell_Phone_Inventory
{
    public partial class Form1 : Form
    {
        // 用來存儲 CellPhone 物件的清單
        List<CellPhone> phoneList = new List<CellPhone>();

        public Form1()
        {
            InitializeComponent();
        }

        // 此方法用於取得手機資料
        // 接收一個 CellPhone 物件作為參數
        // 將使用者輸入的資料指派給物件的屬性
        private void GetPhoneData(CellPhone phone)
        {
            // 暫時變數，用來存儲價格
            decimal price;

            // 取得手機的品牌
            phone.Brand = brandTextBox.Text;

            // 取得手機的型號
            phone.Model = modelTextBox.Text;

            // 取得手機的價格
            // 嘗試將輸入的文字轉換為十進位數
            if (decimal.TryParse(priceTextBox.Text, out price))
            {
                phone.Price = price;
            }
            else
            {
                // 顯示錯誤訊息
                MessageBox.Show("無效的價格");
            }
        }

        // 新增手機按鈕的點擊事件處理程式
        // 此方法會建立新的手機物件，取得使用者輸入的資料，
        // 並將其添加到清單中
        private void addPhoneButton_Click(object sender, EventArgs e)
        {
            // 建立新的 CellPhone 物件
            CellPhone myPhone = new CellPhone();

            // 呼叫 GetPhoneData 方法取得使用者輸入的資料
            GetPhoneData(myPhone);

            // 將手機物件添加到清單
            phoneList.Add(myPhone);

            // 將新手機資料添加到清單框顯示
            // 顯示格式為：品牌 + 型號
            phoneListBox.Items.Add(myPhone.Brand + " " + myPhone.Model);

            // 清空所有輸入框中的文字
            brandTextBox.Clear();
            modelTextBox.Clear();
            priceTextBox.Clear();

            // 回到品牌輸入框，準備輸入下一支手機
            brandTextBox.Focus();
        }

        // 手機清單框的索引改變事件處理程式
        // 當使用者在清單中選擇不同的手機時，此方法會被執行
        private void phoneListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 取得清單中目前選擇的項目索引
            int index = phoneListBox.SelectedIndex;

            // 檢查是否有有效的選擇（索引不為 -1）
            if (index != -1)
            {
                // 根據索引從 phoneList 中取得對應的手機物件
                CellPhone selectedPhone = phoneList[index];

                // 顯示選中手機的價格訊息框
                MessageBox.Show("價格：" + selectedPhone.Price);
            }
        }

        // 結束按鈕的點擊事件處理程式
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}
