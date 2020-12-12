namespace orvosirendelo
{
    partial class BetegRegisztralForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.textBoxJel1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nevTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSZIG = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTAJ = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.telefonTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxJel2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 389);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(400, 17);
            this.label4.TabIndex = 28;
            this.label4.Text = "Figyelmezteteés hogy már van ilyen nevű ilyen jelszavú ember";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(596, 294);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 27;
            this.button3.Text = "OK";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBoxJel1
            // 
            this.textBoxJel1.Location = new System.Drawing.Point(115, 262);
            this.textBoxJel1.Name = "textBoxJel1";
            this.textBoxJel1.Size = new System.Drawing.Size(100, 22);
            this.textBoxJel1.TabIndex = 25;
            this.textBoxJel1.TextChanged += new System.EventHandler(this.textBoxJel1_TextChanged);
            this.textBoxJel1.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxJel1_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "jelszó";
            // 
            // nevTextBox
            // 
            this.nevTextBox.Location = new System.Drawing.Point(115, 33);
            this.nevTextBox.Name = "nevTextBox";
            this.nevTextBox.Size = new System.Drawing.Size(100, 22);
            this.nevTextBox.TabIndex = 26;
            this.nevTextBox.TextChanged += new System.EventHandler(this.nevTextBox_TextChanged);
            this.nevTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.nevTextBox_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 17);
            this.label6.TabIndex = 24;
            this.label6.Text = "név";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "email cím";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(115, 161);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(100, 22);
            this.emailTextBox.TabIndex = 26;
            this.emailTextBox.TextChanged += new System.EventHandler(this.emailTextBox_TextChanged);
            this.emailTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.emailTextBox_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "SZIG szám";
            // 
            // textBoxSZIG
            // 
            this.textBoxSZIG.Location = new System.Drawing.Point(115, 77);
            this.textBoxSZIG.Name = "textBoxSZIG";
            this.textBoxSZIG.Size = new System.Drawing.Size(100, 22);
            this.textBoxSZIG.TabIndex = 26;
            this.textBoxSZIG.TextChanged += new System.EventHandler(this.textBoxSZIG_TextChanged);
            this.textBoxSZIG.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxSZIG_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "TAJ szám";
            // 
            // textBoxTAJ
            // 
            this.textBoxTAJ.Location = new System.Drawing.Point(115, 123);
            this.textBoxTAJ.Name = "textBoxTAJ";
            this.textBoxTAJ.Size = new System.Drawing.Size(100, 22);
            this.textBoxTAJ.TabIndex = 26;
            this.textBoxTAJ.TextChanged += new System.EventHandler(this.textBoxTAJ_TextChanged);
            this.textBoxTAJ.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxTAJ_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "TELEFON";
            // 
            // telefonTextBox
            // 
            this.telefonTextBox.Location = new System.Drawing.Point(115, 208);
            this.telefonTextBox.Name = "telefonTextBox";
            this.telefonTextBox.Size = new System.Drawing.Size(100, 22);
            this.telefonTextBox.TabIndex = 26;
            this.telefonTextBox.TextChanged += new System.EventHandler(this.telefonTextBox_TextChanged);
            this.telefonTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.telefonTextBox_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 295);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 17);
            this.label8.TabIndex = 23;
            this.label8.Text = "jelszó újra";
            // 
            // textBoxJel2
            // 
            this.textBoxJel2.Location = new System.Drawing.Point(115, 295);
            this.textBoxJel2.Name = "textBoxJel2";
            this.textBoxJel2.Size = new System.Drawing.Size(100, 22);
            this.textBoxJel2.TabIndex = 25;
            this.textBoxJel2.TextChanged += new System.EventHandler(this.textBoxJel2_TextChanged);
            this.textBoxJel2.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxJel2_Validating);
            // 
            // BetegRegisztralForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBoxJel2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxJel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxTAJ);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.telefonTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxSZIG);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nevTextBox);
            this.Controls.Add(this.label6);
            this.Name = "BetegRegisztralForm";
            this.Text = "BetegRegisztralForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBoxJel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nevTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSZIG;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTAJ;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox telefonTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxJel2;
    }
}