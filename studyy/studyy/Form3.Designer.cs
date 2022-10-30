namespace studyy
{
    partial class Form3
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
            this.addStudent = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxMark = new System.Windows.Forms.TextBox();
            this.textBoxPeriod = new System.Windows.Forms.TextBox();
            this.textBoxFIO = new System.Windows.Forms.TextBox();
            this.comboBoxSubject = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // addStudent
            // 
            this.addStudent.BackColor = System.Drawing.Color.Peru;
            this.addStudent.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addStudent.Location = new System.Drawing.Point(12, 12);
            this.addStudent.Name = "addStudent";
            this.addStudent.Size = new System.Drawing.Size(776, 45);
            this.addStudent.TabIndex = 0;
            this.addStudent.Text = "Добавить студента";
            this.addStudent.UseVisualStyleBackColor = false;
            this.addStudent.Click += new System.EventHandler(this.addStudent_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(160, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 41);
            this.label2.TabIndex = 2;
            this.label2.Text = "ФИО:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(160, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 41);
            this.label3.TabIndex = 3;
            this.label3.Text = "Семестр:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(160, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 41);
            this.label4.TabIndex = 4;
            this.label4.Text = "Дисциплина:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(160, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 41);
            this.label5.TabIndex = 5;
            this.label5.Text = "Оценка:";
            // 
            // textBoxMark
            // 
            this.textBoxMark.Location = new System.Drawing.Point(414, 204);
            this.textBoxMark.Name = "textBoxMark";
            this.textBoxMark.Size = new System.Drawing.Size(180, 27);
            this.textBoxMark.TabIndex = 6;
            // 
            // textBoxPeriod
            // 
            this.textBoxPeriod.Location = new System.Drawing.Point(414, 122);
            this.textBoxPeriod.Name = "textBoxPeriod";
            this.textBoxPeriod.Size = new System.Drawing.Size(180, 27);
            this.textBoxPeriod.TabIndex = 8;
            // 
            // textBoxFIO
            // 
            this.textBoxFIO.Location = new System.Drawing.Point(414, 81);
            this.textBoxFIO.Name = "textBoxFIO";
            this.textBoxFIO.Size = new System.Drawing.Size(180, 27);
            this.textBoxFIO.TabIndex = 9;
            // 
            // comboBoxSubject
            // 
            this.comboBoxSubject.FormattingEnabled = true;
            this.comboBoxSubject.Items.AddRange(new object[] {
            "Русский язык",
            "Литература",
            "Иностранный язык",
            "Математика: алгебра, начала математического анализа, геометрия",
            "История",
            "Физическая культура",
            "ОБЖ",
            "Информатика",
            "Физика",
            "Астрономия",
            "Химия",
            "Обществознание (вкл. экономику и право)",
            "Введение в специальность/ Основы профессиональной этики",
            "Индивидуальный проект/ Решение нестандартных задач",
            "Русский язык",
            "Литература",
            "Иностранный язык",
            "Математика: алгебра, начала математического анализа, геометрия",
            "История",
            "Физическая культура",
            "ОБЖ",
            "Информатика",
            "Физика",
            "Астрономия",
            "Химия",
            "Обществознание (вкл. экономику и право)",
            "Введение в специальность/ Основы профессиональной этики",
            "Индивидуальный проект/ Решение нестандартных задач",
            "Основы философии",
            "История",
            "Психология общения",
            "Иностранный язык в профессиональной деятельности",
            "Физическая культура",
            "Иностранный язык в профессиональной деятельности",
            "Физическая культура",
            "Иностранный язык в профессиональной деятельности",
            "Физическая культура",
            "Иностранный язык в профессиональной деятельности",
            "Физическая культура",
            "Иностранный язык в профессиональной деятельности",
            "Физическая культура",
            "Иностранный язык в профессиональной деятельности",
            "Физическая культура",
            "Элементы высшей математики",
            "Дискретная математика с элементами математической логики",
            "Теория вероятностей и математическая статистика",
            "Операционные системы и среды",
            "Архитектура аппаратных средств",
            "Информационные технологии",
            "Основы алгоритмизации и программирования",
            "Правовое обеспечение профессиональной деятельности",
            "Безопасность жизнедеятельности",
            "Экономика отрасли",
            "Основы проектирования баз данных",
            "Стандартизация, сертификация и техническое документоведение",
            "Численные методы",
            "Компьютерные сети",
            "Менеджмент в профессиональной деятельности",
            "Основы информационной безопасности",
            "Веб-дизайн и разработка",
            "Основы проектирования баз данных",
            "Разработка программных модулей",
            "Поддержка и тестирование программных модулей",
            "Разработка мобильных приложений",
            "Системное программирование",
            "Учебная практика",
            "Производственная практика ",
            "Разработка программных модулей",
            "Разработка программных модулей",
            "Разработка программных модулей",
            "Поддержка и тестирование программных модулей",
            "Разработка мобильных приложений",
            "Системное программирование",
            "Производственная практика ",
            "Производственная практика ",
            "Технология разработки программного обеспечения",
            "Инструментальные средства разработки программного обеспечения",
            "Математическое моделирование",
            "Учебная практика",
            "Производственная практика",
            "Инструментальные средства разработки программного обеспечения",
            "Производственная практика",
            "Технология разработки и защиты баз данных",
            "Учебная практика",
            "Производственная практика",
            "Технология разработки и защиты баз данных",
            "Производственная практика"});
            this.comboBoxSubject.Location = new System.Drawing.Point(414, 163);
            this.comboBoxSubject.Name = "comboBoxSubject";
            this.comboBoxSubject.Size = new System.Drawing.Size(180, 28);
            this.comboBoxSubject.TabIndex = 10;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxSubject);
            this.Controls.Add(this.textBoxFIO);
            this.Controls.Add(this.textBoxPeriod);
            this.Controls.Add(this.textBoxMark);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addStudent);
            this.Name = "Form3";
            this.Text = "Добавить студента";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addStudent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxMark;
        private System.Windows.Forms.TextBox textBoxPeriod;
        private System.Windows.Forms.TextBox textBoxFIO;
        private System.Windows.Forms.ComboBox comboBoxSubject;
    }
}