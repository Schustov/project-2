namespace Grades
{
    partial class Form2
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.math_n = new System.Windows.Forms.NumericUpDown();
            this.bio_n = new System.Windows.Forms.NumericUpDown();
            this.practice_n = new System.Windows.Forms.NumericUpDown();
            this.save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.math_n)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bio_n)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.practice_n)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(52, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Математика";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(52, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Биология";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(52, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Практика";
            // 
            // math_n
            // 
            this.math_n.Location = new System.Drawing.Point(204, 39);
            this.math_n.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.math_n.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.math_n.Name = "math_n";
            this.math_n.ReadOnly = true;
            this.math_n.Size = new System.Drawing.Size(58, 20);
            this.math_n.TabIndex = 3;
            this.math_n.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // bio_n
            // 
            this.bio_n.Location = new System.Drawing.Point(204, 82);
            this.bio_n.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.bio_n.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.bio_n.Name = "bio_n";
            this.bio_n.ReadOnly = true;
            this.bio_n.Size = new System.Drawing.Size(58, 20);
            this.bio_n.TabIndex = 4;
            this.bio_n.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // practice_n
            // 
            this.practice_n.Location = new System.Drawing.Point(204, 129);
            this.practice_n.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.practice_n.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.practice_n.Name = "practice_n";
            this.practice_n.ReadOnly = true;
            this.practice_n.Size = new System.Drawing.Size(58, 20);
            this.practice_n.TabIndex = 5;
            this.practice_n.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // save
            // 
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.save.Location = new System.Drawing.Point(103, 169);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(120, 50);
            this.save.TabIndex = 6;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(314, 231);
            this.Controls.Add(this.save);
            this.Controls.Add(this.practice_n);
            this.Controls.Add(this.bio_n);
            this.Controls.Add(this.math_n);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form2";
            this.Text = "Изменение оценок";
            ((System.ComponentModel.ISupportInitialize)(this.math_n)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bio_n)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.practice_n)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button save;
        public System.Windows.Forms.NumericUpDown math_n;
        public System.Windows.Forms.NumericUpDown bio_n;
        public System.Windows.Forms.NumericUpDown practice_n;
    }
}