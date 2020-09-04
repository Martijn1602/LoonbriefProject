namespace LoonbriefProject
{
    partial class Form1
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
            this.lbWerknemer = new System.Windows.Forms.ListBox();
            this.btnMaakAan = new System.Windows.Forms.Button();
            this.btnPasAan = new System.Windows.Forms.Button();
            this.btnVerwijder = new System.Windows.Forms.Button();
            this.btnMaakBrief = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbWerknemer
            // 
            this.lbWerknemer.FormattingEnabled = true;
            this.lbWerknemer.Location = new System.Drawing.Point(32, 25);
            this.lbWerknemer.Name = "lbWerknemer";
            this.lbWerknemer.Size = new System.Drawing.Size(188, 277);
            this.lbWerknemer.TabIndex = 0;
            this.lbWerknemer.SelectedIndexChanged += new System.EventHandler(this.lbWerknemer_SelectedIndexChanged_1);
            // 
            // btnMaakAan
            // 
            this.btnMaakAan.Location = new System.Drawing.Point(32, 318);
            this.btnMaakAan.Name = "btnMaakAan";
            this.btnMaakAan.Size = new System.Drawing.Size(188, 23);
            this.btnMaakAan.TabIndex = 1;
            this.btnMaakAan.Text = "Werknemer Aanmaken";
            this.btnMaakAan.UseVisualStyleBackColor = true;
            this.btnMaakAan.Click += new System.EventHandler(this.btnMaakAan_Click);
            // 
            // btnPasAan
            // 
            this.btnPasAan.Location = new System.Drawing.Point(32, 347);
            this.btnPasAan.Name = "btnPasAan";
            this.btnPasAan.Size = new System.Drawing.Size(188, 23);
            this.btnPasAan.TabIndex = 2;
            this.btnPasAan.Text = "Werknemer Aanpassen";
            this.btnPasAan.UseVisualStyleBackColor = true;
            this.btnPasAan.Click += new System.EventHandler(this.btnPasAan_Click_1);
            // 
            // btnVerwijder
            // 
            this.btnVerwijder.Location = new System.Drawing.Point(32, 376);
            this.btnVerwijder.Name = "btnVerwijder";
            this.btnVerwijder.Size = new System.Drawing.Size(188, 23);
            this.btnVerwijder.TabIndex = 3;
            this.btnVerwijder.Text = "Werknemer Verwijderen";
            this.btnVerwijder.UseVisualStyleBackColor = true;
            // 
            // btnMaakBrief
            // 
            this.btnMaakBrief.Location = new System.Drawing.Point(32, 415);
            this.btnMaakBrief.Name = "btnMaakBrief";
            this.btnMaakBrief.Size = new System.Drawing.Size(188, 23);
            this.btnMaakBrief.TabIndex = 4;
            this.btnMaakBrief.Text = "Maak Loonbrieven";
            this.btnMaakBrief.UseVisualStyleBackColor = true;
            this.btnMaakBrief.Click += new System.EventHandler(this.btnMaakBrief_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 450);
            this.Controls.Add(this.btnMaakBrief);
            this.Controls.Add(this.btnVerwijder);
            this.Controls.Add(this.btnPasAan);
            this.Controls.Add(this.btnMaakAan);
            this.Controls.Add(this.lbWerknemer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbWerknemer;
        private System.Windows.Forms.Button btnMaakAan;
        private System.Windows.Forms.Button btnPasAan;
        private System.Windows.Forms.Button btnVerwijder;
        private System.Windows.Forms.Button btnMaakBrief;
    }
}

