using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Supermarket_mvp._Repositories;
using Microsoft.Data.SqlClient;
using Microsoft.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;
using MongoDB.Driver.Core.Configuration;
using Supermarket_mvp.Presenters;
using Supermarket_mvp.Models;
using Supermarket_mvp.Properties;

namespace Supermarket_mvp.Views
{
    public partial class SellView : Form, ISellView
    {
        private bool isEdit;
        private bool isSuccessful;
        private string message;
        int numero;
        string connectionString;
        private ICustomerView view;
        private ICustomerRepository repository;

        public SellView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();

            tabControl1.TabPages.Remove(tabPageSellDetail);
            BtnClose.Click += delegate { this.Close(); };
            BtnSave.Enabled = false;
        }

        private void AssociateAndRaiseViewEvents()
        {
            BtnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            TxtSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };

            BtnNew.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);

                tabControl1.TabPages.Remove(tabPageSellList);
                tabControl1.TabPages.Add(tabPageSellDetail);
                tabPageSellDetail.Text = "Add New Sell";

                string sqlConnectionString = Settings.Default.SqlConnection;
                CustomerRepository customers = new CustomerRepository(sqlConnectionString);
                DgSellCustomers.DataSource = customers.GetAll();
                ProductRepository products = new ProductRepository(sqlConnectionString);
                DgSellProducts.DataSource = products.GetAll();
                PayModeRepository payModes = new PayModeRepository(sqlConnectionString);
                DgSellPayMode.DataSource = payModes.GetAll();

            };

            BtnEdit.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);

                tabControl1.TabPages.Remove(tabPageSellList);
                tabControl1.TabPages.Add(tabPageSellDetail);
                tabPageSellDetail.Text = "Edit Sell";

                string sqlConnectionString = Settings.Default.SqlConnection;
                CustomerRepository customers = new CustomerRepository(sqlConnectionString);
                DgSellCustomers.DataSource = customers.GetAll();
                DgSellCustomers.Enabled = true;
                ProductRepository products = new ProductRepository(sqlConnectionString);
                DgSellProducts.DataSource = products.GetAll();
                DgSellProducts.Enabled = true;
                PayModeRepository payModes = new PayModeRepository(sqlConnectionString);
                DgSellPayMode.DataSource = payModes.GetAll();
                DgSellPayMode.Enabled = true;
            };

            BtnSave.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);

                if (isSuccessful)
                {
                    tabControl1.TabPages.Remove(tabPageSellDetail);
                    tabControl1.TabPages.Add(tabPageSellList);
                }
                MessageBox.Show(Message);

                DgSellCustomers.DefaultCellStyle.BackColor = SystemColors.Window;
                DgSellProducts.DefaultCellStyle.BackColor = SystemColors.Window;
                DgSellPayMode.DefaultCellStyle.BackColor = SystemColors.Window;

            };

            BtnCancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);

                tabControl1.TabPages.Remove(tabPageSellDetail);
                tabControl1.TabPages.Add(tabPageSellList);
            };

            BtnDelete.Click += delegate
            {
                var result = MessageBox.Show(
                    "Are you sure you want to delete the selected Sell",
                    "Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };

        }

        public string Sell_Id
        {
            get { return txtSellId.Text; }
            set { txtSellId.Text = value; }
        }
        public string Sell_CustomerId
        {
            get
            {
                if (txtSellCustomerId.Text != "" && int.TryParse(txtSellCustomerId.Text, out numero))
                {
                    return txtSellCustomerId.Text;
                }
                return "";
            }
            set { txtSellCustomerId.Text = value; }

        }
        public string Sell_Total
        {
            get
            {
                if (txtSellTotal.Text != "" && int.TryParse(txtSellTotal.Text, out numero))
                {
                    return txtSellTotal.Text;
                }
                return "";
            }
            set { txtSellTotal.Text = value; }
    
        }
        public string Sell_PayMode
        {
            get { return txtSellPayMode.Text; }
            set { txtSellPayMode.Text = value; }
        }
        public string Sell_Observation
        {
            get { return txtSellObservation.Text; }
            set { txtSellObservation.Text = value; }
        }
        public string SearchValue
        {
            get { return TxtSearch.Text; }
            set { TxtSearch.Text = value; }
        }
        public bool IsEdit
        {
            get { return isEdit; }
            set { isEdit = value; }
        }
        public bool IsSuccesful
        {
            get { return isSuccessful; }
            set { isSuccessful = value; }
        }
        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        public void SetSellListBildingSource(BindingSource sellList)
        {
            DgSell.DataSource = sellList;
        }

        public void SetSellListsBildingSource(BindingSource customerList,
        BindingSource productsList, BindingSource payModeList)
        {
            DgSellCustomers.DataSource = customerList;
            DgSellProducts.DataSource = productsList;
            DgSellPayMode.DataSource = payModeList;
        }

        private static SellView instance;
        public static SellView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new SellView();
                instance.MdiParent = parentContainer;

                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                {
                    instance.WindowState = FormWindowState.Normal;
                }
                instance.BringToFront();
            }
            return instance;

        }

        private void DgSellProducts_Click(object sender, EventArgs e)
        {
            if (txtQuantity.Text != "")
            {
                if (DgSellProducts.CurrentRow != null) // Verifica que la fila seleccionada no sea nula
                {
                    DataGridViewRow fila = DgSellProducts.CurrentRow;
                    double valorCelda = double.Parse(fila.Cells[3].Value.ToString()); // Obtiene el valor de la segunda columna
                    double total = valorCelda * double.Parse(txtQuantity.Text);
                    txtSubtotal.Text = total.ToString();
                    DgSellProducts.DefaultCellStyle.BackColor = SystemColors.ControlDark;
                    DgSellProducts.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Quantity is required", "Alert");
            }
        }

        private void DgSellCustomers_Click(object sender, EventArgs e)
        {
            if (DgSellCustomers.CurrentRow != null) // Verifica que la fila seleccionada no sea nula
            {
                DataGridViewRow fila = DgSellCustomers.CurrentRow;
                string valorCelda = fila.Cells[0].Value.ToString(); // Obtiene el valor de la segunda columna
                txtSellCustomerId.Text = valorCelda;
                DgSellCustomers.DefaultCellStyle.BackColor = SystemColors.ControlDark;
                DgSellCustomers.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BtnSave.Enabled = false;
            DgSellProducts.Enabled = true;
            DgSellProducts.DefaultCellStyle.BackColor = SystemColors.Window;

            if (txtSubtotal.Text != "")
            {
                DgSellProducts.DefaultCellStyle.BackColor = SystemColors.Window;
                DgSellProducts.Enabled = true;
                double acu = 0;
                acu = double.Parse(txtSellTotal.Text) + double.Parse(txtSubtotal.Text);
                txtSellTotal.Text = acu.ToString();
                DataGridViewRow fila = DgSellProducts.CurrentRow;
                string valorCelda2 = fila.Cells[1].Value.ToString();
                txtSellObservation.Text += " - " + txtQuantity.Text + " " + valorCelda2;
                button1.Text = "Next Product";

            }
            else
            {
                MessageBox.Show("You must choose a product", "Alert");
            }
            txtSubtotal.Clear();
            txtQuantity.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BtnSave.Enabled = true;
            DgSellProducts.DefaultCellStyle.BackColor = SystemColors.ControlDark;
            DgSellProducts.Enabled = false;
            if (txtSubtotal.Text != "")
            {
                double total = double.Parse(txtSellTotal.Text) + double.Parse(txtSubtotal.Text);
                txtSellTotal.Text = total.ToString();
                DataGridViewRow fila = DgSellProducts.CurrentRow;
                string valorCelda2 = fila.Cells[1].Value.ToString();
                txtSellObservation.Text += " - " + txtQuantity.Text + " " + valorCelda2;
            }
            txtQuantity.Clear();
            txtSubtotal.Clear();
        }

        private void BtnChooseAnother_Click(object sender, EventArgs e)
        {
            DgSellCustomers.Enabled = true;
            DgSellCustomers.DefaultCellStyle.BackColor = SystemColors.Window;

        }

        private void DgSellPayMode_Click(object sender, EventArgs e)
        {
            DataGridViewRow fila = DgSellPayMode.CurrentRow;
            string valorCelda = fila.Cells[1].Value.ToString(); // Obtiene el valor de la segunda columna
            txtSellPayMode.Text = valorCelda;
            DgSellPayMode.DefaultCellStyle.BackColor = SystemColors.ControlDark;
            DgSellPayMode.Enabled = false;
        }

        private void BtnChooseAnotherPay_Click(object sender, EventArgs e)
        {
            DgSellPayMode.DefaultCellStyle.BackColor = SystemColors.Window;
            DgSellPayMode.Enabled = true;
        }
    }
}
