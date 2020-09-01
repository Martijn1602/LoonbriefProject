namespace LoonbriefProject
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtVoornaam = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAchternaam = new System.Windows.Forms.TextBox();
            this.rbVrouw = new System.Windows.Forms.RadioButton();
            this.rbMan = new System.Windows.Forms.RadioButton();
            this.dtGeboorte = new System.Windows.Forms.DateTimePicker();
            this.dtInDient = new System.Windows.Forms.DateTimePicker();
            this.txtRijksregisternummer = new System.Windows.Forms.TextBox();
            this.txtIBAN = new System.Windows.Forms.TextBox();
            this.txtBruto = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Voornaam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Achternaam";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Geslacht";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Geboortedatum";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Rijksregisternummer";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Datum Indiensttreding";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "IBAN-nummer";
            // 
            // txtVoornaam
            // 
            this.txtVoornaam.Location = new System.Drawing.Point(142, 19);
            this.txtVoornaam.Name = "txtVoornaam";
            this.txtVoornaam.Size = new System.Drawing.Size(216, 20);
            this.txtVoornaam.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Brutoloon";
            // 
            // txtAchternaam
            // 
            this.txtAchternaam.Location = new System.Drawing.Point(142, 45);
            this.txtAchternaam.Name = "txtAchternaam";
            this.txtAchternaam.Size = new System.Drawing.Size(216, 20);
            this.txtAchternaam.TabIndex = 9;
            // 
            // rbVrouw
            // 
            this.rbVrouw.AutoSize = true;
            this.rbVrouw.Checked = true;
            this.rbVrouw.Location = new System.Drawing.Point(142, 75);
            this.rbVrouw.Name = "rbVrouw";
            this.rbVrouw.Size = new System.Drawing.Size(55, 17);
            this.rbVrouw.TabIndex = 10;
            this.rbVrouw.TabStop = true;
            this.rbVrouw.Text = "Vrouw";
            this.rbVrouw.UseVisualStyleBackColor = true;
            // 
            // rbMan
            // 
            this.rbMan.AutoSize = true;
            this.rbMan.Location = new System.Drawing.Point(273, 75);
            this.rbMan.Name = "rbMan";
            this.rbMan.Size = new System.Drawing.Size(46, 17);
            this.rbMan.TabIndex = 11;
            this.rbMan.TabStop = true;
            this.rbMan.Text = "Man";
            this.rbMan.UseVisualStyleBackColor = true;
            // 
            // dtGeboorte
            // 
            this.dtGeboorte.Location = new System.Drawing.Point(142, 101);
            this.dtGeboorte.Name = "dtGeboorte";
            this.dtGeboorte.Size = new System.Drawing.Size(216, 20);
            this.dtGeboorte.TabIndex = 13;
            // 
            // dtInDient
            // 
            this.dtInDient.Location = new System.Drawing.Point(142, 156);
            this.dtInDient.Name = "dtInDient";
            this.dtInDient.Size = new System.Drawing.Size(216, 20);
            this.dtInDient.TabIndex = 14;
            // 
            // txtRijksregisternummer
            // 
            this.txtRijksregisternummer.Location = new System.Drawing.Point(142, 127);
            this.txtRijksregisternummer.Name = "txtRijksregisternummer";
            this.txtRijksregisternummer.Size = new System.Drawing.Size(216, 20);
            this.txtRijksregisternummer.TabIndex = 15;
            // 
            // txtIBAN
            // 
            this.txtIBAN.Location = new System.Drawing.Point(142, 182);
            this.txtIBAN.Name = "txtIBAN";
            this.txtIBAN.Size = new System.Drawing.Size(216, 20);
            this.txtIBAN.TabIndex = 16;
            // 
            // txtBruto
            // 
            this.txtBruto.Location = new System.Drawing.Point(142, 208);
            this.txtBruto.Name = "txtBruto";
            this.txtBruto.Size = new System.Drawing.Size(216, 20);
            this.txtBruto.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(329, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Aanmaken";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 329);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBruto);
            this.Controls.Add(this.txtIBAN);
            this.Controls.Add(this.txtRijksregisternummer);
            this.Controls.Add(this.dtInDient);
            this.Controls.Add(this.dtGeboorte);
            this.Controls.Add(this.rbMan);
            this.Controls.Add(this.rbVrouw);
            this.Controls.Add(this.txtAchternaam);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtVoornaam);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Werknemer Aanmaken";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtVoornaam;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAchternaam;
        private System.Windows.Forms.RadioButton rbVrouw;
        private System.Windows.Forms.RadioButton rbMan;
        private System.Windows.Forms.DateTimePicker dtGeboorte;
        private System.Windows.Forms.DateTimePicker dtInDient;
        private System.Windows.Forms.TextBox txtRijksregisternummer;
        private System.Windows.Forms.TextBox txtIBAN;
        private System.Windows.Forms.TextBox txtBruto;
        private System.Windows.Forms.Button button1;
    }
}