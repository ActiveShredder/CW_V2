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
    public partial class Home : Form
    {
        private Label label;


        public Home()
        {
            InitializeComponent();
            disableAll();
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            //CreateCourse course = new CreateCourse();
            //course.Show();
            createLabel("Test", listBox1);
        }

        private void btnAddLevel_Click(object sender, EventArgs e)
        {
            // CreateLevel level = new CreateLevel();
            //level.Show();
            createLabel("Test", listBox2);
        }

        private void btnAddModule_Click(object sender, EventArgs e)
        {
            // AddModule module = new AddModule();
            //module.Show();
            createLabel("Test", listBox3);
        }

        private void btnAddAssesment_Click(object sender, EventArgs e)
        {
            //Add_Assesment assesment = new Add_Assesment();
            // assesment.Show();
            createLabel("Test", listBox4);
        }

        private void createLabel(string name, ListBox panel)
        {
            panel.Items.Add(name);
        }

        private void rightClickOparetor(ListBox list, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                if (list.SelectedIndex != -1)
                {
                    MenuItem delete = new MenuItem();
                    MenuItem edit = new MenuItem();
                    MenuItem fedback = new MenuItem();

                    delete.Text = "&Delete";
                    edit.Text = "&Edit";
                    fedback.Text = "&Feedback";

                    ContextMenu cm = new ContextMenu();

                    cm.MenuItems.Add(fedback);
                    cm.MenuItems.Add(edit);
                    cm.MenuItems.Add(delete);

                    delete.Click += new System.EventHandler(this.menuDelete_Click);
                    delete.Click += new System.EventHandler(this.menuEdit_Click);
                    delete.Click += new System.EventHandler(this.menuFeedback_Click);

                    list.ContextMenu = cm;
                }
            }
        }

        private void menuEdit_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex != -1){
                
            }
        }

        private void menuDelete_Click(object sender, EventArgs e)
        {

        }

        private void menuFeedback_Click(object sender, EventArgs e)
        {

        }

        private void Home_Enter(object sender, EventArgs e)
        {
            disableAll();
        }
        
        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            rightClickOparetor(listBox1, e);
            disableAll();
        }

        private void disableAll()
        {
            switch(listBox1.SelectedIndex){
                case -1:
                    listBox2.Visible = false;
                    btnAddLevel.Visible = false;
                    break;
                default:
                    listBox2.Visible = true;
                    btnAddLevel.Visible = true;
                    break;
            }

            switch(listBox2.SelectedIndex){
                case -1:
                    listBox3.Visible = false;
                    btnAddModule.Visible = false;
                    break;
                default:
                    listBox3.Visible = true;
                    btnAddModule.Visible = true;
                    break;
            }

            switch (listBox3.SelectedIndex)
            {
                case -1:
                    listBox4.Visible = false;
                    btnAddAssesment.Visible = false;
                    break;
                default:
                    listBox4.Visible = true;
                    btnAddAssesment.Visible = true;
                    break;
            }
        }

        private void listBox2_MouseDown(object sender, MouseEventArgs e)
        {
            rightClickOparetor(listBox2, e);
            disableAll();
        }

        private void listBox3_MouseDown(object sender, MouseEventArgs e)
        {
            rightClickOparetor(listBox3, e);
            disableAll();
        }

        private void listBox4_MouseDown(object sender, MouseEventArgs e)
        {
            rightClickOparetor(listBox4, e);
        }


    }
}
