﻿namespace Supermarket_mvp.Views
{
    partial class MainView
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
            BtnSell = new Button();
            BtnCategorie = new Button();
            BtnProvider = new Button();
            BtnCustomer = new Button();
            BtnProduct = new Button();
            BtnExit = new Button();
            BtnPayMode = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(BtnSell);
            panel1.Controls.Add(BtnCategorie);
            panel1.Controls.Add(BtnProvider);
            panel1.Controls.Add(BtnCustomer);
            panel1.Controls.Add(BtnProduct);
            panel1.Controls.Add(BtnExit);
            panel1.Controls.Add(BtnPayMode);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 448);
            panel1.TabIndex = 0;
            // 
            // BtnSell
            // 
            BtnSell.BackgroundImage = Properties.Resources.sell;
            BtnSell.BackgroundImageLayout = ImageLayout.Zoom;
            BtnSell.Location = new Point(3, 331);
            BtnSell.Name = "BtnSell";
            BtnSell.Size = new Size(194, 49);
            BtnSell.TabIndex = 7;
            BtnSell.UseVisualStyleBackColor = true;
            // 
            // BtnCategorie
            // 
            BtnCategorie.BackgroundImage = Properties.Resources.categorias;
            BtnCategorie.BackgroundImageLayout = ImageLayout.Zoom;
            BtnCategorie.Location = new Point(3, 276);
            BtnCategorie.Name = "BtnCategorie";
            BtnCategorie.Size = new Size(194, 49);
            BtnCategorie.TabIndex = 6;
            BtnCategorie.UseVisualStyleBackColor = true;
            // 
            // BtnProvider
            // 
            BtnProvider.BackgroundImage = Properties.Resources.providers;
            BtnProvider.BackgroundImageLayout = ImageLayout.Zoom;
            BtnProvider.Location = new Point(3, 221);
            BtnProvider.Name = "BtnProvider";
            BtnProvider.Size = new Size(194, 49);
            BtnProvider.TabIndex = 5;
            BtnProvider.UseVisualStyleBackColor = true;
            // 
            // BtnCustomer
            // 
            BtnCustomer.BackgroundImage = Properties.Resources.customers;
            BtnCustomer.BackgroundImageLayout = ImageLayout.Zoom;
            BtnCustomer.Location = new Point(3, 166);
            BtnCustomer.Name = "BtnCustomer";
            BtnCustomer.Size = new Size(194, 49);
            BtnCustomer.TabIndex = 4;
            BtnCustomer.UseVisualStyleBackColor = true;
            // 
            // BtnProduct
            // 
            BtnProduct.BackgroundImage = Properties.Resources.products;
            BtnProduct.BackgroundImageLayout = ImageLayout.Zoom;
            BtnProduct.Location = new Point(3, 111);
            BtnProduct.Name = "BtnProduct";
            BtnProduct.Size = new Size(194, 49);
            BtnProduct.TabIndex = 3;
            BtnProduct.UseVisualStyleBackColor = true;
            // 
            // BtnExit
            // 
            BtnExit.BackgroundImage = Properties.Resources.salida;
            BtnExit.BackgroundImageLayout = ImageLayout.Zoom;
            BtnExit.Dock = DockStyle.Bottom;
            BtnExit.Location = new Point(0, 399);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(200, 49);
            BtnExit.TabIndex = 2;
            BtnExit.UseVisualStyleBackColor = true;
            // 
            // BtnPayMode
            // 
            BtnPayMode.BackgroundImage = Properties.Resources.buy;
            BtnPayMode.BackgroundImageLayout = ImageLayout.Zoom;
            BtnPayMode.Location = new Point(3, 56);
            BtnPayMode.Name = "BtnPayMode";
            BtnPayMode.Size = new Size(194, 49);
            BtnPayMode.TabIndex = 1;
            BtnPayMode.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = Properties.Resources.sell;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(809, 448);
            Controls.Add(panel1);
            IsMdiContainer = true;
            Margin = new Padding(2);
            Name = "MainView";
            Text = "Supermarket";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button BtnPayMode;
        private PictureBox pictureBox1;
        private Button BtnExit;
        private Button BtnProduct;
        private Button BtnCustomer;
        private Button BtnProvider;
        private Button BtnCategorie;
        private Button BtnSell;
    }
}