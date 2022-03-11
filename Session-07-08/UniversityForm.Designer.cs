namespace EpsilonNet.CodingSchool2022.Session_07_08
{
    partial class UniversityForm
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
            System.Windows.Forms.GroupBox gbProfessorInfo;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Panel panel1;
            System.Windows.Forms.Button btnCommit;
            System.Windows.Forms.GroupBox gbStudentInfo;
            System.Windows.Forms.GroupBox gbGradeInfo;
            System.Windows.Forms.GroupBox gbCourseInfo;
            System.Windows.Forms.GroupBox gbSchedule;
            this.clbProfessorCourses = new System.Windows.Forms.CheckedListBox();
            this.tbProfRank = new System.Windows.Forms.TextBox();
            this.tbProfAge = new System.Windows.Forms.NumericUpDown();
            this.tbProfName = new System.Windows.Forms.TextBox();
            this.cbCommitOnClose = new System.Windows.Forms.CheckBox();
            this.btnRevert = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpProfessors = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnNewProfessor = new System.Windows.Forms.Button();
            this.btnDeleteProfessor = new System.Windows.Forms.Button();
            this.lbProfessors = new System.Windows.Forms.ListBox();
            this.tpStudents = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnNewStudent = new System.Windows.Forms.Button();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.lbStudents = new System.Windows.Forms.ListBox();
            this.tpGrade = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnNewGrade = new System.Windows.Forms.Button();
            this.btnDeleteGrade = new System.Windows.Forms.Button();
            this.lbGrades = new System.Windows.Forms.ListBox();
            this.tpCourse = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnNewCourse = new System.Windows.Forms.Button();
            this.btnDeleteCourse = new System.Windows.Forms.Button();
            this.lbCourses = new System.Windows.Forms.ListBox();
            this.tpSchedule = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnNewChedule = new System.Windows.Forms.Button();
            this.btnDeleteSchedule = new System.Windows.Forms.Button();
            this.lbSchedule = new System.Windows.Forms.ListBox();
            this.tpUniversity = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nudUniversityYearsInService = new System.Windows.Forms.NumericUpDown();
            this.tbUniversityName = new System.Windows.Forms.TextBox();
            gbProfessorInfo = new System.Windows.Forms.GroupBox();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            btnCommit = new System.Windows.Forms.Button();
            gbStudentInfo = new System.Windows.Forms.GroupBox();
            gbGradeInfo = new System.Windows.Forms.GroupBox();
            gbCourseInfo = new System.Windows.Forms.GroupBox();
            gbSchedule = new System.Windows.Forms.GroupBox();
            gbProfessorInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbProfAge)).BeginInit();
            panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpProfessors.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tpStudents.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tpGrade.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tpCourse.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tpSchedule.SuspendLayout();
            this.panel6.SuspendLayout();
            this.tpUniversity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUniversityYearsInService)).BeginInit();
            this.SuspendLayout();
            // 
            // gbProfessorInfo
            // 
            gbProfessorInfo.Controls.Add(label4);
            gbProfessorInfo.Controls.Add(this.clbProfessorCourses);
            gbProfessorInfo.Controls.Add(this.tbProfRank);
            gbProfessorInfo.Controls.Add(this.tbProfAge);
            gbProfessorInfo.Controls.Add(this.tbProfName);
            gbProfessorInfo.Controls.Add(label3);
            gbProfessorInfo.Controls.Add(label2);
            gbProfessorInfo.Controls.Add(label1);
            gbProfessorInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            gbProfessorInfo.Location = new System.Drawing.Point(192, 3);
            gbProfessorInfo.Name = "gbProfessorInfo";
            gbProfessorInfo.Size = new System.Drawing.Size(625, 293);
            gbProfessorInfo.TabIndex = 1;
            gbProfessorInfo.TabStop = false;
            gbProfessorInfo.Text = "Professor Info";
            // 
            // label4
            // 
            label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            label4.Location = new System.Drawing.Point(350, 58);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(80, 24);
            label4.TabIndex = 7;
            label4.Text = "Courses";
            // 
            // clbProfessorCourses
            // 
            this.clbProfessorCourses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clbProfessorCourses.FormattingEnabled = true;
            this.clbProfessorCourses.Location = new System.Drawing.Point(436, 59);
            this.clbProfessorCourses.MultiColumn = true;
            this.clbProfessorCourses.Name = "clbProfessorCourses";
            this.clbProfessorCourses.Size = new System.Drawing.Size(169, 199);
            this.clbProfessorCourses.TabIndex = 6;
            // 
            // tbProfRank
            // 
            this.tbProfRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.tbProfRank.Location = new System.Drawing.Point(105, 150);
            this.tbProfRank.Name = "tbProfRank";
            this.tbProfRank.Size = new System.Drawing.Size(134, 26);
            this.tbProfRank.TabIndex = 5;
            // 
            // tbProfAge
            // 
            this.tbProfAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.tbProfAge.Location = new System.Drawing.Point(105, 104);
            this.tbProfAge.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.tbProfAge.Name = "tbProfAge";
            this.tbProfAge.Size = new System.Drawing.Size(74, 26);
            this.tbProfAge.TabIndex = 4;
            this.tbProfAge.Value = new decimal(new int[] {
            59,
            0,
            0,
            0});
            // 
            // tbProfName
            // 
            this.tbProfName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.tbProfName.Location = new System.Drawing.Point(105, 58);
            this.tbProfName.Name = "tbProfName";
            this.tbProfName.Size = new System.Drawing.Size(161, 26);
            this.tbProfName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            label3.Location = new System.Drawing.Point(26, 152);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(53, 24);
            label3.TabIndex = 2;
            label3.Text = "Rank";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            label2.Location = new System.Drawing.Point(26, 106);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(45, 24);
            label2.TabIndex = 1;
            label2.Text = "Age";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            label1.Location = new System.Drawing.Point(26, 60);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(61, 24);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // panel1
            // 
            panel1.Controls.Add(this.cbCommitOnClose);
            panel1.Controls.Add(this.btnRevert);
            panel1.Controls.Add(btnCommit);
            panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel1.Location = new System.Drawing.Point(0, 387);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(828, 78);
            panel1.TabIndex = 8;
            // 
            // cbCommitOnClose
            // 
            this.cbCommitOnClose.AutoSize = true;
            this.cbCommitOnClose.Checked = true;
            this.cbCommitOnClose.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbCommitOnClose.Location = new System.Drawing.Point(527, 40);
            this.cbCommitOnClose.Name = "cbCommitOnClose";
            this.cbCommitOnClose.Size = new System.Drawing.Size(138, 17);
            this.cbCommitOnClose.TabIndex = 2;
            this.cbCommitOnClose.Text = "Save changes on close";
            this.cbCommitOnClose.UseVisualStyleBackColor = true;
            // 
            // btnRevert
            // 
            this.btnRevert.Location = new System.Drawing.Point(699, 29);
            this.btnRevert.Name = "btnRevert";
            this.btnRevert.Size = new System.Drawing.Size(102, 37);
            this.btnRevert.TabIndex = 1;
            this.btnRevert.Text = "Revert changes";
            this.btnRevert.UseVisualStyleBackColor = true;
            this.btnRevert.Click += new System.EventHandler(this.btnRevert_Click);
            // 
            // btnCommit
            // 
            btnCommit.Location = new System.Drawing.Point(379, 29);
            btnCommit.Name = "btnCommit";
            btnCommit.Size = new System.Drawing.Size(114, 37);
            btnCommit.TabIndex = 0;
            btnCommit.Text = "Save changes";
            btnCommit.UseVisualStyleBackColor = true;
            btnCommit.Click += new System.EventHandler(this.btnCommit_Click);
            // 
            // gbStudentInfo
            // 
            gbStudentInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            gbStudentInfo.Location = new System.Drawing.Point(192, 3);
            gbStudentInfo.Name = "gbStudentInfo";
            gbStudentInfo.Size = new System.Drawing.Size(625, 293);
            gbStudentInfo.TabIndex = 1;
            gbStudentInfo.TabStop = false;
            gbStudentInfo.Text = "Student Info";
            // 
            // gbGradeInfo
            // 
            gbGradeInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            gbGradeInfo.Location = new System.Drawing.Point(192, 3);
            gbGradeInfo.Name = "gbGradeInfo";
            gbGradeInfo.Size = new System.Drawing.Size(625, 293);
            gbGradeInfo.TabIndex = 3;
            gbGradeInfo.TabStop = false;
            gbGradeInfo.Text = "Grade Info";
            // 
            // gbCourseInfo
            // 
            gbCourseInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            gbCourseInfo.Location = new System.Drawing.Point(192, 3);
            gbCourseInfo.Name = "gbCourseInfo";
            gbCourseInfo.Size = new System.Drawing.Size(625, 293);
            gbCourseInfo.TabIndex = 11;
            gbCourseInfo.TabStop = false;
            gbCourseInfo.Text = "Course Info";
            // 
            // gbSchedule
            // 
            gbSchedule.Dock = System.Windows.Forms.DockStyle.Fill;
            gbSchedule.Location = new System.Drawing.Point(192, 3);
            gbSchedule.Name = "gbSchedule";
            gbSchedule.Size = new System.Drawing.Size(625, 293);
            gbSchedule.TabIndex = 14;
            gbSchedule.TabStop = false;
            gbSchedule.Text = "Schedule Info";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpProfessors);
            this.tabControl1.Controls.Add(this.tpStudents);
            this.tabControl1.Controls.Add(this.tpGrade);
            this.tabControl1.Controls.Add(this.tpCourse);
            this.tabControl1.Controls.Add(this.tpSchedule);
            this.tabControl1.Controls.Add(this.tpUniversity);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(828, 387);
            this.tabControl1.TabIndex = 0;
            // 
            // tpProfessors
            // 
            this.tpProfessors.Controls.Add(gbProfessorInfo);
            this.tpProfessors.Controls.Add(this.panel2);
            this.tpProfessors.Controls.Add(this.lbProfessors);
            this.tpProfessors.Location = new System.Drawing.Point(4, 22);
            this.tpProfessors.Name = "tpProfessors";
            this.tpProfessors.Padding = new System.Windows.Forms.Padding(3);
            this.tpProfessors.Size = new System.Drawing.Size(820, 361);
            this.tpProfessors.TabIndex = 0;
            this.tpProfessors.Text = "Professors";
            this.tpProfessors.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnNewProfessor);
            this.panel2.Controls.Add(this.btnDeleteProfessor);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(192, 296);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(625, 62);
            this.panel2.TabIndex = 8;
            // 
            // btnNewProfessor
            // 
            this.btnNewProfessor.Location = new System.Drawing.Point(394, 18);
            this.btnNewProfessor.Name = "btnNewProfessor";
            this.btnNewProfessor.Size = new System.Drawing.Size(75, 23);
            this.btnNewProfessor.TabIndex = 6;
            this.btnNewProfessor.Text = "New";
            this.btnNewProfessor.UseVisualStyleBackColor = true;
            this.btnNewProfessor.Click += new System.EventHandler(this.btnNewProfessor_Click);
            // 
            // btnDeleteProfessor
            // 
            this.btnDeleteProfessor.Location = new System.Drawing.Point(530, 18);
            this.btnDeleteProfessor.Name = "btnDeleteProfessor";
            this.btnDeleteProfessor.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteProfessor.TabIndex = 7;
            this.btnDeleteProfessor.Text = "Delete";
            this.btnDeleteProfessor.UseVisualStyleBackColor = true;
            // 
            // lbProfessors
            // 
            this.lbProfessors.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbProfessors.Location = new System.Drawing.Point(3, 3);
            this.lbProfessors.Name = "lbProfessors";
            this.lbProfessors.Size = new System.Drawing.Size(189, 355);
            this.lbProfessors.TabIndex = 0;
            // 
            // tpStudents
            // 
            this.tpStudents.Controls.Add(gbStudentInfo);
            this.tpStudents.Controls.Add(this.panel3);
            this.tpStudents.Controls.Add(this.lbStudents);
            this.tpStudents.Location = new System.Drawing.Point(4, 22);
            this.tpStudents.Name = "tpStudents";
            this.tpStudents.Padding = new System.Windows.Forms.Padding(3);
            this.tpStudents.Size = new System.Drawing.Size(820, 361);
            this.tpStudents.TabIndex = 1;
            this.tpStudents.Text = "Students";
            this.tpStudents.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnNewStudent);
            this.panel3.Controls.Add(this.btnDeleteStudent);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(192, 296);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(625, 62);
            this.panel3.TabIndex = 9;
            // 
            // btnNewStudent
            // 
            this.btnNewStudent.Location = new System.Drawing.Point(394, 18);
            this.btnNewStudent.Name = "btnNewStudent";
            this.btnNewStudent.Size = new System.Drawing.Size(75, 23);
            this.btnNewStudent.TabIndex = 6;
            this.btnNewStudent.Text = "New";
            this.btnNewStudent.UseVisualStyleBackColor = true;
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.Location = new System.Drawing.Point(530, 18);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteStudent.TabIndex = 7;
            this.btnDeleteStudent.Text = "Delete";
            this.btnDeleteStudent.UseVisualStyleBackColor = true;
            // 
            // lbStudents
            // 
            this.lbStudents.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbStudents.FormattingEnabled = true;
            this.lbStudents.Location = new System.Drawing.Point(3, 3);
            this.lbStudents.Name = "lbStudents";
            this.lbStudents.Size = new System.Drawing.Size(189, 355);
            this.lbStudents.TabIndex = 0;
            // 
            // tpGrade
            // 
            this.tpGrade.Controls.Add(gbGradeInfo);
            this.tpGrade.Controls.Add(this.panel4);
            this.tpGrade.Controls.Add(this.lbGrades);
            this.tpGrade.Location = new System.Drawing.Point(4, 22);
            this.tpGrade.Name = "tpGrade";
            this.tpGrade.Padding = new System.Windows.Forms.Padding(3);
            this.tpGrade.Size = new System.Drawing.Size(820, 361);
            this.tpGrade.TabIndex = 2;
            this.tpGrade.Text = "Grades";
            this.tpGrade.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnNewGrade);
            this.panel4.Controls.Add(this.btnDeleteGrade);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(192, 296);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(625, 62);
            this.panel4.TabIndex = 9;
            // 
            // btnNewGrade
            // 
            this.btnNewGrade.Location = new System.Drawing.Point(394, 18);
            this.btnNewGrade.Name = "btnNewGrade";
            this.btnNewGrade.Size = new System.Drawing.Size(75, 23);
            this.btnNewGrade.TabIndex = 6;
            this.btnNewGrade.Text = "New";
            this.btnNewGrade.UseVisualStyleBackColor = true;
            // 
            // btnDeleteGrade
            // 
            this.btnDeleteGrade.Location = new System.Drawing.Point(530, 18);
            this.btnDeleteGrade.Name = "btnDeleteGrade";
            this.btnDeleteGrade.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteGrade.TabIndex = 7;
            this.btnDeleteGrade.Text = "Delete";
            this.btnDeleteGrade.UseVisualStyleBackColor = true;
            // 
            // lbGrades
            // 
            this.lbGrades.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbGrades.FormattingEnabled = true;
            this.lbGrades.Location = new System.Drawing.Point(3, 3);
            this.lbGrades.Name = "lbGrades";
            this.lbGrades.Size = new System.Drawing.Size(189, 355);
            this.lbGrades.TabIndex = 2;
            // 
            // tpCourse
            // 
            this.tpCourse.Controls.Add(gbCourseInfo);
            this.tpCourse.Controls.Add(this.panel5);
            this.tpCourse.Controls.Add(this.lbCourses);
            this.tpCourse.Location = new System.Drawing.Point(4, 22);
            this.tpCourse.Name = "tpCourse";
            this.tpCourse.Padding = new System.Windows.Forms.Padding(3);
            this.tpCourse.Size = new System.Drawing.Size(820, 361);
            this.tpCourse.TabIndex = 3;
            this.tpCourse.Text = "Courses";
            this.tpCourse.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnNewCourse);
            this.panel5.Controls.Add(this.btnDeleteCourse);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(192, 296);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(625, 62);
            this.panel5.TabIndex = 12;
            // 
            // btnNewCourse
            // 
            this.btnNewCourse.Location = new System.Drawing.Point(394, 18);
            this.btnNewCourse.Name = "btnNewCourse";
            this.btnNewCourse.Size = new System.Drawing.Size(75, 23);
            this.btnNewCourse.TabIndex = 6;
            this.btnNewCourse.Text = "New";
            this.btnNewCourse.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCourse
            // 
            this.btnDeleteCourse.Location = new System.Drawing.Point(530, 18);
            this.btnDeleteCourse.Name = "btnDeleteCourse";
            this.btnDeleteCourse.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteCourse.TabIndex = 7;
            this.btnDeleteCourse.Text = "Delete";
            this.btnDeleteCourse.UseVisualStyleBackColor = true;
            // 
            // lbCourses
            // 
            this.lbCourses.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbCourses.FormattingEnabled = true;
            this.lbCourses.Location = new System.Drawing.Point(3, 3);
            this.lbCourses.Name = "lbCourses";
            this.lbCourses.Size = new System.Drawing.Size(189, 355);
            this.lbCourses.TabIndex = 10;
            // 
            // tpSchedule
            // 
            this.tpSchedule.Controls.Add(gbSchedule);
            this.tpSchedule.Controls.Add(this.panel6);
            this.tpSchedule.Controls.Add(this.lbSchedule);
            this.tpSchedule.Location = new System.Drawing.Point(4, 22);
            this.tpSchedule.Name = "tpSchedule";
            this.tpSchedule.Padding = new System.Windows.Forms.Padding(3);
            this.tpSchedule.Size = new System.Drawing.Size(820, 361);
            this.tpSchedule.TabIndex = 4;
            this.tpSchedule.Text = "Schedule";
            this.tpSchedule.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnNewChedule);
            this.panel6.Controls.Add(this.btnDeleteSchedule);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(192, 296);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(625, 62);
            this.panel6.TabIndex = 15;
            // 
            // btnNewChedule
            // 
            this.btnNewChedule.Location = new System.Drawing.Point(394, 18);
            this.btnNewChedule.Name = "btnNewChedule";
            this.btnNewChedule.Size = new System.Drawing.Size(75, 23);
            this.btnNewChedule.TabIndex = 6;
            this.btnNewChedule.Text = "New";
            this.btnNewChedule.UseVisualStyleBackColor = true;
            // 
            // btnDeleteSchedule
            // 
            this.btnDeleteSchedule.Location = new System.Drawing.Point(530, 18);
            this.btnDeleteSchedule.Name = "btnDeleteSchedule";
            this.btnDeleteSchedule.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteSchedule.TabIndex = 7;
            this.btnDeleteSchedule.Text = "Delete";
            this.btnDeleteSchedule.UseVisualStyleBackColor = true;
            // 
            // lbSchedule
            // 
            this.lbSchedule.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbSchedule.FormattingEnabled = true;
            this.lbSchedule.Location = new System.Drawing.Point(3, 3);
            this.lbSchedule.Name = "lbSchedule";
            this.lbSchedule.Size = new System.Drawing.Size(189, 355);
            this.lbSchedule.TabIndex = 13;
            // 
            // tpUniversity
            // 
            this.tpUniversity.Controls.Add(this.tbUniversityName);
            this.tpUniversity.Controls.Add(this.nudUniversityYearsInService);
            this.tpUniversity.Controls.Add(this.label6);
            this.tpUniversity.Controls.Add(this.label5);
            this.tpUniversity.Location = new System.Drawing.Point(4, 22);
            this.tpUniversity.Name = "tpUniversity";
            this.tpUniversity.Padding = new System.Windows.Forms.Padding(3);
            this.tpUniversity.Size = new System.Drawing.Size(820, 361);
            this.tpUniversity.TabIndex = 5;
            this.tpUniversity.Text = "University";
            this.tpUniversity.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label5.Location = new System.Drawing.Point(129, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label6.Location = new System.Drawing.Point(129, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "Years in Service";
            // 
            // nudUniversityYearsInService
            // 
            this.nudUniversityYearsInService.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.nudUniversityYearsInService.Location = new System.Drawing.Point(330, 155);
            this.nudUniversityYearsInService.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudUniversityYearsInService.Name = "nudUniversityYearsInService";
            this.nudUniversityYearsInService.Size = new System.Drawing.Size(90, 29);
            this.nudUniversityYearsInService.TabIndex = 2;
            // 
            // tbUniversityName
            // 
            this.tbUniversityName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUniversityName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.tbUniversityName.Location = new System.Drawing.Point(330, 82);
            this.tbUniversityName.Name = "tbUniversityName";
            this.tbUniversityName.Size = new System.Drawing.Size(188, 29);
            this.tbUniversityName.TabIndex = 3;
            // 
            // UniversityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 465);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "UniversityForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Theodore\'s University";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UniversityForm_FormClosed);
            this.Load += new System.EventHandler(this.UniversityForm_Load);
            gbProfessorInfo.ResumeLayout(false);
            gbProfessorInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbProfAge)).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tpProfessors.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tpStudents.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tpGrade.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.tpCourse.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.tpSchedule.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.tpUniversity.ResumeLayout(false);
            this.tpUniversity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUniversityYearsInService)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpProfessors;
        private System.Windows.Forms.TabPage tpStudents;
        private System.Windows.Forms.TabPage tpGrade;
        private System.Windows.Forms.TabPage tpCourse;
        private System.Windows.Forms.TabPage tpSchedule;
        private System.Windows.Forms.ListBox lbProfessors;
        private System.Windows.Forms.TextBox tbProfRank;
        private System.Windows.Forms.NumericUpDown tbProfAge;
        private System.Windows.Forms.TextBox tbProfName;
        private System.Windows.Forms.Button btnDeleteProfessor;
        private System.Windows.Forms.Button btnNewProfessor;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox cbCommitOnClose;
        private System.Windows.Forms.Button btnRevert;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnNewStudent;
        private System.Windows.Forms.Button btnDeleteStudent;
        private System.Windows.Forms.ListBox lbStudents;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnNewGrade;
        private System.Windows.Forms.Button btnDeleteGrade;
        private System.Windows.Forms.ListBox lbGrades;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnNewCourse;
        private System.Windows.Forms.Button btnDeleteCourse;
        private System.Windows.Forms.ListBox lbCourses;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnNewChedule;
        private System.Windows.Forms.Button btnDeleteSchedule;
        private System.Windows.Forms.ListBox lbSchedule;
        private System.Windows.Forms.CheckedListBox clbProfessorCourses;
        private System.Windows.Forms.TabPage tpUniversity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbUniversityName;
        private System.Windows.Forms.NumericUpDown nudUniversityYearsInService;
    }
}

