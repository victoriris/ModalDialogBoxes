using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModalDialogBoxes
{
    public partial class EditorModal : Form
    {
        // Variables
        public string customerName;
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

        private void saveIngredients()
        {
            // Get all ingredient boxes and stores their value
            var checkBoxes = ingredientsBox.Controls.OfType<CheckBox>();
            foreach (CheckBox cb in checkBoxes)
            {
                ingredients[cb.Text] = cb.Checked;
            }
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            saveIngredients();
        }
    }
}
