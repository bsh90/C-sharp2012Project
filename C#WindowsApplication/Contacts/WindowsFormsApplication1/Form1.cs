using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using WindowsFormsApplication1.DBDataSetTableAdapters;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Programed by Bahareh Shidrang
            // TODO: This line of code loads data into the 'dBDataSet.Contacts' table. You can move, or remove it, as needed.
            this.contactsTableAdapter.Fill(this.dBDataSet.Contacts);
            clear();
        }
        
        ContactsTableAdapter cta=new ContactsTableAdapter();
        DBDataSet.ContactsDataTable cdt=new DBDataSet.ContactsDataTable();

        private void clear()
        {
            txtName.Clear();
            txtSurname.Clear();
            txtNum.Clear();
            txtCell.Clear();
            txtAddress.Clear();
            txtID.Clear();
            txtName.DataBindings.Clear();
            txtSurname.DataBindings.Clear();
            txtNum.DataBindings.Clear();
            txtCell.DataBindings.Clear();
            txtAddress.DataBindings.Clear();
            txtID.DataBindings.Clear();
        }
        private void clearb()
        {
            txtName.DataBindings.Clear();
            txtSurname.DataBindings.Clear();
            txtNum.DataBindings.Clear();
            txtCell.DataBindings.Clear();
            txtAddress.DataBindings.Clear();
            txtID.DataBindings.Clear();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataView dv;
            CurrencyManager cm;

            dv = new DataView(cdt);
            cta.Fill(cdt);
            cm = (CurrencyManager)BindingContext[dv];
            if (e.RowIndex > (dv.Count - 1))
                clear();
            else
            {
                clear();
                cm.Position = e.RowIndex;
                txtName.DataBindings.Add("Text", dv, "FirstName");
                txtSurname.DataBindings.Add("Text", dv, "LastName");
                txtNum.DataBindings.Add("Text", dv, "Phone");
                txtCell.DataBindings.Add("Text", dv, "Mobile");
                txtAddress.DataBindings.Add("Text", dv, "Address");
                txtID.DataBindings.Add("Text", dv, "ContactId");
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtID.Text))
                {
                    if (!String.IsNullOrEmpty(txtName.Text))
                    {
                        cta.Insert(txtName.Text, txtSurname.Text, txtNum.Text, txtCell.Text, txtAddress.Text);
                        clear();
                    }
                    else { MessageBox.Show("فرم را تکمیل کنید."); }
                }
                else
                {
                    cta.UpdateQuery(txtName.Text, txtSurname.Text, txtNum.Text, txtCell.Text, txtAddress.Text, Int32.Parse(txtID.Text));
                    
                    clear();
                }
            }
            catch { MessageBox.Show("فرم را تکمیل کنید!"); }
            cta.Fill(cdt);
            dataGridView1.DataSource = cdt;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                cta.UpdateQuery(txtName.Text, txtSurname.Text, txtNum.Text, txtCell.Text, txtAddress.Text, Int32.Parse(txtID.Text));
                clearb();
                cta.Fill(cdt); 
                dataGridView1.DataSource = cdt;
            }
            catch 
            {
                 MessageBox.Show("فرم را تکمیل کنید."); 

            }
        }    
    }
}
