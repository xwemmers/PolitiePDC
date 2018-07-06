namespace PersonenBeheer
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtVoornaam = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAchternaam = new System.Windows.Forms.TextBox();
            this.dtpGeboortedatum = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.rbMan = new System.Windows.Forms.RadioButton();
            this.rbVrouw = new System.Windows.Forms.RadioButton();
            this.rbOnbekend = new System.Windows.Forms.RadioButton();
            this.cmbLand = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnToevoegen = new System.Windows.Forms.Button();
            this.lbxPersonen = new System.Windows.Forms.ListBox();
            this.dgvPersonen = new System.Windows.Forms.DataGridView();
            this.btnOpslaan = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.txtZoekveld = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonen)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Voornaam:";
            // 
            // txtVoornaam
            // 
            this.txtVoornaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVoornaam.Location = new System.Drawing.Point(26, 71);
            this.txtVoornaam.Name = "txtVoornaam";
            this.txtVoornaam.Size = new System.Drawing.Size(413, 35);
            this.txtVoornaam.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Achternaam:";
            // 
            // txtAchternaam
            // 
            this.txtAchternaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAchternaam.Location = new System.Drawing.Point(26, 159);
            this.txtAchternaam.Name = "txtAchternaam";
            this.txtAchternaam.Size = new System.Drawing.Size(413, 35);
            this.txtAchternaam.TabIndex = 3;
            // 
            // dtpGeboortedatum
            // 
            this.dtpGeboortedatum.CustomFormat = "dd MMMM yyyy HH:mm:sss";
            this.dtpGeboortedatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpGeboortedatum.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpGeboortedatum.Location = new System.Drawing.Point(26, 257);
            this.dtpGeboortedatum.Name = "dtpGeboortedatum";
            this.dtpGeboortedatum.Size = new System.Drawing.Size(413, 35);
            this.dtpGeboortedatum.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Geboortedatum:";
            // 
            // rbMan
            // 
            this.rbMan.AutoSize = true;
            this.rbMan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMan.Location = new System.Drawing.Point(26, 359);
            this.rbMan.Name = "rbMan";
            this.rbMan.Size = new System.Drawing.Size(84, 33);
            this.rbMan.TabIndex = 6;
            this.rbMan.TabStop = true;
            this.rbMan.Text = "Man";
            this.rbMan.UseVisualStyleBackColor = true;
            // 
            // rbVrouw
            // 
            this.rbVrouw.AutoSize = true;
            this.rbVrouw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbVrouw.Location = new System.Drawing.Point(144, 359);
            this.rbVrouw.Name = "rbVrouw";
            this.rbVrouw.Size = new System.Drawing.Size(106, 33);
            this.rbVrouw.TabIndex = 7;
            this.rbVrouw.TabStop = true;
            this.rbVrouw.Text = "Vrouw";
            this.rbVrouw.UseVisualStyleBackColor = true;
            // 
            // rbOnbekend
            // 
            this.rbOnbekend.AutoSize = true;
            this.rbOnbekend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOnbekend.Location = new System.Drawing.Point(282, 359);
            this.rbOnbekend.Name = "rbOnbekend";
            this.rbOnbekend.Size = new System.Drawing.Size(151, 33);
            this.rbOnbekend.TabIndex = 8;
            this.rbOnbekend.TabStop = true;
            this.rbOnbekend.Text = "Onbekend";
            this.rbOnbekend.UseVisualStyleBackColor = true;
            // 
            // cmbLand
            // 
            this.cmbLand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLand.FormattingEnabled = true;
            this.cmbLand.Items.AddRange(new object[] {
            "Belgie",
            "Frankrijk",
            "Engeland",
            "Kroatie",
            "Rusland",
            "Brazilie",
            "Uruguay",
            "Zweden"});
            this.cmbLand.Location = new System.Drawing.Point(26, 454);
            this.cmbLand.Name = "cmbLand";
            this.cmbLand.Size = new System.Drawing.Size(413, 37);
            this.cmbLand.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "Geslacht:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 422);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 29);
            this.label5.TabIndex = 11;
            this.label5.Text = "Land:";
            // 
            // btnToevoegen
            // 
            this.btnToevoegen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToevoegen.Location = new System.Drawing.Point(26, 526);
            this.btnToevoegen.Name = "btnToevoegen";
            this.btnToevoegen.Size = new System.Drawing.Size(413, 57);
            this.btnToevoegen.TabIndex = 12;
            this.btnToevoegen.Text = "Toevoegen";
            this.btnToevoegen.UseVisualStyleBackColor = true;
            this.btnToevoegen.Click += new System.EventHandler(this.btnToevoegen_Click);
            // 
            // lbxPersonen
            // 
            this.lbxPersonen.DisplayMember = "VolledigeNaam";
            this.lbxPersonen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxPersonen.FormattingEnabled = true;
            this.lbxPersonen.ItemHeight = 37;
            this.lbxPersonen.Location = new System.Drawing.Point(494, 59);
            this.lbxPersonen.Name = "lbxPersonen";
            this.lbxPersonen.Size = new System.Drawing.Size(261, 522);
            this.lbxPersonen.TabIndex = 13;
            // 
            // dgvPersonen
            // 
            this.dgvPersonen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPersonen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonen.Location = new System.Drawing.Point(790, 59);
            this.dgvPersonen.Name = "dgvPersonen";
            this.dgvPersonen.RowTemplate.Height = 28;
            this.dgvPersonen.Size = new System.Drawing.Size(808, 524);
            this.dgvPersonen.TabIndex = 14;
            // 
            // btnOpslaan
            // 
            this.btnOpslaan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpslaan.Location = new System.Drawing.Point(26, 632);
            this.btnOpslaan.Name = "btnOpslaan";
            this.btnOpslaan.Size = new System.Drawing.Size(407, 53);
            this.btnOpslaan.TabIndex = 15;
            this.btnOpslaan.Text = "Opslaan Familie";
            this.btnOpslaan.UseVisualStyleBackColor = true;
            this.btnOpslaan.Click += new System.EventHandler(this.btnOpslaan_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(31, 727);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(407, 53);
            this.button1.TabIndex = 16;
            this.button1.Text = "Inlezen familie";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(557, 632);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(198, 57);
            this.button2.TabIndex = 17;
            this.button2.Text = "Alle mannen";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(557, 723);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(198, 57);
            this.button3.TabIndex = 18;
            this.button3.Text = "Alle vrouwen";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(790, 632);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(198, 57);
            this.button4.TabIndex = 19;
            this.button4.Text = "Ouder dan 40";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(790, 723);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(198, 57);
            this.button5.TabIndex = 20;
            this.button5.Text = "Sorteren leeftijd";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // txtZoekveld
            // 
            this.txtZoekveld.Location = new System.Drawing.Point(1041, 658);
            this.txtZoekveld.Name = "txtZoekveld";
            this.txtZoekveld.Size = new System.Drawing.Size(217, 26);
            this.txtZoekveld.TabIndex = 21;
            this.txtZoekveld.TextChanged += new System.EventHandler(this.txtZoekveld_TextChanged);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(1041, 725);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(217, 57);
            this.button6.TabIndex = 22;
            this.button6.Text = "Zoeken";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(1406, 732);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(165, 50);
            this.button7.TabIndex = 23;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(32, 833);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(407, 53);
            this.button8.TabIndex = 24;
            this.button8.Text = "Export XML";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(32, 905);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(407, 53);
            this.button9.TabIndex = 25;
            this.button9.Text = "Import XML";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(494, 905);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(407, 53);
            this.button10.TabIndex = 26;
            this.button10.Text = "Oude XML";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(941, 905);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(407, 53);
            this.button11.TabIndex = 27;
            this.button11.Text = "XML writer";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1628, 1035);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.txtZoekveld);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnOpslaan);
            this.Controls.Add(this.dgvPersonen);
            this.Controls.Add(this.lbxPersonen);
            this.Controls.Add(this.btnToevoegen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbLand);
            this.Controls.Add(this.rbOnbekend);
            this.Controls.Add(this.rbVrouw);
            this.Controls.Add(this.rbMan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpGeboortedatum);
            this.Controls.Add(this.txtAchternaam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtVoornaam);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVoornaam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAchternaam;
        private System.Windows.Forms.DateTimePicker dtpGeboortedatum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbMan;
        private System.Windows.Forms.RadioButton rbVrouw;
        private System.Windows.Forms.RadioButton rbOnbekend;
        private System.Windows.Forms.ComboBox cmbLand;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnToevoegen;
        private System.Windows.Forms.ListBox lbxPersonen;
        private System.Windows.Forms.DataGridView dgvPersonen;
        private System.Windows.Forms.Button btnOpslaan;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txtZoekveld;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
    }
}

