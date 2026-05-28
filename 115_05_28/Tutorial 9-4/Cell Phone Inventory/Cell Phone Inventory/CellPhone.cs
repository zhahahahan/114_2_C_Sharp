using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cell_Phone_Inventory
{
    class CellPhone
    {
        // 欄位宣告
        private string _brand;   // 手機的品牌
        private string _model;   // 手機的型號
        private decimal _price;  // 零售價格

        // 建構函式 - 初始化所有欄位
        public CellPhone()
        {
            _brand = "";
            _model = "";
            _price = 0m;
        }

        // 品牌屬性 - 用來獲取和設定手機的品牌
        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }

        // 型號屬性 - 用來獲取和設定手機的型號
        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        // 價格屬性 - 用來獲取和設定手機的零售價格
        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }
    }
}
