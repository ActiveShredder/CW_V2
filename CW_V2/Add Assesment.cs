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
    public partial class Add_Assesment : Form
    {
        PredictionEngineImpl pre = PredictionEngineImpl.getEngineInstance();

        public Add_Assesment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Assessment assesment = new Assessment();
            assesment.AssessmentName = txtAssesmentName.Text;
            assesment.DueDate = dateTimePicker1.Value;
            assesment.Marks = Int32.Parse(maskedBox.Text);

            Module m = new Module();
            m.ModuleID = 12;
            pre.addAssessment(assesment, m);
        }
    }
}
