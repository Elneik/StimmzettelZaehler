using MetroFramework.Controls;
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
    public partial class MainForm : MetroForm
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public List<Stimmzettel> gezaehlteStimmzettel = new List<Stimmzettel>();
        public List<MetroCheckBox> checkBoxes = new List<MetroCheckBox>(); 
        int xCheckBox;
        int yCheckBox;
        private int stimmzettelSinceLastBackup = 0;
        

        public MainForm()
        {
            InitializeComponent();
            loadWindowSize();
            xCheckBox = Convert.ToInt32(Properties.Settings.Default.X_Checkbox);
            yCheckBox = Convert.ToInt32(Properties.Settings.Default.Y_Checkbox);
            createCheckboxes();            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void loadWindowSize()
        {
            this.Height = Convert.ToInt32(Properties.Settings.Default.WindowHeight);
            this.Width = Convert.ToInt32(Properties.Settings.Default.WindowWidth);
        }


        private void createCheckboxes()
        {
            string kandidatenStrings = Properties.Settings.Default.Kandidaten;
            var splitted = kandidatenStrings.Split(';').ToList();
            foreach(var s in splitted)
            {               
                var checkBox = new MetroCheckBox();
                checkBox.Checked = false;
                checkBox.Name = "cB" + s;
                checkBox.Text = s;
                checkBox.Location = new Point(xCheckBox, yCheckBox);                
                checkBox.Height = 40;
                checkBoxes.Add(checkBox);                
                this.Controls.Add(checkBox);
                yCheckBox += 40;
                if(this.Height - 100 < yCheckBox)
                {
                    xCheckBox += 200;
                    yCheckBox = Convert.ToInt32(Properties.Settings.Default.Y_Checkbox);
                }               
            }
        }

        private void ChangeLabel(Label lbl, bool success)
        {
            if (success)
            {
                lbl.Text = "Erfolgreich";
                lbl.ForeColor = Color.Green;                
            }
            else
            {
                lbl.Text = "Fehler";
                lbl.ForeColor = Color.Red;
            }
            ShowControlXSeconds.ShowLabel(lbl, 2);
        }


        private void cmdNext_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach(var c in checkBoxes)
            {
                if (c.Checked)
                    count++;
            }
            if(count > Properties.Settings.Default.MaximaleAuswahl || count < 1)
            {
                ChangeLabel(lblSaved, false);
                logger.Info("Stimmzettel wurde nicht gespeichert. Falsche Anzahl an Stimmen");
                return;
            }
            int id = Convert.ToInt32(nudId.Value);
            var stimmzettel = gezaehlteStimmzettel.Find(s => s.id == id);
            var stimmen = getStimmen();
            if (stimmzettel != null)
            {
                stimmzettel.gewaehlteKandidaten = stimmen;
                logger.Info("Stimmzettel " + id + " wurde geändert");
            }
            else
            {
                gezaehlteStimmzettel.Add(new Stimmzettel(id, stimmen));
                logger.Info("Stimmzettel " + id + " wurde gespeichert");
            }
            stimmzettelSinceLastBackup++;
            if (stimmzettelSinceLastBackup >= Properties.Settings.Default.AnzahlStimmzettelbisBackup)
            {
                Save();
                stimmzettelSinceLastBackup = 0;
            }
            nudId.Value = id + 1;
            ChangeLabel(lblSaved, true);
        }

        private void clearCheckboxes()
        {
            foreach (var c in checkBoxes)
                c.Checked = false;
        }

        private List<String> getStimmen()
        {
            var stimmen = new List<String>();
            foreach (var c in checkBoxes)
            {
                if (c.Checked)
                    stimmen.Add(c.Text);
            }
            return stimmen;
        }

        private void fillCheckBoxes(List<String> gewaehlteKandidaten)
        {
            foreach(var k in gewaehlteKandidaten)
            {
                var checkbox = checkBoxes.Find(c => c.Text == k);
                if (k != null)
                    checkbox.Checked = true;
            }
        }

        private void nudId_ValueChanged(object sender, EventArgs e)
        {
            clearCheckboxes();
            int id = Convert.ToInt32(nudId.Value);
            var stimmzettel = gezaehlteStimmzettel.Find(s => s.id == id);
            if (stimmzettel != null)
            {
                fillCheckBoxes(stimmzettel.gewaehlteKandidaten);
            }
        }

        private void cmdEinstellungen_Click(object sender, EventArgs e)
        {
          
            FormProperties properties = new FormProperties();
            properties.ShowDialog();   
            if(properties.backupStimmzettel.Count > 0)
            {
                gezaehlteStimmzettel = properties.backupStimmzettel;
                int id = findHighestId();
                nudId.Value = id + 1;
            }
            loadWindowSize();
            deleteCheckboxes();
            createCheckboxes();
        }

        private void Save()
        {
            string directory = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + @"\Backup";
            Serializer.Save(directory + @"\Backup_" + DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss") + ".bin", this.gezaehlteStimmzettel);
        }

        private int findHighestId()
        {
            int highestID = 0;
            foreach(var s in gezaehlteStimmzettel)
            {
                if (s.id > highestID)
                    highestID = s.id;
            }
            return highestID;
        }

        private void deleteCheckboxes()
        {
            foreach(var c in checkBoxes)
            {
                this.Controls.Remove(c);
            }
            checkBoxes = new List<MetroCheckBox>();
            xCheckBox = Convert.ToInt32(Properties.Settings.Default.X_Checkbox);
            yCheckBox = Convert.ToInt32(Properties.Settings.Default.Y_Checkbox);
        }

        private void cmdAuswertung_Click(object sender, EventArgs e)
        {
            string directory = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + @"\Backup";
            Serializer.Save(directory + @"\Final" + DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss") + ".bin", this.gezaehlteStimmzettel);
            FormAuswertung auswertung = new FormAuswertung(gezaehlteStimmzettel);
            auswertung.ShowDialog();

        }

        private void cmdVergleich_Click(object sender, EventArgs e)
        {            
            var vergleich = new FormVergleich();
            vergleich.ShowDialog();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Save();
        }
    }
}
