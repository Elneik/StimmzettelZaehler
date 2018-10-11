using MetroFramework.Forms;
using NLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stimmzettel
{
    public partial class FormProperties : MetroForm
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public List<Stimmzettel> backupStimmzettel = new List<Stimmzettel>();

        public FormProperties()
        {
            InitializeComponent();
        }

        private void FormProperties_Load(object sender, EventArgs e)
        {
            rtbKandidaten.Text = Properties.Settings.Default.Kandidaten;
            nudBackup.Value = Convert.ToInt32(Properties.Settings.Default.AnzahlStimmzettelbisBackup);
            nudMaxStimmen.Value = Convert.ToInt32(Properties.Settings.Default.MaximaleAuswahl);
            nudXPosition.Value = Convert.ToInt32(Properties.Settings.Default.X_Checkbox);
            nudYPosition.Value = Convert.ToInt32(Properties.Settings.Default.Y_Checkbox);
            nudWindowWidth.Value = Convert.ToInt32(Properties.Settings.Default.WindowWidth);
            nudWindowHeight.Value = Convert.ToInt32(Properties.Settings.Default.WindowHeight);
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            try
            {                
                Properties.Settings.Default.Kandidaten = rtbKandidaten.Text;
                Properties.Settings.Default.AnzahlStimmzettelbisBackup = Convert.ToInt32(nudBackup.Value);
                Properties.Settings.Default.MaximaleAuswahl = Convert.ToInt32(nudMaxStimmen.Value);
                Properties.Settings.Default.X_Checkbox = Convert.ToInt32(nudXPosition.Value);
                Properties.Settings.Default.Y_Checkbox = Convert.ToInt32(nudYPosition.Value);
                Properties.Settings.Default.WindowWidth = Convert.ToInt32(nudWindowWidth.Value);
                Properties.Settings.Default.WindowHeight = Convert.ToInt32(nudWindowHeight.Value);
                Properties.Settings.Default.Save();
                this.Close();
            }
            catch(Exception ex)
            {
                ShowControlXSeconds.ShowLabel(lblError, 4);
            }
        }

        private void cmdLoadBackup_Click(object sender, EventArgs e)
        {
            if (ofdLoadBackup.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                try
                {
                    this.backupStimmzettel = Serializer.Load<List<Stimmzettel>>(ofdLoadBackup.FileName);
                }
                catch(Exception ex)
                {
                    logger.Error(ex);
                }
            }
        }
    }
}
