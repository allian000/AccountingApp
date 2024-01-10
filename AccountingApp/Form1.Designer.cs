
namespace AccountingApp
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
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
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.ItemSellLabel = new System.Windows.Forms.Label();
            this.ItemsList = new System.Windows.Forms.ComboBox();
            this.AddSellItemButton = new System.Windows.Forms.Button();
            this.ItemSellList = new System.Windows.Forms.ListView();
            this.DelSellItemButton = new System.Windows.Forms.Button();
            this.displayTotal = new System.Windows.Forms.Label();
            this.checkout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ItemSellLabel
            // 
            this.ItemSellLabel.AutoSize = true;
            this.ItemSellLabel.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ItemSellLabel.Location = new System.Drawing.Point(35, 38);
            this.ItemSellLabel.Name = "ItemSellLabel";
            this.ItemSellLabel.Size = new System.Drawing.Size(60, 24);
            this.ItemSellLabel.TabIndex = 0;
            this.ItemSellLabel.Text = "商品";
            // 
            // ItemsList
            // 
            this.ItemsList.FormattingEnabled = true;
            this.ItemsList.Location = new System.Drawing.Point(269, 79);
            this.ItemsList.Name = "ItemsList";
            this.ItemsList.Size = new System.Drawing.Size(121, 20);
            this.ItemsList.TabIndex = 5;
            // 
            // AddSellItemButton
            // 
            this.AddSellItemButton.Location = new System.Drawing.Point(269, 114);
            this.AddSellItemButton.Name = "AddSellItemButton";
            this.AddSellItemButton.Size = new System.Drawing.Size(142, 59);
            this.AddSellItemButton.TabIndex = 6;
            this.AddSellItemButton.Text = "新增";
            this.AddSellItemButton.UseVisualStyleBackColor = true;
            this.AddSellItemButton.Click += new System.EventHandler(this.AddSellItemButton_Click);
            // 
            // ItemSellList
            // 
            this.ItemSellList.Font = new System.Drawing.Font("新細明體", 14F);
            this.ItemSellList.HideSelection = false;
            this.ItemSellList.HoverSelection = true;
            this.ItemSellList.Location = new System.Drawing.Point(39, 78);
            this.ItemSellList.Name = "ItemSellList";
            this.ItemSellList.Size = new System.Drawing.Size(209, 247);
            this.ItemSellList.TabIndex = 7;
            this.ItemSellList.UseCompatibleStateImageBehavior = false;
            this.ItemSellList.View = System.Windows.Forms.View.List;
            // 
            // DelSellItemButton
            // 
            this.DelSellItemButton.Location = new System.Drawing.Point(269, 191);
            this.DelSellItemButton.Name = "DelSellItemButton";
            this.DelSellItemButton.Size = new System.Drawing.Size(142, 59);
            this.DelSellItemButton.TabIndex = 8;
            this.DelSellItemButton.Text = "刪除";
            this.DelSellItemButton.UseVisualStyleBackColor = true;
            this.DelSellItemButton.Click += new System.EventHandler(this.DelSellItemButton_Click);
            // 
            // displayTotal
            // 
            this.displayTotal.AutoSize = true;
            this.displayTotal.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.displayTotal.Location = new System.Drawing.Point(35, 342);
            this.displayTotal.Name = "displayTotal";
            this.displayTotal.Size = new System.Drawing.Size(143, 21);
            this.displayTotal.TabIndex = 9;
            this.displayTotal.Text = "此訂單總價: 0";
            // 
            // checkout
            // 
            this.checkout.Location = new System.Drawing.Point(269, 266);
            this.checkout.Name = "checkout";
            this.checkout.Size = new System.Drawing.Size(142, 59);
            this.checkout.TabIndex = 10;
            this.checkout.Text = "完成";
            this.checkout.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkout);
            this.Controls.Add(this.displayTotal);
            this.Controls.Add(this.DelSellItemButton);
            this.Controls.Add(this.ItemSellList);
            this.Controls.Add(this.AddSellItemButton);
            this.Controls.Add(this.ItemsList);
            this.Controls.Add(this.ItemSellLabel);
            this.Name = "Form1";
            this.Text = "記帳程式";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ItemSellLabel;
        private System.Windows.Forms.ComboBox ItemsList;
        private System.Windows.Forms.Button AddSellItemButton;
        private System.Windows.Forms.ListView ItemSellList;
        private System.Windows.Forms.Button DelSellItemButton;
        private System.Windows.Forms.Label displayTotal;
        private System.Windows.Forms.Button checkout;
    }
}

