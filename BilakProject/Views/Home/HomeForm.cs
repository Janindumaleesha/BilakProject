using BilakProject.Views.EBills;
using BilakProject.Views.Employee;
using BilakProject.Views.Inventory;
using BilakProject.Views.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.SessionState;
using System.Windows.Forms;

namespace BilakProject.Views.Home
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
            CustomizeDesign();
            LoadData();
        }

        public static AddProductForm addProductForm;
        public static ViewProductForm viewProductForm;
        public static AddEBillForm addEBillForm;
        public static ViewEBillForm viewEBillForm;
        public static AddEmployeeForm addEmployeeForm;
        public static ViewEmployeeForm viewEmployeeForm;
        public static AddInventoryForm addInventoryForm;
        public static ViewInventoryForm viewInventoryForm;

        internal void LoadData()
        {
            addProductForm = new AddProductForm();
            addProductForm.TopLevel = false;
            addProductForm.FormBorderStyle = FormBorderStyle.None;
            addProductForm.Dock = DockStyle.Fill;
            PanelChildForm.Controls.Add(addProductForm);

            viewProductForm = new ViewProductForm();
            viewProductForm.TopLevel = false;
            viewProductForm.FormBorderStyle = FormBorderStyle.None;
            viewProductForm.Dock = DockStyle.Fill;
            PanelChildForm.Controls.Add(viewProductForm);

            addEBillForm = new AddEBillForm();
            addEBillForm.TopLevel = false;
            addEBillForm.FormBorderStyle = FormBorderStyle.None;
            addEBillForm.Dock = DockStyle.Fill;
            PanelChildForm.Controls.Add(addEBillForm);

            viewEBillForm = new ViewEBillForm();
            viewEBillForm.TopLevel = false;
            viewEBillForm.FormBorderStyle = FormBorderStyle.None;
            viewEBillForm.Dock = DockStyle.Fill;
            PanelChildForm.Controls.Add(viewEBillForm);

            addEmployeeForm = new AddEmployeeForm();
            addEmployeeForm.TopLevel = false;
            addEmployeeForm.FormBorderStyle = FormBorderStyle.None;
            addEmployeeForm.Dock = DockStyle.Fill;
            PanelChildForm.Controls.Add(addEmployeeForm);

            viewEmployeeForm = new ViewEmployeeForm();
            viewEmployeeForm.TopLevel = false;
            viewEmployeeForm.FormBorderStyle = FormBorderStyle.None;
            viewEmployeeForm.Dock = DockStyle.Fill;
            PanelChildForm.Controls.Add(viewEmployeeForm);

            addInventoryForm = new AddInventoryForm();
            addInventoryForm.TopLevel = false;
            addInventoryForm.FormBorderStyle = FormBorderStyle.None;
            addInventoryForm.Dock = DockStyle.Fill;
            PanelChildForm.Controls.Add(addInventoryForm);

            viewInventoryForm = new ViewInventoryForm();
            viewInventoryForm.TopLevel = false;
            viewInventoryForm.FormBorderStyle = FormBorderStyle.None;
            viewInventoryForm.Dock = DockStyle.Fill;
            PanelChildForm.Controls.Add(viewInventoryForm);
        }

        private void CustomizeDesign()
        {
            productPanel.Visible = false;
            ebillPanel.Visible = false;
            employeePanel.Visible = false;
            inventoryPanel.Visible = false;
        }

        private void HideSubMenu()
        {
            if (productPanel.Visible == true)
                productPanel.Visible = false;
            if (ebillPanel.Visible == true)
                ebillPanel.Visible = false;
            if (employeePanel.Visible == true)
                employeePanel.Visible = false;
            if (inventoryPanel.Visible == true)
                inventoryPanel.Visible = false;
        }

        private void ShowSubMenu(Panel panel)
        {
            if (panel.Visible == false)
            {
                HideSubMenu();
                panel.Visible = true;
            }
            else
            {
                panel.Visible = false;
            }
        }

        private void productButton_Click(object sender, EventArgs e)
        {
            ShowSubMenu(productPanel);
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            addProductForm.BringToFront();
            addProductForm.Show();
            HideSubMenu();
        }

        private void viewProductButton_Click(object sender, EventArgs e)
        { 
            viewProductForm.BringToFront();
            viewProductForm.Show();
            HideSubMenu();
        }

        private void ebillsButton_Click(object sender, EventArgs e)
        {
            ShowSubMenu(ebillPanel);
        }

        private void AddEbillButton_Click(object sender, EventArgs e)
        {
            addEBillForm.BringToFront();
            addEBillForm.Show();
            HideSubMenu();
        }

        private void viewEbillButton_Click(object sender, EventArgs e)
        {
            viewEBillForm.BringToFront();
            viewEBillForm.Show();
            HideSubMenu();
        }

        private void employeeButton_Click(object sender, EventArgs e)
        {
            ShowSubMenu(employeePanel);
        }

        private void AddEmployeeButton_Click(object sender, EventArgs e)
        {
            addEmployeeForm.BringToFront();
            addEmployeeForm.Show();
            HideSubMenu();
        }

        private void viewEmployeeButton_Click(object sender, EventArgs e)
        {
            viewEmployeeForm.BringToFront();
            viewEmployeeForm.Show();
            HideSubMenu();
        }

        private void inventoryButton_Click(object sender, EventArgs e)
        {
            ShowSubMenu(inventoryPanel);
        }

        private void firstInventoryButton_Click(object sender, EventArgs e)
        {
            addInventoryForm.BringToFront();
            addInventoryForm.Show();
            HideSubMenu();
        }

        private void secondInventoryButton_Click(object sender, EventArgs e)
        {
            viewInventoryForm.BringToFront();
            viewInventoryForm.Show();
            HideSubMenu();
        }

        private void closePictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void maxPictureBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void minPictureBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
