using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CW_V2
{
    public partial class FeedBack : Form
    {
        public FeedBack()
        {
            InitializeComponent();
        }

        private void buttonCreator(string name)
        {
            Button button = new Button();
            button.Text = name;
            button.Width = flowLayoutPanel1.Width;
            button.AutoSize = true;
            button.Margin = new Padding(1);
            button.Click += new EventHandler(buttonCreated_Click);
            flowLayoutPanel1.Controls.Add(button);
        }

        private void buttonCreated_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.Red;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 5; i++){
                buttonCreator("test");
            }
        }

        private void createDetails(string name, string precentage)
        {
            // labelName
            Label lbl1 = new Label();
            lbl1.AutoSize = true;
            lbl1.Location = new System.Drawing.Point(3, 0);
            lbl1.Size = new System.Drawing.Size(35, 13);
            lbl1.TabIndex = 0;
            lbl1.Text = name;

            // labelPercentage
            Label lbl2 = new Label();
            lbl2.AutoSize = true;
            lbl2.Location = new System.Drawing.Point(563, 0);
            lbl2.Size = new System.Drawing.Size(35, 13);
            lbl2.TabIndex = 1;
            lbl2.Text = precentage;

            ProgressBar bar = new ProgressBar();
            bar.Location = new System.Drawing.Point(150, 3);
            bar.Size = new System.Drawing.Size(407, 22);
            bar.TabIndex = 2;

            TableLayoutPanel tlp = new TableLayoutPanel();
            tlp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top 
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            tlp.BackColor = System.Drawing.SystemColors.AppWorkspace;
            tlp.ColumnCount = 3;
            tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.72727F));
            tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.63636F));
            tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.63636F));
            tlp.Controls.Add(lbl1, 0, 0);
            tlp.Controls.Add(lbl2, 2, 0);
            tlp.Controls.Add(bar, 1, 0);
            tlp.Location = new System.Drawing.Point(3, 3);
            tlp.RowCount = 1;
            tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlp.Size = new System.Drawing.Size(649, 28);
            tlp.TabIndex = 0;

            flowLayoutPanel2.Controls.Add(tlp);
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {
            createDetails("hello", "30%");
        }


    }
}
