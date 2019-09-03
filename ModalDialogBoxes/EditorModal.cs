using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ModalDialogBoxes
{
    public partial class EditorModal : Form
    {
        // Variables
        public string customerName = "";
        public string breadType = "";
        public IDictionary<string, bool> ingredients = new Dictionary<string, bool>();

        public EditorModal()
        {
            InitializeComponent();
            initializeIngredients();
        }

        private void initializeIngredients()
        {
            // Get all ingredient options and store/init their values
            var checkBoxes = ingredientsBox.Controls.OfType<CheckBox>();
            foreach (CheckBox cb in checkBoxes)
            {
                if (!ingredients.ContainsKey(cb.Name))
                {
                    bool is_checked = cb.Text == "Pepperoni" ? true : false;
                    ingredients.Add(cb.Text, is_checked);
                }
                cb.Checked = ingredients[cb.Text];
            }
        }

        private void setFormValues ()
        {
            // Get all ingredient options and store/init their values
            var checkBoxes = ingredientsBox.Controls.OfType<CheckBox>();
            foreach (CheckBox cb in checkBoxes)
            {
                cb.Checked = ingredients[cb.Text];
            }
            customerNameBox.Text = customerName;
            breadTypeBox.SelectedIndex = breadTypeBox.Items.IndexOf(breadType);
        }

        private void saveFormData()
        {
            // Get all ingredient boxes and stores their value
            var checkBoxes = ingredientsBox.Controls.OfType<CheckBox>();
            foreach (CheckBox cb in checkBoxes)
            {
                ingredients[cb.Text] = cb.Checked;
            }

            // Save customer name
            customerName = this.customerNameBox.Text;

            // Save bread type
            breadType = this.breadTypeBox.SelectedItem.ToString();
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            saveFormData();
        }

        private void EditorModal_Load(object sender, EventArgs e)
        {
            setFormValues();
        }
    }
}
