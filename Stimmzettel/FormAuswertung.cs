using MetroFramework.Forms;
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
    public partial class FormAuswertung : MetroForm
    {
        private List<Stimmzettel> gezaehlteStimmzettel;
        private List<Kandidat> kandidaten = new List<Kandidat>();

        public FormAuswertung(List<Stimmzettel> gezaehlteStimmzettel)
        {
            InitializeComponent();
            dgvStimmen.ColumnCount = 2;
            dgvStimmen.AutoGenerateColumns = false;
            dgvStimmen.ReadOnly = true;         
            dgvStimmen.Enabled = true;
            dgvStimmen.Columns[0].Name = "Name";
            dgvStimmen.Columns[0].DataPropertyName = "name";
            dgvStimmen.Columns[1].Name = "Menge";
            dgvStimmen.Columns[1].DataPropertyName = "menge";
            this.gezaehlteStimmzettel = gezaehlteStimmzettel;
        }

        private void FormAuswertung_Load(object sender, EventArgs e)
        {
            string strKandidaten = Properties.Settings.Default.Kandidaten;
            var listStringKandidaten = strKandidaten.Split(';');
            foreach(var k in listStringKandidaten)
            {
                var stimmen = gezaehlteStimmzettel.Count(x => x.gewaehlteKandidaten.Contains(k));                
                kandidaten.Add(new Kandidat(k, stimmen));
            }
            kandidaten = kandidaten.OrderByDescending(o => o.stimmen).ToList<Kandidat>();
            foreach(var k in kandidaten)
            {               
                dgvStimmen.Rows.Add(k.name, k.stimmen);
            }
        }

        
    }
}
