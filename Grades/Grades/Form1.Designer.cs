namespace Grades
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.studentsList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.removeStudent = new System.Windows.Forms.Button();
            this.editGrades = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.addStudent = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.math = new System.Windows.Forms.Label();
            this.biology = new System.Windows.Forms.Label();
            this.practice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // studentsList
            // 
            this.studentsList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.studentsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.studentsList.FormattingEnabled = true;
            this.studentsList.Location = new System.Drawing.Point(34, 35);
            this.studentsList.Name = "studentsList";
            this.studentsList.Size = new System.Drawing.Size(413, 28);
            this.studentsList.TabIndex = 0;
            this.studentsList.SelectedIndexChanged += new System.EventHandler(this.studentsList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(30, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Дисциплина:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(30, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Математика";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(30, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Биология";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(30, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Практика";
            // 
            // removeStudent
            // 
            this.removeStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.removeStudent.Location = new System.Drawing.Point(34, 270);
            this.removeStudent.Name = "removeStudent";
            this.removeStudent.Size = new System.Drawing.Size(199, 49);
            this.removeStudent.TabIndex = 5;
            this.removeStudent.Text = "Отчислить студента";
            this.removeStudent.UseVisualStyleBackColor = true;
            this.removeStudent.Click += new System.EventHandler(this.removeStudent_Click);
            // 
            // editGrades
            // 
            this.editGrades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editGrades.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editGrades.Location = new System.Drawing.Point(248, 270);
            this.editGrades.Name = "editGrades";
            this.editGrades.Size = new System.Drawing.Size(199, 49);
            this.editGrades.TabIndex = 6;
            this.editGrades.Text = "Редактировать оценки";
            this.editGrades.UseVisualStyleBackColor = true;
            this.editGrades.Click += new System.EventHandler(this.editGrades_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(315, 122);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 26);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(315, 154);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 26);
            this.textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(315, 186);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(132, 26);
            this.textBox3.TabIndex = 9;
            // 
            // addStudent
            // 
            this.addStudent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.addStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addStudent.Location = new System.Drawing.Point(315, 218);
            this.addStudent.Name = "addStudent";
            this.addStudent.Size = new System.Drawing.Size(132, 30);
            this.addStudent.TabIndex = 10;
            this.addStudent.Text = "Добавить";
            this.addStudent.UseVisualStyleBackColor = false;
            this.addStudent.Click += new System.EventHandler(this.addStudent_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(168, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Оценки:";
            // 
            // math
            // 
            this.math.AutoSize = true;
            this.math.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.math.Location = new System.Drawing.Point(188, 146);
            this.math.Name = "math";
            this.math.Size = new System.Drawing.Size(0, 20);
            this.math.TabIndex = 12;
            // 
            // biology
            // 
            this.biology.AutoSize = true;
            this.biology.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.biology.Location = new System.Drawing.Point(188, 184);
            this.biology.Name = "biology";
            this.biology.Size = new System.Drawing.Size(0, 20);
            this.biology.TabIndex = 13;
            // 
            // practice
            // 
            this.practice.AutoSize = true;
            this.practice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.practice.Location = new System.Drawing.Point(188, 222);
            this.practice.Name = "practice";
            this.practice.Size = new System.Drawing.Size(0, 20);
            this.practice.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 341);
            this.Controls.Add(this.practice);
            this.Controls.Add(this.biology);
            this.Controls.Add(this.math);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.addStudent);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.editGrades);
            this.Controls.Add(this.removeStudent);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.studentsList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Табель оценок";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox studentsList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button removeStudent;
        private System.Windows.Forms.Button editGrades;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button addStudent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label math;
        private System.Windows.Forms.Label biology;
        private System.Windows.Forms.Label practice;
    }
}

