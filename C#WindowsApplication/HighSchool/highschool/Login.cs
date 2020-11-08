using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace highschool
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnlogin_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=HighSchool;Integrated Security=True");
            con.Open();
            SqlCommand cmm = new SqlCommand("select * from users where Username=@u and password=@p", con);
            cmm.Parameters.AddWithValue("@u", textBox1.Text);
            cmm.Parameters.AddWithValue("@p", textBox2.Text);
            SqlDataReader dr;
            dr = cmm.ExecuteReader();  //dr=motaghayere hafeze ke natijeye ejraye dastur select ra dar khod zakhire mikonad.
            if (dr.Read() == true)  //yani user o pass dorost ast
            {
                if (dr["RoleID"].ToString().Trim() == "1")
                {
                    frmDaftardar frm = new frmDaftardar();
                    frm.Show();
                    this.Hide();
                }
                if (dr["RoleID"].ToString().Trim() == "2")
                {
                    frmNazem frm = new frmNazem();
                    frm.Show();
                    this.Hide();
                }

                if (dr["RoleID"].ToString().Trim() == "3")
                {
                    frmMAmuzeshi frm = new frmMAmuzeshi();
                    frm.Show();
                    this.Hide();
                }

            }
            else
            {
                MessageBox.Show("نام کاربری یا رمز عبور اشتباه است.");
            }
        }
    }
}
