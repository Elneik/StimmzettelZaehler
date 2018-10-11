namespace Stimmzettel
{
    partial class FormVergleich
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
            this.dgvStimmen = new System.Windows.Forms.DataGridView();
            this.tbFile1 = new MetroFramework.Controls.MetroTextBox();
            this.lblFile1 = new MetroFramework.Controls.MetroLabel();
            this.lblFile2 = new MetroFramework.Controls.MetroLabel();
            this.tbFile2 = new MetroFramework.Controls.MetroTextBox();
            this.cmdVergleich = new MetroFramework.Controls.MetroButton();
            this.ofdFiles = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStimmen)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStimmen
            // 
            this.dgvStimmen.AllowUserToAddRows = false;
            this.dgvStimmen.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvStimmen.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvStimmen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvStimmen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStimmen.Location = new System.Drawing.Point(23, 199);
            this.dgvStimmen.MultiSelect = false;
            this.dgvStimmen.Name = "dgvStimmen";
            this.dgvStimmen.ReadOnly = true;
            this.dgvStimmen.Size = new System.Drawing.Size(1256, 269);
            this.dgvStimmen.TabIndex = 3;
            // 
            // tbFile1
            // 
            this.tbFile1.Location = new System.Drawing.Point(562, 79);
            this.tbFile1.Name = "tbFile1";
            this.tbFile1.Size = new System.Drawing.Size(188, 23);
            this.tbFile1.TabIndex = 4;
            this.tbFile1.Enter += new System.EventHandler(this.tbFile1_Enter_1);
            // 
            // lblFile1
            // 
            this.lblFile1.AutoSize = true;
            this.lblFile1.Location = new System.Drawing.Point(559, 57);
            this.lblFile1.Name = "lblFile1";
            this.lblFile1.Size = new System.Drawing.Size(48, 19);
            this.lblFile1.TabIndex = 1;
            this.lblFile1.Text = "Datei 1";
            // 
            // lblFile2
            // 
            this.lblFile2.AutoSize = true;
            this.lblFile2.Location = new System.Drawing.Point(559, 105);
            this.lblFile2.Name = "lblFile2";
            this.lblFile2.Size = new System.Drawing.Size(50, 19);
            this.lblFile2.TabIndex = 7;
            this.lblFile2.Text = "Datei 2";
            // 
            // tbFile2
            // 
            this.tbFile2.Location = new System.Drawing.Point(562, 127);
            this.tbFile2.Name = "tbFile2";
            this.tbFile2.Size = new System.Drawing.Size(188, 23);
            this.tbFile2.TabIndex = 6;
            this.tbFile2.Enter += new System.EventHandler(this.tbFile2_Enter);
            // 
            // cmdVergleich
            // 
            this.cmdVergleich.Location = new System.Drawing.Point(618, 165);
            this.cmdVergleich.Name = "cmdVergleich";
            this.cmdVergleich.Size = new System.Drawing.Size(75, 23);
            this.cmdVergleich.TabIndex = 8;
            this.cmdVergleich.Text = "Vergleich";
            this.cmdVergleich.Click += new System.EventHandler(this.cmdVergleich_Click);
            // 
            // FormVergleich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 510);
            this.Controls.Add(this.cmdVergleich);
            this.Controls.Add(this.lblFile2);
            this.Controls.Add(this.tbFile2);
            this.Controls.Add(this.lblFile1);
            this.Controls.Add(this.tbFile1);
            this.Controls.Add(this.dgvStimmen);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormVergleich";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Vergleich";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Load += new System.EventHandler(this.FormVergleich_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStimmen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStimmen;
        private MetroFramework.Controls.MetroTextBox tbFile1;
        private MetroFramework.Controls.MetroLabel lblFile1;
        private MetroFramework.Controls.MetroLabel lblFile2;
        private MetroFramework.Controls.MetroTextBox tbFile2;
        private MetroFramework.Controls.MetroButton cmdVergleich;
        private System.Windows.Forms.OpenFileDialog ofdFiles;
    }
}