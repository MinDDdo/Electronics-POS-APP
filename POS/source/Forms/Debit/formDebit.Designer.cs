
namespace POS
{
    partial class formDebit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblConfirm = new System.Windows.Forms.Label();
            this.lblBack = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblConfirm
            // 
            this.lblConfirm.BackColor = System.Drawing.Color.DimGray;
            this.lblConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblConfirm.ForeColor = System.Drawing.Color.White;
            this.lblConfirm.Location = new System.Drawing.Point(286, 312);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new System.Drawing.Size(259, 34);
            this.lblConfirm.TabIndex = 40;
            this.lblConfirm.Text = "               Confirm";
            this.lblConfirm.Click += new System.EventHandler(this.lblConfirm_Click);
            // 
            // lblBack
            // 
            this.lblBack.BackColor = System.Drawing.Color.DimGray;
            this.lblBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblBack.ForeColor = System.Drawing.Color.White;
            this.lblBack.Location = new System.Drawing.Point(41, 31);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(147, 34);
            this.lblBack.TabIndex = 39;
            this.lblBack.Text = "       Back";
            this.lblBack.Click += new System.EventHandler(this.lblBack_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Thistle;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(41, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(297, 34);
            this.label4.TabIndex = 38;
            this.label4.Text = "                    Total";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LemonChiffon;
            this.panel3.Controls.Add(this.lblTotal);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.lblAmount);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Location = new System.Drawing.Point(41, 145);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(297, 145);
            this.panel3.TabIndex = 37;
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblTotal.ForeColor = System.Drawing.Color.Black;
            this.lblTotal.Location = new System.Drawing.Point(87, 89);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(183, 30);
            this.lblTotal.TabIndex = 15;
            this.lblTotal.Text = " Price";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(11, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 34);
            this.label3.TabIndex = 15;
            this.label3.Text = "Amount :";
            // 
            // lblAmount
            // 
            this.lblAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblAmount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblAmount.ForeColor = System.Drawing.Color.Black;
            this.lblAmount.Location = new System.Drawing.Point(118, 37);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(152, 30);
            this.lblAmount.TabIndex = 16;
            this.lblAmount.Text = "100";
            this.lblAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(11, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 25);
            this.label10.TabIndex = 16;
            this.label10.Text = "Total : ";
            // 
            // formDebit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(577, 375);
            this.Controls.Add(this.lblConfirm);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel3);
            this.Name = "formDebit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formDebit";
            this.Load += new System.EventHandler(this.formDebit_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label label10;
    }
}