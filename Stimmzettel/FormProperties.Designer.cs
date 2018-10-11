namespace Stimmzettel
{
    partial class FormProperties
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtbKandidaten = new System.Windows.Forms.RichTextBox();
            this.lblBackup = new MetroFramework.Controls.MetroLabel();
            this.nudBackup = new System.Windows.Forms.NumericUpDown();
            this.lblKandidaten = new MetroFramework.Controls.MetroLabel();
            this.nudMaxStimmen = new System.Windows.Forms.NumericUpDown();
            this.lblMax = new MetroFramework.Controls.MetroLabel();
            this.nudXPosition = new System.Windows.Forms.NumericUpDown();
            this.lblXPosition = new MetroFramework.Controls.MetroLabel();
            this.nudYPosition = new System.Windows.Forms.NumericUpDown();
            this.lblYPosition = new MetroFramework.Controls.MetroLabel();
            this.lblError = new System.Windows.Forms.Label();
            this.cmdSave = new MetroFramework.Controls.MetroButton();
            this.ofdLoadBackup = new System.Windows.Forms.OpenFileDialog();
            this.cmdLoadBackup = new MetroFramework.Controls.MetroButton();
            this.nudWindowHeight = new System.Windows.Forms.NumericUpDown();
            this.lblFensterHoehe = new MetroFramework.Controls.MetroLabel();
            this.nudWindowWidth = new System.Windows.Forms.NumericUpDown();
            this.lblFensterBreite = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.nudBackup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxStimmen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudXPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWindowHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWindowWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbKandidaten
            // 
            this.rtbKandidaten.Location = new System.Drawing.Point(38, 85);
            this.rtbKandidaten.Name = "rtbKandidaten";
            this.rtbKandidaten.Size = new System.Drawing.Size(227, 207);
            this.rtbKandidaten.TabIndex = 0;
            this.rtbKandidaten.Text = "";
            // 
            // lblBackup
            // 
            this.lblBackup.AutoSize = true;
            this.lblBackup.Location = new System.Drawing.Point(341, 64);
            this.lblBackup.Name = "lblBackup";
            this.lblBackup.Size = new System.Drawing.Size(174, 19);
            this.lblBackup.TabIndex = 1;
            this.lblBackup.Text = "Backup nach X Stimmzetteln";
            // 
            // nudBackup
            // 
            this.nudBackup.Location = new System.Drawing.Point(346, 87);
            this.nudBackup.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudBackup.Name = "nudBackup";
            this.nudBackup.Size = new System.Drawing.Size(81, 20);
            this.nudBackup.TabIndex = 2;
            // 
            // lblKandidaten
            // 
            this.lblKandidaten.AutoSize = true;
            this.lblKandidaten.Location = new System.Drawing.Point(38, 60);
            this.lblKandidaten.Name = "lblKandidaten";
            this.lblKandidaten.Size = new System.Drawing.Size(74, 19);
            this.lblKandidaten.TabIndex = 3;
            this.lblKandidaten.Text = "Kandidaten";
            // 
            // nudMaxStimmen
            // 
            this.nudMaxStimmen.Location = new System.Drawing.Point(346, 131);
            this.nudMaxStimmen.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudMaxStimmen.Name = "nudMaxStimmen";
            this.nudMaxStimmen.Size = new System.Drawing.Size(81, 20);
            this.nudMaxStimmen.TabIndex = 5;
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(341, 109);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(165, 19);
            this.lblMax.TabIndex = 4;
            this.lblMax.Text = "Maximale Anzahl Stimmen";
            // 
            // nudXPosition
            // 
            this.nudXPosition.Location = new System.Drawing.Point(346, 176);
            this.nudXPosition.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudXPosition.Name = "nudXPosition";
            this.nudXPosition.Size = new System.Drawing.Size(81, 20);
            this.nudXPosition.TabIndex = 7;
            // 
            // lblXPosition
            // 
            this.lblXPosition.AutoSize = true;
            this.lblXPosition.Location = new System.Drawing.Point(341, 154);
            this.lblXPosition.Name = "lblXPosition";
            this.lblXPosition.Size = new System.Drawing.Size(66, 19);
            this.lblXPosition.TabIndex = 6;
            this.lblXPosition.Text = "X Position";
            // 
            // nudYPosition
            // 
            this.nudYPosition.Location = new System.Drawing.Point(346, 221);
            this.nudYPosition.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudYPosition.Name = "nudYPosition";
            this.nudYPosition.Size = new System.Drawing.Size(81, 20);
            this.nudYPosition.TabIndex = 9;
            // 
            // lblYPosition
            // 
            this.lblYPosition.AutoSize = true;
            this.lblYPosition.Location = new System.Drawing.Point(341, 199);
            this.lblYPosition.Name = "lblYPosition";
            this.lblYPosition.Size = new System.Drawing.Size(66, 19);
            this.lblYPosition.TabIndex = 8;
            this.lblYPosition.Text = "Y Position";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(355, 314);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(56, 20);
            this.lblError.TabIndex = 10;
            this.lblError.Text = "Fehler";
            this.lblError.Visible = false;
            // 
            // cmdSave
            // 
            this.cmdSave.Location = new System.Drawing.Point(346, 339);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(75, 23);
            this.cmdSave.TabIndex = 11;
            this.cmdSave.Text = "Speichern";
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // ofdLoadBackup
            // 
            this.ofdLoadBackup.FileName = "openFileDialog1";
            // 
            // cmdLoadBackup
            // 
            this.cmdLoadBackup.Location = new System.Drawing.Point(346, 260);
            this.cmdLoadBackup.Name = "cmdLoadBackup";
            this.cmdLoadBackup.Size = new System.Drawing.Size(75, 23);
            this.cmdLoadBackup.TabIndex = 14;
            this.cmdLoadBackup.Text = "Lade Backup";
            this.cmdLoadBackup.Click += new System.EventHandler(this.cmdLoadBackup_Click);
            // 
            // nudWindowHeight
            // 
            this.nudWindowHeight.Location = new System.Drawing.Point(562, 131);
            this.nudWindowHeight.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudWindowHeight.Name = "nudWindowHeight";
            this.nudWindowHeight.Size = new System.Drawing.Size(81, 20);
            this.nudWindowHeight.TabIndex = 18;
            // 
            // lblFensterHoehe
            // 
            this.lblFensterHoehe.AutoSize = true;
            this.lblFensterHoehe.Location = new System.Drawing.Point(557, 109);
            this.lblFensterHoehe.Name = "lblFensterHoehe";
            this.lblFensterHoehe.Size = new System.Drawing.Size(86, 19);
            this.lblFensterHoehe.TabIndex = 17;
            this.lblFensterHoehe.Text = "Fenster Höhe";
            // 
            // nudWindowWidth
            // 
            this.nudWindowWidth.Location = new System.Drawing.Point(562, 86);
            this.nudWindowWidth.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudWindowWidth.Name = "nudWindowWidth";
            this.nudWindowWidth.Size = new System.Drawing.Size(81, 20);
            this.nudWindowWidth.TabIndex = 16;
            // 
            // lblFensterBreite
            // 
            this.lblFensterBreite.AutoSize = true;
            this.lblFensterBreite.Location = new System.Drawing.Point(557, 64);
            this.lblFensterBreite.Name = "lblFensterBreite";
            this.lblFensterBreite.Size = new System.Drawing.Size(89, 19);
            this.lblFensterBreite.TabIndex = 15;
            this.lblFensterBreite.Text = "Fenster Breite";
            // 
            // FormProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 385);
            this.Controls.Add(this.nudWindowHeight);
            this.Controls.Add(this.lblFensterHoehe);
            this.Controls.Add(this.nudWindowWidth);
            this.Controls.Add(this.lblFensterBreite);
            this.Controls.Add(this.cmdLoadBackup);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.nudYPosition);
            this.Controls.Add(this.lblYPosition);
            this.Controls.Add(this.nudXPosition);
            this.Controls.Add(this.lblXPosition);
            this.Controls.Add(this.nudMaxStimmen);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.lblKandidaten);
            this.Controls.Add(this.nudBackup);
            this.Controls.Add(this.lblBackup);
            this.Controls.Add(this.rtbKandidaten);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormProperties";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Einstellungen";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Load += new System.EventHandler(this.FormProperties_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudBackup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxStimmen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudXPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWindowHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWindowWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbKandidaten;
        private MetroFramework.Controls.MetroLabel lblBackup;
        private System.Windows.Forms.NumericUpDown nudBackup;
        private MetroFramework.Controls.MetroLabel lblKandidaten;
        private System.Windows.Forms.NumericUpDown nudMaxStimmen;
        private MetroFramework.Controls.MetroLabel lblMax;
        private System.Windows.Forms.NumericUpDown nudXPosition;
        private MetroFramework.Controls.MetroLabel lblXPosition;
        private System.Windows.Forms.NumericUpDown nudYPosition;
        private MetroFramework.Controls.MetroLabel lblYPosition;
        private System.Windows.Forms.Label lblError;
        private MetroFramework.Controls.MetroButton cmdSave;
        private System.Windows.Forms.OpenFileDialog ofdLoadBackup;
        private MetroFramework.Controls.MetroButton cmdLoadBackup;
        private System.Windows.Forms.NumericUpDown nudWindowHeight;
        private MetroFramework.Controls.MetroLabel lblFensterHoehe;
        private System.Windows.Forms.NumericUpDown nudWindowWidth;
        private MetroFramework.Controls.MetroLabel lblFensterBreite;
    }
}