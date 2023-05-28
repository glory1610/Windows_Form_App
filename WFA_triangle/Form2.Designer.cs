
namespace WFA_triangle
{
    partial class AddForm
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
            this.RBTriangle = new System.Windows.Forms.RadioButton();
            this.RBRightTriangle = new System.Windows.Forms.RadioButton();
            this.labelA = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.TBA = new System.Windows.Forms.TextBox();
            this.TBB = new System.Windows.Forms.TextBox();
            this.TBC = new System.Windows.Forms.TextBox();
            this.labelA_ = new System.Windows.Forms.Label();
            this.TBA_ = new System.Windows.Forms.TextBox();
            this.ADD_btn = new System.Windows.Forms.Button();
            this.labelC = new System.Windows.Forms.Label();
            this.LEAVE_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RBTriangle
            // 
            this.RBTriangle.AutoSize = true;
            this.RBTriangle.BackColor = System.Drawing.Color.DarkOrchid;
            this.RBTriangle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RBTriangle.Location = new System.Drawing.Point(45, 45);
            this.RBTriangle.Name = "RBTriangle";
            this.RBTriangle.Size = new System.Drawing.Size(109, 24);
            this.RBTriangle.TabIndex = 0;
            this.RBTriangle.TabStop = true;
            this.RBTriangle.Text = "Трикутник";
            this.RBTriangle.UseVisualStyleBackColor = false;
            // 
            // RBRightTriangle
            // 
            this.RBRightTriangle.AutoSize = true;
            this.RBRightTriangle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RBRightTriangle.Location = new System.Drawing.Point(45, 165);
            this.RBRightTriangle.Name = "RBRightTriangle";
            this.RBRightTriangle.Size = new System.Drawing.Size(207, 24);
            this.RBRightTriangle.TabIndex = 1;
            this.RBRightTriangle.TabStop = true;
            this.RBRightTriangle.Text = "Правильний трикутник";
            this.RBRightTriangle.UseVisualStyleBackColor = true;
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(41, 96);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(35, 20);
            this.labelA.TabIndex = 2;
            this.labelA.Text = "a  =";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(195, 96);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(35, 20);
            this.labelB.TabIndex = 3;
            this.labelB.Text = "b  =";
            // 
            // TBA
            // 
            this.TBA.Location = new System.Drawing.Point(82, 96);
            this.TBA.Name = "TBA";
            this.TBA.Size = new System.Drawing.Size(72, 26);
            this.TBA.TabIndex = 5;
            // 
            // TBB
            // 
            this.TBB.Location = new System.Drawing.Point(236, 96);
            this.TBB.Name = "TBB";
            this.TBB.Size = new System.Drawing.Size(72, 26);
            this.TBB.TabIndex = 6;
            // 
            // TBC
            // 
            this.TBC.Location = new System.Drawing.Point(381, 96);
            this.TBC.Name = "TBC";
            this.TBC.Size = new System.Drawing.Size(72, 26);
            this.TBC.TabIndex = 7;
            // 
            // labelA_
            // 
            this.labelA_.AutoSize = true;
            this.labelA_.Location = new System.Drawing.Point(41, 213);
            this.labelA_.Name = "labelA_";
            this.labelA_.Size = new System.Drawing.Size(35, 20);
            this.labelA_.TabIndex = 8;
            this.labelA_.Text = "a  =";
            // 
            // TBA_
            // 
            this.TBA_.Location = new System.Drawing.Point(82, 207);
            this.TBA_.Name = "TBA_";
            this.TBA_.Size = new System.Drawing.Size(72, 26);
            this.TBA_.TabIndex = 9;
            // 
            // ADD_btn
            // 
            this.ADD_btn.BackColor = System.Drawing.Color.MediumOrchid;
            this.ADD_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ADD_btn.Location = new System.Drawing.Point(381, 249);
            this.ADD_btn.Name = "ADD_btn";
            this.ADD_btn.Size = new System.Drawing.Size(131, 35);
            this.ADD_btn.TabIndex = 10;
            this.ADD_btn.Text = "Додати";
            this.ADD_btn.UseVisualStyleBackColor = false;
            this.ADD_btn.Click += new System.EventHandler(this.ADD_btn_Click);
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.Location = new System.Drawing.Point(341, 96);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(34, 20);
            this.labelC.TabIndex = 11;
            this.labelC.Text = "c  =";
            // 
            // LEAVE_btn
            // 
            this.LEAVE_btn.BackColor = System.Drawing.Color.MediumOrchid;
            this.LEAVE_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LEAVE_btn.Location = new System.Drawing.Point(236, 249);
            this.LEAVE_btn.Name = "LEAVE_btn";
            this.LEAVE_btn.Size = new System.Drawing.Size(131, 35);
            this.LEAVE_btn.TabIndex = 12;
            this.LEAVE_btn.Text = "Закрити";
            this.LEAVE_btn.UseVisualStyleBackColor = true;
            this.LEAVE_btn.Click += new System.EventHandler(this.LEAVE_btn_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrchid;
            this.ClientSize = new System.Drawing.Size(525, 296);
            this.Controls.Add(this.LEAVE_btn);
            this.Controls.Add(this.labelC);
            this.Controls.Add(this.ADD_btn);
            this.Controls.Add(this.TBA_);
            this.Controls.Add(this.labelA_);
            this.Controls.Add(this.TBC);
            this.Controls.Add(this.TBB);
            this.Controls.Add(this.TBA);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.RBRightTriangle);
            this.Controls.Add(this.RBTriangle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "AddForm";
            this.Text = "Додавання трикутника";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton RBTriangle;
        private System.Windows.Forms.RadioButton RBRightTriangle;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.TextBox TBA;
        private System.Windows.Forms.TextBox TBB;
        private System.Windows.Forms.TextBox TBC;
        private System.Windows.Forms.Label labelA_;
        private System.Windows.Forms.TextBox TBA_;
        private System.Windows.Forms.Button ADD_btn;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.Button LEAVE_btn;
    }
}