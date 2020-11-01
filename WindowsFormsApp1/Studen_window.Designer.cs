namespace WindowsFormsApp1
{
    partial class Studen_window
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Studen_window));
            this.back_button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Close_button = new System.Windows.Forms.Button();
            this.student_button = new System.Windows.Forms.Button();
            this.teacher_button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.Color.Orange;
            this.back_button.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.back_button.Location = new System.Drawing.Point(804, 507);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(189, 41);
            this.back_button.TabIndex = 3;
            this.back_button.Text = "Back to main menu";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.Close_button);
            this.groupBox1.Controls.Add(this.student_button);
            this.groupBox1.Controls.Add(this.teacher_button);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(159, 536);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Learn with TUKE";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Orange;
            this.button2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(6, 268);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 41);
            this.button2.TabIndex = 4;
            this.button2.Text = "Progress";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Orange;
            this.button1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(6, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "Results";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Close_button
            // 
            this.Close_button.BackColor = System.Drawing.Color.Orange;
            this.Close_button.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close_button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Close_button.Location = new System.Drawing.Point(6, 174);
            this.Close_button.Name = "Close_button";
            this.Close_button.Size = new System.Drawing.Size(142, 41);
            this.Close_button.TabIndex = 2;
            this.Close_button.Text = "Tests";
            this.Close_button.UseVisualStyleBackColor = false;
            // 
            // student_button
            // 
            this.student_button.BackColor = System.Drawing.Color.Orange;
            this.student_button.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.student_button.Location = new System.Drawing.Point(6, 127);
            this.student_button.Name = "student_button";
            this.student_button.Size = new System.Drawing.Size(142, 41);
            this.student_button.TabIndex = 0;
            this.student_button.Text = "Exercises";
            this.student_button.UseVisualStyleBackColor = false;
            // 
            // teacher_button
            // 
            this.teacher_button.BackColor = System.Drawing.Color.Orange;
            this.teacher_button.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacher_button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.teacher_button.Location = new System.Drawing.Point(6, 80);
            this.teacher_button.Name = "teacher_button";
            this.teacher_button.Size = new System.Drawing.Size(142, 41);
            this.teacher_button.TabIndex = 1;
            this.teacher_button.Text = "Lectures";
            this.teacher_button.UseVisualStyleBackColor = false;
            // 
            // Studen_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(1005, 560);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.back_button);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Studen_window";
            this.Text = "Student";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Close_button;
        private System.Windows.Forms.Button student_button;
        private System.Windows.Forms.Button teacher_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}