namespace WindowsFormsApp1
{
    partial class FormConfig
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
            this.checkHospital = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkPolideportivo = new System.Windows.Forms.CheckBox();
            this.checkCasas = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkHospital
            // 
            this.checkHospital.AutoSize = true;
            this.checkHospital.Location = new System.Drawing.Point(3, 3);
            this.checkHospital.Name = "checkHospital";
            this.checkHospital.Size = new System.Drawing.Size(64, 17);
            this.checkHospital.TabIndex = 0;
            this.checkHospital.Text = "Hospital";
            this.checkHospital.UseVisualStyleBackColor = true;
            this.checkHospital.Click += new System.EventHandler(this.checkHospital_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBox5);
            this.panel1.Controls.Add(this.checkBox4);
            this.panel1.Controls.Add(this.checkCasas);
            this.panel1.Controls.Add(this.checkPolideportivo);
            this.panel1.Controls.Add(this.checkHospital);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 126);
            this.panel1.TabIndex = 1;
            // 
            // checkPolideportivo
            // 
            this.checkPolideportivo.AutoSize = true;
            this.checkPolideportivo.Location = new System.Drawing.Point(3, 26);
            this.checkPolideportivo.Name = "checkPolideportivo";
            this.checkPolideportivo.Size = new System.Drawing.Size(86, 17);
            this.checkPolideportivo.TabIndex = 1;
            this.checkPolideportivo.Text = "polideportivo";
            this.checkPolideportivo.UseVisualStyleBackColor = true;
            this.checkPolideportivo.Click += new System.EventHandler(this.checkPolideportivo_CheckedChanged);
            // 
            // checkCasas
            // 
            this.checkCasas.AutoSize = true;
            this.checkCasas.Location = new System.Drawing.Point(3, 49);
            this.checkCasas.Name = "checkCasas";
            this.checkCasas.Size = new System.Drawing.Size(54, 17);
            this.checkCasas.TabIndex = 2;
            this.checkCasas.Text = "casas";
            this.checkCasas.UseVisualStyleBackColor = true;
            this.checkCasas.Click += new System.EventHandler(this.checkCasas_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(3, 72);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(80, 17);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "checkBox4";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(3, 95);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(80, 17);
            this.checkBox5.TabIndex = 4;
            this.checkBox5.Text = "checkBox5";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "tunk";
            // 
            // FormConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "FormConfig";
            this.Text = "FormConfig";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkHospital;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkCasas;
        private System.Windows.Forms.CheckBox checkPolideportivo;
        private System.Windows.Forms.Label label1;
    }
}