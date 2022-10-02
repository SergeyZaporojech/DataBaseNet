namespace DataBaseNet
{
    partial class EditProductForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDiscription = new System.Windows.Forms.TextBox();
            this.lvImages = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddImage = new System.Windows.Forms.Button();
            this.btnEditProduct = new System.Windows.Forms.Button();
            this.btnCansel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Назва";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 61);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(226, 27);
            this.txtName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ціна";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(12, 144);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(226, 27);
            this.txtPrice.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(297, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Опис";
            // 
            // txtDiscription
            // 
            this.txtDiscription.Location = new System.Drawing.Point(297, 61);
            this.txtDiscription.Multiline = true;
            this.txtDiscription.Name = "txtDiscription";
            this.txtDiscription.Size = new System.Drawing.Size(270, 68);
            this.txtDiscription.TabIndex = 1;
            // 
            // lvImages
            // 
            this.lvImages.Location = new System.Drawing.Point(7, 26);
            this.lvImages.Name = "lvImages";
            this.lvImages.Size = new System.Drawing.Size(576, 139);
            this.lvImages.TabIndex = 2;
            this.lvImages.UseCompatibleStateImageBehavior = false;
            this.lvImages.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.lvImages_ItemDrag);
            this.lvImages.DragDrop += new System.Windows.Forms.DragEventHandler(this.lvImages_DragDrop);
            this.lvImages.DragEnter += new System.Windows.Forms.DragEventHandler(this.lvImages_DragEnter);
            this.lvImages.DragOver += new System.Windows.Forms.DragEventHandler(this.lvImages_DragOver);
            this.lvImages.DragLeave += new System.EventHandler(this.lvImages_DragLeave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddImage);
            this.groupBox1.Controls.Add(this.lvImages);
            this.groupBox1.Location = new System.Drawing.Point(12, 198);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(740, 199);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Фото";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnAddImage
            // 
            this.btnAddImage.Location = new System.Drawing.Point(616, 26);
            this.btnAddImage.Name = "btnAddImage";
            this.btnAddImage.Size = new System.Drawing.Size(94, 29);
            this.btnAddImage.TabIndex = 3;
            this.btnAddImage.Text = "Додати";
            this.btnAddImage.UseVisualStyleBackColor = true;
            this.btnAddImage.Click += new System.EventHandler(this.btnAddImage_Click);
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.Location = new System.Drawing.Point(663, 43);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(94, 29);
            this.btnEditProduct.TabIndex = 4;
            this.btnEditProduct.Text = "Змінити";
            this.btnEditProduct.UseVisualStyleBackColor = true;
            this.btnEditProduct.Click += new System.EventHandler(this.btnEditProduct_Click);
            // 
            // btnCansel
            // 
            this.btnCansel.Location = new System.Drawing.Point(663, 100);
            this.btnCansel.Name = "btnCansel";
            this.btnCansel.Size = new System.Drawing.Size(94, 29);
            this.btnCansel.TabIndex = 5;
            this.btnCansel.Text = "Скасувати";
            this.btnCansel.UseVisualStyleBackColor = true;
            this.btnCansel.Click += new System.EventHandler(this.btnCansel_Click);
            // 
            // EditProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 450);
            this.Controls.Add(this.btnCansel);
            this.Controls.Add(this.btnEditProduct);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtDiscription);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditProductForm";
            this.Text = "Редагування товару";
            this.Load += new System.EventHandler(this.EditProductForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private Label label2;
        private TextBox txtPrice;
        private Label label3;
        private TextBox txtDiscription;
        private ListView lvImages;
        private GroupBox groupBox1;
        private Button btnAddImage;
        private Button btnEditProduct;
        private Button btnCansel;
    }
}