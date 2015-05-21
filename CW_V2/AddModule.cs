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
    public partial class AddModule : Form
    {
        PredictionEngineImpl pre = PredictionEngineImpl.getEngineInstance();
        public AddModule()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Module module = new Module();
            module.ModuleCode = txtModuleCode.Text;
            module.ModuleName = txtModuleName.Text;
            module.ModileCredits = Int32.Parse(txtModuleCredits.Text);

            Level level = new Level();
            level.LevelID = 2;
            level.LevelName = "wq";
            
            pre.addModule(module, level);
        }
    }
}
