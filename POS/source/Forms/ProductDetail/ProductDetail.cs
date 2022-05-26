using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class ProductDetail : Form
    {
        private double totalPrice;
        public ProductDetail()
        {
            InitializeComponent();
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            var Index = new formIndex();
            Index.Show();
            this.Hide();
        }

        private void ProductDetail_Load(object sender, EventArgs e)
        {
            ShowProductDetail();
            ShowTotalDetail();
        }
        private void ShowProductDetail()
        {
            string product_name = "";
            string product_amount = "";
            string product_price = "";
            int i = 0;
            foreach(var itm in ProductData.Proname)
            {
                product_name += itm;
                product_amount += ProductData.Proamount[i];
                product_price += ProductData.Proprice[i].ToString("#,#.00");

                product_name += ((i - 1 < ProductData.Proname.Count) ? "\n" : "");
                product_amount += ((i - 1 < ProductData.Proname.Count) ? "\n" : "");
                product_price += ((i - 1 < ProductData.Proname.Count) ? "\n" : "");

                i++;
            }
            lbName.Text = product_name;
            lbAmount.Text = product_amount;
            lbPrice.Text = product_price;
        }
        private void ShowTotalDetail()
        {
            lblAmount.Text = ProductData.Proname.Count.ToString("#,#");
            totalPrice = 0;
            for(int i = 0; i < ProductData.Proname.Count; i++)
            {
                totalPrice += ProductData.Proamount[i] * ProductData.Proprice[i];
            }
            lblTotal.Text = totalPrice.ToString("#,#.00");
        }

        //private void lblCal_Click(object sender, EventArgs e)
        //{
        //    double amount = Convert.ToDouble(txtCash.Text);

        //    double change = amount - totalPrice;
        //    if(change >= 0)
        //    {
        //        txtChange.Text = change.ToString("#,#.00");
        //        canBuy = true;
        //    }
        //    else
        //    {
        //        MessageBox.Show("Money not enough");
        //    }
        //}

        private void lblConfirm_Click(object sender, EventArgs e)
        {
            var payment = new formPayment();
            payment.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void lblAmount_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
