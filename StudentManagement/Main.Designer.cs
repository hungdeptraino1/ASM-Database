namespace StudentManagement
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnStuList = new System.Windows.Forms.Button();
            this.btnEnroll = new System.Windows.Forms.Button();
            this.btnClassList = new System.Windows.Forms.Button();
            this.btnCourseList = new System.Windows.Forms.Button();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.lblWelcom = new System.Windows.Forms.Label();
            this.btnDepartmentView_Click = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.OrangeRed;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(903, 593);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(155, 85);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnStuList
            // 
            this.btnStuList.BackColor = System.Drawing.Color.Cyan;
            this.btnStuList.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStuList.Location = new System.Drawing.Point(43, 464);
            this.btnStuList.Name = "btnStuList";
            this.btnStuList.Size = new System.Drawing.Size(175, 86);
            this.btnStuList.TabIndex = 1;
            this.btnStuList.Text = "Student list";
            this.btnStuList.UseVisualStyleBackColor = false;
            this.btnStuList.Click += new System.EventHandler(this.btnStuList_Click);
            // 
            // btnEnroll
            // 
            this.btnEnroll.BackColor = System.Drawing.Color.Yellow;
            this.btnEnroll.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnroll.Location = new System.Drawing.Point(450, 464);
            this.btnEnroll.Name = "btnEnroll";
            this.btnEnroll.Size = new System.Drawing.Size(175, 87);
            this.btnEnroll.TabIndex = 2;
            this.btnEnroll.Text = "Enrollment";
            this.btnEnroll.UseVisualStyleBackColor = false;
            this.btnEnroll.Click += new System.EventHandler(this.btnClassList_Click);
            // 
            // btnClassList
            // 
            this.btnClassList.BackColor = System.Drawing.Color.LightCoral;
            this.btnClassList.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClassList.Location = new System.Drawing.Point(248, 464);
            this.btnClassList.Name = "btnClassList";
            this.btnClassList.Size = new System.Drawing.Size(175, 87);
            this.btnClassList.TabIndex = 3;
            this.btnClassList.Text = "Class list";
            this.btnClassList.UseVisualStyleBackColor = false;
            this.btnClassList.Click += new System.EventHandler(this.btnClassList_Click_1);
            // 
            // btnCourseList
            // 
            this.btnCourseList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnCourseList.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCourseList.Location = new System.Drawing.Point(652, 464);
            this.btnCourseList.Name = "btnCourseList";
            this.btnCourseList.Size = new System.Drawing.Size(175, 87);
            this.btnCourseList.TabIndex = 4;
            this.btnCourseList.Text = "Course list";
            this.btnCourseList.UseVisualStyleBackColor = false;
            this.btnCourseList.Click += new System.EventHandler(this.btnCourseList_Click);
            // 
            // btnSignOut
            // 
            this.btnSignOut.BackColor = System.Drawing.Color.White;
            this.btnSignOut.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignOut.Location = new System.Drawing.Point(807, 644);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(90, 34);
            this.btnSignOut.TabIndex = 5;
            this.btnSignOut.Text = "Sign Out";
            this.btnSignOut.UseVisualStyleBackColor = false;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // lblWelcom
            // 
            this.lblWelcom.AutoSize = true;
            this.lblWelcom.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcom.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcom.Location = new System.Drawing.Point(12, 9);
            this.lblWelcom.Name = "lblWelcom";
            this.lblWelcom.Size = new System.Drawing.Size(373, 25);
            this.lblWelcom.TabIndex = 6;
            this.lblWelcom.Text = "Welcome to Student Management System";
            this.lblWelcom.Click += new System.EventHandler(this.lblHello_Click);
            // 
            // btnDepartmentView_Click
            // 
            this.btnDepartmentView_Click.BackColor = System.Drawing.Color.LawnGreen;
            this.btnDepartmentView_Click.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepartmentView_Click.Location = new System.Drawing.Point(853, 464);
            this.btnDepartmentView_Click.Name = "btnDepartmentView_Click";
            this.btnDepartmentView_Click.Size = new System.Drawing.Size(175, 86);
            this.btnDepartmentView_Click.TabIndex = 7;
            this.btnDepartmentView_Click.Text = "Department";
            this.btnDepartmentView_Click.UseVisualStyleBackColor = false;
            this.btnDepartmentView_Click.Click += new System.EventHandler(this.btnDepartmentView_Click_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Lime;
            this.BackgroundImage = global::StudentManagement.Properties.Resources.e6dac007_1932_4811_8cd7_b3035bbcc35d;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1064, 685);
            this.Controls.Add(this.btnDepartmentView_Click);
            this.Controls.Add(this.lblWelcom);
            this.Controls.Add(this.btnCourseList);
            this.Controls.Add(this.btnClassList);
            this.Controls.Add(this.btnEnroll);
            this.Controls.Add(this.btnStuList);
            this.Controls.Add(this.btnSignOut);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnStuList;
        private System.Windows.Forms.Button btnEnroll;
        private System.Windows.Forms.Button btnClassList;
        private System.Windows.Forms.Button btnCourseList;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Label lblWelcom;
        private System.Windows.Forms.Button btnDepartmentView_Click;
    }
}