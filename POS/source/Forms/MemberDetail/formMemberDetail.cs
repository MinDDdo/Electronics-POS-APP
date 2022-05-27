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
    public partial class formMemberDetail : Form
    {
        public formMemberDetail()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MemberData.clearData();
            var form = new formMember();
            form.Show();
            this.Hide();
        }

        private void formMemberDetail_Load(object sender, EventArgs e)
        {
            init();
            status();
        }
        private void init()
        {
            txtPhone.Text = MemberData.id;
            txtFname.Text = MemberData.fname;
            txtLname.Text = MemberData.lname;
            txtAddress.Text = MemberData.address;
            txtEmail.Text = MemberData.email;
        }
        private void status()
        {
            if (MemberData.status == "U")
            {
                lblstatus.Text = "Unlocked";
                unlocked();
            }
            if (MemberData.status == "L")
            {
                lblstatus.Text = "Locked";
                locked();
            }
        }
        private void unlocked()
        {
            lblstatus.BackColor = Color.FromArgb(28, 255, 128);
        }
        private void locked()
        {
            lblstatus.BackColor = Color.FromArgb(255, 128, 128);
        }

        private void lblEdit_Click(object sender, EventArgs e)
        {
            if (lblEdit.Text == "Edit")
            {
                lblEdit.Text = "Cancel";
                enableText(true);
            }
            else
            {
                lblEdit.Text = "Edit";
                enableText(false);
                init();
            }
        }
        private void enableText(bool b)
        {
            txtFname.Enabled = b;
            txtLname.Enabled = b;
            txtAddress.Enabled = b;
            txtEmail.Enabled = b;
            lblSave.Visible = b;
        }

        private void lblSave_Click(object sender, EventArgs e)
        {
            if(validChange() && validFill())
            {
                lblEdit.Text = "Edit";
                enableText(false);
                putMemberDB();
            }
        }
        private void putMemberDB()
        {
            DBConfig.conn.Open();

            var adapter = new SqlDataAdapter();
            string sql = $"UPDATE Members " +
                $"SET fname ='{txtFname.Text}'," +
                $"lname = '{txtLname.Text}'," +
                $"address = '{txtAddress.Text}'," +
                $"email = '{txtEmail.Text}' " +
                $"WHERE member_id = '{txtPhone.Text}'";

            adapter.UpdateCommand = DBConfig.conn.CreateCommand();
            adapter.UpdateCommand.CommandText = sql;
            adapter.UpdateCommand.ExecuteNonQuery();

            MessageBox.Show("Save success");
            DBConfig.conn.Close();
        }
        private bool validChange()
        {
            if(txtFname.Text == MemberData.fname &&
                txtLname.Text == MemberData.lname &&
                txtAddress.Text == MemberData.address &&
                txtEmail.Text == MemberData.email)
            {
                MessageBox.Show("Cannot save");
                return false;
            }
            return true;
        }
        private bool validFill()
        {
            if (txtFname.Text == "" ||
                txtLname.Text == "" ||
                txtAddress.Text == ""||
                txtEmail.Text == "")
            {
                MessageBox.Show("Please complete data");
                return false;
            }
            return true;
        }

        private void lblstatus_Click(object sender, EventArgs e)
        {
            if(lblstatus.Text == "Unlocked")
            {
                lblstatus.Text = "Locked";
                locked();

                putStatusMem("L");
            }
            else
            {
                lblstatus.Text = "Unlocked";
                unlocked();

                putStatusMem("U");
            }
        }
        private void putStatusMem(string status)
        {
            DBConfig.conn.Open();

            var adapter = new SqlDataAdapter();
            string sql = $"UPDATE Members " +
                $"SET member_status = '{status}' " +
                $"WHERE member_id = '{txtPhone.Text}'";

            adapter.UpdateCommand = DBConfig.conn.CreateCommand();
            adapter.UpdateCommand.CommandText = sql;
            adapter.UpdateCommand.ExecuteNonQuery();

            DBConfig.conn.Close();
        }
    }
}
