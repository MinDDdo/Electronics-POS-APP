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
    public partial class formPayment : Form
    {
        double totalPrice;
        public formPayment()
        {
            InitializeComponent();
        }

        private void formPayment_Load(object sender, EventArgs e)
        {
            ShowTotalDetail();
        }
        private void ShowTotalDetail()
        {
            lblAmount.Text = ProductData.Proname.Count.ToString("#,#");
            totalPrice = 0;
            for (int i = 0; i < ProductData.Proname.Count; i++)
            {
                totalPrice += ProductData.Proamount[i] * ProductData.Proprice[i];
            }
            lblTotal.Text = totalPrice.ToString("#,#.00");
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            var back = new ProductDetail();
            back.Show();
            this.Hide();
        }

        private void lblOK_Click(object sender, EventArgs e)
        {
            if(txtPhoneMem.Text.Length != 10)
            {
                MessageBox.Show("Please phone 10 digit", "Error");
            }
            else
            {
                fetchMemberData();
            }
        }
        private void fetchMemberData()
        {
            DBConfig.conn.Open();
            var adapter = new SqlDataAdapter();
            var tb = new DataTable();
            string sql = "SELECT * FROM Members";

            adapter.SelectCommand = new SqlCommand(sql, DBConfig.conn);
            adapter.Fill(tb);

            sql = $"member_id={txtPhoneMem.Text}";
            try
            {
                DataRow[] dr = tb.Select(sql);
                lblMemname.Text = dr[0]["fname"].ToString() + "" + dr[0]["lname"].ToString();
                MemberData.id_pur = dr[0]["member_id"].ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            DBConfig.conn.Close();
        }

        private void txtPhoneMem_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
