namespace Stimmzettel
{
    partial class FormAuswertung
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
            this.dgvStimmen.Location = new System.Drawing.Point(242, 63);
            this.dgvStimmen.MultiSelect = false;
            this.dgvStimmen.Name = "dgvStimmen";
            this.dgvStimmen.ReadOnly = true;
            this.dgvStimmen.Size = new System.Drawing.Size(335, 335);
            this.dgvStimmen.TabIndex = 2;
            // 
            // FormAuswertung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvStimmen);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAuswertung";
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Auswertung";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Load += new System.EventHandler(this.FormAuswertung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStimmen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvStimmen;
    }
}