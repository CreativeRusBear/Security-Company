using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Security
{
    public partial class fAuth : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["SqlCon"].ConnectionString;
        SqlConnection connection;
        public fAuth()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(172, 204, 196);
            panel1.ForeColor = Color.FromArgb(255, 255, 255);
            this.BackColor = Color.FromArgb(245, 245, 245);
            signInBtn.BackColor = Color.FromArgb(172, 204, 196);
            this.ForeColor= Color.FromArgb(168, 182, 192);
        }

        private void seePassword_CheckedChanged(object sender, EventArgs e)
        {
            if (seePassword.Checked) tbPassword.UseSystemPasswordChar = false;
            else tbPassword.UseSystemPasswordChar = true;
        }

        private void signInBtn_Click(object sender, EventArgs e)
        {
            SqlDataReader reader;
            string role = "";
            string username = "";
            try
            {
                using (connection = new SqlConnection(connectionString))
                {
                    string command = String.Format("Select sLog, sRole From tReg Where " +
                        "(sLog='{0}' Collate SQL_Latin1_General_CP1251_CS_AS) and " +
                        "(sPass='{1}' Collate SQL_Latin1_General_CP1251_CS_AS)",
                        tbLog.Text, tbPassword.Text);
                    SqlCommand Select = new SqlCommand(command, connection);
                    connection.Open();
                    reader = Select.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            username = reader[0].ToString().Trim();
                            role = reader[1].ToString();
                        }
                        seePassword.Checked = false;
                        fMain main = new fMain(role,username);
                        tbLog.Text = "";
                        tbPassword.Text = "";
                        main.Owner = this;
                        main.Show();
                    }
                    else
                    {
                        MessageBox.Show("Неверные логин или пароль",
                            "Ошибка",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tbLog_KeyPress(object sender, KeyPressEventArgs e)
        {
            char word = e.KeyChar;
            if ((word < 'A' || word > 'Z') && word != '\b' && (word < 'a' || word > 'z') && (word < '0' || word > '9')) e.Handled = true;
        }
    }
}
