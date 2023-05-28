using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_triangle
{
    public partial class AddForm : System.Windows.Forms.Form
    {
        public bool IsSimpleTriangle { get; private set; }
        public bool IsRightTriangle { get; private set; }

        public double SideA { get; private set; }
        public double SideB { get; private set; }
        public double SideC { get; private set; }
        public double Side { get; private set; }

        public AddForm()
        {
            InitializeComponent();
        }

        private void LEAVE_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ADD_btn_Click(object sender, EventArgs e)
        {
            if (RBTriangle.Checked)
            {
                if (ValidateSideLengths())
                {
                    IsSimpleTriangle = true;
                    IsRightTriangle = false;

                    SideA = double.Parse(TBA.Text);
                    SideB = double.Parse(TBB.Text);
                    SideC = double.Parse(TBC.Text);

                    DialogResult = DialogResult.OK;
                }
            }
            else if (RBRightTriangle.Checked)
            {
                if (ValidateSideLength())
                {
                    IsSimpleTriangle = false;
                    IsRightTriangle = true;

                    Side = double.Parse(TBA_.Text);

                    DialogResult = DialogResult.OK;
                }
            }
        }
        private void RBTriangle_CheckedChanged(object sender, EventArgs e)
        {
            if (RBTriangle.Checked)
            {
                TBA.Enabled = true;
                TBB.Enabled = true;
                TBC.Enabled = true;

                TBA_.Enabled = false;
            }
        }
        private void RBRightTriangle_CheckedChanged(object sender, EventArgs e)
        {
            if (RBRightTriangle.Checked)
            {
                TBA_.Enabled = true;

                TBA.Enabled = false;
                TBB.Enabled = false;
                TBC.Enabled = false;
            }
        }
        private bool ValidateSideLengths()
        {
            if (!double.TryParse(TBA.Text, out double sideA) ||
                !double.TryParse(TBB.Text, out double sideB) ||
                !double.TryParse(TBC.Text, out double sideC))
            {
                MessageBox.Show("Неправильно введені сторони. Будь ласка, введіть дійсні числа.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                MessageBox.Show("Сторони повинні бути більші за нуль.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
            {
                MessageBox.Show("Неправильно введені сторони. Сума двох будь-яких сторін повина бути більша за третю.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private bool ValidateSideLength()
        {
            if (!double.TryParse(TBA_.Text, out double side))
            {
                MessageBox.Show("Неправильно введена сторона. Будь ласка, введіть дійсне число.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (side <= 0)
            {
                MessageBox.Show("Сторона повинна бути більша за нуль.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
        