using Microsoft.VisualBasic;

namespace Win32List
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = Interaction.InputBox("Add an item", "User input", "Item");
            ListViewItems.Items.Add(text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ListViewItems.SelectedItems.Count > 0)
            {
                ListViewItems.Items.Remove(ListViewItems.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show("Please select an item to remove");
            }
        }
    }
}