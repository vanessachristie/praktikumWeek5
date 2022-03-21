namespace praktikumWeek4
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
            this.tBoxInput = new System.Windows.Forms.TextBox();
            this.labelData = new System.Windows.Forms.Label();
            this.lBoxData = new System.Windows.Forms.ListBox();
            this.rButtonMerah = new System.Windows.Forms.RadioButton();
            this.btnAdd = new System.Windows.Forms.Button();
            this.rButtonBiru = new System.Windows.Forms.RadioButton();
            this.cBoxAktif = new System.Windows.Forms.CheckBox();
            this.labelSetting = new System.Windows.Forms.Label();
            this.labelOutput = new System.Windows.Forms.Label();
            this.labelOutput2 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.labelKoleksi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tBoxInput
            // 
            this.tBoxInput.Location = new System.Drawing.Point(147, 54);
            this.tBoxInput.Name = "tBoxInput";
            this.tBoxInput.Size = new System.Drawing.Size(125, 27);
            this.tBoxInput.TabIndex = 1;
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(66, 57);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(41, 20);
            this.labelData.TabIndex = 2;
            this.labelData.Text = "Data";
            // 
            // lBoxData
            // 
            this.lBoxData.FormattingEnabled = true;
            this.lBoxData.ItemHeight = 20;
            this.lBoxData.Location = new System.Drawing.Point(147, 146);
            this.lBoxData.Name = "lBoxData";
            this.lBoxData.Size = new System.Drawing.Size(150, 104);
            this.lBoxData.TabIndex = 3;
            this.lBoxData.SelectedIndexChanged += new System.EventHandler(this.lBoxData_SelectedIndexChanged);
            // 
            // rButtonMerah
            // 
            this.rButtonMerah.AutoSize = true;
            this.rButtonMerah.Location = new System.Drawing.Point(529, 138);
            this.rButtonMerah.Name = "rButtonMerah";
            this.rButtonMerah.Size = new System.Drawing.Size(118, 24);
            this.rButtonMerah.TabIndex = 4;
            this.rButtonMerah.TabStop = true;
            this.rButtonMerah.Text = "Warna Merah";
            this.rButtonMerah.UseVisualStyleBackColor = true;
            this.rButtonMerah.CheckedChanged += new System.EventHandler(this.rButtonMerah_CheckedChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(360, 51);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 29);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // rButtonBiru
            // 
            this.rButtonBiru.AutoSize = true;
            this.rButtonBiru.Location = new System.Drawing.Point(529, 168);
            this.rButtonBiru.Name = "rButtonBiru";
            this.rButtonBiru.Size = new System.Drawing.Size(102, 24);
            this.rButtonBiru.TabIndex = 6;
            this.rButtonBiru.TabStop = true;
            this.rButtonBiru.Text = "Warna Biru";
            this.rButtonBiru.UseVisualStyleBackColor = true;
            this.rButtonBiru.CheckedChanged += new System.EventHandler(this.rButtonBiru_CheckedChanged);
            // 
            // cBoxAktif
            // 
            this.cBoxAktif.AutoSize = true;
            this.cBoxAktif.Location = new System.Drawing.Point(529, 108);
            this.cBoxAktif.Name = "cBoxAktif";
            this.cBoxAktif.Size = new System.Drawing.Size(62, 24);
            this.cBoxAktif.TabIndex = 7;
            this.cBoxAktif.Text = "Aktif";
            this.cBoxAktif.UseVisualStyleBackColor = true;
            this.cBoxAktif.CheckedChanged += new System.EventHandler(this.cBoxAktif_CheckedChanged);
            // 
            // labelSetting
            // 
            this.labelSetting.AutoSize = true;
            this.labelSetting.Location = new System.Drawing.Point(534, 70);
            this.labelSetting.Name = "labelSetting";
            this.labelSetting.Size = new System.Drawing.Size(59, 20);
            this.labelSetting.TabIndex = 8;
            this.labelSetting.Text = "Setting:";
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Location = new System.Drawing.Point(399, 230);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(55, 20);
            this.labelOutput.TabIndex = 9;
            this.labelOutput.Text = "Output";
            // 
            // labelOutput2
            // 
            this.labelOutput2.AutoSize = true;
            this.labelOutput2.Location = new System.Drawing.Point(561, 307);
            this.labelOutput2.Name = "labelOutput2";
            this.labelOutput2.Size = new System.Drawing.Size(31, 20);
            this.labelOutput2.TabIndex = 10;
            this.labelOutput2.Text = "(....)";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(495, 358);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 29);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // labelKoleksi
            // 
            this.labelKoleksi.AutoSize = true;
            this.labelKoleksi.Location = new System.Drawing.Point(149, 107);
            this.labelKoleksi.Name = "labelKoleksi";
            this.labelKoleksi.Size = new System.Drawing.Size(59, 20);
            this.labelKoleksi.TabIndex = 12;
            this.labelKoleksi.Text = "Koleksi:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelKoleksi);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.labelOutput2);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.labelSetting);
            this.Controls.Add(this.cBoxAktif);
            this.Controls.Add(this.rButtonBiru);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.rButtonMerah);
            this.Controls.Add(this.lBoxData);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.tBoxInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tBoxInput;
        private Label labelData;
        private ListBox lBoxData;
        private RadioButton rButtonMerah;
        private Button btnAdd;
        private RadioButton rButtonBiru;
        private CheckBox cBoxAktif;
        private Label labelSetting;
        private Label labelOutput;
        private Label labelOutput2;
        private Button btnClear;
        private Label labelKoleksi;
    }
}