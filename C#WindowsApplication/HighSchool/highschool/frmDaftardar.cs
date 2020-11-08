using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Data.SqlClient;
using highschool.DataSet1TableAdapters;
using System.Globalization;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace highschool
{
    
    public partial class frmDaftardar : Form
    {
  
        public frmDaftardar()
        {
            InitializeComponent();
        }
        PersianCalendar pc = new PersianCalendar();
        StudentTableAdapter sta = new StudentTableAdapter();
        DataSet1.StudentDataTable dt = new DataSet1.StudentDataTable();
        private void frmMoaven_Load(object sender, EventArgs e)
        {
         
            // TODO: This line of code loads data into the 'highSchoolDataSet3.Term' table. You can move, or remove it, as needed.
            this.termTableAdapter.Fill(this.highSchoolDataSet3.Term);
            // TODO: This line of code loads data into the 'courseDataSet3.Course' table. You can move, or remove it, as needed.
            this.courseTableAdapter.Fill(this.courseDataSet3.Course);
            // TODO: This line of code loads data into the 'highSchoolDataSet2.Year' table. You can move, or remove it, as needed.
            this.yearTableAdapter.Fill(this.highSchoolDataSet2.Year);
            // TODO: This line of code loads data into the 'highSchoolDataSet1.Field' table. You can move, or remove it, as needed.
            this.fieldTableAdapter.Fill(this.highSchoolDataSet1.Field);
            // TODO: This line of code loads data into the 'highSchoolDataSet.Grade' table. You can move, or remove it, as needed.
            this.gradeTableAdapter.Fill(this.highSchoolDataSet.Grade);
            groupBox2.Enabled = false;

            
            time.Text = "  تاریخ   "+pc.GetYear(DateTime.Now).ToString() + "/" +
                pc.GetMonth(DateTime.Now).ToString() + "/" +
                pc.GetDayOfMonth(DateTime.Now).ToString() + "  ساعت   " +
                pc.GetHour(DateTime.Now).ToString() + ":" +
                pc.GetMinute(DateTime.Now).ToString() + ":" +
                pc.GetSecond(DateTime.Now).ToString();

            
            cmb2.Enabled = false;
            

            FillDasetAndView();
            BindControl();
            
        }
       
        private void btn1_Click(object sender, EventArgs e)
        {
            try{
                if (Convert.ToDouble(textBox1.Text) > 13 && Convert.ToDouble(textBox1.Text) <= 20 && Convert.ToDouble(textBox2.Text) > 14 && Convert.ToDouble(textBox2.Text) <= 20 && (cmb1.SelectedValue.ToString() == "1")
                || Convert.ToDouble(textBox1.Text) > 13 && Convert.ToDouble(textBox1.Text) <= 20 && Convert.ToDouble(textBox2.Text) > 14 && Convert.ToDouble(textBox2.Text) <= 20 && (cmb1.SelectedValue.ToString() == "2")
                || Convert.ToDouble(textBox1.Text) > 13 && Convert.ToDouble(textBox1.Text) <= 20 && Convert.ToDouble(textBox2.Text) > 14 && Convert.ToDouble(textBox2.Text) <= 20 && (cmb1.SelectedValue.ToString() == "3"))
            {

                SqlConnection con = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=HighSchool;Integrated Security=True");
                con.Open();
                SqlCommand cmm = new SqlCommand("insert into Archieve(MelliCode,PreAverage,PreRegScore)Values(@m,@pa,@ps)", con);
                cmm.Parameters.AddWithValue("@m", Int64.Parse(mtb3.Text));
                cmm.Parameters.AddWithValue("@pa", Convert.ToDouble(textBox1.Text));
                cmm.Parameters.AddWithValue("@ps", Convert.ToDouble(textBox2.Text));
                cmm.ExecuteNonQuery();  //baraye ejraye dasture insert o delete o update
                groupBox2.Enabled = true;
                
                //foreach(ClassNO a in cta)
                //txtCode.Text = pc.GetYear(DateTime.Now).ToString() + txtClassNo.Text+ sta.Count();

            }}
            catch
            {
                MessageBox.Show("غیر قابل ثبت نام");
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "JPEG(*.JPG;*.JPEG)|*.JPG;*.JPEG|Bitmap(*.bmp)|*.bmp|PNG(*.PNG)|*.PNG";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName;
            }
        }
        

        private void btnSabt_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text != null && txtFamily.Text != null && txtAddress.Text != null && pictureBox1.ImageLocation != null && mtbPhone.Text != null && mtbBirthday.Text != null)
                {

                    //int year = Int32.Parse(mtbBirthday.Text.Substring(0, 4));
                    //int month = Int32.Parse(mtbBirthday.Text.Substring(5, 2));
                    //int day = Int32.Parse(mtbBirthday.Text.Substring(8, 2));
                    //PersianCalendar pt = new PersianCalendar();
                    //DateTime Birthday = pt.ToDateTime(year, month, day, 0, 0, 0, 0);

                    //string time = Birthday.Year.ToString() + "/" + Birthday.Month.ToString() + "/" + Birthday.Day.ToString();

                    sta.Insert(txtName.Text, txtFamily.Text, txtAddress.Text, pictureBox1.ImageLocation, Int64.Parse(mtbPhone.Text), mtbBirthday.Text, Int64.Parse(mtb3.Text), Int32.Parse(cmb1.SelectedValue.ToString()), Int32.Parse(cmb2.SelectedValue.ToString()), Int64.Parse(mtbMobile.Text));
                    MessageBox.Show("ثبت نام با موفقیت انجام شد");                   
                }
                else
                    MessageBox.Show("اطلاعات وارد شده کامل نیست");
            }
            catch
            {
                MessageBox.Show("غیر قابل ثبت نام");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            time.Text = "  تاریخ   " + pc.GetYear(DateTime.Now).ToString() + "/" +
                pc.GetMonth(DateTime.Now).ToString() + "/" +
                pc.GetDayOfMonth(DateTime.Now).ToString() + "  ساعت   " +
                pc.GetHour(DateTime.Now).ToString() + ":" +
                pc.GetMinute(DateTime.Now).ToString() + ":" +
                pc.GetSecond(DateTime.Now).ToString();
        }
        //
        //
        //
        //
        //
        //
        //
        //tab3
        ScoreTableAdapter ssta = new ScoreTableAdapter();
        DataSet1.ScoreDataTable ssdt = new DataSet1.ScoreDataTable();
        private void btnScoreSabt_Click(object sender, EventArgs e)
        {
            try
            {
                //sta.CheckCode(dt, Int32.Parse(txtSCode.Text));
                if (dt.Rows.Count == 0)
                    MessageBox.Show("کد دانش آموزی اشتباه است", "Error", MessageBoxButtons.YesNo);
                else
                {
                    ssta.Insert(Convert.ToDouble(txtScore.Text), Int32.Parse(cmbTerm.SelectedValue.ToString()), Int32.Parse(cmbYear.SelectedValue.ToString()), Int64.Parse(txtSCode.Text), Int32.Parse(cmbCourse.SelectedValue.ToString()));
                    ssta.AllScores(ssdt, Int64.Parse(txtSCode.Text));
                    dataGridView1.DataSource = ssdt;
                }
            }
            catch { MessageBox.Show("فیلدهای خالی را پر کنید"); }
        }
        private void btnScoreShow_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSCode.Text != null)
                {
                    ssta.AllScores(ssdt, Int64.Parse(txtSCode.Text));
                    dataGridView1.DataSource = ssdt;
                }
                else
                    MessageBox.Show("لطفا کد دانشجویی را وارد کنید");
            }
            catch { MessageBox.Show("لطفا کد دانشجویی را وارد کنید"); }
        }
        int row;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                row = e.RowIndex;
                if (e.ColumnIndex == 0)
                {
                    ssta.UpdateQuery(Convert.ToDouble(dataGridView1[2, row].Value.ToString()), Int32.Parse(dataGridView1[3, row].Value.ToString()), Int32.Parse(dataGridView1[4, row].Value.ToString()), Int64.Parse(dataGridView1[5, row].Value.ToString()), Int32.Parse(dataGridView1[6, row].Value.ToString()), Int32.Parse(dataGridView1[1, row].Value.ToString()));
                    ssta.Fill(ssdt);
                    dataGridView1.DataSource = ssdt;
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
        //
        //
        //
        //
        //
        //
        //
        //tab4
        DataView dv;
        CurrencyManager cm;
        
        public void FillDasetAndView()
        {
            sta.Fill(dt);
            dv = new DataView(dt);
            cm = (CurrencyManager)BindingContext[dv];
        }
        
        public void BindControl()
        {
            try
            {
                txtName1.DataBindings.Add("Text", dv, "SName");
                txtFamily1.DataBindings.Add("Text", dv, "SFamily");
                txtBirthday1.DataBindings.Add("Text", dv, "Birthday");
                txtPhone1.DataBindings.Add("Text", dv, "Phone");
                txtMobile1.DataBindings.Add("Text", dv, "Mobile");
                txtSID1.DataBindings.Add("Text", dv, "SID");
                txtAddress1.DataBindings.Add("Text", dv, "Address");
                mtb2.DataBindings.Add("Text", dv, "MelliCard");
                cbGrade1.DataBindings.Add("SelectedValue", dv, "GradeID");
                cbField1.DataBindings.Add("SelectedValue", dv, "FieldID");
                pictureBox2.DataBindings.Add("ImageLocation", dv, "Image");
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            cm.Position += 1;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            cm.Position -= 1;
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            cm.Position = 0;
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            cm.Position = dv.Count-1;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try{
            sta.DeleteQuery(Int32.Parse(txtSID1.Text));
            
            FillDasetAndView();
            ClearForm();
            BindControl();
            MessageBox.Show("رکورد مورد نظر حذف شد");
            }
             catch
            {
                MessageBox.Show("Error");
            }
        }
        public void ClearForm()
        {
            txtName1.DataBindings.Clear();
            txtFamily1.DataBindings.Clear();
            txtBirthday1.DataBindings.Clear();
            txtPhone1.DataBindings.Clear();
            txtMobile1.DataBindings.Clear();
            txtSID1.DataBindings.Clear();
            txtAddress1.DataBindings.Clear();
            mtb2.DataBindings.Clear();
            cbGrade1.DataBindings.Clear();
            cbField1.DataBindings.Clear();
            pictureBox2.DataBindings.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try{
                sta.UpdateQuery(txtName1.Text, txtFamily1.Text, txtAddress1.Text, pictureBox2.ImageLocation, Int64.Parse(txtPhone1.Text), txtBirthday1.Text, Int64.Parse(mtb2.Text), Int32.Parse(cbGrade1.SelectedValue.ToString()), Int32.Parse(cbField1.SelectedValue.ToString()), Int64.Parse(txtMobile1.Text),Int32.Parse(txtSID1.Text));
            FillDasetAndView();
            ClearForm();
            BindControl();
            MessageBox.Show("تغییر اعمال شد");
            }
             catch
            {
                MessageBox.Show("Error");
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
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

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

        private void cmb1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmb1.SelectedIndex != 0)
                cmb2.Enabled = true;
            else
                cmb2.Enabled = false;
        }
    }
}
