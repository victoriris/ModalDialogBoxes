using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ModalDialogBoxes
{
    public partial class MainForm : Form
    {
        EditorModal editorModal = new EditorModal();
        public BindingSource ingredientsSource;

        public MainForm()
        {
            InitializeComponent();
            reloadIngredientsView();
            
        }

        private void reloadIngredientsView ()
        {
            this.ingredientsSource = new BindingSource(editorModal.ingredients.Where(i => i.Value), null);
            ingredientList.DataSource = ingredientsSource;
            ingredientList.DisplayMember = "Key";
            ingredientList.ValueMember = "Value";
            ingredientList.Enabled = false;
            ingredientList.ClearSelected();
        }
        

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void OpenEditorBtn_Click(object sender, EventArgs e)
        {
            editorModal.ShowDialog(this);
            this.reloadIngredientsView();
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
