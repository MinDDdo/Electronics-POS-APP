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
    public partial class BankTransfer : Form
    {
        double totalPrice;
        string pay = "Pay by Bank transfer";
        public BankTransfer()
        {
            InitializeComponent();
        }

        private void BankTransfer_Load(object sender, EventArgs e)
        {
            showTotalDetail();
        }
        private void showTotalDetail()
        {
            lblAmount.Text = ProductData.Proname.Count.ToString("#,#");

            totalPrice = 0;
            for (int i = 0; i < ProductData.Proname.Count; i++)
            {
                totalPrice += ProductData.amount[i] * ProductData.Proprice[i];
            }
            lblTotal.Text = totalPrice.ToString("#,#.00");
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            MemberData.clearData();

            var form = new formPayment();
            form.Show();
            this.Hide();
        }

        private void lblConfirm_Click(object sender, EventArgs e)
        {
            putProductDB();
            postReq();

            // Clear
            MemberData.clearData();
            ProductData.ClearData();

            MessageBox.Show("Purchase success", "Notification");

            // Go to Home form
            var form = new formIndex();
            form.Show();
            this.Hide();
        }
        private void putProductDB()
        {
            DBConfig.conn.Open();
            try
            {
                for (int i = 0; i < ProductData.Proname.Count; i++)
                {
                    var adapter = new SqlDataAdapter();

                    string sql =
                        $"UPDATE Products " +
                        $"SET amount = '{ProductData.amount[i]}' " +
                        $"WHERE product_id = '{ProductData.ProID[i]}'";
                    adapter.UpdateCommand = DBConfig.conn.CreateCommand();
                    adapter.UpdateCommand.CommandText = sql;
                    adapter.UpdateCommand.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            DBConfig.conn.Close();
        }


        private void postReq()
        {
            //Date now when payment
            DateTime dt = new DateTime();
            dt = DateTime.Now;
            string dateNow = dt.ToString().Split()[0];
            Console.WriteLine(dateNow);

            //Check used member with phone
            bool member = MemberData.id_pur != null;
            string member_col = (member) ? "member_id," : "";
            string member_id = (member) ? $"'{MemberData.id_pur}'," : "";

            DBConfig.conn.Open();

            try
            {
                for (int i = 0; i < ProductData.Proname.Count; i++)
                {
                    var adapter = new SqlDataAdapter();

                    string sql =
                        $"INSERT INTO RequestProducts " +
                        $"(product_id," +
                        $"req_amount," +
                        $"{member_col}" +
                        $"req_price, " +
                        $"req_date, " +
                        $"req_status," +
                        $"payment_method," +
                        $"payment_status," +
                        $"payment_date) " +
                        $"VALUES(" +
                        $"'{ProductData.ProID[i]}'," +
                        $"'{ProductData.Proamount[i]}'," +
                        $"{member_id}" +
                        $"'{ProductData.Proprice[i] * ProductData.Proamount[i]}'," +
                        $"'{dateNow}'," +
                        $" 'YES'," +
                        $"'{pay}'," +
                        $"'YES'," +
                        $"'{dateNow}'" +
                        $")";

                    adapter.InsertCommand = DBConfig.conn.CreateCommand();
                    adapter.InsertCommand.CommandText = sql;
                    adapter.InsertCommand.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            DBConfig.conn.Close();
        }
    }
}
