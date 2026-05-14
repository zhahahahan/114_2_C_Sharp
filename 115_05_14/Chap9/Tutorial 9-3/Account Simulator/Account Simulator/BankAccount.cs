using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_Simulator
{
    class BankAccount
    {
        // 帳戶餘額欄位
        private decimal balance;

        // 建構子：使用傳入的初始餘額建立帳戶
        public BankAccount(decimal initialBalance)
        {
            balance = initialBalance;
        }

        // 取得目前餘額（唯讀）
        public decimal Balance
        {
            get { return balance; }
        }

        // 存款方法：金額必須為正數，否則拋出例外
        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                balance += amount;
            }
            else
            {
                // 傳回中文錯誤訊息，表示存款金額需為正數
                throw new ArgumentException("存款金額必須為正數。");
            }
        }

        // 提款方法：金額必須為正數且不可超過目前餘額
        public void Withdraw(decimal amount)
        {
            if (amount > 0)
            {
                if (amount <= balance)
                {
                    balance -= amount;
                }
                else
                {
                    // 傳回中文錯誤訊息，表示餘額不足
                    throw new InvalidOperationException("餘額不足，無法提款。");
                }
            }
            else
            {
                // 傳回中文錯誤訊息，表示提款金額需為正數
                throw new ArgumentException("提款金額必須為正數。");
            }
        }
    }
}
