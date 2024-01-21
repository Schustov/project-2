using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grades
{
    public partial class Form2 : Form
    {
        public Form2(int num1, int num2, int num3)
        {
            InitializeComponent();
            math_n.Value = num1;
            bio_n.Value = num2;
            practice_n.Value = num3;
            this.AcceptButton = save;
        }

        private void save_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
