using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GradePredictionEngine.PredictionEngine;
using GradePredictionEngine.DAO.Model;

namespace CW_V2
{
    public partial class CreateCourse : Form
    {
        Home home;
        PredictionEngineImpl pre = PredictionEngineImpl.getEngineInstance();
        public CreateCourse(Home home)
        {
            InitializeComponent();
            this.home = home;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Course cw = new Course();
            cw.CourseName = txtCourseName.Text;
            pre.addCourse(cw);
            home.Enabled = true;
            this.Close();
        }

        private void CreateCourse_Load(object sender, EventArgs e)
        {

        }
    }
}
