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
    public partial class MakeCourse : Form
    {
        PredictionEngineImpl pre = PredictionEngineImpl.getEngineInstance();

        public MakeCourse()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Course cw = new Course();
            cw.CourseName = textBox1.Text;
            pre.addCourse(cw);
        }
    }
}
