namespace ConsignmentShopUI
{
    partial class ConsignmentShop
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.headerText = new System.Windows.Forms.Label();
            this.itemListbox = new System.Windows.Forms.ListBox();
            this.itemsListboxLabel = new System.Windows.Forms.Label();
            this.addToCart = new System.Windows.Forms.Button();
            this.shoppingCartListbox = new System.Windows.Forms.ListBox();
            this.shoppingCartListboxLabel = new System.Windows.Forms.Label();
            this.makePurchase = new System.Windows.Forms.Button();
            this.vendorListbox = new System.Windows.Forms.ListBox();
            this.vendorListboxLable = new System.Windows.Forms.Label();
            this.storeProfitLabel = new System.Windows.Forms.Label();
            this.storeProfitValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // headerText
            // 
            this.headerText.AutoSize = true;
            this.headerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.headerText.Location = new System.Drawing.Point(12, 9);
            this.headerText.Name = "headerText";
            this.headerText.Size = new System.Drawing.Size(343, 44);
            this.headerText.TabIndex = 0;
            this.headerText.Text = "Consignment Shop";
            // 
            // itemListbox
            // 
            this.itemListbox.FormattingEnabled = true;
            this.itemListbox.ItemHeight = 16;
            this.itemListbox.Location = new System.Drawing.Point(20, 104);
            this.itemListbox.Name = "itemListbox";
            this.itemListbox.Size = new System.Drawing.Size(335, 228);
            this.itemListbox.TabIndex = 1;
            // 
            // itemsListboxLabel
            // 
            this.itemsListboxLabel.AutoSize = true;
            this.itemsListboxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.itemsListboxLabel.Location = new System.Drawing.Point(17, 72);
            this.itemsListboxLabel.Name = "itemsListboxLabel";
            this.itemsListboxLabel.Size = new System.Drawing.Size(106, 20);
            this.itemsListboxLabel.TabIndex = 2;
            this.itemsListboxLabel.Text = "Store Items";
            this.itemsListboxLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // addToCart
            // 
            this.addToCart.Location = new System.Drawing.Point(393, 104);
            this.addToCart.Name = "addToCart";
            this.addToCart.Size = new System.Drawing.Size(130, 55);
            this.addToCart.TabIndex = 3;
            this.addToCart.Text = "Add To Cart ->";
            this.addToCart.UseVisualStyleBackColor = true;
            this.addToCart.Click += new System.EventHandler(this.addToCart_Click);
            // 
            // shoppingCartListbox
            // 
            this.shoppingCartListbox.FormattingEnabled = true;
            this.shoppingCartListbox.ItemHeight = 16;
            this.shoppingCartListbox.Location = new System.Drawing.Point(558, 104);
            this.shoppingCartListbox.Name = "shoppingCartListbox";
            this.shoppingCartListbox.Size = new System.Drawing.Size(335, 228);
            this.shoppingCartListbox.TabIndex = 1;
            // 
            // shoppingCartListboxLabel
            // 
            this.shoppingCartListboxLabel.AutoSize = true;
            this.shoppingCartListboxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.shoppingCartListboxLabel.Location = new System.Drawing.Point(554, 72);
            this.shoppingCartListboxLabel.Name = "shoppingCartListboxLabel";
            this.shoppingCartListboxLabel.Size = new System.Drawing.Size(128, 20);
            this.shoppingCartListboxLabel.TabIndex = 2;
            this.shoppingCartListboxLabel.Text = "Shopping Cart";
            this.shoppingCartListboxLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // makePurchase
            // 
            this.makePurchase.Location = new System.Drawing.Point(763, 338);
            this.makePurchase.Name = "makePurchase";
            this.makePurchase.Size = new System.Drawing.Size(130, 55);
            this.makePurchase.TabIndex = 4;
            this.makePurchase.Text = "Purchase";
            this.makePurchase.UseVisualStyleBackColor = true;
            this.makePurchase.Click += new System.EventHandler(this.makePurchase_Click);
            // 
            // vendorListbox
            // 
            this.vendorListbox.FormattingEnabled = true;
            this.vendorListbox.ItemHeight = 16;
            this.vendorListbox.Location = new System.Drawing.Point(20, 415);
            this.vendorListbox.Name = "vendorListbox";
            this.vendorListbox.Size = new System.Drawing.Size(335, 228);
            this.vendorListbox.TabIndex = 1;
            // 
            // vendorListboxLable
            // 
            this.vendorListboxLable.AutoSize = true;
            this.vendorListboxLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vendorListboxLable.Location = new System.Drawing.Point(17, 383);
            this.vendorListboxLable.Name = "vendorListboxLable";
            this.vendorListboxLable.Size = new System.Drawing.Size(78, 20);
            this.vendorListboxLable.TabIndex = 2;
            this.vendorListboxLable.Text = "Vendors";
            this.vendorListboxLable.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // storeProfitLabel
            // 
            this.storeProfitLabel.AutoSize = true;
            this.storeProfitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.storeProfitLabel.Location = new System.Drawing.Point(563, 415);
            this.storeProfitLabel.Name = "storeProfitLabel";
            this.storeProfitLabel.Size = new System.Drawing.Size(112, 20);
            this.storeProfitLabel.TabIndex = 2;
            this.storeProfitLabel.Text = "Store Profit:";
            this.storeProfitLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // storeProfitValue
            // 
            this.storeProfitValue.AutoSize = true;
            this.storeProfitValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.storeProfitValue.Location = new System.Drawing.Point(675, 415);
            this.storeProfitValue.Name = "storeProfitValue";
            this.storeProfitValue.Size = new System.Drawing.Size(60, 20);
            this.storeProfitValue.TabIndex = 2;
            this.storeProfitValue.Text = "$ 0.00";
            this.storeProfitValue.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // ConsignmentShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 701);
            this.Controls.Add(this.makePurchase);
            this.Controls.Add(this.addToCart);
            this.Controls.Add(this.shoppingCartListboxLabel);
            this.Controls.Add(this.shoppingCartListbox);
            this.Controls.Add(this.storeProfitValue);
            this.Controls.Add(this.storeProfitLabel);
            this.Controls.Add(this.vendorListboxLable);
            this.Controls.Add(this.vendorListbox);
            this.Controls.Add(this.itemsListboxLabel);
            this.Controls.Add(this.itemListbox);
            this.Controls.Add(this.headerText);
            this.Name = "ConsignmentShop";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerText;
        private System.Windows.Forms.ListBox itemListbox;
        private System.Windows.Forms.Label itemsListboxLabel;
        private System.Windows.Forms.Button addToCart;
        private System.Windows.Forms.ListBox shoppingCartListbox;
        private System.Windows.Forms.Label shoppingCartListboxLabel;
        private System.Windows.Forms.Button makePurchase;
        private System.Windows.Forms.ListBox vendorListbox;
        private System.Windows.Forms.Label vendorListboxLable;
        private System.Windows.Forms.Label storeProfitLabel;
        private System.Windows.Forms.Label storeProfitValue;
    }
}

