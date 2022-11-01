namespace RadioButton_kontrola
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
            this.grpBox1 = new System.Windows.Forms.GroupBox();
            this.radAvion = new System.Windows.Forms.RadioButton();
            this.radAutobus = new System.Windows.Forms.RadioButton();
            this.radVprijevoz = new System.Windows.Forms.RadioButton();
            this.brnRezerviraj = new System.Windows.Forms.Button();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.grpBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBox1
            // 
            this.grpBox1.Controls.Add(this.radVprijevoz);
            this.grpBox1.Controls.Add(this.radAutobus);
            this.grpBox1.Controls.Add(this.radAvion);
            this.grpBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBox1.Location = new System.Drawing.Point(61, 27);
            this.grpBox1.Name = "grpBox1";
            this.grpBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grpBox1.Size = new System.Drawing.Size(156, 105);
            this.grpBox1.TabIndex = 0;
            this.grpBox1.TabStop = false;
            this.grpBox1.Text = "Odaberite vrstu prijevoza";
            // 
            // radAvion
            // 
            this.radAvion.AutoSize = true;
            this.radAvion.Location = new System.Drawing.Point(7, 21);
            this.radAvion.Name = "radAvion";
            this.radAvion.Size = new System.Drawing.Size(54, 19);
            this.radAvion.TabIndex = 0;
            this.radAvion.TabStop = true;
            this.radAvion.Text = "Avion";
            this.radAvion.UseVisualStyleBackColor = true;
            this.radAvion.CheckedChanged += new System.EventHandler(this.radAvion_CheckedChanged);
            // 
            // radAutobus
            // 
            this.radAutobus.AutoSize = true;
            this.radAutobus.Location = new System.Drawing.Point(7, 47);
            this.radAutobus.Name = "radAutobus";
            this.radAutobus.Size = new System.Drawing.Size(69, 19);
            this.radAutobus.TabIndex = 1;
            this.radAutobus.TabStop = true;
            this.radAutobus.Text = "Autobus";
            this.radAutobus.UseVisualStyleBackColor = true;
            // 
            // radVprijevoz
            // 
            this.radVprijevoz.AutoSize = true;
            this.radVprijevoz.Location = new System.Drawing.Point(7, 73);
            this.radVprijevoz.Name = "radVprijevoz";
            this.radVprijevoz.Size = new System.Drawing.Size(105, 19);
            this.radVprijevoz.TabIndex = 2;
            this.radVprijevoz.TabStop = true;
            this.radVprijevoz.Text = "Vlastiti prijevoz";
            this.radVprijevoz.UseVisualStyleBackColor = true;
            // 
            // brnRezerviraj
            // 
            this.brnRezerviraj.Location = new System.Drawing.Point(68, 156);
            this.brnRezerviraj.Name = "brnRezerviraj";
            this.brnRezerviraj.Size = new System.Drawing.Size(138, 23);
            this.brnRezerviraj.TabIndex = 1;
            this.brnRezerviraj.Text = "Rezerviraj";
            this.brnRezerviraj.UseVisualStyleBackColor = true;
            this.brnRezerviraj.Click += new System.EventHandler(this.brnRezerviraj_Click);
            // 
            // txtBox
            // 
            this.txtBox.Enabled = false;
            this.txtBox.Location = new System.Drawing.Point(61, 213);
            this.txtBox.Multiline = true;
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(156, 75);
            this.txtBox.TabIndex = 2;
            this.txtBox.TextChanged += new System.EventHandler(this.txtBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 321);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.brnRezerviraj);
            this.Controls.Add(this.grpBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpBox1.ResumeLayout(false);
            this.grpBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBox1;
        private System.Windows.Forms.RadioButton radVprijevoz;
        private System.Windows.Forms.RadioButton radAutobus;
        private System.Windows.Forms.RadioButton radAvion;
        private System.Windows.Forms.Button brnRezerviraj;
        private System.Windows.Forms.TextBox txtBox;
    }
}

