namespace ModalDialogBoxes
{
    partial class MainForm
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
            this.openEditorBtn = new System.Windows.Forms.Button();
            this.ingredientList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openEditorBtn
            // 
            this.openEditorBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.openEditorBtn.Location = new System.Drawing.Point(12, 12);
            this.openEditorBtn.Name = "openEditorBtn";
            this.openEditorBtn.Size = new System.Drawing.Size(91, 37);
            this.openEditorBtn.TabIndex = 0;
            this.openEditorBtn.Text = "Edit Order";
            this.openEditorBtn.UseVisualStyleBackColor = true;
            this.openEditorBtn.Click += new System.EventHandler(this.OpenEditorBtn_Click);
            // 
            // ingredientList
            // 
            this.ingredientList.FormattingEnabled = true;
            this.ingredientList.Location = new System.Drawing.Point(12, 88);
            this.ingredientList.Name = "ingredientList";
            this.ingredientList.Size = new System.Drawing.Size(120, 95);
            this.ingredientList.TabIndex = 1;
            this.ingredientList.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Current Ingredients";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ingredientList);
            this.Controls.Add(this.openEditorBtn);
            this.Name = "MainForm";
            this.Text = "Modal Dialog Boxes";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openEditorBtn;
        private System.Windows.Forms.ListBox ingredientList;
        private System.Windows.Forms.Label label1;
    }
}

