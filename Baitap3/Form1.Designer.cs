namespace Baitap3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtProductID = new TextBox();
            txtOrigin = new TextBox();
            txtPrice = new TextBox();
            txtQuantity = new TextBox();
            txtName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            dtpExpirationDate = new DateTimePicker();
            label8 = new Label();
            pictureBox2 = new PictureBox();
            dgvProducts = new DataGridView();
            ProductID = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Origin = new DataGridViewTextBoxColumn();
            ExpiredDate = new DataGridViewTextBoxColumn();
            btnPriceInRange = new Button();
            txtMinPrice = new TextBox();
            txtMaxPrice = new TextBox();
            btnAdd = new Button();
            btnDelete = new Button();
            ExpensivePrice = new Button();
            ProductFromJP = new Button();
            ExpiredProducts = new Button();
            btnCheckExpiredDate = new Button();
            btnDeleteExpiredProducts = new Button();
            btbDeleteFromOrigin = new Button();
            txtDeleteFromOrigin = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // txtProductID
            // 
            txtProductID.Location = new Point(146, 67);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new Size(260, 27);
            txtProductID.TabIndex = 1;
            // 
            // txtOrigin
            // 
            txtOrigin.Location = new Point(146, 307);
            txtOrigin.Name = "txtOrigin";
            txtOrigin.Size = new Size(260, 27);
            txtOrigin.TabIndex = 3;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(146, 247);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(260, 27);
            txtPrice.TabIndex = 4;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(146, 187);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(260, 27);
            txtQuantity.TabIndex = 5;
            // 
            // txtName
            // 
            txtName.Location = new Point(146, 123);
            txtName.Name = "txtName";
            txtName.Size = new Size(260, 27);
            txtName.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 70);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 7;
            label1.Text = "Mã SP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 130);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 8;
            label2.Text = "Tên SP";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 310);
            label3.Name = "label3";
            label3.Size = new Size(59, 20);
            label3.TabIndex = 9;
            label3.Text = "Xuất xứ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 250);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 10;
            label4.Text = "Đơn giá";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 190);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 11;
            label5.Text = "Số lượng";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(36, 370);
            label6.Name = "label6";
            label6.Size = new Size(97, 20);
            label6.TabIndex = 12;
            label6.Text = "Ngày hết hạn";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(146, 9);
            label7.Name = "label7";
            label7.Size = new Size(177, 20);
            label7.TabIndex = 13;
            label7.Text = "Nhập thông tin sản phẩm";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(431, 453);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // dtpExpirationDate
            // 
            dtpExpirationDate.Location = new Point(146, 365);
            dtpExpirationDate.Name = "dtpExpirationDate";
            dtpExpirationDate.Size = new Size(260, 27);
            dtpExpirationDate.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(740, 9);
            label8.Name = "label8";
            label8.Size = new Size(177, 20);
            label8.TabIndex = 16;
            label8.Text = "Chọn chức năng tìm kiếm";
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(460, 21);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(710, 453);
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // dgvProducts
            // 
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Columns.AddRange(new DataGridViewColumn[] { ProductID, ProductName, Quantity, Price, Origin, ExpiredDate });
            dgvProducts.Location = new Point(12, 480);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.Size = new Size(830, 415);
            dgvProducts.TabIndex = 18;
            // 
            // ProductID
            // 
            ProductID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ProductID.FillWeight = 55.8288765F;
            ProductID.HeaderText = "Mã SP";
            ProductID.MinimumWidth = 6;
            ProductID.Name = "ProductID";
            ProductID.ReadOnly = true;
            ProductID.Resizable = DataGridViewTriState.False;
            // 
            // ProductName
            // 
            ProductName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ProductName.FillWeight = 55.8288765F;
            ProductName.HeaderText = "Tên SP";
            ProductName.MinimumWidth = 6;
            ProductName.Name = "ProductName";
            ProductName.ReadOnly = true;
            ProductName.Resizable = DataGridViewTriState.False;
            // 
            // Quantity
            // 
            Quantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Quantity.FillWeight = 320.855621F;
            Quantity.HeaderText = "Số lượng";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            Quantity.ReadOnly = true;
            Quantity.Resizable = DataGridViewTriState.False;
            // 
            // Price
            // 
            Price.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Price.FillWeight = 55.8288765F;
            Price.HeaderText = "Đơn giá";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            Price.ReadOnly = true;
            Price.Resizable = DataGridViewTriState.False;
            // 
            // Origin
            // 
            Origin.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Origin.FillWeight = 55.8288765F;
            Origin.HeaderText = "Xuất xứ";
            Origin.MinimumWidth = 6;
            Origin.Name = "Origin";
            Origin.ReadOnly = true;
            Origin.Resizable = DataGridViewTriState.False;
            // 
            // ExpiredDate
            // 
            ExpiredDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ExpiredDate.FillWeight = 55.8288765F;
            ExpiredDate.HeaderText = "Ngày hết hạn";
            ExpiredDate.MinimumWidth = 6;
            ExpiredDate.Name = "ExpiredDate";
            ExpiredDate.ReadOnly = true;
            ExpiredDate.Resizable = DataGridViewTriState.False;
            // 
            // btnPriceInRange
            // 
            btnPriceInRange.Location = new Point(906, 51);
            btnPriceInRange.Name = "btnPriceInRange";
            btnPriceInRange.Size = new Size(111, 58);
            btnPriceInRange.TabIndex = 22;
            btnPriceInRange.Text = "Xuất các SP có ĐG [a ... b]";
            btnPriceInRange.UseVisualStyleBackColor = true;
            btnPriceInRange.Click += btn_btnPriceInRange_Click;
            // 
            // txtMinPrice
            // 
            txtMinPrice.Location = new Point(1031, 70);
            txtMinPrice.Name = "txtMinPrice";
            txtMinPrice.Size = new Size(52, 27);
            txtMinPrice.TabIndex = 23;
            // 
            // txtMaxPrice
            // 
            txtMaxPrice.Location = new Point(1097, 70);
            txtMaxPrice.Name = "txtMaxPrice";
            txtMaxPrice.Size = new Size(52, 27);
            txtMaxPrice.TabIndex = 24;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(146, 420);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(125, 45);
            btnAdd.TabIndex = 25;
            btnAdd.Text = "Lưu SP";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btn_Add_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(870, 792);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(130, 60);
            btnDelete.TabIndex = 26;
            btnDelete.Text = "Xóa toàn bộ SP";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btn_Delete_Click;
            // 
            // ExpensivePrice
            // 
            ExpensivePrice.Location = new Point(474, 51);
            ExpensivePrice.Name = "ExpensivePrice";
            ExpensivePrice.Size = new Size(111, 58);
            ExpensivePrice.TabIndex = 27;
            ExpensivePrice.Text = "1 SP có ĐG cao nhất";
            ExpensivePrice.UseVisualStyleBackColor = true;
            ExpensivePrice.Click += ExpensivePrice_Click;
            // 
            // ProductFromJP
            // 
            ProductFromJP.Location = new Point(591, 54);
            ProductFromJP.Name = "ProductFromJP";
            ProductFromJP.Size = new Size(111, 58);
            ProductFromJP.TabIndex = 28;
            ProductFromJP.Text = "1 SP từ Nhật Bản";
            ProductFromJP.UseVisualStyleBackColor = true;
            ProductFromJP.Click += ProductFromJP_Click;
            // 
            // ExpiredProducts
            // 
            ExpiredProducts.Location = new Point(708, 54);
            ExpiredProducts.Name = "ExpiredProducts";
            ExpiredProducts.Size = new Size(111, 58);
            ExpiredProducts.TabIndex = 29;
            ExpiredProducts.Text = "Xuất SP quá hạn";
            ExpiredProducts.UseVisualStyleBackColor = true;
            ExpiredProducts.Click += ExpiredProducts_Click;
            // 
            // btnCheckExpiredDate
            // 
            btnCheckExpiredDate.Location = new Point(870, 655);
            btnCheckExpiredDate.Name = "btnCheckExpiredDate";
            btnCheckExpiredDate.Size = new Size(292, 68);
            btnCheckExpiredDate.TabIndex = 30;
            btnCheckExpiredDate.Text = "Kiểm tra kho có SP quá hạn hay k";
            btnCheckExpiredDate.UseVisualStyleBackColor = true;
            btnCheckExpiredDate.Click += btnCheckExpiredDate_Click;
            // 
            // btnDeleteExpiredProducts
            // 
            btnDeleteExpiredProducts.Location = new Point(1031, 792);
            btnDeleteExpiredProducts.Name = "btnDeleteExpiredProducts";
            btnDeleteExpiredProducts.Size = new Size(130, 60);
            btnDeleteExpiredProducts.TabIndex = 32;
            btnDeleteExpiredProducts.Text = "Xóa toàn bộ SP quá hạn";
            btnDeleteExpiredProducts.UseVisualStyleBackColor = true;
            btnDeleteExpiredProducts.Click += btnDeleteExpiredProducts_Click;
            // 
            // btbDeleteFromOrigin
            // 
            btbDeleteFromOrigin.Location = new Point(870, 480);
            btbDeleteFromOrigin.Name = "btbDeleteFromOrigin";
            btbDeleteFromOrigin.Size = new Size(147, 68);
            btbDeleteFromOrigin.TabIndex = 33;
            btbDeleteFromOrigin.Text = "Xóa SP theo xuất xứ";
            btbDeleteFromOrigin.UseVisualStyleBackColor = true;
            btbDeleteFromOrigin.Click += btbDeleteFromOrigin_Click;
            // 
            // txtDeleteFromOrigin
            // 
            txtDeleteFromOrigin.Location = new Point(1031, 501);
            txtDeleteFromOrigin.Name = "txtDeleteFromOrigin";
            txtDeleteFromOrigin.Size = new Size(130, 27);
            txtDeleteFromOrigin.TabIndex = 35;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 907);
            Controls.Add(txtDeleteFromOrigin);
            Controls.Add(btbDeleteFromOrigin);
            Controls.Add(btnDeleteExpiredProducts);
            Controls.Add(btnCheckExpiredDate);
            Controls.Add(ExpiredProducts);
            Controls.Add(ProductFromJP);
            Controls.Add(ExpensivePrice);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(txtMaxPrice);
            Controls.Add(txtMinPrice);
            Controls.Add(btnPriceInRange);
            Controls.Add(dgvProducts);
            Controls.Add(dtpExpirationDate);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtName);
            Controls.Add(txtQuantity);
            Controls.Add(txtPrice);
            Controls.Add(txtOrigin);
            Controls.Add(txtProductID);
            Controls.Add(pictureBox1);
            Controls.Add(label8);
            Controls.Add(pictureBox2);
            Name = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtProductID;
        private TextBox txtOrigin;
        private TextBox txtPrice;
        private TextBox txtQuantity;
        private TextBox txtName;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private PictureBox pictureBox1;
        private DateTimePicker dtpExpirationDate;
        private Label label8;
        private PictureBox pictureBox2;
        private DataGridView dgvProducts;

        private Button btnPriceInRange;
        private TextBox txtMinPrice;
        private TextBox txtMaxPrice;
        private Button btnAdd;
        private Button btnDelete;
        private Button ExpensivePrice;
        private Button ProductFromJP;
        private Button ExpiredProducts;
        private DataGridViewTextBoxColumn ProductID;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Origin;
        private DataGridViewTextBoxColumn ExpiredDate;
        private Button btnCheckExpiredDate;
        private Button btnDeleteExpiredProducts;
        private Button btbDeleteFromOrigin;
        private TextBox txtDeleteFromOrigin;
    }
}
