using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace RegistrationFromADO
{
    public partial class Form1 : Form
    {
        private SqlConnection con = null; 
        private SqlCommand cmd = null;
        private SqlDataAdapter adapter = null;  
        private DataSet ds = null;  
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            using (con = new SqlConnection(ConfigurationManager.ConnectionStrings["HRConn"].ConnectionString))
            {
                using (cmd = new SqlCommand("usp_employeedetails", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                    DataTable dt = new DataTable();

                    cmd.Parameters.AddWithValue("@FirstName", TxtFirstNmae.Text);
                    cmd.Parameters.AddWithValue("@LastName", Txtlastname.Text);
                    cmd.Parameters.AddWithValue("@Birthdate", dtpbirthdate.Value);
                    cmd.Parameters.AddWithValue("@Gender", comboBoxgender.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Emailid", TxtEmailId.Text);
                    cmd.Parameters.AddWithValue("@password", Txtpassword.Text);
                    cmd.Parameters.AddWithValue("@ConfirmPassword", TxtConfrmpswd.Text);
                }

                try
                {
                    if (Txtpassword.Text == TxtConfrmpswd.Text)
                    {
                        adapter.Fill(dt);
                        Form1 f1 = new Form1();
                        f2.show();
                    }
                    else
                    {
                        MessageBox.Show("Password and confirm password is enterd ")
                    }
                }
            }
        }
    }
}
