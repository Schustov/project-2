using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Grades
{
    public partial class Form1 : Form
    {
        internal static List<Student> students;
        private string path = @"students.json";
        public class Student
        {
            public string Surname { get; set; }
            public string Name { get; set; }
            public string Patronymic { get; set; }
            public int mathGrade { get; set; }
            public int bioGrade { get; set; }
            public int practiceGrade { get; set; }

            public Student(string surname, string name, string patronymic, int mathGrade, int bioGrade, int practiceGrade)
            {
                Surname = surname;
                Name = name;
                Patronymic = patronymic;
                this.mathGrade = mathGrade;
                this.bioGrade = bioGrade;
                this.practiceGrade = practiceGrade;
            }
        }
        public Form1()
        {
            InitializeComponent();
            students = File.Exists("students.json") ? JsonConvert.DeserializeObject<List<Student>>(File.ReadAllText(path)) : new List<Student>();
            addStudents();
            updateList();
        }

        private void addStudents()
        {
            if (students.Count == 0)
            {
                students.Add(new Student("Шустов", "Денис", "Константинович", 2, 2, 2));
                students.Add(new Student("Марков", "Максим", "Глебович", 2, 2, 2));
                students.Add(new Student("Крылова", "Ева", "Андреевна", 2, 2, 2));
                students.Add(new Student("Лосев", "Дмитрий", "Артемович", 2, 2, 2));
                students.Add(new Student("Старикова", "Милана", "Марковна", 2, 2, 2));
                students.Add(new Student("Зимин", "Александр", "Лукич", 2, 2, 2));
                students.Add(new Student("Ефимов", "Давид", "Александрович", 2, 2, 2));
                students.Add(new Student("Давыдов", "Вадим", "Андреевич", 2, 2, 2));
                students.Add(new Student("Коротков", "Всеволод", "Сергеевич", 2, 2, 2));
                students.Add(new Student("Демьянов", "Николай", "Иванович", 2, 2, 2));
                students.Add(new Student("Филиппов", "Алексей", "Матвеевич", 2, 2, 2));
                students.Add(new Student("Логинов", "Егор", "Маркович", 2, 2, 2));
                students.Add(new Student("Горлова", "Милана", "Михайловна", 2, 2, 2));
                students.Add(new Student("Савельева", "Екатерина", "Кирилловна", 2, 2, 2));
                students.Add(new Student("Сорокин", "Дмитрий", "Максимович", 2, 2, 2));
                students.Add(new Student("Галкина", "София", "Артемовна", 2, 2, 2));
            }
        }

        private void updateList()
        {
            studentsList.Items.Clear();
            for (int i = 0; i <  students.Count; i++)
            {
                studentsList.Items.Add(string.Join(" ", students[i].Surname, students[i].Name, students[i].Patronymic));
            }
        }

        private void addStudent_Click(object sender, EventArgs e)
        {
            string surname = textBox1.Text.Trim();
            string name = textBox2.Text.Trim();
            string patronymic = textBox3.Text.Trim();
            if (surname == "" || name == "" || patronymic == "")
            {
                MessageBox.Show("Напишите ФИО студента полностью", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                students.Add(new Student(surname, name, patronymic, 2, 2, 2));
                updateList();
                studentsList.SelectedIndex = students.Count - 1;
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                editGrades_Click(sender, e);
            }
        }

        private void editGrades_Click(object sender, EventArgs e)
        {
            int index = studentsList.SelectedIndex;
            if (index != -1)
            {
                Form2 inputDialog = new Form2(students[index].mathGrade, students[index].bioGrade, students[index].practiceGrade);
                if (inputDialog.ShowDialog() == DialogResult.OK)
                {
                    students[index].mathGrade = Convert.ToInt32(inputDialog.math_n.Value);
                    students[index].bioGrade = Convert.ToInt32(inputDialog.bio_n.Value);
                    students[index].practiceGrade = Convert.ToInt32(inputDialog.practice_n.Value);
                    studentsList_SelectedIndexChanged(sender, e);
                }
                inputDialog.Close();
            }
            else
            {
                MessageBox.Show("Сначала выберите студента", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void studentsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = studentsList.SelectedIndex;
            if (index == -1)
            {
                math.Text = "";
                biology.Text = "";
                practice.Text = "";
            } else
            {
                math.Text = students[index].mathGrade.ToString();
                setColour(math, math.Text);
                biology.Text = students[index].bioGrade.ToString();
                setColour(biology, biology.Text);
                practice.Text = students[index].practiceGrade.ToString();
                setColour(practice, practice.Text);
            }
        }

        private void removeStudent_Click(object sender, EventArgs e)
        {
            int index = studentsList.SelectedIndex;
            if (index != -1)
            {
                students.RemoveAt(index);
                updateList();
                studentsList.SelectedIndex = -1;
                studentsList_SelectedIndexChanged(sender, e);
                MessageBox.Show("Студент был отчислен", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                MessageBox.Show("Сначала выберите студента", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setColour(Label label, string grade)
        {
            switch (grade)
            {
                case "2":
                    label.BackColor = Color.Red; break;
                case "3":
                    label.BackColor = Color.Orange; break;
                case "4":
                    label.BackColor = Color.Yellow; break;
                case "5":
                    label.BackColor = Color.LawnGreen; break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var res = MessageBox.Show("Действительно ли Вы планируете закрыть программу?", "Закрытие", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (res != DialogResult.Yes)
            {
                e.Cancel = true;
                return;
            }

            var save = MessageBox.Show("Сохранить изменения в файл?", "Сохранение", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (save == DialogResult.Yes)
            {
                string prettyJson = JsonConvert.SerializeObject(students, Formatting.Indented);
                File.WriteAllText(Path.GetFullPath(path), prettyJson);
            }
        }
    }
}
