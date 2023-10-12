namespace frmWinCsProjet1
{
    partial class frmBureauDeChange
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
            this.lstPays = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblInfoUs = new System.Windows.Forms.Label();
            this.lblInfoDevise = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radDevise = new System.Windows.Forms.RadioButton();
            this.radUS = new System.Windows.Forms.RadioButton();
            this.lblDeviseChoisie = new System.Windows.Forms.Label();
            this.txtChiffre = new System.Windows.Forms.TextBox();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnEffacer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAutreDevise = new System.Windows.Forms.Label();
            this.lblResultat = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "BUREAU-XCHANGE";
            // 
            // lstPays
            // 
            this.lstPays.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPays.FormattingEnabled = true;
            this.lstPays.Location = new System.Drawing.Point(178, 61);
            this.lstPays.Name = "lstPays";
            this.lstPays.Size = new System.Drawing.Size(162, 24);
            this.lstPays.TabIndex = 1;
            this.lstPays.Text = "Choisir un pays";
            this.lstPays.SelectedIndexChanged += new System.EventHandler(this.lstPays_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Info : ";
            // 
            // lblInfoUs
            // 
            this.lblInfoUs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInfoUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoUs.Location = new System.Drawing.Point(86, 88);
            this.lblInfoUs.Name = "lblInfoUs";
            this.lblInfoUs.Size = new System.Drawing.Size(394, 33);
            this.lblInfoUs.TabIndex = 3;
            this.lblInfoUs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInfoDevise
            // 
            this.lblInfoDevise.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInfoDevise.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoDevise.Location = new System.Drawing.Point(86, 130);
            this.lblInfoDevise.Name = "lblInfoDevise";
            this.lblInfoDevise.Size = new System.Drawing.Size(394, 33);
            this.lblInfoDevise.TabIndex = 4;
            this.lblInfoDevise.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radDevise);
            this.groupBox1.Controls.Add(this.radUS);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 175);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 129);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type de conversion";
            // 
            // radDevise
            // 
            this.radDevise.AutoSize = true;
            this.radDevise.Location = new System.Drawing.Point(6, 76);
            this.radDevise.Name = "radDevise";
            this.radDevise.Size = new System.Drawing.Size(14, 13);
            this.radDevise.TabIndex = 1;
            this.radDevise.TabStop = true;
            this.radDevise.UseVisualStyleBackColor = true;
            // 
            // radUS
            // 
            this.radUS.AutoSize = true;
            this.radUS.Location = new System.Drawing.Point(6, 33);
            this.radUS.Name = "radUS";
            this.radUS.Size = new System.Drawing.Size(14, 13);
            this.radUS.TabIndex = 0;
            this.radUS.TabStop = true;
            this.radUS.UseVisualStyleBackColor = true;
            this.radUS.CheckedChanged += new System.EventHandler(this.radUS_CheckedChanged);
            // 
            // lblDeviseChoisie
            // 
            this.lblDeviseChoisie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDeviseChoisie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeviseChoisie.Location = new System.Drawing.Point(379, 181);
            this.lblDeviseChoisie.Name = "lblDeviseChoisie";
            this.lblDeviseChoisie.Size = new System.Drawing.Size(101, 24);
            this.lblDeviseChoisie.TabIndex = 6;
            this.lblDeviseChoisie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtChiffre
            // 
            this.txtChiffre.Location = new System.Drawing.Point(271, 184);
            this.txtChiffre.Name = "txtChiffre";
            this.txtChiffre.Size = new System.Drawing.Size(102, 20);
            this.txtChiffre.TabIndex = 7;
            this.txtChiffre.TextChanged += new System.EventHandler(this.txtChiffre_TextChanged);
            // 
            // btnConvertir
            // 
            this.btnConvertir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertir.Location = new System.Drawing.Point(271, 208);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(102, 28);
            this.btnConvertir.TabIndex = 8;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.Location = new System.Drawing.Point(271, 276);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(102, 28);
            this.btnQuitter.TabIndex = 9;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnEffacer
            // 
            this.btnEffacer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEffacer.Location = new System.Drawing.Point(271, 242);
            this.btnEffacer.Name = "btnEffacer";
            this.btnEffacer.Size = new System.Drawing.Size(102, 28);
            this.btnEffacer.TabIndex = 10;
            this.btnEffacer.Text = "Effacer";
            this.btnEffacer.UseVisualStyleBackColor = true;
            this.btnEffacer.Click += new System.EventHandler(this.btnEffacer_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(415, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "en";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAutreDevise
            // 
            this.lblAutreDevise.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAutreDevise.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutreDevise.Location = new System.Drawing.Point(379, 248);
            this.lblAutreDevise.Name = "lblAutreDevise";
            this.lblAutreDevise.Size = new System.Drawing.Size(101, 24);
            this.lblAutreDevise.TabIndex = 12;
            this.lblAutreDevise.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResultat
            // 
            this.lblResultat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResultat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultat.Location = new System.Drawing.Point(379, 280);
            this.lblResultat.Name = "lblResultat";
            this.lblResultat.Size = new System.Drawing.Size(101, 24);
            this.lblResultat.TabIndex = 13;
            this.lblResultat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmBureauDeChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 325);
            this.Controls.Add(this.lblResultat);
            this.Controls.Add(this.lblAutreDevise);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEffacer);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.txtChiffre);
            this.Controls.Add(this.lblDeviseChoisie);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblInfoDevise);
            this.Controls.Add(this.lblInfoUs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstPays);
            this.Controls.Add(this.label1);
            this.Name = "frmBureauDeChange";
            this.Text = "frmBureauDeChange";
            this.Load += new System.EventHandler(this.frmBureauDeChange_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox lstPays;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblInfoUs;
        private System.Windows.Forms.Label lblInfoDevise;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radDevise;
        private System.Windows.Forms.RadioButton radUS;
        private System.Windows.Forms.Label lblDeviseChoisie;
        private System.Windows.Forms.TextBox txtChiffre;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnEffacer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAutreDevise;
        private System.Windows.Forms.Label lblResultat;
    }
}