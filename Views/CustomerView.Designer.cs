namespace Supermarket_mvp.Views
{
    partial class CustomerView
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
            tabPageCustomerList = new TabPage();
            tabPageCustomerDetail = new TabPage();
            TxtCustomerObservation = new TextBox();
            label5 = new Label();
            label4 = new Label();
            TxtCustomerName = new TextBox();
            label3 = new Label();
            TxtCustomerId = new TextBox();
            BtnClose = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            DgCustomer = new DataGridView();
            BtnSearch = new Button();
            TxtSearch = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPageCustomerList.SuspendLayout();
            tabPageCustomerDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgCustomer).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 59);
            panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.customers;
            pictureBox1.Location = new Point(0, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(94, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(100, 9);
            label1.Name = "label1";
            label1.Size = new Size(162, 37);
            label1.TabIndex = 0;
            label1.Text = "CUSTOMER";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageCustomerList);
            tabControl1.Controls.Add(tabPageCustomerDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 59);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 391);
            tabControl1.TabIndex = 3;
            // 
            // tabPageCustomerList
            // 
            tabPageCustomerList.Controls.Add(BtnClose);
            tabPageCustomerList.Controls.Add(BtnDelete);
            tabPageCustomerList.Controls.Add(BtnEdit);
            tabPageCustomerList.Controls.Add(BtnNew);
            tabPageCustomerList.Controls.Add(DgCustomer);
            tabPageCustomerList.Controls.Add(BtnSearch);
            tabPageCustomerList.Controls.Add(TxtSearch);
            tabPageCustomerList.Controls.Add(label2);
            tabPageCustomerList.Location = new Point(4, 24);
            tabPageCustomerList.Name = "tabPageCustomerList";
            tabPageCustomerList.Padding = new Padding(3);
            tabPageCustomerList.Size = new Size(792, 363);
            tabPageCustomerList.TabIndex = 0;
            tabPageCustomerList.Text = "Customer List";
            tabPageCustomerList.UseVisualStyleBackColor = true;
            // 
            // tabPageCustomerDetail
            // 
            tabPageCustomerDetail.Controls.Add(TxtCustomerObservation);
            tabPageCustomerDetail.Controls.Add(label5);
            tabPageCustomerDetail.Controls.Add(label4);
            tabPageCustomerDetail.Controls.Add(TxtCustomerName);
            tabPageCustomerDetail.Controls.Add(label3);
            tabPageCustomerDetail.Controls.Add(TxtCustomerId);
            tabPageCustomerDetail.Location = new Point(4, 24);
            tabPageCustomerDetail.Name = "tabPageCustomerDetail";
            tabPageCustomerDetail.Padding = new Padding(3);
            tabPageCustomerDetail.Size = new Size(792, 363);
            tabPageCustomerDetail.TabIndex = 1;
            tabPageCustomerDetail.Text = "Customer Detail";
            tabPageCustomerDetail.UseVisualStyleBackColor = true;
            // 
            // TxtCustomerObservation
            // 
            TxtCustomerObservation.Location = new Point(29, 192);
            TxtCustomerObservation.Multiline = true;
            TxtCustomerObservation.Name = "TxtCustomerObservation";
            TxtCustomerObservation.PlaceholderText = "Customer Observation";
            TxtCustomerObservation.Size = new Size(278, 66);
            TxtCustomerObservation.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(29, 174);
            label5.Name = "label5";
            label5.Size = new Size(132, 15);
            label5.TabIndex = 5;
            label5.Text = "Customer Observation";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(29, 35);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 4;
            label4.Text = "Customer Id";
            // 
            // TxtCustomerName
            // 
            TxtCustomerName.Location = new Point(29, 121);
            TxtCustomerName.Name = "TxtCustomerName";
            TxtCustomerName.PlaceholderText = "Customer Name";
            TxtCustomerName.Size = new Size(278, 23);
            TxtCustomerName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(29, 103);
            label3.Name = "label3";
            label3.Size = new Size(97, 15);
            label3.TabIndex = 2;
            label3.Text = "Customer Name";
            // 
            // TxtCustomerId
            // 
            TxtCustomerId.Location = new Point(29, 53);
            TxtCustomerId.Name = "TxtCustomerId";
            TxtCustomerId.ReadOnly = true;
            TxtCustomerId.Size = new Size(157, 23);
            TxtCustomerId.TabIndex = 1;
            TxtCustomerId.Text = "0";
            TxtCustomerId.TextAlign = HorizontalAlignment.Right;
            // 
            // BtnClose
            // 
            BtnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.Location = new Point(585, 288);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(180, 59);
            BtnClose.TabIndex = 23;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.Location = new Point(585, 214);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(180, 58);
            BtnDelete.TabIndex = 22;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.Location = new Point(585, 141);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(180, 59);
            BtnEdit.TabIndex = 21;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            BtnNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnNew.Image = Properties.Resources._new;
            BtnNew.Location = new Point(585, 70);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(180, 59);
            BtnNew.TabIndex = 20;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // DgCustomer
            // 
            DgCustomer.AllowUserToAddRows = false;
            DgCustomer.AllowUserToDeleteRows = false;
            DgCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgCustomer.Location = new Point(27, 70);
            DgCustomer.Name = "DgCustomer";
            DgCustomer.ReadOnly = true;
            DgCustomer.RowTemplate.Height = 25;
            DgCustomer.Size = new Size(540, 277);
            DgCustomer.TabIndex = 19;
            // 
            // BtnSearch
            // 
            BtnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSearch.Image = Properties.Resources.search_small;
            BtnSearch.Location = new Point(523, 25);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(44, 39);
            BtnSearch.TabIndex = 18;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // TxtSearch
            // 
            TxtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtSearch.Location = new Point(27, 34);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to search";
            TxtSearch.Size = new Size(490, 23);
            TxtSearch.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(27, 16);
            label2.Name = "label2";
            label2.Size = new Size(102, 15);
            label2.TabIndex = 16;
            label2.Text = "Search Customer";
            // 
            // CustomerView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "CustomerView";
            Text = "Customer Management";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPageCustomerList.ResumeLayout(false);
            tabPageCustomerList.PerformLayout();
            tabPageCustomerDetail.ResumeLayout(false);
            tabPageCustomerDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgCustomer).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPageCustomerList;
        private TabPage tabPageCustomerDetail;
        private TextBox TxtCustomerObservation;
        private Label label5;
        private Label label4;
        private TextBox TxtCustomerName;
        private Label label3;
        private TextBox TxtCustomerId;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private DataGridView DgCustomer;
        private Button BtnSearch;
        private TextBox TxtSearch;
        private Label label2;
    }
}