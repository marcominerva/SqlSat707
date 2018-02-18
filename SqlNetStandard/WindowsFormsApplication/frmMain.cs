using NorthwindData;
using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApplication
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void cmdLoadEmployees_Click(object sender, EventArgs e)
        {
            var data = Northwind.LoadEmployeesFromDatabase();

            lstEmployees.DataSource = data;
            lstEmployees.DisplayMember = "TitleFullName";
        }
    }
}



