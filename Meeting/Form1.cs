namespace Meeting
{
    public partial class Form1 : Form
    {
        private string MeetType = "������";
        public Form1()
        {
            InitializeComponent();
            dayListBox.SelectedIndex = 0;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lectureButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton box = sender as RadioButton;
            if (box.Checked) MeetType = box.Text;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            string answer = string.Format(
                "{0} ���������� � {1} �� {2} \n���. ���������: {3}.", MeetType, dayListBox.Items[dayListBox.SelectedIndex],
                LessonUpDown.Value, platformComboBox.Text);
            if (recordBox.Checked) answer += "\n������� ���� ��������.";
            if (controlBox.Checked) answer += "\n������� ����������.";
            if (AdditionTextBox.Text != string.Empty) answer += "\n\n���������: " + AdditionTextBox.Text;

            MessageBox.Show(answer, "������", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dayListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (dayListBox.SelectedIndex)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                    LessonUpDown.Maximum = 7;
                    controlBox.Enabled = true;
                    seminarButton.Enabled = true;
                    laboratoryButton.Enabled = true;
                    practiceButton.Enabled = true;
                    break;
                case 5:
                    LessonUpDown.Maximum = 3;
                    controlBox.Enabled = false;
                    seminarButton.Enabled = true;
                    laboratoryButton.Enabled = true;
                    practiceButton.Enabled = true;
                    break;
                case 6:
                    LessonUpDown.Minimum = 2;
                    LessonUpDown.Maximum = 3;
                    controlBox.Enabled = false;
                    seminarButton.Enabled = false;
                    laboratoryButton.Enabled = false;
                    practiceButton.Enabled = false;
                    break;

            }
        }
    }
}