namespace DataBaseNet
{
    partial class ProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lvProducts = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnRemoveProduct = new System.Windows.Forms.Button();
            this.btnEditProduct = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvProducts
            // 
            this.lvProducts.Location = new System.Drawing.Point(12, 68);
            this.lvProducts.MultiSelect = false;
            this.lvProducts.Name = "lvProducts";
            this.lvProducts.Size = new System.Drawing.Size(775, 370);
            this.lvProducts.TabIndex = 0;
            this.lvProducts.UseCompatibleStateImageBehavior = false;
            this.lvProducts.InsertionMark.Color = Color.Green;
            this.lvProducts.AllowDrop = true;
            this.lvProducts.ItemDrag += new ItemDragEventHandler(lvProducts_ItemDrag);
            this.lvProducts.DragEnter += new DragEventHandler(lvProducts_DragEnter);
            this.lvProducts.DragOver += new DragEventHandler(lvProducts_DragOver);
            this.lvProducts.DragLeave += new EventHandler(lvProducts_DragLeave);
            this.lvProducts.DragDrop += new DragEventHandler(lvProducts_DragDrop);
            this.lvProducts.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvProducts_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(24, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Список продуктів";
            // 
            // btnUsers
            // 
            this.btnUsers.Location = new System.Drawing.Point(824, 390);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(118, 29);
            this.btnUsers.TabIndex = 2;
            this.btnUsers.Text = "Користувачі";
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(810, 68);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(132, 29);
            this.btnAddProduct.TabIndex = 3;
            this.btnAddProduct.Text = "Додати";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnRemoveProduct
            // 
            this.btnRemoveProduct.Location = new System.Drawing.Point(810, 115);
            this.btnRemoveProduct.Name = "btnRemoveProduct";
            this.btnRemoveProduct.Size = new System.Drawing.Size(132, 29);
            this.btnRemoveProduct.TabIndex = 4;
            this.btnRemoveProduct.Text = "Видалити";
            this.btnRemoveProduct.UseVisualStyleBackColor = true;
            this.btnRemoveProduct.Click += new System.EventHandler(this.btnRemoveProduct_Click);
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.Location = new System.Drawing.Point(810, 167);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(132, 33);
            this.btnEditProduct.TabIndex = 5;
            this.btnEditProduct.Text = "Редагувати";
            this.btnEditProduct.UseVisualStyleBackColor = true;
            this.btnEditProduct.Click += new System.EventHandler(this.btnEditProduct_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(810, 223);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(132, 50);
            this.btnInfo.TabIndex = 6;
            this.btnInfo.Text = "Інформація про товар";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 450);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnEditProduct);
            this.Controls.Add(this.btnRemoveProduct);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.btnUsers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvProducts);
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView lvProducts;
        private Label label1;
        private Button btnUsers;
        private Button btnAddProduct;
        private Button btnRemoveProduct;
        private Button btnEditProduct;
        private Button btnInfo;
    }
}