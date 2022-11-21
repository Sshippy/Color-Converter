namespace ColorConverter
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
            this.groupBoxFirst = new System.Windows.Forms.GroupBox();
            this.radioButtonRed = new System.Windows.Forms.RadioButton();
            this.radioButtonBlue = new System.Windows.Forms.RadioButton();
            this.radioButtonYellow = new System.Windows.Forms.RadioButton();
            this.groupBoxSecond = new System.Windows.Forms.GroupBox();
            this.radioBtnRed = new System.Windows.Forms.RadioButton();
            this.radioBtnBlue = new System.Windows.Forms.RadioButton();
            this.radioBtnYellow = new System.Windows.Forms.RadioButton();
            this.btnMix = new System.Windows.Forms.Button();
            this.groupBoxFirst.SuspendLayout();
            this.groupBoxSecond.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxFirst
            // 
            this.groupBoxFirst.Controls.Add(this.radioButtonYellow);
            this.groupBoxFirst.Controls.Add(this.radioButtonBlue);
            this.groupBoxFirst.Controls.Add(this.radioButtonRed);
            this.groupBoxFirst.Location = new System.Drawing.Point(106, 39);
            this.groupBoxFirst.Name = "groupBoxFirst";
            this.groupBoxFirst.Size = new System.Drawing.Size(128, 184);
            this.groupBoxFirst.TabIndex = 0;
            this.groupBoxFirst.TabStop = false;
            this.groupBoxFirst.Text = "First Color";
            this.groupBoxFirst.Enter += new System.EventHandler(this.groupBoxFirst_Enter);
            // 
            // radioButtonRed
            // 
            this.radioButtonRed.AutoSize = true;
            this.radioButtonRed.Location = new System.Drawing.Point(7, 39);
            this.radioButtonRed.Name = "radioButtonRed";
            this.radioButtonRed.Size = new System.Drawing.Size(54, 20);
            this.radioButtonRed.TabIndex = 0;
            this.radioButtonRed.TabStop = true;
            this.radioButtonRed.Text = "Red";
            this.radioButtonRed.UseVisualStyleBackColor = true;
            this.radioButtonRed.CheckedChanged += new System.EventHandler(this.radioButtonRed_CheckedChanged);
            // 
            // radioButtonBlue
            // 
            this.radioButtonBlue.AutoSize = true;
            this.radioButtonBlue.Location = new System.Drawing.Point(7, 84);
            this.radioButtonBlue.Name = "radioButtonBlue";
            this.radioButtonBlue.Size = new System.Drawing.Size(55, 20);
            this.radioButtonBlue.TabIndex = 1;
            this.radioButtonBlue.TabStop = true;
            this.radioButtonBlue.Text = "Blue";
            this.radioButtonBlue.UseVisualStyleBackColor = true;
            this.radioButtonBlue.CheckedChanged += new System.EventHandler(this.radioButtonBlue_CheckedChanged);
            // 
            // radioButtonYellow
            // 
            this.radioButtonYellow.AutoSize = true;
            this.radioButtonYellow.Location = new System.Drawing.Point(7, 135);
            this.radioButtonYellow.Name = "radioButtonYellow";
            this.radioButtonYellow.Size = new System.Drawing.Size(68, 20);
            this.radioButtonYellow.TabIndex = 2;
            this.radioButtonYellow.TabStop = true;
            this.radioButtonYellow.Text = "Yellow";
            this.radioButtonYellow.UseVisualStyleBackColor = true;
            this.radioButtonYellow.CheckedChanged += new System.EventHandler(this.radioButtonYellow_CheckedChanged);
            // 
            // groupBoxSecond
            // 
            this.groupBoxSecond.Controls.Add(this.radioBtnYellow);
            this.groupBoxSecond.Controls.Add(this.radioBtnBlue);
            this.groupBoxSecond.Controls.Add(this.radioBtnRed);
            this.groupBoxSecond.Location = new System.Drawing.Point(401, 39);
            this.groupBoxSecond.Name = "groupBoxSecond";
            this.groupBoxSecond.Size = new System.Drawing.Size(128, 184);
            this.groupBoxSecond.TabIndex = 1;
            this.groupBoxSecond.TabStop = false;
            this.groupBoxSecond.Text = "Second Color";
            this.groupBoxSecond.Enter += new System.EventHandler(this.groupBoxSecond_Enter);
            // 
            // radioBtnRed
            // 
            this.radioBtnRed.AutoSize = true;
            this.radioBtnRed.Location = new System.Drawing.Point(7, 38);
            this.radioBtnRed.Name = "radioBtnRed";
            this.radioBtnRed.Size = new System.Drawing.Size(54, 20);
            this.radioBtnRed.TabIndex = 0;
            this.radioBtnRed.TabStop = true;
            this.radioBtnRed.Text = "Red";
            this.radioBtnRed.UseVisualStyleBackColor = true;
            this.radioBtnRed.CheckedChanged += new System.EventHandler(this.radioBtnRed_CheckedChanged);
            // 
            // radioBtnBlue
            // 
            this.radioBtnBlue.AutoSize = true;
            this.radioBtnBlue.Location = new System.Drawing.Point(7, 83);
            this.radioBtnBlue.Name = "radioBtnBlue";
            this.radioBtnBlue.Size = new System.Drawing.Size(55, 20);
            this.radioBtnBlue.TabIndex = 1;
            this.radioBtnBlue.TabStop = true;
            this.radioBtnBlue.Text = "Blue";
            this.radioBtnBlue.UseVisualStyleBackColor = true;
            this.radioBtnBlue.CheckedChanged += new System.EventHandler(this.radioBtnBlue_CheckedChanged);
            // 
            // radioBtnYellow
            // 
            this.radioBtnYellow.AutoSize = true;
            this.radioBtnYellow.Location = new System.Drawing.Point(7, 134);
            this.radioBtnYellow.Name = "radioBtnYellow";
            this.radioBtnYellow.Size = new System.Drawing.Size(68, 20);
            this.radioBtnYellow.TabIndex = 2;
            this.radioBtnYellow.TabStop = true;
            this.radioBtnYellow.Text = "Yellow";
            this.radioBtnYellow.UseVisualStyleBackColor = true;
            this.radioBtnYellow.CheckedChanged += new System.EventHandler(this.radioBtnYellow_CheckedChanged);
            // 
            // btnMix
            // 
            this.btnMix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnMix.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMix.Location = new System.Drawing.Point(230, 267);
            this.btnMix.Name = "btnMix";
            this.btnMix.Size = new System.Drawing.Size(173, 48);
            this.btnMix.TabIndex = 2;
            this.btnMix.Text = "Mix Color";
            this.btnMix.UseVisualStyleBackColor = false;
            this.btnMix.Click += new System.EventHandler(this.btnMix_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMix);
            this.Controls.Add(this.groupBoxSecond);
            this.Controls.Add(this.groupBoxFirst);
            this.Name = "Form1";
            this.Text = "Color Mixer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxFirst.ResumeLayout(false);
            this.groupBoxFirst.PerformLayout();
            this.groupBoxSecond.ResumeLayout(false);
            this.groupBoxSecond.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxFirst;
        private System.Windows.Forms.RadioButton radioButtonYellow;
        private System.Windows.Forms.RadioButton radioButtonBlue;
        private System.Windows.Forms.RadioButton radioButtonRed;
        private System.Windows.Forms.GroupBox groupBoxSecond;
        private System.Windows.Forms.RadioButton radioBtnYellow;
        private System.Windows.Forms.RadioButton radioBtnBlue;
        private System.Windows.Forms.RadioButton radioBtnRed;
        private System.Windows.Forms.Button btnMix;
    }
}
