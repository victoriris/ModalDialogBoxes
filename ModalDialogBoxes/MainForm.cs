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
            editorModal.breadType = "Regular";
            refreshDataView();
        }

        private void refreshDataView ()
        {
            this.ingredientsSource = new BindingSource(editorModal.ingredients.Where(i => i.Value), null);
            ingredientList.DataSource = ingredientsSource;
            ingredientList.DisplayMember = "Key";
            ingredientList.ValueMember = "Value";
            ingredientList.Enabled = false;
            ingredientList.ClearSelected();

            this.customerNameView.Text = editorModal.customerName;
            this.breadTypeView.Text = editorModal.breadType;
        }
        

        private void OpenEditorBtn_Click(object sender, EventArgs e)
        {
            editorModal.ShowDialog(this);
            this.refreshDataView();
        }


    }
}
