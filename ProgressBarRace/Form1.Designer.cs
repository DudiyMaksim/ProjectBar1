namespace ProgressBarRace
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
            button1 = new Button();
            progressBar1 = new ProgressBar();
            progressBar2 = new ProgressBar();
            progressBar3 = new ProgressBar();
            progressBar4 = new ProgressBar();
            progressBar5 = new ProgressBar();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(336, 355);
            button1.Name = "button1";
            button1.Size = new Size(129, 42);
            button1.TabIndex = 0;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(48, 63);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(696, 10);
            progressBar1.TabIndex = 1;
            // 
            // progressBar2
            // 
            progressBar2.Location = new Point(48, 120);
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(696, 10);
            progressBar2.TabIndex = 2;
            // 
            // progressBar3
            // 
            progressBar3.Location = new Point(48, 176);
            progressBar3.Name = "progressBar3";
            progressBar3.Size = new Size(696, 10);
            progressBar3.TabIndex = 3;
            // 
            // progressBar4
            // 
            progressBar4.Location = new Point(48, 231);
            progressBar4.Name = "progressBar4";
            progressBar4.Size = new Size(696, 10);
            progressBar4.TabIndex = 4;
            // 
            // progressBar5
            // 
            progressBar5.Location = new Point(48, 288);
            progressBar5.Name = "progressBar5";
            progressBar5.Size = new Size(696, 10);
            progressBar5.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 58);
            label1.Name = "label1";
            label1.Size = new Size(15, 15);
            label1.TabIndex = 6;
            label1.Text = "A";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 115);
            label2.Name = "label2";
            label2.Size = new Size(14, 15);
            label2.TabIndex = 6;
            label2.Text = "B";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 171);
            label3.Name = "label3";
            label3.Size = new Size(15, 15);
            label3.TabIndex = 6;
            label3.Text = "C";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 226);
            label4.Name = "label4";
            label4.Size = new Size(15, 15);
            label4.TabIndex = 6;
            label4.Text = "D";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 283);
            label5.Name = "label5";
            label5.Size = new Size(13, 15);
            label5.TabIndex = 6;
            label5.Text = "E";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(750, 58);
            label6.Name = "label6";
            label6.Size = new Size(0, 15);
            label6.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(750, 115);
            label7.Name = "label7";
            label7.Size = new Size(0, 15);
            label7.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(750, 171);
            label8.Name = "label8";
            label8.Size = new Size(0, 15);
            label8.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(750, 226);
            label9.Name = "label9";
            label9.Size = new Size(0, 15);
            label9.TabIndex = 10;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(750, 283);
            label10.Name = "label10";
            label10.Size = new Size(0, 15);
            label10.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(progressBar5);
            Controls.Add(progressBar4);
            Controls.Add(progressBar3);
            Controls.Add(progressBar2);
            Controls.Add(progressBar1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ProgressBar progressBar1;
        private ProgressBar progressBar2;
        private ProgressBar progressBar3;
        private ProgressBar progressBar4;
        private ProgressBar progressBar5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
    }
}
