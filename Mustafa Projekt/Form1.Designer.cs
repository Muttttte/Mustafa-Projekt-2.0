namespace Mustafa_Projekt
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblStörstaTalet = new System.Windows.Forms.Label();
            this.lblDator = new System.Windows.Forms.Label();
            this.lblGissa = new System.Windows.Forms.Label();
            this.lblResultat = new System.Windows.Forms.Label();
            this.lblDatornsTal = new System.Windows.Forms.Label();
            this.tbxGissa = new System.Windows.Forms.TextBox();
            this.btnGissa = new System.Windows.Forms.Button();
            this.tbxMinaResultat = new System.Windows.Forms.TextBox();
            this.lblMinaResultat = new System.Windows.Forms.Label();
            this.btnSpelaIgen = new System.Windows.Forms.Button();
            this.btnStartaSpelet = new System.Windows.Forms.Button();
            this.gbxSpeldata = new System.Windows.Forms.GroupBox();
            this.lbxStörstaTalet = new System.Windows.Forms.ListBox();
            this.gbxSpelet = new System.Windows.Forms.GroupBox();
            this.gbxSpeldata.SuspendLayout();
            this.gbxSpelet.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStörstaTalet
            // 
            this.lblStörstaTalet.AutoSize = true;
            this.lblStörstaTalet.Location = new System.Drawing.Point(3, 26);
            this.lblStörstaTalet.Name = "lblStörstaTalet";
            this.lblStörstaTalet.Size = new System.Drawing.Size(70, 15);
            this.lblStörstaTalet.TabIndex = 0;
            this.lblStörstaTalet.Text = "Största Talet";
            // 
            // lblDator
            // 
            this.lblDator.AutoSize = true;
            this.lblDator.Location = new System.Drawing.Point(6, 33);
            this.lblDator.Name = "lblDator";
            this.lblDator.Size = new System.Drawing.Size(64, 15);
            this.lblDator.TabIndex = 1;
            this.lblDator.Text = "Datorns tal";
            // 
            // lblGissa
            // 
            this.lblGissa.AutoSize = true;
            this.lblGissa.Location = new System.Drawing.Point(3, 68);
            this.lblGissa.Name = "lblGissa";
            this.lblGissa.Size = new System.Drawing.Size(67, 15);
            this.lblGissa.TabIndex = 2;
            this.lblGissa.Text = "Gissa ett tal";
            // 
            // lblResultat
            // 
            this.lblResultat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultat.Location = new System.Drawing.Point(14, 106);
            this.lblResultat.Name = "lblResultat";
            this.lblResultat.Size = new System.Drawing.Size(100, 23);
            this.lblResultat.TabIndex = 3;
            this.lblResultat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDatornsTal
            // 
            this.lblDatornsTal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDatornsTal.Location = new System.Drawing.Point(82, 29);
            this.lblDatornsTal.Name = "lblDatornsTal";
            this.lblDatornsTal.Size = new System.Drawing.Size(100, 23);
            this.lblDatornsTal.TabIndex = 4;
            this.lblDatornsTal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbxGissa
            // 
            this.tbxGissa.Location = new System.Drawing.Point(82, 61);
            this.tbxGissa.Name = "tbxGissa";
            this.tbxGissa.Size = new System.Drawing.Size(100, 23);
            this.tbxGissa.TabIndex = 5;
            // 
            // btnGissa
            // 
            this.btnGissa.Location = new System.Drawing.Point(218, 61);
            this.btnGissa.Name = "btnGissa";
            this.btnGissa.Size = new System.Drawing.Size(75, 23);
            this.btnGissa.TabIndex = 6;
            this.btnGissa.Text = "Gissa";
            this.btnGissa.UseVisualStyleBackColor = true;
            this.btnGissa.Click += new System.EventHandler(this.btnGissa_Click);
            // 
            // tbxMinaResultat
            // 
            this.tbxMinaResultat.Enabled = false;
            this.tbxMinaResultat.Location = new System.Drawing.Point(346, 61);
            this.tbxMinaResultat.Multiline = true;
            this.tbxMinaResultat.Name = "tbxMinaResultat";
            this.tbxMinaResultat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxMinaResultat.Size = new System.Drawing.Size(90, 60);
            this.tbxMinaResultat.TabIndex = 7;
            // 
            // lblMinaResultat
            // 
            this.lblMinaResultat.AutoSize = true;
            this.lblMinaResultat.Location = new System.Drawing.Point(346, 29);
            this.lblMinaResultat.Name = "lblMinaResultat";
            this.lblMinaResultat.Size = new System.Drawing.Size(79, 15);
            this.lblMinaResultat.TabIndex = 8;
            this.lblMinaResultat.Text = "Mina Resultat";
            // 
            // btnSpelaIgen
            // 
            this.btnSpelaIgen.Enabled = false;
            this.btnSpelaIgen.Location = new System.Drawing.Point(361, 177);
            this.btnSpelaIgen.Name = "btnSpelaIgen";
            this.btnSpelaIgen.Size = new System.Drawing.Size(108, 23);
            this.btnSpelaIgen.TabIndex = 9;
            this.btnSpelaIgen.Text = "Spela Igen";
            this.btnSpelaIgen.UseVisualStyleBackColor = true;
            this.btnSpelaIgen.Click += new System.EventHandler(this.btnSpelaIgen_Click);
            // 
            // btnStartaSpelet
            // 
            this.btnStartaSpelet.Location = new System.Drawing.Point(361, 134);
            this.btnStartaSpelet.Name = "btnStartaSpelet";
            this.btnStartaSpelet.Size = new System.Drawing.Size(108, 23);
            this.btnStartaSpelet.TabIndex = 10;
            this.btnStartaSpelet.Text = "Starta Spelet";
            this.btnStartaSpelet.UseVisualStyleBackColor = true;
            this.btnStartaSpelet.Click += new System.EventHandler(this.btnStartaSpelet_Click);
            // 
            // gbxSpeldata
            // 
            this.gbxSpeldata.Controls.Add(this.lbxStörstaTalet);
            this.gbxSpeldata.Controls.Add(this.lblStörstaTalet);
            this.gbxSpeldata.Location = new System.Drawing.Point(71, 134);
            this.gbxSpeldata.Name = "gbxSpeldata";
            this.gbxSpeldata.Size = new System.Drawing.Size(205, 66);
            this.gbxSpeldata.TabIndex = 11;
            this.gbxSpeldata.TabStop = false;
            this.gbxSpeldata.Text = "Speldata";
            // 
            // lbxStörstaTalet
            // 
            this.lbxStörstaTalet.FormattingEnabled = true;
            this.lbxStörstaTalet.ItemHeight = 15;
            this.lbxStörstaTalet.Location = new System.Drawing.Point(92, 22);
            this.lbxStörstaTalet.Name = "lbxStörstaTalet";
            this.lbxStörstaTalet.Size = new System.Drawing.Size(90, 34);
            this.lbxStörstaTalet.TabIndex = 13;
            // 
            // gbxSpelet
            // 
            this.gbxSpelet.Controls.Add(this.lblResultat);
            this.gbxSpelet.Controls.Add(this.lblGissa);
            this.gbxSpelet.Controls.Add(this.lblMinaResultat);
            this.gbxSpelet.Controls.Add(this.tbxGissa);
            this.gbxSpelet.Controls.Add(this.tbxMinaResultat);
            this.gbxSpelet.Controls.Add(this.lblDatornsTal);
            this.gbxSpelet.Controls.Add(this.btnGissa);
            this.gbxSpelet.Controls.Add(this.lblDator);
            this.gbxSpelet.Enabled = false;
            this.gbxSpelet.Location = new System.Drawing.Point(71, 247);
            this.gbxSpelet.Name = "gbxSpelet";
            this.gbxSpelet.Size = new System.Drawing.Size(456, 142);
            this.gbxSpelet.TabIndex = 12;
            this.gbxSpelet.TabStop = false;
            this.gbxSpelet.Text = "Spelet";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = global::Mustafa_Projekt.Properties.Resources._0_GettyImages_1249152860;
            this.ClientSize = new System.Drawing.Size(622, 409);
            this.Controls.Add(this.gbxSpelet);
            this.Controls.Add(this.btnSpelaIgen);
            this.Controls.Add(this.gbxSpeldata);
            this.Controls.Add(this.btnStartaSpelet);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxSpeldata.ResumeLayout(false);
            this.gbxSpeldata.PerformLayout();
            this.gbxSpelet.ResumeLayout(false);
            this.gbxSpelet.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblStörstaTalet;
        private Label lblDator;
        private Label lblGissa;
        private Label lblResultat;
        private Label lblDatornsTal;
        private TextBox tbxGissa;
        private Button btnGissa;
        private TextBox tbxMinaResultat;
        private Label lblMinaResultat;
        private Button btnSpelaIgen;
        private Button btnStartaSpelet;
        private GroupBox gbxSpeldata;
        private ListBox lbxStörstaTalet;
        private GroupBox gbxSpelet;
    }
}