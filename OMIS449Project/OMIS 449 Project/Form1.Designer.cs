namespace OMIS_449_Project
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
            this.button1 = new System.Windows.Forms.Button();
            this.ViewStudents = new System.Windows.Forms.Button();
            this.TakeAttendance = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ViewStudents
            // 
            this.ViewStudents.Location = new System.Drawing.Point(12, 12);
            this.ViewStudents.Name = "ViewStudents";
            this.ViewStudents.Size = new System.Drawing.Size(113, 52);
            this.ViewStudents.TabIndex = 1;
            this.ViewStudents.Text = "View Students";
            this.ViewStudents.UseVisualStyleBackColor = true;
            this.ViewStudents.Click += new System.EventHandler(this.ViewStudents_Click);
            // 
            // TakeAttendance
            // 
            this.TakeAttendance.Location = new System.Drawing.Point(12, 70);
            this.TakeAttendance.Name = "TakeAttendance";
            this.TakeAttendance.Size = new System.Drawing.Size(113, 52);
            this.TakeAttendance.TabIndex = 2;
            this.TakeAttendance.Text = "Take Attendance";
            this.TakeAttendance.UseVisualStyleBackColor = true;
            this.TakeAttendance.Click += new System.EventHandler(this.TakeAttendance_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Castellar", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(131, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 44);
            this.label1.TabIndex = 3;
            this.label1.Text = "EduTech";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(350, 212);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TakeAttendance);
            this.Controls.Add(this.ViewStudents);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "EduTech Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ViewStudents;
        private System.Windows.Forms.Button TakeAttendance;
        private System.Windows.Forms.Label label1;
    }
}

