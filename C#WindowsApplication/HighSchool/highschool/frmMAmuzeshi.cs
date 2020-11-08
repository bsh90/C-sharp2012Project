using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using highschool.DataSet1TableAdapters;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace highschool
{
    public partial class frmMAmuzeshi : Form
    {
        public frmMAmuzeshi()
        {
            InitializeComponent();
        }

        KarnameTableAdapter kta = new KarnameTableAdapter();
        DataSet1.KarnameDataTable kdt = new DataSet1.KarnameDataTable();
        MoadelTableAdapter mta = new MoadelTableAdapter();
        StudentTableAdapter sta = new StudentTableAdapter();
        private void btnKarnameShow_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSCode.Text != null)
                {
                    kta.Karname(kdt, Int64.Parse(txtSCode.Text), Int32.Parse(cmbYear.SelectedValue.ToString()), Int32.Parse(cmbTerm.SelectedValue.ToString()));
                    dataGridView1.DataSource = kdt;

                    lblTerm.Text = mta.MoadelT(Int64.Parse(txtSCode.Text), Int32.Parse(cmbYear.SelectedValue.ToString()), Int32.Parse(cmbTerm.SelectedValue.ToString())).ToString();
                    lblYear.Text = mta.MoadelS(Int64.Parse(txtSCode.Text), Int32.Parse(cmbYear.SelectedValue.ToString())).ToString();
                    txtName.Text = sta.Name(Int64.Parse(txtSCode.Text)).ToString() + " " + sta.Family(Int64.Parse(txtSCode.Text)).ToString();
                }
                else
                    MessageBox.Show("لطفا کد دانشجویی را وارد کنید");
            }
            catch { MessageBox.Show("!لطفا کد دانشجویی را وارد کنید"); }
        }

        private void btnkarnamePrint_Click(object sender, EventArgs e)
        {
            try
            {
                CaptureScreen();
                printDialog1.Document = printDocument1;
                DialogResult result = printDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    printDocument1.Print();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }


        Bitmap memoryImage;
        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

        private void frmMAmuzeshi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'highSchoolDataSet3.Term' table. You can move, or remove it, as needed.
            this.termTableAdapter.Fill(this.highSchoolDataSet3.Term);
            // TODO: This line of code loads data into the 'highSchoolDataSet2.Year' table. You can move, or remove it, as needed.
            this.yearTableAdapter.Fill(this.highSchoolDataSet2.Year);

        }


        

    

       

        
       

       

        
       
    }
}
