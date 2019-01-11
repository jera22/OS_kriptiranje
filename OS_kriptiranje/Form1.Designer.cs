namespace OS_kriptiranje
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.asimRadio = new System.Windows.Forms.RadioButton();
            this.simRadio = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dekriptButton = new System.Windows.Forms.Button();
            this.kriptButton = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(956, 74);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ključevi";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(275, 364);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 13);
            this.statusLabel.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(164, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Tajni";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Javni i Privatni";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.asimRadio);
            this.groupBox2.Controls.Add(this.simRadio);
            this.groupBox2.Location = new System.Drawing.Point(13, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(956, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Simetričnost";
            // 
            // asimRadio
            // 
            this.asimRadio.AutoSize = true;
            this.asimRadio.Location = new System.Drawing.Point(112, 44);
            this.asimRadio.Name = "asimRadio";
            this.asimRadio.Size = new System.Drawing.Size(79, 17);
            this.asimRadio.TabIndex = 1;
            this.asimRadio.TabStop = true;
            this.asimRadio.Text = "Asimetrično";
            this.asimRadio.UseVisualStyleBackColor = true;
            // 
            // simRadio
            // 
            this.simRadio.AutoSize = true;
            this.simRadio.Location = new System.Drawing.Point(20, 44);
            this.simRadio.Name = "simRadio";
            this.simRadio.Size = new System.Drawing.Size(74, 17);
            this.simRadio.TabIndex = 0;
            this.simRadio.TabStop = true;
            this.simRadio.Text = "Simetrično";
            this.simRadio.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dekriptButton);
            this.groupBox3.Controls.Add(this.kriptButton);
            this.groupBox3.Location = new System.Drawing.Point(13, 213);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(956, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // dekriptButton
            // 
            this.dekriptButton.Location = new System.Drawing.Point(164, 41);
            this.dekriptButton.Name = "dekriptButton";
            this.dekriptButton.Size = new System.Drawing.Size(75, 23);
            this.dekriptButton.TabIndex = 1;
            this.dekriptButton.Text = "Dekriptiraj";
            this.dekriptButton.UseVisualStyleBackColor = true;
            this.dekriptButton.Click += new System.EventHandler(this.dekriptButton_Click);
            // 
            // kriptButton
            // 
            this.kriptButton.Location = new System.Drawing.Point(34, 41);
            this.kriptButton.Name = "kriptButton";
            this.kriptButton.Size = new System.Drawing.Size(75, 23);
            this.kriptButton.TabIndex = 0;
            this.kriptButton.Text = "Kriptiraj";
            this.kriptButton.UseVisualStyleBackColor = true;
            this.kriptButton.Click += new System.EventHandler(this.kriptButton_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(13, 415);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(159, 23);
            this.button6.TabIndex = 3;
            this.button6.Text = "Učitaj datoteku";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 450);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton asimRadio;
        private System.Windows.Forms.RadioButton simRadio;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button dekriptButton;
        private System.Windows.Forms.Button kriptButton;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

