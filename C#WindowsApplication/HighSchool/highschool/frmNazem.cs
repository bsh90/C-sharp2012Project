using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using highschool.DataSet1TableAdapters;
using System.Text;
using System.Windows.Forms;

namespace highschool
{
    public partial class frmNazem : Form
    {
        public frmNazem()
        {
            InitializeComponent();
        }
        GheybatTableAdapter gta = new GheybatTableAdapter();

        private void btnSabtG_Click(object sender, EventArgs e)
        {
            try
            {
                gta.Insert(Int64.Parse(txtSID.Text.ToString()), Int32.Parse(cmbClass.SelectedValue.ToString()), DateTime.Now, txtReason.Text);
                MessageBox.Show("غیبت ثبت شد");
            }
            catch
            {
                MessageBox.Show("Error");
            }  
        }

        private void frmNazem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'highSchoolDataSet5.Class' table. You can move, or remove it, as needed.
            this.classTableAdapter.Fill(this.highSchoolDataSet5.Class);

        }

       

       
    }
}
