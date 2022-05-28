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
    public partial class formMember : Form
    {
        public formMember()
        {
            InitializeComponent();
        }

        private void lblProducts_Click(object sender, EventArgs e)
        {
            MemberData.clearData();
            var form = new formIndex();
            form.Show();
            this.Hide();
        }

        private void lbRegister_Click(object sender, EventArgs e)
        {
            var form = new formRegistercs();
            form.Show();
            this.Hide();
        }

        private void lbAccount_Click(object sender, EventArgs e)
        {
            if(validFill()) fetchMemberData();
        }
        private void fetchMemberData()
        {
            DBConfig.conn.Open();
            var adapter = new SqlDataAdapter();
            var tb = new DataTable();
            string sql = "SELECT * FROM Members";

            adapter.SelectCommand = new SqlCommand(sql, DBConfig.conn);
            adapter.Fill(tb);

            sql = $"member_id = '{txtPhone.Text}'";
            try
            {
                DataRow[] dr = tb.Select(sql);
                MemberData.id = dr[0]["member_id"].ToString();
                MemberData.fname = dr[0]["fname"].ToString();
                MemberData.lname = dr[0]["lname"].ToString();
                MemberData.address = dr[0]["address"].ToString();
                MemberData.status = dr[0]["member_status"].ToString();
                MemberData.email = dr[0]["email"].ToString();

                MessageBox.Show("Member account successed");

                var form = new formMemberDetail();
                form.Show();
                this.Hide();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Member account doesn't exist", "Error");
            }
            DBConfig.conn.Close();
        }
        private bool validFill()
        {
            if(txtPhone.Text == "")
            {
                MessageBox.Show("Please complete phone", "Error");
                return false;
            }
            return true;
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            var form = new formLogin();
            form.Show();
            this.Hide();
        }
    }
}
