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
    public partial class FormVergleich : MetroForm
    {
        private List<Stimmzettel> file1 = new List<Stimmzettel>();
        private List<Stimmzettel> file2 = new List<Stimmzettel>();

        public FormVergleich()
        {
            InitializeComponent();
            dgvStimmen.ColumnCount = 3;
            dgvStimmen.AutoGenerateColumns = false;
            dgvStimmen.ReadOnly = true;
            dgvStimmen.Enabled = true;
            dgvStimmen.Columns[0].Name = "Id";
            dgvStimmen.Columns[0].DataPropertyName = "id";
            dgvStimmen.Columns[0].Width = 60;
            dgvStimmen.Columns[1].Name = "File1";
            dgvStimmen.Columns[1].DataPropertyName = "file1";
            dgvStimmen.Columns[1].Width = 550;
            dgvStimmen.Columns[2].Name = "File2";
            dgvStimmen.Columns[2].DataPropertyName = "file2";
            dgvStimmen.Columns[2].Width = 550;

        }

        private void FormVergleich_Load(object sender, EventArgs e)
        {
            
        }


        private void cmdVergleich_Click(object sender, EventArgs e)
        {
            try
            {
                this.file1 = Serializer.Load<List<Stimmzettel>>(tbFile1.Text);
                this.file2 = Serializer.Load<List<Stimmzettel>>(tbFile2.Text);
                var firstNotSecond = file1.Where(s => !file2.Any(s2 => s.id == s2.id));
                var secondNotFirst = file2.Where(s => !file1.Any(s2 => s.id == s2.id));
                foreach (var f in firstNotSecond)
                {
                    dgvStimmen.Rows.Add(f.id, String.Join(", ", f.gewaehlteKandidaten.ToArray()), "");
                }
                foreach (var s in secondNotFirst)
                {
                    dgvStimmen.Rows.Add(s.id, "",String.Join(", ", s.gewaehlteKandidaten.ToArray()));
                }
                var sameList1 = file1.Except(firstNotSecond).ToList();
                var sameList2 = file2.Except(secondNotFirst).ToList();
                foreach(var s in sameList1)
                {
                    var s2 = sameList2.Find(x => x.id == s.id);
                    if (!s.gewaehlteKandidaten.SequenceEqual(s2.gewaehlteKandidaten))
                        dgvStimmen.Rows.Add(s.id, String.Join(", ", s.gewaehlteKandidaten.ToArray()), String.Join(", ", s2.gewaehlteKandidaten.ToArray()));
                }
            }

            catch(Exception ex)
            {
                MessageBox.Show("Fehler beim Laden der Datei: " + ex, "Fehler");
            }


        }

        private void tbFile1_Enter_1(object sender, EventArgs e)
        {
            if (ofdFiles.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tbFile1.Text = ofdFiles.FileName;
            }
        }

        private void tbFile2_Enter(object sender, EventArgs e)
        {
            if (ofdFiles.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tbFile2.Text = ofdFiles.FileName;
            }
        }
    }
}
