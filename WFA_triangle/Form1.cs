using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WFA_triangle
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        private List<Triangle> triangles = new List<Triangle>();
        public MainForm()
        {
            InitializeComponent();
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Download_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                try
                {
                    string[] lines = File.ReadAllLines(filePath);

                    foreach (string line in lines)
                    {
                        string[] triangleSides = line.Split(';');
                        if (triangleSides.Length == 3)
                        {
                            double a, b, c;
                            if (double.TryParse(triangleSides[0], out a) && double.TryParse(triangleSides[1], out b) && double.TryParse(triangleSides[2], out c))
                            {
                                Triangle t;
                                if (a == b && b == c)
                                {
                                    t = new RightTriangle(a);
                                    triangles.Add(t);
                                    LBTriangles.Items.Add(String.Format("a = {0} cm", a) + Environment.NewLine);
                                }
                                else
                                {
                                    t = new Triangle(a, b, c);
                                    triangles.Add(t);
                                    LBTriangles.Items.Add(String.Format("a = {0} cm,  b = {1} cm,  c = {2} cm", a, b, c) + Environment.NewLine);
                                }
                            }
                        }
                    }
                }
                catch (IOException)
                {
                    MessageBox.Show("Помилка читання файлу.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Perimeter_btn_Click(object sender, EventArgs e)
        {
            TBPerimeter.Clear();
            int selectedIndex = LBTriangles.SelectedIndex;
            if (selectedIndex >= 0 && selectedIndex < triangles.Count)
            {
                Triangle selectedTriangle = triangles[selectedIndex];
                double perimeter = selectedTriangle.Perimeter();
                TBPerimeter.AppendText(String.Format("P = {0} cm", perimeter));
            }
        }

        private void Area_btn_Click(object sender, EventArgs e)
        {
            TBArea.Clear();
            int selectedIndex = LBTriangles.SelectedIndex;
            if (selectedIndex >= 0 && selectedIndex < triangles.Count)
            {
                Triangle selectedTriangle = triangles[selectedIndex];
                double perimeter = selectedTriangle.Area();
                TBArea.AppendText(String.Format("S = {0} cm²", perimeter));
            }
        }

        private void Circumscribed_btn_Click(object sender, EventArgs e)
        {
            TBCircumscribed.Clear();
            int selectedIndex = LBTriangles.SelectedIndex;
            if (selectedIndex >= 0 && selectedIndex < triangles.Count)
            {
                Triangle selectedTriangle = triangles[selectedIndex];
                if (selectedTriangle is RightTriangle)
                {
                    RightTriangle rightTriangle = selectedTriangle as RightTriangle;
                    double circumscribedRadius = rightTriangle.RadiusOfCircumscribedCircle();
                    TBCircumscribed.AppendText(String.Format("R = {0} cm", circumscribedRadius));
                }
                else 
                {
                    MessageBox.Show("Вибраний трикутник повинен бути правильним.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void Inscribed_btn_Click(object sender, EventArgs e)
        {
            TBInscribed.Clear();
            int selectedIndex = LBTriangles.SelectedIndex;
            if (selectedIndex >= 0 && selectedIndex < triangles.Count)
            {
                Triangle selectedTriangle = triangles[selectedIndex];
                if (selectedTriangle is RightTriangle)
                {
                    RightTriangle rightTriangle = selectedTriangle as RightTriangle;
                    double inscribedRadius = rightTriangle.RadiusOfInscribedCircle();
                    TBInscribed.AppendText(String.Format("r = {0} cm", inscribedRadius));
                }
                else
                {
                    MessageBox.Show("Вибраний трикутник повинен бути правильним.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                try
                {
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        foreach (Triangle triangle in triangles)
                        {
                            writer.WriteLine($"{triangle.A};{triangle.B};{triangle.C}");
                        }
                    }

                    MessageBox.Show("Файл успішно збережено.", "Збереження файлу", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (IOException)
                {
                    MessageBox.Show("Помилка збереження.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            AddForm triangleForm = new AddForm();
            if (triangleForm.ShowDialog() == DialogResult.OK)
            {
                if (triangleForm.IsSimpleTriangle)
                {
                    double a = triangleForm.SideA;
                    double b = triangleForm.SideB;
                    double c = triangleForm.SideC;

                    try
                    {
                        Triangle triangle = new Triangle(a, b, c);
                        triangles.Add(triangle);
                        LBTriangles.Items.Add(String.Format("a = {0} cm,  b = {1} cm,  c = {2} cm", a, b, c) + Environment.NewLine);
                    }
                    catch (ArgumentException ex)
                    {
                        MessageBox.Show(ex.Message, "Неправильний трикутник", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else if (triangleForm.IsRightTriangle)
                {
                    double a = triangleForm.Side;

                    try
                    {
                        RightTriangle rightTriangle = new RightTriangle(a);
                        triangles.Add(rightTriangle);
                        LBTriangles.Items.Add(String.Format("a = {0} cm", a) + Environment.NewLine);
                    }
                    catch (ArgumentException ex)
                    {
                        MessageBox.Show(ex.Message, "Неправильний трикутник", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void Remove_btn_Click(object sender, EventArgs e)
        {
            int selectedIndex = LBTriangles.SelectedIndex;
            if (selectedIndex >= 0 && selectedIndex < triangles.Count)
            {
                triangles.RemoveAt(selectedIndex);
                LBTriangles.Items.RemoveAt(selectedIndex);
            }
        }
    }
}
