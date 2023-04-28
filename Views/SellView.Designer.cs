namespace Supermarket_mvp.Views
{
    partial class SellView
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
            tabControl1 = new TabControl();
            tabPageSellList = new TabPage();
            BtnClose = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            DgSell = new DataGridView();
            BtnSearch = new Button();
            TxtSearch = new TextBox();
            label11 = new Label();
            tabPageSellDetail = new TabPage();
            txtQuantity = new TextBox();
            txtSubtotal = new TextBox();
            button2 = new Button();
            label2 = new Label();
            button1 = new Button();
            label14 = new Label();
            BtnChooseAnotherPay = new Button();
            BtnChooseAnother = new Button();
            label13 = new Label();
            label12 = new Label();
            BtnCancel = new Button();
            BtnSave = new Button();
            txtSellObservation = new TextBox();
            label10 = new Label();
            txtSellPayMode = new TextBox();
            label9 = new Label();
            txtSellTotal = new TextBox();
            label8 = new Label();
            txtSellCustomerId = new TextBox();
            label7 = new Label();
            txtSellId = new TextBox();
            label6 = new Label();
            DgSellPayMode = new DataGridView();
            DgSellProducts = new DataGridView();
            DgSellCustomers = new DataGridView();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            tabControl1.SuspendLayout();
            tabPageSellList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgSell).BeginInit();
            tabPageSellDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgSellPayMode).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DgSellProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DgSellCustomers).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPageSellList);
            tabControl1.Controls.Add(tabPageSellDetail);
            tabControl1.Location = new Point(0, 103);
            tabControl1.Margin = new Padding(4, 5, 4, 5);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1406, 1100);
            tabControl1.TabIndex = 4;
            // 
            // tabPageSellList
            // 
            tabPageSellList.Controls.Add(BtnClose);
            tabPageSellList.Controls.Add(BtnDelete);
            tabPageSellList.Controls.Add(BtnEdit);
            tabPageSellList.Controls.Add(BtnNew);
            tabPageSellList.Controls.Add(DgSell);
            tabPageSellList.Controls.Add(BtnSearch);
            tabPageSellList.Controls.Add(TxtSearch);
            tabPageSellList.Controls.Add(label11);
            tabPageSellList.Location = new Point(4, 34);
            tabPageSellList.Margin = new Padding(4, 5, 4, 5);
            tabPageSellList.Name = "tabPageSellList";
            tabPageSellList.Padding = new Padding(4, 5, 4, 5);
            tabPageSellList.Size = new Size(1398, 1062);
            tabPageSellList.TabIndex = 0;
            tabPageSellList.Text = "Sell List";
            tabPageSellList.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            BtnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.Location = new Point(1081, 488);
            BtnClose.Margin = new Padding(4, 5, 4, 5);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(244, 98);
            BtnClose.TabIndex = 39;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.Location = new Point(1081, 365);
            BtnDelete.Margin = new Padding(4, 5, 4, 5);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(244, 97);
            BtnDelete.TabIndex = 38;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.Location = new Point(1081, 243);
            BtnEdit.Margin = new Padding(4, 5, 4, 5);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(244, 98);
            BtnEdit.TabIndex = 37;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            BtnNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnNew.Image = Properties.Resources._new;
            BtnNew.Location = new Point(1081, 125);
            BtnNew.Margin = new Padding(4, 5, 4, 5);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(244, 98);
            BtnNew.TabIndex = 36;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // DgSell
            // 
            DgSell.AllowUserToAddRows = false;
            DgSell.AllowUserToDeleteRows = false;
            DgSell.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgSell.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgSell.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgSell.Location = new Point(34, 125);
            DgSell.Margin = new Padding(4, 5, 4, 5);
            DgSell.Name = "DgSell";
            DgSell.ReadOnly = true;
            DgSell.RowHeadersWidth = 62;
            DgSell.RowTemplate.Height = 25;
            DgSell.Size = new Size(1009, 461);
            DgSell.TabIndex = 35;
            // 
            // BtnSearch
            // 
            BtnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSearch.Image = Properties.Resources.search_small;
            BtnSearch.Location = new Point(993, 50);
            BtnSearch.Margin = new Padding(4, 5, 4, 5);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(50, 65);
            BtnSearch.TabIndex = 34;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // TxtSearch
            // 
            TxtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtSearch.Location = new Point(34, 65);
            TxtSearch.Margin = new Padding(4, 5, 4, 5);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to search";
            TxtSearch.Size = new Size(948, 31);
            TxtSearch.TabIndex = 33;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(34, 35);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(146, 25);
            label11.TabIndex = 32;
            label11.Text = "Search Provider";
            // 
            // tabPageSellDetail
            // 
            tabPageSellDetail.Controls.Add(txtQuantity);
            tabPageSellDetail.Controls.Add(txtSubtotal);
            tabPageSellDetail.Controls.Add(button2);
            tabPageSellDetail.Controls.Add(label2);
            tabPageSellDetail.Controls.Add(button1);
            tabPageSellDetail.Controls.Add(label14);
            tabPageSellDetail.Controls.Add(BtnChooseAnotherPay);
            tabPageSellDetail.Controls.Add(BtnChooseAnother);
            tabPageSellDetail.Controls.Add(label13);
            tabPageSellDetail.Controls.Add(label12);
            tabPageSellDetail.Controls.Add(BtnCancel);
            tabPageSellDetail.Controls.Add(BtnSave);
            tabPageSellDetail.Controls.Add(txtSellObservation);
            tabPageSellDetail.Controls.Add(label10);
            tabPageSellDetail.Controls.Add(txtSellPayMode);
            tabPageSellDetail.Controls.Add(label9);
            tabPageSellDetail.Controls.Add(txtSellTotal);
            tabPageSellDetail.Controls.Add(label8);
            tabPageSellDetail.Controls.Add(txtSellCustomerId);
            tabPageSellDetail.Controls.Add(label7);
            tabPageSellDetail.Controls.Add(txtSellId);
            tabPageSellDetail.Controls.Add(label6);
            tabPageSellDetail.Controls.Add(DgSellPayMode);
            tabPageSellDetail.Controls.Add(DgSellProducts);
            tabPageSellDetail.Controls.Add(DgSellCustomers);
            tabPageSellDetail.Controls.Add(label4);
            tabPageSellDetail.Controls.Add(label5);
            tabPageSellDetail.Controls.Add(label3);
            tabPageSellDetail.Location = new Point(4, 34);
            tabPageSellDetail.Margin = new Padding(4, 5, 4, 5);
            tabPageSellDetail.Name = "tabPageSellDetail";
            tabPageSellDetail.Padding = new Padding(4, 5, 4, 5);
            tabPageSellDetail.Size = new Size(1398, 1062);
            tabPageSellDetail.TabIndex = 1;
            tabPageSellDetail.Text = "Sell Detail";
            tabPageSellDetail.UseVisualStyleBackColor = true;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(639, 480);
            txtQuantity.Margin = new Padding(4, 5, 4, 5);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(97, 31);
            txtQuantity.TabIndex = 39;
            txtQuantity.TextAlign = HorizontalAlignment.Right;
            // 
            // txtSubtotal
            // 
            txtSubtotal.Location = new Point(874, 477);
            txtSubtotal.Margin = new Padding(4, 5, 4, 5);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.ReadOnly = true;
            txtSubtotal.Size = new Size(168, 31);
            txtSubtotal.TabIndex = 38;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(684, 537);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(201, 37);
            button2.TabIndex = 37;
            button2.Text = "<<Finish>>";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(769, 480);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(97, 28);
            label2.TabIndex = 36;
            label2.Text = "Subtotal:";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(456, 537);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(209, 37);
            button1.TabIndex = 34;
            button1.Text = "<<Enter Product>>";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(454, 480);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(177, 28);
            label14.TabIndex = 33;
            label14.Text = "Product quantity:";
            // 
            // BtnChooseAnotherPay
            // 
            BtnChooseAnotherPay.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BtnChooseAnotherPay.Location = new Point(454, 410);
            BtnChooseAnotherPay.Margin = new Padding(4, 5, 4, 5);
            BtnChooseAnotherPay.Name = "BtnChooseAnotherPay";
            BtnChooseAnotherPay.Size = new Size(271, 49);
            BtnChooseAnotherPay.TabIndex = 31;
            BtnChooseAnotherPay.Text = "<<Choose Another>>";
            BtnChooseAnotherPay.UseVisualStyleBackColor = true;
            BtnChooseAnotherPay.Click += BtnChooseAnotherPay_Click;
            // 
            // BtnChooseAnother
            // 
            BtnChooseAnother.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BtnChooseAnother.Location = new Point(454, 172);
            BtnChooseAnother.Margin = new Padding(4, 5, 4, 5);
            BtnChooseAnother.Name = "BtnChooseAnother";
            BtnChooseAnother.Size = new Size(269, 42);
            BtnChooseAnother.TabIndex = 30;
            BtnChooseAnother.Text = "<<Choose Another>>";
            BtnChooseAnother.UseVisualStyleBackColor = true;
            BtnChooseAnother.Click += BtnChooseAnother_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(1131, 1028);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(97, 28);
            label13.TabIndex = 28;
            label13.Text = "Subtotal:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(854, 1028);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(177, 28);
            label12.TabIndex = 25;
            label12.Text = "Product quantity:";
            // 
            // BtnCancel
            // 
            BtnCancel.Image = Properties.Resources.cancel;
            BtnCancel.Location = new Point(196, 708);
            BtnCancel.Margin = new Padding(4, 5, 4, 5);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(117, 67);
            BtnCancel.TabIndex = 23;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            BtnSave.Image = Properties.Resources.save;
            BtnSave.Location = new Point(26, 708);
            BtnSave.Margin = new Padding(4, 5, 4, 5);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(117, 67);
            BtnSave.TabIndex = 22;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // txtSellObservation
            // 
            txtSellObservation.Location = new Point(26, 445);
            txtSellObservation.Margin = new Padding(4, 5, 4, 5);
            txtSellObservation.Multiline = true;
            txtSellObservation.Name = "txtSellObservation";
            txtSellObservation.Size = new Size(287, 233);
            txtSellObservation.TabIndex = 21;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(26, 402);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(128, 28);
            label10.TabIndex = 20;
            label10.Text = "Observation";
            // 
            // txtSellPayMode
            // 
            txtSellPayMode.Location = new Point(26, 243);
            txtSellPayMode.Margin = new Padding(4, 5, 4, 5);
            txtSellPayMode.Name = "txtSellPayMode";
            txtSellPayMode.ReadOnly = true;
            txtSellPayMode.Size = new Size(210, 31);
            txtSellPayMode.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(26, 210);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(106, 28);
            label9.TabIndex = 18;
            label9.Text = "Pay Mode";
            // 
            // txtSellTotal
            // 
            txtSellTotal.Location = new Point(26, 340);
            txtSellTotal.Margin = new Padding(4, 5, 4, 5);
            txtSellTotal.Name = "txtSellTotal";
            txtSellTotal.ReadOnly = true;
            txtSellTotal.Size = new Size(210, 31);
            txtSellTotal.TabIndex = 17;
            txtSellTotal.Text = "0";
            txtSellTotal.TextAlign = HorizontalAlignment.Right;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(26, 307);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(99, 28);
            label8.TabIndex = 16;
            label8.Text = "Sell Total";
            // 
            // txtSellCustomerId
            // 
            txtSellCustomerId.Location = new Point(26, 150);
            txtSellCustomerId.Margin = new Padding(4, 5, 4, 5);
            txtSellCustomerId.Name = "txtSellCustomerId";
            txtSellCustomerId.ReadOnly = true;
            txtSellCustomerId.Size = new Size(184, 31);
            txtSellCustomerId.TabIndex = 15;
            txtSellCustomerId.Text = "0";
            txtSellCustomerId.TextAlign = HorizontalAlignment.Right;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(23, 117);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(166, 28);
            label7.TabIndex = 14;
            label7.Text = "Sell Customer Id";
            // 
            // txtSellId
            // 
            txtSellId.Location = new Point(26, 62);
            txtSellId.Margin = new Padding(4, 5, 4, 5);
            txtSellId.Name = "txtSellId";
            txtSellId.ReadOnly = true;
            txtSellId.Size = new Size(184, 31);
            txtSellId.TabIndex = 13;
            txtSellId.Text = "0";
            txtSellId.TextAlign = HorizontalAlignment.Right;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(26, 28);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(70, 28);
            label6.TabIndex = 12;
            label6.Text = "Sell Id";
            // 
            // DgSellPayMode
            // 
            DgSellPayMode.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgSellPayMode.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgSellPayMode.Location = new Point(454, 275);
            DgSellPayMode.Margin = new Padding(4, 5, 4, 5);
            DgSellPayMode.Name = "DgSellPayMode";
            DgSellPayMode.RowHeadersWidth = 62;
            DgSellPayMode.RowTemplate.Height = 25;
            DgSellPayMode.Size = new Size(657, 120);
            DgSellPayMode.TabIndex = 11;
            DgSellPayMode.Click += DgSellPayMode_Click;
            // 
            // DgSellProducts
            // 
            DgSellProducts.AllowUserToAddRows = false;
            DgSellProducts.AllowUserToDeleteRows = false;
            DgSellProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgSellProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgSellProducts.Location = new Point(454, 625);
            DgSellProducts.Margin = new Padding(4, 5, 4, 5);
            DgSellProducts.Name = "DgSellProducts";
            DgSellProducts.ReadOnly = true;
            DgSellProducts.RowHeadersWidth = 62;
            DgSellProducts.RowTemplate.Height = 25;
            DgSellProducts.Size = new Size(841, 191);
            DgSellProducts.TabIndex = 10;
            DgSellProducts.Click += DgSellProducts_Click;
            // 
            // DgSellCustomers
            // 
            DgSellCustomers.AllowUserToAddRows = false;
            DgSellCustomers.AllowUserToDeleteRows = false;
            DgSellCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgSellCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgSellCustomers.Location = new Point(456, 42);
            DgSellCustomers.Margin = new Padding(4, 5, 4, 5);
            DgSellCustomers.Name = "DgSellCustomers";
            DgSellCustomers.ReadOnly = true;
            DgSellCustomers.RowHeadersWidth = 62;
            DgSellCustomers.RowTemplate.Height = 25;
            DgSellCustomers.Size = new Size(657, 120);
            DgSellCustomers.TabIndex = 9;
            DgSellCustomers.Click += DgSellCustomers_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(454, 5);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(232, 32);
            label4.TabIndex = 7;
            label4.Text = "Choose Customers:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(452, 235);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(224, 32);
            label5.TabIndex = 8;
            label5.Text = "Choose Pay Mode:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(452, 588);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(213, 32);
            label3.TabIndex = 6;
            label3.Text = "Choose Products:";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1406, 98);
            panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.sell;
            pictureBox1.Location = new Point(0, 10);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(134, 83);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(143, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(111, 55);
            label1.TabIndex = 0;
            label1.Text = "SELL";
            // 
            // SellView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1406, 1050);
            Controls.Add(panel1);
            Controls.Add(tabControl1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "SellView";
            Text = "SellView";
            tabControl1.ResumeLayout(false);
            tabPageSellList.ResumeLayout(false);
            tabPageSellList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgSell).EndInit();
            tabPageSellDetail.ResumeLayout(false);
            tabPageSellDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgSellPayMode).EndInit();
            ((System.ComponentModel.ISupportInitialize)DgSellProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)DgSellCustomers).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabControl1;
        private TabPage tabPageSellList;
        private TabPage tabPageSellDetail;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtSellId;
        private Label label6;
        private DataGridView DgSellPayMode;
        private DataGridView DgSellProducts;
        private DataGridView DgSellCustomers;
        private TextBox txtSellCustomerId;
        private Label label7;
        private TextBox txtSellTotal;
        private Label label8;
        private Label label10;
        private TextBox txtSellPayMode;
        private Label label9;
        private Button BtnCancel;
        private Button BtnSave;
        private TextBox txtSellObservation;
        private Label label12;

        //private Button button1;
        private Label label13;
        //private TextBox txtSubtotal;
        //private Button button2;
        private Button BtnChooseAnother;
        private Button BtnChooseAnotherPay;
        private Button button2;
        private Label label2;
        //private TextBox txtQuantity;
        private Button button1;
        private Label label14;
        private TextBox textBox2;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private DataGridView DgSell;
        private Button BtnSearch;
        private TextBox TxtSearch;
        private Label label11;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txtSubtotal;
        private TextBox txtQuantity;
    }
}