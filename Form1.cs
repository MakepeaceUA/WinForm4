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
                MessageBox.Show("Введите имя и номер телефона.");
                return;
            }
            string name = textBox_Name.Text;
            string phone = textBox_Phone.Text;
            DateTime orderDate = dateTimePicker.Value;
            string mainFood = Food_comboBox.SelectedItem?.ToString() ?? "Не выбрано";
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
            string type = radioButton_Delivery.Checked ? "Доставка" : "Самовывоз";
            MessageBox.Show($"Заказ подтверждён:\n\nИмя:{name}\nТелефон:{phone}\nДата и время:{orderDate}\nОсновное блюдо:{mainFood}\nДополнительно:{extraFood}\nТип заказа:{type}");
        }
    }
}