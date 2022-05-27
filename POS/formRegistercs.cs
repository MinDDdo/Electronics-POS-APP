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

namespace POS
{
    public partial class formRegistercs : Form
    {
        public formRegistercs()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var form = new formMember();
            form.Show();
            this.Hide();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (validFill())
            {
                postMemberDB();

                MessageBox.Show("Register success", "Notification");

                var form = new formMember();
                form.Show();
                this.Hide();
            }
        }
        private void postMemberDB()
        {
            DBConfig.conn.Open();

            var adapter = new SqlDataAdapter();
            string sql =
                "INSERT INTO MemberS " +
                $"VALUES(" +
                $"'{txtPhone.Text}'," +
                $"'{txtFname.Text}'," +
                $"'{txtLname.Text}'," +
                $"'{txtAddress.Text}'," +
                $"'U'," +
                $"'{txtEmail.Text}')";

            adapter.InsertCommand = DBConfig.conn.CreateCommand();
            adapter.InsertCommand.CommandText = sql;
            adapter.InsertCommand.ExecuteNonQuery();

            DBConfig.conn.Close();
        }
        private bool validFill()
        {
            if (txtPhone.Text == "" ||
                txtFname.Text == "" ||
                txtLname.Text == "" ||
                txtAddress.Text == "" ||
                txtEmail.Text == "" )
            {
                MessageBox.Show("Please complete imformation", "Notification");
                return false;
            }
            return true;
        }

    }
}
