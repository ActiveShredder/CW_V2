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
    public partial class CreateLevel : Form
    {
        PredictionEngineImpl pre = PredictionEngineImpl.getEngineInstance();

        public CreateLevel()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Level level = new Level();
            level.LevelName = comboBox1.SelectedText;

            Course c = new Course();
            c.CourseID = 2;
            c.CourseName = "12sda";
            pre.addLevel(level, c);
        }
    }
}
