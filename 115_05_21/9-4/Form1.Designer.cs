namespace Cell_Phone_Inventory
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除所使用的任何資源。
        /// </summary>
        /// <param name="disposing">如果為 true，表示應該釋放受管理的資源；否則不釋放。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 設計工具所需的方法。請勿使用程式碼編輯器修改
        /// 此方法內的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.enterDataGroupBox = new System.Windows.Forms.GroupBox();
            this.addPhoneButton = new System.Windows.Forms.Button();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.brandTextBox = new System.Windows.Forms.TextBox();
            this.promptPriceLabel = new System.Windows.Forms.Label();
            this.promptModelLabel = new System.Windows.Forms.Label();
            this.promptBrandLabel = new System.Windows.Forms.Label();
            this.listGroupBox = new System.Windows.Forms.GroupBox();
            this.phoneListBox = new System.Windows.Forms.ListBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.enterDataGroupBox.SuspendLayout();
            this.listGroupBox.SuspendLayout();
            this.SuspendLayout();
            //
            // 注意：以下為設計器程式碼調整
            // 已將字型統一設定為 18pt（繁體中文 UI 使用較大字型以利閱讀）
            // 並調整各元件位置與大小，避免元件重疊或擠在一起。
            //
            // 將表單的預設字型設定為 18pt，子控制項會繼承此設定
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // enterDataGroupBox
            // 群組方塊：輸入手機資料（包含品牌、型號、價格與新增按鈕）
            this.enterDataGroupBox.Controls.Add(this.addPhoneButton);
            this.enterDataGroupBox.Controls.Add(this.priceTextBox);
            this.enterDataGroupBox.Controls.Add(this.modelTextBox);
            this.enterDataGroupBox.Controls.Add(this.brandTextBox);
            this.enterDataGroupBox.Controls.Add(this.promptPriceLabel);
            this.enterDataGroupBox.Controls.Add(this.promptModelLabel);
            this.enterDataGroupBox.Controls.Add(this.promptBrandLabel);
            this.enterDataGroupBox.Location = new System.Drawing.Point(12, 12);
            this.enterDataGroupBox.Name = "enterDataGroupBox";
            this.enterDataGroupBox.Size = new System.Drawing.Size(340, 240);
            this.enterDataGroupBox.TabIndex = 5;
            this.enterDataGroupBox.TabStop = false;
            this.enterDataGroupBox.Text = "輸入手機資料"; // 繁體中文標題
            // 
            // addPhoneButton
            // 新增手機按鈕：文字改為繁體中文並放大按鈕尺寸
            this.addPhoneButton.Location = new System.Drawing.Point(110, 186);
            this.addPhoneButton.Name = "addPhoneButton";
            this.addPhoneButton.Size = new System.Drawing.Size(120, 40);
            this.addPhoneButton.TabIndex = 7;
            this.addPhoneButton.Text = "新增手機";
            this.addPhoneButton.UseVisualStyleBackColor = true;
            this.addPhoneButton.Click += new System.EventHandler(this.addPhoneButton_Click);
            // 
            // priceTextBox
            // 價格欄位：增高與增寬以配合大字型
            this.priceTextBox.Location = new System.Drawing.Point(120, 132);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(200, 35);
            this.priceTextBox.TabIndex = 5;
            // 
            // modelTextBox
            // 型號欄位
            this.modelTextBox.Location = new System.Drawing.Point(120, 88);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(200, 35);
            this.modelTextBox.TabIndex = 4;
            // 
            // brandTextBox
            // 品牌欄位
            this.brandTextBox.Location = new System.Drawing.Point(120, 44);
            this.brandTextBox.Name = "brandTextBox";
            this.brandTextBox.Size = new System.Drawing.Size(200, 35);
            this.brandTextBox.TabIndex = 3;
            // 
            // promptPriceLabel
            // 價格提示標籤：改為繁體中文
            this.promptPriceLabel.AutoSize = true;
            this.promptPriceLabel.Location = new System.Drawing.Point(24, 136);
            this.promptPriceLabel.Name = "promptPriceLabel";
            this.promptPriceLabel.Size = new System.Drawing.Size(84, 29);
            this.promptPriceLabel.TabIndex = 2;
            this.promptPriceLabel.Text = "價格：";
            // 
            // promptModelLabel
            // 型號提示標籤：改為繁體中文
            this.promptModelLabel.AutoSize = true;
            this.promptModelLabel.Location = new System.Drawing.Point(24, 92);
            this.promptModelLabel.Name = "promptModelLabel";
            this.promptModelLabel.Size = new System.Drawing.Size(84, 29);
            this.promptModelLabel.TabIndex = 1;
            this.promptModelLabel.Text = "型號：";
            // 
            // promptBrandLabel
            // 品牌提示標籤：改為繁體中文
            this.promptBrandLabel.AutoSize = true;
            this.promptBrandLabel.Location = new System.Drawing.Point(24, 48);
            this.promptBrandLabel.Name = "promptBrandLabel";
            this.promptBrandLabel.Size = new System.Drawing.Size(84, 29);
            this.promptBrandLabel.TabIndex = 0;
            this.promptBrandLabel.Text = "品牌：";
            // 
            // listGroupBox
            // 群組方塊：顯示手機清單
            this.listGroupBox.Controls.Add(this.phoneListBox);
            this.listGroupBox.Location = new System.Drawing.Point(370, 12);
            this.listGroupBox.Name = "listGroupBox";
            this.listGroupBox.Size = new System.Drawing.Size(318, 240);
            this.listGroupBox.TabIndex = 8;
            this.listGroupBox.TabStop = false;
            this.listGroupBox.Text = "選擇手機"; // 繁體中文標題
            // 
            // phoneListBox
            // 列表方塊：顯示已新增的手機項目，大小與字型調整以免截斷文字
            this.phoneListBox.FormattingEnabled = true;
            this.phoneListBox.ItemHeight = 29;
            this.phoneListBox.Location = new System.Drawing.Point(16, 36);
            this.phoneListBox.Name = "phoneListBox";
            this.phoneListBox.Size = new System.Drawing.Size(286, 184);
            this.phoneListBox.TabIndex = 8;
            this.phoneListBox.SelectedIndexChanged += new System.EventHandler(this.phoneListBox_SelectedIndexChanged);
            // 
            // exitButton
            // 離開按鈕：改為繁體中文並放大，置於表單下方以利操作
            this.exitButton.Location = new System.Drawing.Point(310, 264);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(120, 40);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 表單層級設定：調整自動縮放與客戶區大小，並設定表單標題為繁體中文
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 320);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.listGroupBox);
            this.Controls.Add(this.enterDataGroupBox);
            this.Name = "Form1";
            this.Text = "手機庫存管理"; // 繁體中文表單標題
            this.enterDataGroupBox.ResumeLayout(false);
            this.enterDataGroupBox.PerformLayout();
            this.listGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox enterDataGroupBox;
        private System.Windows.Forms.Button addPhoneButton;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.TextBox brandTextBox;
        private System.Windows.Forms.Label promptPriceLabel;
        private System.Windows.Forms.Label promptModelLabel;
        private System.Windows.Forms.Label promptBrandLabel;
        private System.Windows.Forms.GroupBox listGroupBox;
        private System.Windows.Forms.ListBox phoneListBox;
        private System.Windows.Forms.Button exitButton;
    }
}

