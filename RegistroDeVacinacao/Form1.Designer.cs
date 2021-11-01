
namespace RegistroDeVacinacao
{
    partial class RegistroVacinaColabForm
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
            this.NomeColabLabel = new System.Windows.Forms.Label();
            this.IdColabLabel = new System.Windows.Forms.Label();
            this.NomeColabTextBox = new System.Windows.Forms.TextBox();
            this.IdColabTextBox = new System.Windows.Forms.TextBox();
            this.InfoPessoalGroupBox = new System.Windows.Forms.GroupBox();
            this.InfoVacinaGroupBox = new System.Windows.Forms.GroupBox();
            this.DoseNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.DoseDataMonthCalendar = new System.Windows.Forms.MonthCalendar();
            this.FabricVacinaListBox = new System.Windows.Forms.ListBox();
            this.DataDoseLabel = new System.Windows.Forms.Label();
            this.DoseVacinaLabel = new System.Windows.Forms.Label();
            this.FabricVacinaLabel = new System.Windows.Forms.Label();
            this.EnviarButton = new System.Windows.Forms.Button();
            this.InfoPessoalGroupBox.SuspendLayout();
            this.InfoVacinaGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DoseNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // NomeColabLabel
            // 
            this.NomeColabLabel.AutoSize = true;
            this.NomeColabLabel.Location = new System.Drawing.Point(26, 31);
            this.NomeColabLabel.Name = "NomeColabLabel";
            this.NomeColabLabel.Size = new System.Drawing.Size(35, 13);
            this.NomeColabLabel.TabIndex = 0;
            this.NomeColabLabel.Text = "Nome";
            // 
            // IdColabLabel
            // 
            this.IdColabLabel.AutoSize = true;
            this.IdColabLabel.Location = new System.Drawing.Point(43, 61);
            this.IdColabLabel.Name = "IdColabLabel";
            this.IdColabLabel.Size = new System.Drawing.Size(18, 13);
            this.IdColabLabel.TabIndex = 1;
            this.IdColabLabel.Text = "ID";
            // 
            // NomeColabTextBox
            // 
            this.NomeColabTextBox.Location = new System.Drawing.Point(67, 28);
            this.NomeColabTextBox.Name = "NomeColabTextBox";
            this.NomeColabTextBox.Size = new System.Drawing.Size(180, 20);
            this.NomeColabTextBox.TabIndex = 2;
            // 
            // IdColabTextBox
            // 
            this.IdColabTextBox.Location = new System.Drawing.Point(67, 58);
            this.IdColabTextBox.Name = "IdColabTextBox";
            this.IdColabTextBox.Size = new System.Drawing.Size(180, 20);
            this.IdColabTextBox.TabIndex = 3;
            // 
            // InfoPessoalGroupBox
            // 
            this.InfoPessoalGroupBox.Controls.Add(this.NomeColabTextBox);
            this.InfoPessoalGroupBox.Controls.Add(this.IdColabLabel);
            this.InfoPessoalGroupBox.Controls.Add(this.IdColabTextBox);
            this.InfoPessoalGroupBox.Controls.Add(this.NomeColabLabel);
            this.InfoPessoalGroupBox.Location = new System.Drawing.Point(12, 12);
            this.InfoPessoalGroupBox.Name = "InfoPessoalGroupBox";
            this.InfoPessoalGroupBox.Size = new System.Drawing.Size(271, 97);
            this.InfoPessoalGroupBox.TabIndex = 4;
            this.InfoPessoalGroupBox.TabStop = false;
            this.InfoPessoalGroupBox.Text = "Informações pessoais";
            // 
            // InfoVacinaGroupBox
            // 
            this.InfoVacinaGroupBox.Controls.Add(this.DoseNumericUpDown);
            this.InfoVacinaGroupBox.Controls.Add(this.DoseDataMonthCalendar);
            this.InfoVacinaGroupBox.Controls.Add(this.FabricVacinaListBox);
            this.InfoVacinaGroupBox.Controls.Add(this.DataDoseLabel);
            this.InfoVacinaGroupBox.Controls.Add(this.DoseVacinaLabel);
            this.InfoVacinaGroupBox.Controls.Add(this.FabricVacinaLabel);
            this.InfoVacinaGroupBox.Location = new System.Drawing.Point(12, 120);
            this.InfoVacinaGroupBox.Name = "InfoVacinaGroupBox";
            this.InfoVacinaGroupBox.Size = new System.Drawing.Size(270, 303);
            this.InfoVacinaGroupBox.TabIndex = 5;
            this.InfoVacinaGroupBox.TabStop = false;
            this.InfoVacinaGroupBox.Text = "Informações vacinais";
            // 
            // DoseNumericUpDown
            // 
            this.DoseNumericUpDown.Location = new System.Drawing.Point(67, 76);
            this.DoseNumericUpDown.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.DoseNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DoseNumericUpDown.Name = "DoseNumericUpDown";
            this.DoseNumericUpDown.Size = new System.Drawing.Size(180, 20);
            this.DoseNumericUpDown.TabIndex = 5;
            this.DoseNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // DoseDataMonthCalendar
            // 
            this.DoseDataMonthCalendar.Location = new System.Drawing.Point(20, 129);
            this.DoseDataMonthCalendar.Name = "DoseDataMonthCalendar";
            this.DoseDataMonthCalendar.TabIndex = 4;
            // 
            // FabricVacinaListBox
            // 
            this.FabricVacinaListBox.FormattingEnabled = true;
            this.FabricVacinaListBox.Items.AddRange(new object[] {
            "AstraZeneca/Oxford",
            "BioNTech/Pfizer",
            "CureVac",
            "Gamaleya",
            "Johnson & Johnson (Janssen)",
            "Moderna",
            "Novavax",
            "Sanofi/GSK",
            "Sinopharm",
            "Sinovac Biotech (Coronavac)"});
            this.FabricVacinaListBox.Location = new System.Drawing.Point(67, 34);
            this.FabricVacinaListBox.Name = "FabricVacinaListBox";
            this.FabricVacinaListBox.Size = new System.Drawing.Size(180, 30);
            this.FabricVacinaListBox.TabIndex = 4;
            // 
            // DataDoseLabel
            // 
            this.DataDoseLabel.AutoSize = true;
            this.DataDoseLabel.Location = new System.Drawing.Point(31, 107);
            this.DataDoseLabel.Name = "DataDoseLabel";
            this.DataDoseLabel.Size = new System.Drawing.Size(30, 13);
            this.DataDoseLabel.TabIndex = 3;
            this.DataDoseLabel.Text = "Data";
            // 
            // DoseVacinaLabel
            // 
            this.DoseVacinaLabel.AutoSize = true;
            this.DoseVacinaLabel.Location = new System.Drawing.Point(29, 78);
            this.DoseVacinaLabel.Name = "DoseVacinaLabel";
            this.DoseVacinaLabel.Size = new System.Drawing.Size(32, 13);
            this.DoseVacinaLabel.TabIndex = 2;
            this.DoseVacinaLabel.Text = "Dose";
            // 
            // FabricVacinaLabel
            // 
            this.FabricVacinaLabel.AutoSize = true;
            this.FabricVacinaLabel.Location = new System.Drawing.Point(6, 34);
            this.FabricVacinaLabel.Name = "FabricVacinaLabel";
            this.FabricVacinaLabel.Size = new System.Drawing.Size(57, 13);
            this.FabricVacinaLabel.TabIndex = 0;
            this.FabricVacinaLabel.Text = "Fabricante";
            // 
            // EnviarButton
            // 
            this.EnviarButton.Location = new System.Drawing.Point(12, 429);
            this.EnviarButton.Name = "EnviarButton";
            this.EnviarButton.Size = new System.Drawing.Size(270, 34);
            this.EnviarButton.TabIndex = 6;
            this.EnviarButton.Text = "Enviar";
            this.EnviarButton.UseVisualStyleBackColor = true;
            // 
            // RegistroVacinaColabForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 471);
            this.Controls.Add(this.EnviarButton);
            this.Controls.Add(this.InfoVacinaGroupBox);
            this.Controls.Add(this.InfoPessoalGroupBox);
            this.Name = "RegistroVacinaColabForm";
            this.Text = "Vacinação para COVID-19";
            this.Load += new System.EventHandler(this.registroVacinaColabForm_Load);
            this.InfoPessoalGroupBox.ResumeLayout(false);
            this.InfoPessoalGroupBox.PerformLayout();
            this.InfoVacinaGroupBox.ResumeLayout(false);
            this.InfoVacinaGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DoseNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label NomeColabLabel;
        private System.Windows.Forms.Label IdColabLabel;
        private System.Windows.Forms.TextBox NomeColabTextBox;
        private System.Windows.Forms.TextBox IdColabTextBox;
        private System.Windows.Forms.GroupBox InfoPessoalGroupBox;
        private System.Windows.Forms.GroupBox InfoVacinaGroupBox;
        private System.Windows.Forms.ListBox FabricVacinaListBox;
        private System.Windows.Forms.Label DataDoseLabel;
        private System.Windows.Forms.Label DoseVacinaLabel;
        private System.Windows.Forms.Label FabricVacinaLabel;
        private System.Windows.Forms.NumericUpDown DoseNumericUpDown;
        private System.Windows.Forms.MonthCalendar DoseDataMonthCalendar;
        private System.Windows.Forms.Button EnviarButton;
    }
}

