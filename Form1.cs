namespace WinFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void confirmationBTN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_Name.Text) || string.IsNullOrWhiteSpace(textBox_Phone.Text))
            {
                MessageBox.Show("������� ��� � ����� ��������.");
                return;
            }
            string name = textBox_Name.Text;
            string phone = textBox_Phone.Text;
            DateTime orderDate = dateTimePicker.Value;
            string mainFood = Food_comboBox.SelectedItem?.ToString() ?? "�� �������";
            string extraFood = "";
            foreach (var item in checkedListBox.Items)
            {
                int index = checkedListBox.Items.IndexOf(item);
                if (checkedListBox.GetItemChecked(index))
                {
                    if (extraFood != "")
                    {
                        extraFood += ", ";
                    }
                    extraFood += item.ToString();
                }
            }
            string type = radioButton_Delivery.Checked ? "��������" : "���������";
            MessageBox.Show($"����� ����������:\n\n���:{name}\n�������:{phone}\n���� � �����:{orderDate}\n�������� �����:{mainFood}\n�������������:{extraFood}\n��� ������:{type}");
        }
    }
}