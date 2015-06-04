using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RollDiced
{
    public partial class settings : Form
    {
        
        public settings()
        {
            InitializeComponent();
            this.chk_ClearUI.Checked = MainDiceRoll.oSettings.clearSearch;
            this.chk_PlaySound.Checked = MainDiceRoll.oSettings.playSound;
        }

        private void btn_SaveSettings_Click(object sender, EventArgs e)
        {
            MainDiceRoll.oSettings.clearSearch = this.chk_ClearUI.Checked;
            MainDiceRoll.oSettings.playSound = this.chk_PlaySound.Checked;
            SystemSettings.SaveSettings(MainDiceRoll.oSettings, MainDiceRoll.location);
            this.Close();
        }
    }
}
