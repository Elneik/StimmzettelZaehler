namespace Stimmzettel
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.nudId = new System.Windows.Forms.NumericUpDown();
            this.cmdNext = new MetroFramework.Controls.MetroButton();
            this.lblSaved = new System.Windows.Forms.Label();
            this.cmdEinstellungen = new System.Windows.Forms.Button();
            this.cmdAuswertung = new MetroFramework.Controls.MetroButton();
            this.cmdVergleich = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.nudId)).BeginInit();
            this.SuspendLayout();
            // 
            // nudId
            // 
            this.nudId.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nudId.Location = new System.Drawing.Point(222, 63);
            this.nudId.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudId.Name = "nudId";
            this.nudId.Size = new System.Drawing.Size(114, 20);
            this.nudId.TabIndex = 1;
            this.nudId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudId.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudId.ValueChanged += new System.EventHandler(this.nudId_ValueChanged);
            // 
            // cmdNext
            // 
            this.cmdNext.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cmdNext.Location = new System.Drawing.Point(222, 868);
            this.cmdNext.Name = "cmdNext";
            this.cmdNext.Size = new System.Drawing.Size(123, 23);
            this.cmdNext.TabIndex = 2;
            this.cmdNext.Text = "Nächster Stimmzettel";
            this.cmdNext.Click += new System.EventHandler(this.cmdNext_Click);
            // 
            // lblSaved
            // 
            this.lblSaved.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblSaved.AutoSize = true;
            this.lblSaved.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaved.Location = new System.Drawing.Point(259, 844);
            this.lblSaved.Name = "lblSaved";
            this.lblSaved.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSaved.Size = new System.Drawing.Size(51, 20);
            this.lblSaved.TabIndex = 3;
            this.lblSaved.Text = "label1";
            this.lblSaved.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSaved.Visible = false;
            // 
            // cmdEinstellungen
            // 
            this.cmdEinstellungen.BackColor = System.Drawing.Color.Transparent;
            this.cmdEinstellungen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdEinstellungen.ForeColor = System.Drawing.Color.Transparent;
            this.cmdEinstellungen.Image = ((System.Drawing.Image)(resources.GetObject("cmdEinstellungen.Image")));
            this.cmdEinstellungen.Location = new System.Drawing.Point(14, 21);
            this.cmdEinstellungen.Name = "cmdEinstellungen";
            this.cmdEinstellungen.Size = new System.Drawing.Size(36, 32);
            this.cmdEinstellungen.TabIndex = 4;
            this.cmdEinstellungen.UseVisualStyleBackColor = false;
            this.cmdEinstellungen.Click += new System.EventHandler(this.cmdEinstellungen_Click);
            // 
            // cmdAuswertung
            // 
            this.cmdAuswertung.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdAuswertung.Location = new System.Drawing.Point(461, 30);
            this.cmdAuswertung.Name = "cmdAuswertung";
            this.cmdAuswertung.Size = new System.Drawing.Size(75, 23);
            this.cmdAuswertung.TabIndex = 5;
            this.cmdAuswertung.Text = "Auswertung";
            this.cmdAuswertung.Click += new System.EventHandler(this.cmdAuswertung_Click);
            // 
            // cmdVergleich
            // 
            this.cmdVergleich.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdVergleich.Location = new System.Drawing.Point(380, 30);
            this.cmdVergleich.Name = "cmdVergleich";
            this.cmdVergleich.Size = new System.Drawing.Size(75, 23);
            this.cmdVergleich.TabIndex = 6;
            this.cmdVergleich.Text = "Vergleich";
            this.cmdVergleich.Click += new System.EventHandler(this.cmdVergleich_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButton1.Location = new System.Drawing.Point(380, 63);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 7;
            this.metroButton1.Text = "Speichern";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 914);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.cmdVergleich);
            this.Controls.Add(this.cmdAuswertung);
            this.Controls.Add(this.cmdEinstellungen);
            this.Controls.Add(this.lblSaved);
            this.Controls.Add(this.cmdNext);
            this.Controls.Add(this.nudId);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Stimmzettel";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudId;
        private MetroFramework.Controls.MetroButton cmdNext;
        private System.Windows.Forms.Label lblSaved;
        private System.Windows.Forms.Button cmdEinstellungen;
        private MetroFramework.Controls.MetroButton cmdAuswertung;
        private MetroFramework.Controls.MetroButton cmdVergleich;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}

