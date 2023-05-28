
namespace WFA_triangle
{
    partial class MainForm
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
            this.Delete_btn = new System.Windows.Forms.Button();
            this.Download_btn = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.Perimeter_btn = new System.Windows.Forms.Button();
            this.TBPerimeter = new System.Windows.Forms.TextBox();
            this.Area_btn = new System.Windows.Forms.Button();
            this.Circumscribed_btn = new System.Windows.Forms.Button();
            this.Inscribed_btn = new System.Windows.Forms.Button();
            this.TBArea = new System.Windows.Forms.TextBox();
            this.TBCircumscribed = new System.Windows.Forms.TextBox();
            this.TBInscribed = new System.Windows.Forms.TextBox();
            this.Save_btn = new System.Windows.Forms.Button();
            this.Add_btn = new System.Windows.Forms.Button();
            this.Remove_btn = new System.Windows.Forms.Button();
            this.LBTriangles = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Delete_btn
            // 
            this.Delete_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Delete_btn.BackColor = System.Drawing.Color.MediumOrchid;
            this.Delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Delete_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Delete_btn.Location = new System.Drawing.Point(848, 505);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(173, 41);
            this.Delete_btn.TabIndex = 1;
            this.Delete_btn.Text = "Завершити";
            this.Delete_btn.UseVisualStyleBackColor = false;
            this.Delete_btn.Click += new System.EventHandler(this.Delete_btn_Click);
            // 
            // Download_btn
            // 
            this.Download_btn.BackColor = System.Drawing.Color.MediumOrchid;
            this.Download_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Download_btn.Location = new System.Drawing.Point(558, 420);
            this.Download_btn.Name = "Download_btn";
            this.Download_btn.Size = new System.Drawing.Size(173, 41);
            this.Download_btn.TabIndex = 2;
            this.Download_btn.Text = "Завантажити";
            this.Download_btn.UseVisualStyleBackColor = false;
            this.Download_btn.Click += new System.EventHandler(this.Download_btn_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // Perimeter_btn
            // 
            this.Perimeter_btn.BackColor = System.Drawing.Color.MediumOrchid;
            this.Perimeter_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Perimeter_btn.Location = new System.Drawing.Point(494, 43);
            this.Perimeter_btn.Name = "Perimeter_btn";
            this.Perimeter_btn.Size = new System.Drawing.Size(155, 35);
            this.Perimeter_btn.TabIndex = 3;
            this.Perimeter_btn.Text = "Периметер";
            this.Perimeter_btn.UseVisualStyleBackColor = false;
            this.Perimeter_btn.Click += new System.EventHandler(this.Perimeter_btn_Click);
            // 
            // TBPerimeter
            // 
            this.TBPerimeter.Location = new System.Drawing.Point(679, 43);
            this.TBPerimeter.Multiline = true;
            this.TBPerimeter.Name = "TBPerimeter";
            this.TBPerimeter.Size = new System.Drawing.Size(317, 34);
            this.TBPerimeter.TabIndex = 4;
            // 
            // Area_btn
            // 
            this.Area_btn.BackColor = System.Drawing.Color.MediumOrchid;
            this.Area_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Area_btn.Location = new System.Drawing.Point(494, 105);
            this.Area_btn.Name = "Area_btn";
            this.Area_btn.Size = new System.Drawing.Size(155, 35);
            this.Area_btn.TabIndex = 5;
            this.Area_btn.Text = "Площа";
            this.Area_btn.UseVisualStyleBackColor = false;
            this.Area_btn.Click += new System.EventHandler(this.Area_btn_Click);
            // 
            // Circumscribed_btn
            // 
            this.Circumscribed_btn.BackColor = System.Drawing.Color.MediumOrchid;
            this.Circumscribed_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Circumscribed_btn.Location = new System.Drawing.Point(494, 158);
            this.Circumscribed_btn.Name = "Circumscribed_btn";
            this.Circumscribed_btn.Size = new System.Drawing.Size(155, 52);
            this.Circumscribed_btn.TabIndex = 6;
            this.Circumscribed_btn.Text = "Радіус описаного кола";
            this.Circumscribed_btn.UseVisualStyleBackColor = false;
            this.Circumscribed_btn.Click += new System.EventHandler(this.Circumscribed_btn_Click);
            // 
            // Inscribed_btn
            // 
            this.Inscribed_btn.BackColor = System.Drawing.Color.MediumOrchid;
            this.Inscribed_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Inscribed_btn.Location = new System.Drawing.Point(494, 229);
            this.Inscribed_btn.Name = "Inscribed_btn";
            this.Inscribed_btn.Size = new System.Drawing.Size(155, 49);
            this.Inscribed_btn.TabIndex = 7;
            this.Inscribed_btn.Text = "Радіус вписаного кола";
            this.Inscribed_btn.UseVisualStyleBackColor = false;
            this.Inscribed_btn.Click += new System.EventHandler(this.Inscribed_btn_Click);
            // 
            // TBArea
            // 
            this.TBArea.Location = new System.Drawing.Point(679, 105);
            this.TBArea.Multiline = true;
            this.TBArea.Name = "TBArea";
            this.TBArea.Size = new System.Drawing.Size(317, 34);
            this.TBArea.TabIndex = 8;
            // 
            // TBCircumscribed
            // 
            this.TBCircumscribed.Location = new System.Drawing.Point(679, 158);
            this.TBCircumscribed.Multiline = true;
            this.TBCircumscribed.Name = "TBCircumscribed";
            this.TBCircumscribed.Size = new System.Drawing.Size(317, 52);
            this.TBCircumscribed.TabIndex = 9;
            // 
            // TBInscribed
            // 
            this.TBInscribed.Location = new System.Drawing.Point(679, 229);
            this.TBInscribed.Multiline = true;
            this.TBInscribed.Name = "TBInscribed";
            this.TBInscribed.Size = new System.Drawing.Size(317, 49);
            this.TBInscribed.TabIndex = 10;
            // 
            // Save_btn
            // 
            this.Save_btn.BackColor = System.Drawing.Color.MediumOrchid;
            this.Save_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Save_btn.Location = new System.Drawing.Point(558, 357);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(173, 41);
            this.Save_btn.TabIndex = 11;
            this.Save_btn.Text = "Зберегти";
            this.Save_btn.UseVisualStyleBackColor = false;
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // Add_btn
            // 
            this.Add_btn.BackColor = System.Drawing.Color.MediumOrchid;
            this.Add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Add_btn.Location = new System.Drawing.Point(777, 357);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(173, 41);
            this.Add_btn.TabIndex = 12;
            this.Add_btn.Text = "Додати";
            this.Add_btn.UseVisualStyleBackColor = false;
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // Remove_btn
            // 
            this.Remove_btn.BackColor = System.Drawing.Color.MediumOrchid;
            this.Remove_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Remove_btn.Location = new System.Drawing.Point(777, 420);
            this.Remove_btn.Name = "Remove_btn";
            this.Remove_btn.Size = new System.Drawing.Size(173, 41);
            this.Remove_btn.TabIndex = 13;
            this.Remove_btn.Text = "Вилучити";
            this.Remove_btn.UseVisualStyleBackColor = false;
            this.Remove_btn.Click += new System.EventHandler(this.Remove_btn_Click);
            // 
            // LBTriangles
            // 
            this.LBTriangles.FormattingEnabled = true;
            this.LBTriangles.ItemHeight = 20;
            this.LBTriangles.Location = new System.Drawing.Point(22, 18);
            this.LBTriangles.Name = "LBTriangles";
            this.LBTriangles.Size = new System.Drawing.Size(443, 524);
            this.LBTriangles.TabIndex = 14;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrchid;
            this.ClientSize = new System.Drawing.Size(1033, 558);
            this.Controls.Add(this.LBTriangles);
            this.Controls.Add(this.Remove_btn);
            this.Controls.Add(this.Add_btn);
            this.Controls.Add(this.Save_btn);
            this.Controls.Add(this.TBInscribed);
            this.Controls.Add(this.TBCircumscribed);
            this.Controls.Add(this.TBArea);
            this.Controls.Add(this.Inscribed_btn);
            this.Controls.Add(this.Circumscribed_btn);
            this.Controls.Add(this.Area_btn);
            this.Controls.Add(this.TBPerimeter);
            this.Controls.Add(this.Perimeter_btn);
            this.Controls.Add(this.Download_btn);
            this.Controls.Add(this.Delete_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Програма трикутник";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Delete_btn;
        private System.Windows.Forms.Button Download_btn;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button Perimeter_btn;
        private System.Windows.Forms.TextBox TBPerimeter;
        private System.Windows.Forms.Button Area_btn;
        private System.Windows.Forms.Button Circumscribed_btn;
        private System.Windows.Forms.Button Inscribed_btn;
        private System.Windows.Forms.TextBox TBArea;
        private System.Windows.Forms.TextBox TBCircumscribed;
        private System.Windows.Forms.TextBox TBInscribed;
        private System.Windows.Forms.Button Save_btn;
        private System.Windows.Forms.Button Add_btn;
        private System.Windows.Forms.Button Remove_btn;
        private System.Windows.Forms.ListBox LBTriangles;
    }
}

