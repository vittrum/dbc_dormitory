﻿namespace Sofa_Course {
    partial class Form1 {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.tabCon = new System.Windows.Forms.TabControl();
            this.tabLogin = new System.Windows.Forms.TabPage();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboRole = new System.Windows.Forms.ComboBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tabStudent = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbNameStudent = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSurnameStudent = new System.Windows.Forms.TextBox();
            this.btnShowStudents = new System.Windows.Forms.Button();
            this.btnConfirmStudent = new System.Windows.Forms.Button();
            this.btnCreateRequestStudent = new System.Windows.Forms.Button();
            this.tabStaff = new System.Windows.Forms.TabPage();
            this.tabSupMan = new System.Windows.Forms.TabPage();
            this.tabWatchman = new System.Windows.Forms.TabPage();
            this.dgvShowStudents = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbTypeOfRepair = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tabDirector = new System.Windows.Forms.TabPage();
            this.dgvStaffShowRequests = new System.Windows.Forms.DataGridView();
            this.btnStaffRefresh = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tabReport = new System.Windows.Forms.TabPage();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbTextReport = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbReportNum = new System.Windows.Forms.TextBox();
            this.btnSendReport = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnGuveLinens = new System.Windows.Forms.Button();
            this.btnGetLinens = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dgvWatchIdFind = new System.Windows.Forms.DataGridView();
            this.tbWatchIdFind = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dgvWatchGuests = new System.Windows.Forms.DataGridView();
            this.label15 = new System.Windows.Forms.Label();
            this.tbGuestName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tbGuestSurname = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tbGuestPatr = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tbGuestHome = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.tbGuestId = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.tabCon.SuspendLayout();
            this.tabLogin.SuspendLayout();
            this.tabStudent.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabStaff.SuspendLayout();
            this.tabSupMan.SuspendLayout();
            this.tabWatchman.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowStudents)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffShowRequests)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.tabReport.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWatchIdFind)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWatchGuests)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCon
            // 
            this.tabCon.Controls.Add(this.tabLogin);
            this.tabCon.Controls.Add(this.tabStudent);
            this.tabCon.Controls.Add(this.tabStaff);
            this.tabCon.Controls.Add(this.tabSupMan);
            this.tabCon.Controls.Add(this.tabWatchman);
            this.tabCon.Controls.Add(this.tabDirector);
            this.tabCon.Controls.Add(this.tabReport);
            this.tabCon.Location = new System.Drawing.Point(12, 12);
            this.tabCon.Name = "tabCon";
            this.tabCon.SelectedIndex = 0;
            this.tabCon.Size = new System.Drawing.Size(1071, 587);
            this.tabCon.TabIndex = 0;
            // 
            // tabLogin
            // 
            this.tabLogin.Controls.Add(this.btnLogin);
            this.tabLogin.Controls.Add(this.label4);
            this.tabLogin.Controls.Add(this.label3);
            this.tabLogin.Controls.Add(this.label2);
            this.tabLogin.Controls.Add(this.label1);
            this.tabLogin.Controls.Add(this.comboRole);
            this.tabLogin.Controls.Add(this.tbPass);
            this.tabLogin.Controls.Add(this.tbLogin);
            this.tabLogin.Location = new System.Drawing.Point(4, 22);
            this.tabLogin.Name = "tabLogin";
            this.tabLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogin.Size = new System.Drawing.Size(912, 463);
            this.tabLogin.TabIndex = 0;
            this.tabLogin.Text = "Login";
            this.tabLogin.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(122, 144);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "войти";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "role";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "pass";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "login";
            // 
            // comboRole
            // 
            this.comboRole.FormattingEnabled = true;
            this.comboRole.Location = new System.Drawing.Point(122, 84);
            this.comboRole.Name = "comboRole";
            this.comboRole.Size = new System.Drawing.Size(121, 21);
            this.comboRole.TabIndex = 2;
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(122, 111);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(100, 20);
            this.tbPass.TabIndex = 1;
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(122, 56);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(100, 20);
            this.tbLogin.TabIndex = 0;
            // 
            // tabStudent
            // 
            this.tabStudent.Controls.Add(this.groupBox4);
            this.tabStudent.Controls.Add(this.groupBox3);
            this.tabStudent.Controls.Add(this.groupBox1);
            this.tabStudent.Location = new System.Drawing.Point(4, 22);
            this.tabStudent.Name = "tabStudent";
            this.tabStudent.Padding = new System.Windows.Forms.Padding(3);
            this.tabStudent.Size = new System.Drawing.Size(1063, 561);
            this.tabStudent.TabIndex = 1;
            this.tabStudent.Text = "Студент";
            this.tabStudent.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvShowStudents);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbNameStudent);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbSurnameStudent);
            this.groupBox1.Controls.Add(this.btnShowStudents);
            this.groupBox1.Location = new System.Drawing.Point(261, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 451);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Посмотреть студентов";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Фамилия";
            // 
            // tbNameStudent
            // 
            this.tbNameStudent.Location = new System.Drawing.Point(89, 102);
            this.tbNameStudent.Name = "tbNameStudent";
            this.tbNameStudent.Size = new System.Drawing.Size(100, 20);
            this.tbNameStudent.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Имя";
            // 
            // tbSurnameStudent
            // 
            this.tbSurnameStudent.Location = new System.Drawing.Point(89, 69);
            this.tbSurnameStudent.Name = "tbSurnameStudent";
            this.tbSurnameStudent.Size = new System.Drawing.Size(100, 20);
            this.tbSurnameStudent.TabIndex = 10;
            // 
            // btnShowStudents
            // 
            this.btnShowStudents.Location = new System.Drawing.Point(89, 164);
            this.btnShowStudents.Name = "btnShowStudents";
            this.btnShowStudents.Size = new System.Drawing.Size(100, 31);
            this.btnShowStudents.TabIndex = 1;
            this.btnShowStudents.Text = "Посмотреть";
            this.btnShowStudents.UseVisualStyleBackColor = true;
            // 
            // btnConfirmStudent
            // 
            this.btnConfirmStudent.Location = new System.Drawing.Point(53, 374);
            this.btnConfirmStudent.Name = "btnConfirmStudent";
            this.btnConfirmStudent.Size = new System.Drawing.Size(97, 42);
            this.btnConfirmStudent.TabIndex = 3;
            this.btnConfirmStudent.Text = "Утвердить ";
            this.btnConfirmStudent.UseVisualStyleBackColor = true;
            // 
            // btnCreateRequestStudent
            // 
            this.btnCreateRequestStudent.Location = new System.Drawing.Point(78, 391);
            this.btnCreateRequestStudent.Name = "btnCreateRequestStudent";
            this.btnCreateRequestStudent.Size = new System.Drawing.Size(97, 42);
            this.btnCreateRequestStudent.TabIndex = 2;
            this.btnCreateRequestStudent.Text = "Подать";
            this.btnCreateRequestStudent.UseVisualStyleBackColor = true;
            // 
            // tabStaff
            // 
            this.tabStaff.Controls.Add(this.btnStaffRefresh);
            this.tabStaff.Controls.Add(this.dgvStaffShowRequests);
            this.tabStaff.Location = new System.Drawing.Point(4, 22);
            this.tabStaff.Name = "tabStaff";
            this.tabStaff.Padding = new System.Windows.Forms.Padding(3);
            this.tabStaff.Size = new System.Drawing.Size(1063, 561);
            this.tabStaff.TabIndex = 2;
            this.tabStaff.Text = "Техперсонал";
            this.tabStaff.UseVisualStyleBackColor = true;
            // 
            // tabSupMan
            // 
            this.tabSupMan.Controls.Add(this.dateTimePicker2);
            this.tabSupMan.Controls.Add(this.btnGetLinens);
            this.tabSupMan.Controls.Add(this.label10);
            this.tabSupMan.Controls.Add(this.dataGridView1);
            this.tabSupMan.Controls.Add(this.groupBox5);
            this.tabSupMan.Location = new System.Drawing.Point(4, 22);
            this.tabSupMan.Name = "tabSupMan";
            this.tabSupMan.Padding = new System.Windows.Forms.Padding(3);
            this.tabSupMan.Size = new System.Drawing.Size(1063, 561);
            this.tabSupMan.TabIndex = 3;
            this.tabSupMan.Text = "Завхоз";
            this.tabSupMan.UseVisualStyleBackColor = true;
            // 
            // tabWatchman
            // 
            this.tabWatchman.Controls.Add(this.groupBox6);
            this.tabWatchman.Controls.Add(this.groupBox2);
            this.tabWatchman.Location = new System.Drawing.Point(4, 22);
            this.tabWatchman.Name = "tabWatchman";
            this.tabWatchman.Padding = new System.Windows.Forms.Padding(3);
            this.tabWatchman.Size = new System.Drawing.Size(1063, 561);
            this.tabWatchman.TabIndex = 4;
            this.tabWatchman.Text = "Вахтёр";
            this.tabWatchman.UseVisualStyleBackColor = true;
            // 
            // dgvShowStudents
            // 
            this.dgvShowStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowStudents.Location = new System.Drawing.Point(6, 259);
            this.dgvShowStudents.Name = "dgvShowStudents";
            this.dgvShowStudents.Size = new System.Drawing.Size(264, 174);
            this.dgvShowStudents.TabIndex = 14;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbTypeOfRepair);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.btnCreateRequestStudent);
            this.groupBox3.Location = new System.Drawing.Point(537, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(253, 451);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Подать заявку на ремонт";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.comboBox1);
            this.groupBox4.Controls.Add(this.btnConfirmStudent);
            this.groupBox4.Location = new System.Drawing.Point(812, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(216, 451);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Утвердить ремонт";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 268);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Тип работ";
            // 
            // tbTypeOfRepair
            // 
            this.tbTypeOfRepair.Location = new System.Drawing.Point(121, 216);
            this.tbTypeOfRepair.Multiline = true;
            this.tbTypeOfRepair.Name = "tbTypeOfRepair";
            this.tbTypeOfRepair.Size = new System.Drawing.Size(106, 141);
            this.tbTypeOfRepair.TabIndex = 19;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(53, 193);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(87, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Мои заявки";
            // 
            // tabDirector
            // 
            this.tabDirector.Location = new System.Drawing.Point(4, 22);
            this.tabDirector.Name = "tabDirector";
            this.tabDirector.Padding = new System.Windows.Forms.Padding(3);
            this.tabDirector.Size = new System.Drawing.Size(1063, 561);
            this.tabDirector.TabIndex = 5;
            this.tabDirector.Text = "Заведующий общежитием";
            this.tabDirector.UseVisualStyleBackColor = true;
            // 
            // dgvStaffShowRequests
            // 
            this.dgvStaffShowRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaffShowRequests.Location = new System.Drawing.Point(22, 6);
            this.dgvStaffShowRequests.Name = "dgvStaffShowRequests";
            this.dgvStaffShowRequests.Size = new System.Drawing.Size(623, 330);
            this.dgvStaffShowRequests.TabIndex = 0;
            // 
            // btnStaffRefresh
            // 
            this.btnStaffRefresh.Location = new System.Drawing.Point(166, 342);
            this.btnStaffRefresh.Name = "btnStaffRefresh";
            this.btnStaffRefresh.Size = new System.Drawing.Size(237, 77);
            this.btnStaffRefresh.TabIndex = 1;
            this.btnStaffRefresh.Text = "Обновить";
            this.btnStaffRefresh.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnGuveLinens);
            this.groupBox5.Controls.Add(this.dateTimePicker1);
            this.groupBox5.Controls.Add(this.comboBox2);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.textBox1);
            this.groupBox5.Location = new System.Drawing.Point(22, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(289, 320);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Выдать бельё";
            // 
            // tabReport
            // 
            this.tabReport.Controls.Add(this.groupBox8);
            this.tabReport.Location = new System.Drawing.Point(4, 22);
            this.tabReport.Name = "tabReport";
            this.tabReport.Padding = new System.Windows.Forms.Padding(3);
            this.tabReport.Size = new System.Drawing.Size(1063, 561);
            this.tabReport.TabIndex = 6;
            this.tabReport.Text = "Заявка о нарушении";
            this.tabReport.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label13);
            this.groupBox8.Controls.Add(this.tbTextReport);
            this.groupBox8.Controls.Add(this.label14);
            this.groupBox8.Controls.Add(this.tbReportNum);
            this.groupBox8.Controls.Add(this.btnSendReport);
            this.groupBox8.Location = new System.Drawing.Point(23, 19);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(249, 451);
            this.groupBox8.TabIndex = 6;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Создать заявку о нарушении";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(44, 184);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "текст жалобы";
            // 
            // tbTextReport
            // 
            this.tbTextReport.Location = new System.Drawing.Point(41, 205);
            this.tbTextReport.Multiline = true;
            this.tbTextReport.Name = "tbTextReport";
            this.tbTextReport.Size = new System.Drawing.Size(142, 117);
            this.tbTextReport.TabIndex = 16;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(38, 145);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 13);
            this.label14.TabIndex = 15;
            this.label14.Text = "Номер студента";
            // 
            // tbReportNum
            // 
            this.tbReportNum.Location = new System.Drawing.Point(41, 161);
            this.tbReportNum.Name = "tbReportNum";
            this.tbReportNum.Size = new System.Drawing.Size(100, 20);
            this.tbReportNum.TabIndex = 14;
            // 
            // btnSendReport
            // 
            this.btnSendReport.Location = new System.Drawing.Point(67, 374);
            this.btnSendReport.Name = "btnSendReport";
            this.btnSendReport.Size = new System.Drawing.Size(94, 31);
            this.btnSendReport.TabIndex = 0;
            this.btnSendReport.Text = "Создать";
            this.btnSendReport.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(118, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Номер студента";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Бельё";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 338);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Состояние белья";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 354);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(582, 201);
            this.dataGridView1.TabIndex = 5;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(118, 116);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(100, 21);
            this.comboBox2.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(20, 167);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(198, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // btnGuveLinens
            // 
            this.btnGuveLinens.Location = new System.Drawing.Point(55, 268);
            this.btnGuveLinens.Name = "btnGuveLinens";
            this.btnGuveLinens.Size = new System.Drawing.Size(75, 23);
            this.btnGuveLinens.TabIndex = 6;
            this.btnGuveLinens.Text = "Выдать";
            this.btnGuveLinens.UseVisualStyleBackColor = true;
            // 
            // btnGetLinens
            // 
            this.btnGetLinens.Location = new System.Drawing.Point(623, 532);
            this.btnGetLinens.Name = "btnGetLinens";
            this.btnGetLinens.Size = new System.Drawing.Size(75, 23);
            this.btnGetLinens.TabIndex = 7;
            this.btnGetLinens.Text = "Принять";
            this.btnGetLinens.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(623, 506);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 8;
            // 
            // dgvWatchIdFind
            // 
            this.dgvWatchIdFind.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWatchIdFind.Location = new System.Drawing.Point(18, 98);
            this.dgvWatchIdFind.Name = "dgvWatchIdFind";
            this.dgvWatchIdFind.Size = new System.Drawing.Size(240, 150);
            this.dgvWatchIdFind.TabIndex = 0;
            // 
            // tbWatchIdFind
            // 
            this.tbWatchIdFind.Location = new System.Drawing.Point(123, 58);
            this.tbWatchIdFind.Name = "tbWatchIdFind";
            this.tbWatchIdFind.Size = new System.Drawing.Size(100, 20);
            this.tbWatchIdFind.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 61);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Номер студента";
            // 
            // dgvWatchGuests
            // 
            this.dgvWatchGuests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWatchGuests.Location = new System.Drawing.Point(31, 218);
            this.dgvWatchGuests.Name = "dgvWatchGuests";
            this.dgvWatchGuests.Size = new System.Drawing.Size(240, 150);
            this.dgvWatchGuests.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(28, 86);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 13);
            this.label15.TabIndex = 5;
            this.label15.Text = "Имя";
            // 
            // tbGuestName
            // 
            this.tbGuestName.Location = new System.Drawing.Point(136, 83);
            this.tbGuestName.Name = "tbGuestName";
            this.tbGuestName.Size = new System.Drawing.Size(100, 20);
            this.tbGuestName.TabIndex = 4;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(28, 118);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 13);
            this.label16.TabIndex = 7;
            this.label16.Text = "Фамилия";
            // 
            // tbGuestSurname
            // 
            this.tbGuestSurname.Location = new System.Drawing.Point(136, 115);
            this.tbGuestSurname.Name = "tbGuestSurname";
            this.tbGuestSurname.Size = new System.Drawing.Size(100, 20);
            this.tbGuestSurname.TabIndex = 6;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(28, 148);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(54, 13);
            this.label17.TabIndex = 9;
            this.label17.Text = "Отчество";
            // 
            // tbGuestPatr
            // 
            this.tbGuestPatr.Location = new System.Drawing.Point(136, 145);
            this.tbGuestPatr.Name = "tbGuestPatr";
            this.tbGuestPatr.Size = new System.Drawing.Size(100, 20);
            this.tbGuestPatr.TabIndex = 8;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(28, 178);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(57, 13);
            this.label18.TabIndex = 11;
            this.label18.Text = "Прописка";
            // 
            // tbGuestHome
            // 
            this.tbGuestHome.Location = new System.Drawing.Point(136, 175);
            this.tbGuestHome.Name = "tbGuestHome";
            this.tbGuestHome.Size = new System.Drawing.Size(100, 20);
            this.tbGuestHome.TabIndex = 10;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(28, 53);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(89, 13);
            this.label19.TabIndex = 13;
            this.label19.Text = "Номер студента";
            // 
            // tbGuestId
            // 
            this.tbGuestId.Location = new System.Drawing.Point(136, 50);
            this.tbGuestId.Name = "tbGuestId";
            this.tbGuestId.Size = new System.Drawing.Size(100, 20);
            this.tbGuestId.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbWatchIdFind);
            this.groupBox2.Controls.Add(this.dgvWatchIdFind);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(359, 549);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Пропустить студента";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label19);
            this.groupBox6.Controls.Add(this.dgvWatchGuests);
            this.groupBox6.Controls.Add(this.tbGuestName);
            this.groupBox6.Controls.Add(this.tbGuestId);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Controls.Add(this.label18);
            this.groupBox6.Controls.Add(this.tbGuestSurname);
            this.groupBox6.Controls.Add(this.tbGuestHome);
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Controls.Add(this.tbGuestPatr);
            this.groupBox6.Location = new System.Drawing.Point(371, 6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(402, 549);
            this.groupBox6.TabIndex = 15;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Пропустить гостя";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 601);
            this.Controls.Add(this.tabCon);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabCon.ResumeLayout(false);
            this.tabLogin.ResumeLayout(false);
            this.tabLogin.PerformLayout();
            this.tabStudent.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabStaff.ResumeLayout(false);
            this.tabSupMan.ResumeLayout(false);
            this.tabSupMan.PerformLayout();
            this.tabWatchman.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowStudents)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffShowRequests)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabReport.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWatchIdFind)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWatchGuests)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCon;
        private System.Windows.Forms.TabPage tabLogin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboRole;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TabPage tabStudent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbNameStudent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSurnameStudent;
        private System.Windows.Forms.Button btnShowStudents;
        private System.Windows.Forms.Button btnConfirmStudent;
        private System.Windows.Forms.Button btnCreateRequestStudent;
        private System.Windows.Forms.TabPage tabStaff;
        private System.Windows.Forms.TabPage tabSupMan;
        private System.Windows.Forms.TabPage tabWatchman;
        private System.Windows.Forms.DataGridView dgvShowStudents;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbTypeOfRepair;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnStaffRefresh;
        private System.Windows.Forms.DataGridView dgvStaffShowRequests;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btnGetLinens;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnGuveLinens;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage tabDirector;
        private System.Windows.Forms.TabPage tabReport;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbTextReport;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbReportNum;
        private System.Windows.Forms.Button btnSendReport;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DataGridView dgvWatchGuests;
        private System.Windows.Forms.TextBox tbGuestName;
        private System.Windows.Forms.TextBox tbGuestId;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tbGuestSurname;
        private System.Windows.Forms.TextBox tbGuestHome;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbGuestPatr;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbWatchIdFind;
        private System.Windows.Forms.DataGridView dgvWatchIdFind;
        private System.Windows.Forms.Label label12;
    }
}

