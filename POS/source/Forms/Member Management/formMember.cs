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
    }
}
