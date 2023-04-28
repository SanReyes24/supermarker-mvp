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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPageSellList = new TabPage();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            DgSell = new DataGridView();
            button5 = new Button();
            TxtSearch = new TextBox();
            label2 = new Label();
            BtnClose = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            BtnSearch = new Button();
            tabPageSellDetail = new TabPage();
            label8 = new Label();
            BtnChooseAnotherPay = new Button();
            BtnChooseAnother = new Button();
            BtnCancel = new Button();
            BtnSave = new Button();
            txtSellObservation = new TextBox();
            label10 = new Label();
            txtSellPayMode = new TextBox();
            label9 = new Label();
            txtSellTotal = new TextBox();
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
            button7 = new Button();
            label13 = new Label();
            txtSubtotal = new TextBox();
            button8 = new Button();
            label12 = new Label();
            txtQuantity = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPageSellList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgSell).BeginInit();
            tabPageSellDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgSellPayMode).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DgSellProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DgSellCustomers).BeginInit();
            SuspendLayout();
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
            panel1.Size = new Size(1191, 98);
            panel1.TabIndex = 3;
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
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageSellList);
            tabControl1.Controls.Add(tabPageSellDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 98);
            tabControl1.Margin = new Padding(4, 5, 4, 5);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1191, 952);
            tabControl1.TabIndex = 4;
            // 
            // tabPageSellList
            // 
            tabPageSellList.Controls.Add(button1);
            tabPageSellList.Controls.Add(button2);
            tabPageSellList.Controls.Add(button3);
            tabPageSellList.Controls.Add(button4);
            tabPageSellList.Controls.Add(DgSell);
            tabPageSellList.Controls.Add(button5);
            tabPageSellList.Controls.Add(TxtSearch);
            tabPageSellList.Controls.Add(label2);
            tabPageSellList.Controls.Add(BtnClose);
            tabPageSellList.Controls.Add(BtnDelete);
            tabPageSellList.Controls.Add(BtnEdit);
            tabPageSellList.Controls.Add(BtnNew);
            tabPageSellList.Controls.Add(BtnSearch);
            tabPageSellList.Location = new Point(4, 34);
            tabPageSellList.Margin = new Padding(4, 5, 4, 5);
            tabPageSellList.Name = "tabPageSellList";
            tabPageSellList.Padding = new Padding(4, 5, 4, 5);
            tabPageSellList.Size = new Size(1183, 882);
            tabPageSellList.TabIndex = 0;
            tabPageSellList.Text = "Sell List";
            tabPageSellList.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Image = Properties.Resources.cerrar;
            button1.Location = new Point(839, 497);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(257, 98);
            button1.TabIndex = 31;
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.Image = Properties.Resources.delete;
            button2.Location = new Point(839, 373);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(257, 97);
            button2.TabIndex = 30;
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.Image = Properties.Resources.edit;
            button3.Location = new Point(839, 252);
            button3.Margin = new Padding(4, 5, 4, 5);
            button3.Name = "button3";
            button3.Size = new Size(257, 98);
            button3.TabIndex = 29;
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button4.Image = Properties.Resources._new;
            button4.Location = new Point(839, 133);
            button4.Margin = new Padding(4, 5, 4, 5);
            button4.Name = "button4";
            button4.Size = new Size(257, 98);
            button4.TabIndex = 28;
            button4.UseVisualStyleBackColor = true;
            // 
            // DgSell
            // 
            DgSell.AllowUserToAddRows = false;
            DgSell.AllowUserToDeleteRows = false;
            DgSell.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgSell.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgSell.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgSell.Location = new Point(41, 133);
            DgSell.Margin = new Padding(4, 5, 4, 5);
            DgSell.Name = "DgSell";
            DgSell.ReadOnly = true;
            DgSell.RowHeadersWidth = 62;
            DgSell.RowTemplate.Height = 25;
            DgSell.Size = new Size(771, 462);
            DgSell.TabIndex = 27;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button5.Image = Properties.Resources.search_small;
            button5.Location = new Point(750, 58);
            button5.Margin = new Padding(4, 5, 4, 5);
            button5.Name = "button5";
            button5.Size = new Size(63, 65);
            button5.TabIndex = 26;
            button5.UseVisualStyleBackColor = true;
            // 
            // TxtSearch
            // 
            TxtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtSearch.Location = new Point(41, 73);
            TxtSearch.Margin = new Padding(4, 5, 4, 5);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to search";
            TxtSearch.Size = new Size(698, 31);
            TxtSearch.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(41, 43);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(155, 25);
            label2.TabIndex = 24;
            label2.Text = "Search Customer";
            // 
            // BtnClose
            // 
            BtnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.Location = new Point(1726, 485);
            BtnClose.Margin = new Padding(4, 5, 4, 5);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(257, 98);
            BtnClose.TabIndex = 23;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.Location = new Point(1726, 362);
            BtnDelete.Margin = new Padding(4, 5, 4, 5);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(257, 97);
            BtnDelete.TabIndex = 22;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.Location = new Point(1726, 240);
            BtnEdit.Margin = new Padding(4, 5, 4, 5);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(257, 98);
            BtnEdit.TabIndex = 21;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            BtnNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnNew.Image = Properties.Resources._new;
            BtnNew.Location = new Point(1726, 122);
            BtnNew.Margin = new Padding(4, 5, 4, 5);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(257, 98);
            BtnNew.TabIndex = 20;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // BtnSearch
            // 
            BtnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSearch.Image = Properties.Resources.search_small;
            BtnSearch.Location = new Point(1637, 47);
            BtnSearch.Margin = new Padding(4, 5, 4, 5);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(63, 65);
            BtnSearch.TabIndex = 18;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // tabPageSellDetail
            // 
            tabPageSellDetail.Controls.Add(button7);
            tabPageSellDetail.Controls.Add(label13);
            tabPageSellDetail.Controls.Add(txtSubtotal);
            tabPageSellDetail.Controls.Add(button8);
            tabPageSellDetail.Controls.Add(label12);
            tabPageSellDetail.Controls.Add(txtQuantity);
            tabPageSellDetail.Controls.Add(label8);
            tabPageSellDetail.Controls.Add(BtnChooseAnotherPay);
            tabPageSellDetail.Controls.Add(BtnChooseAnother);
            tabPageSellDetail.Controls.Add(BtnCancel);
            tabPageSellDetail.Controls.Add(BtnSave);
            tabPageSellDetail.Controls.Add(txtSellObservation);
            tabPageSellDetail.Controls.Add(label10);
            tabPageSellDetail.Controls.Add(txtSellPayMode);
            tabPageSellDetail.Controls.Add(label9);
            tabPageSellDetail.Controls.Add(txtSellTotal);
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
            tabPageSellDetail.Size = new Size(1183, 914);
            tabPageSellDetail.TabIndex = 1;
            tabPageSellDetail.Text = "Sell Detail";
            tabPageSellDetail.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(46, 330);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(99, 28);
            label8.TabIndex = 51;
            label8.Text = "Sell Total";
            // 
            // BtnChooseAnotherPay
            // 
            BtnChooseAnotherPay.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BtnChooseAnotherPay.Location = new Point(476, 547);
            BtnChooseAnotherPay.Margin = new Padding(4, 5, 4, 5);
            BtnChooseAnotherPay.Name = "BtnChooseAnotherPay";
            BtnChooseAnotherPay.Size = new Size(196, 67);
            BtnChooseAnotherPay.TabIndex = 50;
            BtnChooseAnotherPay.Text = "<<Choose Another>>";
            BtnChooseAnotherPay.UseVisualStyleBackColor = true;
            // 
            // BtnChooseAnother
            // 
            BtnChooseAnother.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BtnChooseAnother.Location = new Point(474, 247);
            BtnChooseAnother.Margin = new Padding(4, 5, 4, 5);
            BtnChooseAnother.Name = "BtnChooseAnother";
            BtnChooseAnother.Size = new Size(196, 67);
            BtnChooseAnother.TabIndex = 49;
            BtnChooseAnother.Text = "<<Choose Another>>";
            BtnChooseAnother.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            BtnCancel.Image = Properties.Resources.cancel;
            BtnCancel.Location = new Point(221, 625);
            BtnCancel.Margin = new Padding(4, 5, 4, 5);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(147, 67);
            BtnCancel.TabIndex = 48;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            BtnSave.Image = Properties.Resources.save;
            BtnSave.Location = new Point(43, 625);
            BtnSave.Margin = new Padding(4, 5, 4, 5);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(147, 67);
            BtnSave.TabIndex = 47;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // txtSellObservation
            // 
            txtSellObservation.Location = new Point(44, 468);
            txtSellObservation.Margin = new Padding(4, 5, 4, 5);
            txtSellObservation.Multiline = true;
            txtSellObservation.Name = "txtSellObservation";
            txtSellObservation.Size = new Size(323, 121);
            txtSellObservation.TabIndex = 46;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(43, 427);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(128, 28);
            label10.TabIndex = 45;
            label10.Text = "Observation";
            // 
            // txtSellPayMode
            // 
            txtSellPayMode.Location = new Point(46, 263);
            txtSellPayMode.Margin = new Padding(4, 5, 4, 5);
            txtSellPayMode.Name = "txtSellPayMode";
            txtSellPayMode.ReadOnly = true;
            txtSellPayMode.Size = new Size(287, 31);
            txtSellPayMode.TabIndex = 44;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(46, 230);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(106, 28);
            label9.TabIndex = 43;
            label9.Text = "Pay Mode";
            // 
            // txtSellTotal
            // 
            txtSellTotal.Location = new Point(46, 363);
            txtSellTotal.Margin = new Padding(4, 5, 4, 5);
            txtSellTotal.Name = "txtSellTotal";
            txtSellTotal.ReadOnly = true;
            txtSellTotal.Size = new Size(184, 31);
            txtSellTotal.TabIndex = 42;
            txtSellTotal.Text = "0";
            txtSellTotal.TextAlign = HorizontalAlignment.Right;
            // 
            // txtSellCustomerId
            // 
            txtSellCustomerId.Location = new Point(46, 168);
            txtSellCustomerId.Margin = new Padding(4, 5, 4, 5);
            txtSellCustomerId.Name = "txtSellCustomerId";
            txtSellCustomerId.ReadOnly = true;
            txtSellCustomerId.Size = new Size(184, 31);
            txtSellCustomerId.TabIndex = 41;
            txtSellCustomerId.Text = "0";
            txtSellCustomerId.TextAlign = HorizontalAlignment.Right;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(43, 135);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(166, 28);
            label7.TabIndex = 40;
            label7.Text = "Sell Customer Id";
            // 
            // txtSellId
            // 
            txtSellId.Location = new Point(46, 80);
            txtSellId.Margin = new Padding(4, 5, 4, 5);
            txtSellId.Name = "txtSellId";
            txtSellId.ReadOnly = true;
            txtSellId.Size = new Size(184, 31);
            txtSellId.TabIndex = 39;
            txtSellId.Text = "0";
            txtSellId.TextAlign = HorizontalAlignment.Right;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(44, 43);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(70, 28);
            label6.TabIndex = 38;
            label6.Text = "Sell Id";
            // 
            // DgSellPayMode
            // 
            DgSellPayMode.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgSellPayMode.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgSellPayMode.Location = new Point(476, 370);
            DgSellPayMode.Margin = new Padding(4, 5, 4, 5);
            DgSellPayMode.Name = "DgSellPayMode";
            DgSellPayMode.RowHeadersWidth = 62;
            DgSellPayMode.RowTemplate.Height = 25;
            DgSellPayMode.Size = new Size(657, 167);
            DgSellPayMode.TabIndex = 37;
            // 
            // DgSellProducts
            // 
            DgSellProducts.AllowUserToAddRows = false;
            DgSellProducts.AllowUserToDeleteRows = false;
            DgSellProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgSellProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgSellProducts.Location = new Point(479, 657);
            DgSellProducts.Margin = new Padding(4, 5, 4, 5);
            DgSellProducts.Name = "DgSellProducts";
            DgSellProducts.ReadOnly = true;
            DgSellProducts.RowHeadersWidth = 62;
            DgSellProducts.RowTemplate.Height = 25;
            DgSellProducts.Size = new Size(657, 167);
            DgSellProducts.TabIndex = 36;
            // 
            // DgSellCustomers
            // 
            DgSellCustomers.AllowUserToAddRows = false;
            DgSellCustomers.AllowUserToDeleteRows = false;
            DgSellCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgSellCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgSellCustomers.Location = new Point(476, 72);
            DgSellCustomers.Margin = new Padding(4, 5, 4, 5);
            DgSellCustomers.Name = "DgSellCustomers";
            DgSellCustomers.ReadOnly = true;
            DgSellCustomers.RowHeadersWidth = 62;
            DgSellCustomers.RowTemplate.Height = 25;
            DgSellCustomers.Size = new Size(657, 167);
            DgSellCustomers.TabIndex = 35;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(474, 35);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(232, 32);
            label4.TabIndex = 33;
            label4.Text = "Choose Customers:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(474, 330);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(224, 32);
            label5.TabIndex = 34;
            label5.Text = "Choose Pay Mode:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(474, 618);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(213, 32);
            label3.TabIndex = 32;
            label3.Text = "Choose Products:";
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Location = new Point(221, 734);
            button7.Margin = new Padding(4, 5, 4, 5);
            button7.Name = "button7";
            button7.Size = new Size(146, 67);
            button7.TabIndex = 61;
            button7.Text = "<<Finish>>";
            button7.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(818, 843);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(97, 28);
            label13.TabIndex = 60;
            label13.Text = "Subtotal:";
            // 
            // txtSubtotal
            // 
            txtSubtotal.Location = new Point(923, 843);
            txtSubtotal.Margin = new Padding(4, 5, 4, 5);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.ReadOnly = true;
            txtSubtotal.Size = new Size(168, 31);
            txtSubtotal.TabIndex = 59;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button8.Location = new Point(43, 734);
            button8.Margin = new Padding(4, 5, 4, 5);
            button8.Name = "button8";
            button8.Size = new Size(147, 67);
            button8.TabIndex = 58;
            button8.Text = "<<Enter Product>>";
            button8.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(474, 843);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(177, 28);
            label12.TabIndex = 57;
            label12.Text = "Product quantity:";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(659, 843);
            txtQuantity.Margin = new Padding(4, 5, 4, 5);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(97, 31);
            txtQuantity.TabIndex = 56;
            txtQuantity.TextAlign = HorizontalAlignment.Right;
            // 
            // SellView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1191, 1050);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "SellView";
            Text = "Sell View Management";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPageSellList.ResumeLayout(false);
            tabPageSellList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgSell).EndInit();
            tabPageSellDetail.ResumeLayout(false);
            tabPageSellDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgSellPayMode).EndInit();
            ((System.ComponentModel.ISupportInitialize)DgSellProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)DgSellCustomers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPageSellList;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private Button BtnSearch;
        private TabPage tabPageSellDetail;
        private Label label8;
        private Button BtnChooseAnotherPay;
        private Button BtnChooseAnother;
        private Button BtnCancel;
        private Button BtnSave;
        private TextBox txtSellObservation;
        private Label label10;
        private TextBox txtSellPayMode;
        private Label label9;
        private TextBox txtSellTotal;
        private TextBox txtSellCustomerId;
        private Label label7;
        private TextBox txtSellId;
        private Label label6;
        private DataGridView DgSellPayMode;
        private DataGridView DgSellProducts;
        private DataGridView DgSellCustomers;
        private Label label4;
        private Label label5;
        private Label label3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private DataGridView DgSell;
        private Button button5;
        private TextBox TxtSearch;
        private Label label2;
        private Button button7;
        private Label label13;
        private TextBox txtSubtotal;
        private Button button8;
        private Label label12;
        private TextBox txtQuantity;
    }
}