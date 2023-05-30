namespace Meeting
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            description = new Label();
            groupBox1 = new GroupBox();
            dayListBox = new ListBox();
            groupBox2 = new GroupBox();
            LessonUpDown = new NumericUpDown();
            groupBox3 = new GroupBox();
            platformComboBox = new ComboBox();
            MeetTypeBox = new GroupBox();
            practiceButton = new RadioButton();
            laboratoryButton = new RadioButton();
            seminarButton = new RadioButton();
            lectureButton = new RadioButton();
            groupBox4 = new GroupBox();
            controlBox = new CheckBox();
            recordBox = new CheckBox();
            label1 = new Label();
            AdditionTextBox = new TextBox();
            ExitButton = new Button();
            OkButton = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LessonUpDown).BeginInit();
            groupBox3.SuspendLayout();
            MeetTypeBox.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // description
            // 
            description.AutoSize = true;
            description.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            description.Location = new Point(12, 9);
            description.Name = "description";
            description.Size = new Size(482, 28);
            description.TabIndex = 0;
            description.Text = "Оберіть параметри для проведення online пари:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dayListBox);
            groupBox1.Location = new Point(12, 53);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(164, 142);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "День";
            // 
            // dayListBox
            // 
            dayListBox.FormattingEnabled = true;
            dayListBox.ItemHeight = 20;
            dayListBox.Items.AddRange(new object[] { "Понеділок", "Вівторок", "Середа", "Четвер", "П'ятниця", "Субота", "Неділя" });
            dayListBox.Location = new Point(6, 26);
            dayListBox.Name = "dayListBox";
            dayListBox.Size = new Size(150, 104);
            dayListBox.TabIndex = 2;
            dayListBox.SelectedIndexChanged += dayListBox_SelectedIndexChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(LessonUpDown);
            groupBox2.Location = new Point(182, 53);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(187, 61);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Оберіть пару:";
            // 
            // LessonUpDown
            // 
            LessonUpDown.Location = new Point(6, 23);
            LessonUpDown.Maximum = new decimal(new int[] { 7, 0, 0, 0 });
            LessonUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            LessonUpDown.Name = "LessonUpDown";
            LessonUpDown.Size = new Size(175, 27);
            LessonUpDown.TabIndex = 0;
            LessonUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(platformComboBox);
            groupBox3.Location = new Point(182, 129);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(187, 66);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Оберіть платформу:";
            // 
            // platformComboBox
            // 
            platformComboBox.FormattingEnabled = true;
            platformComboBox.Items.AddRange(new object[] { "Microsoft Teams", "Zoom", "Google Meet" });
            platformComboBox.Location = new Point(6, 26);
            platformComboBox.Name = "platformComboBox";
            platformComboBox.Size = new Size(175, 28);
            platformComboBox.TabIndex = 0;
            platformComboBox.Text = "Microsoft Teams";
            // 
            // MeetTypeBox
            // 
            MeetTypeBox.Controls.Add(practiceButton);
            MeetTypeBox.Controls.Add(laboratoryButton);
            MeetTypeBox.Controls.Add(seminarButton);
            MeetTypeBox.Controls.Add(lectureButton);
            MeetTypeBox.Location = new Point(375, 53);
            MeetTypeBox.Name = "MeetTypeBox";
            MeetTypeBox.Size = new Size(174, 142);
            MeetTypeBox.TabIndex = 4;
            MeetTypeBox.TabStop = false;
            MeetTypeBox.Text = "Задайте вид заняття";
            // 
            // practiceButton
            // 
            practiceButton.AutoSize = true;
            practiceButton.Location = new Point(6, 113);
            practiceButton.Name = "practiceButton";
            practiceButton.Size = new Size(105, 24);
            practiceButton.TabIndex = 3;
            practiceButton.Text = "Практичне";
            practiceButton.UseVisualStyleBackColor = true;
            // 
            // laboratoryButton
            // 
            laboratoryButton.AutoSize = true;
            laboratoryButton.Location = new Point(6, 83);
            laboratoryButton.Name = "laboratoryButton";
            laboratoryButton.Size = new Size(124, 24);
            laboratoryButton.TabIndex = 2;
            laboratoryButton.Text = "Лабораторна";
            laboratoryButton.UseVisualStyleBackColor = true;
            // 
            // seminarButton
            // 
            seminarButton.AutoSize = true;
            seminarButton.Location = new Point(6, 53);
            seminarButton.Name = "seminarButton";
            seminarButton.Size = new Size(88, 24);
            seminarButton.TabIndex = 1;
            seminarButton.Text = "Семінар";
            seminarButton.UseVisualStyleBackColor = true;
            // 
            // lectureButton
            // 
            lectureButton.AutoSize = true;
            lectureButton.Checked = true;
            lectureButton.Location = new Point(6, 23);
            lectureButton.Name = "lectureButton";
            lectureButton.Size = new Size(76, 24);
            lectureButton.TabIndex = 0;
            lectureButton.TabStop = true;
            lectureButton.Text = "Лекція";
            lectureButton.UseVisualStyleBackColor = true;
            lectureButton.CheckedChanged += lectureButton_CheckedChanged;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(controlBox);
            groupBox4.Controls.Add(recordBox);
            groupBox4.Location = new Point(555, 53);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(183, 142);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            groupBox4.Text = "Додатково";
            // 
            // controlBox
            // 
            controlBox.AutoSize = true;
            controlBox.Location = new Point(6, 53);
            controlBox.Name = "controlBox";
            controlBox.Size = new Size(98, 24);
            controlBox.TabIndex = 1;
            controlBox.Text = "Контроль";
            controlBox.UseVisualStyleBackColor = true;
            // 
            // recordBox
            // 
            recordBox.AutoSize = true;
            recordBox.Location = new Point(6, 23);
            recordBox.Name = "recordBox";
            recordBox.Size = new Size(152, 24);
            recordBox.TabIndex = 0;
            recordBox.Text = "Дозволено запис";
            recordBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 221);
            label1.Name = "label1";
            label1.Size = new Size(143, 20);
            label1.TabIndex = 6;
            label1.Text = "Попередні вимоги:";
            // 
            // AdditionTextBox
            // 
            AdditionTextBox.Location = new Point(12, 244);
            AdditionTextBox.Name = "AdditionTextBox";
            AdditionTextBox.Size = new Size(726, 27);
            AdditionTextBox.TabIndex = 7;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(616, 286);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(122, 34);
            ExitButton.TabIndex = 8;
            ExitButton.Text = "Вихід";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // OkButton
            // 
            OkButton.Location = new Point(477, 286);
            OkButton.Name = "OkButton";
            OkButton.Size = new Size(122, 34);
            OkButton.TabIndex = 9;
            OkButton.Text = "Гаразд";
            OkButton.UseVisualStyleBackColor = true;
            OkButton.Click += OkButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(750, 332);
            Controls.Add(OkButton);
            Controls.Add(ExitButton);
            Controls.Add(AdditionTextBox);
            Controls.Add(label1);
            Controls.Add(groupBox4);
            Controls.Add(MeetTypeBox);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(description);
            Name = "Form1";
            Text = "Планування зустрічі";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)LessonUpDown).EndInit();
            groupBox3.ResumeLayout(false);
            MeetTypeBox.ResumeLayout(false);
            MeetTypeBox.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label description;
        private GroupBox groupBox1;
        private ListBox dayListBox;
        private GroupBox groupBox2;
        private NumericUpDown LessonUpDown;
        private GroupBox groupBox3;
        private ComboBox platformComboBox;
        private GroupBox MeetTypeBox;
        private RadioButton practiceButton;
        private RadioButton laboratoryButton;
        private RadioButton seminarButton;
        private RadioButton lectureButton;
        private GroupBox groupBox4;
        private CheckBox controlBox;
        private CheckBox recordBox;
        private Label label1;
        private TextBox AdditionTextBox;
        private Button ExitButton;
        private Button OkButton;
    }
}