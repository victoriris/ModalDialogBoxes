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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.breadTypeView = new System.Windows.Forms.Label();
            this.customerNameView = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openEditorBtn
            // 
            this.openEditorBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.openEditorBtn.Location = new System.Drawing.Point(75, 271);
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
            this.ingredientList.Location = new System.Drawing.Point(12, 128);
            this.ingredientList.Name = "ingredientList";
            this.ingredientList.Size = new System.Drawing.Size(219, 95);
            this.ingredientList.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Current Ingredients:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Customer:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Bread Type:";
            // 
            // breadTypeView
            // 
            this.breadTypeView.AutoSize = true;
            this.breadTypeView.Location = new System.Drawing.Point(80, 80);
            this.breadTypeView.Name = "breadTypeView";
            this.breadTypeView.Size = new System.Drawing.Size(75, 13);
            this.breadTypeView.TabIndex = 6;
            this.breadTypeView.Text = "BREAD TYPE";
            // 
            // customerNameView
            // 
            this.customerNameView.AutoSize = true;
            this.customerNameView.Location = new System.Drawing.Point(72, 51);
            this.customerNameView.Name = "customerNameView";
            this.customerNameView.Size = new System.Drawing.Size(102, 13);
            this.customerNameView.TabIndex = 7;
            this.customerNameView.Text = "CUSTOMER NAME";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(41, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 26);
            this.label4.TabIndex = 8;
            this.label4.Text = "PIZZA SYSTEM";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 354);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.customerNameView);
            this.Controls.Add(this.breadTypeView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ingredientList);
            this.Controls.Add(this.openEditorBtn);
            this.Name = "MainForm";
            this.Text = "Modal Dialog Boxes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openEditorBtn;
        private System.Windows.Forms.ListBox ingredientList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label breadTypeView;
        private System.Windows.Forms.Label customerNameView;
        private System.Windows.Forms.Label label4;
    }
}

