namespace ModalDialogBoxes
{
    partial class EditorModal
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
            this.olivesBox = new System.Windows.Forms.CheckBox();
            this.peppersBox = new System.Windows.Forms.CheckBox();
            this.onionBox = new System.Windows.Forms.CheckBox();
            this.pineappleBox = new System.Windows.Forms.CheckBox();
            this.ingredientsBox = new System.Windows.Forms.GroupBox();
            this.pepperoniBox = new System.Windows.Forms.CheckBox();
            this.breadTypeBox = new System.Windows.Forms.ComboBox();
            this.breadBox = new System.Windows.Forms.GroupBox();
            this.okBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.customerNameBox = new System.Windows.Forms.TextBox();
            this.customerBox = new System.Windows.Forms.GroupBox();
            this.ingredientsBox.SuspendLayout();
            this.breadBox.SuspendLayout();
            this.customerBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // olivesBox
            // 
            this.olivesBox.AutoSize = true;
            this.olivesBox.Location = new System.Drawing.Point(6, 19);
            this.olivesBox.Name = "olivesBox";
            this.olivesBox.Size = new System.Drawing.Size(55, 17);
            this.olivesBox.TabIndex = 0;
            this.olivesBox.Text = "Olives";
            this.olivesBox.UseVisualStyleBackColor = true;
            // 
            // peppersBox
            // 
            this.peppersBox.AutoSize = true;
            this.peppersBox.Location = new System.Drawing.Point(6, 42);
            this.peppersBox.Name = "peppersBox";
            this.peppersBox.Size = new System.Drawing.Size(65, 17);
            this.peppersBox.TabIndex = 1;
            this.peppersBox.Text = "Peppers";
            this.peppersBox.UseVisualStyleBackColor = true;
            // 
            // onionBox
            // 
            this.onionBox.AutoSize = true;
            this.onionBox.Location = new System.Drawing.Point(6, 65);
            this.onionBox.Name = "onionBox";
            this.onionBox.Size = new System.Drawing.Size(54, 17);
            this.onionBox.TabIndex = 2;
            this.onionBox.Text = "Onion";
            this.onionBox.UseVisualStyleBackColor = true;
            // 
            // pineappleBox
            // 
            this.pineappleBox.AutoSize = true;
            this.pineappleBox.Location = new System.Drawing.Point(6, 88);
            this.pineappleBox.Name = "pineappleBox";
            this.pineappleBox.Size = new System.Drawing.Size(73, 17);
            this.pineappleBox.TabIndex = 3;
            this.pineappleBox.Text = "Pineapple";
            this.pineappleBox.UseVisualStyleBackColor = true;
            // 
            // ingredientsBox
            // 
            this.ingredientsBox.Controls.Add(this.pepperoniBox);
            this.ingredientsBox.Controls.Add(this.olivesBox);
            this.ingredientsBox.Controls.Add(this.pineappleBox);
            this.ingredientsBox.Controls.Add(this.peppersBox);
            this.ingredientsBox.Controls.Add(this.onionBox);
            this.ingredientsBox.Location = new System.Drawing.Point(23, 22);
            this.ingredientsBox.Name = "ingredientsBox";
            this.ingredientsBox.Size = new System.Drawing.Size(130, 146);
            this.ingredientsBox.TabIndex = 4;
            this.ingredientsBox.TabStop = false;
            this.ingredientsBox.Text = "Ingredients";
            // 
            // pepperoniBox
            // 
            this.pepperoniBox.AutoSize = true;
            this.pepperoniBox.Location = new System.Drawing.Point(6, 111);
            this.pepperoniBox.Name = "pepperoniBox";
            this.pepperoniBox.Size = new System.Drawing.Size(74, 17);
            this.pepperoniBox.TabIndex = 5;
            this.pepperoniBox.Text = "Pepperoni";
            this.pepperoniBox.UseVisualStyleBackColor = true;
            // 
            // breadTypeBox
            // 
            this.breadTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.breadTypeBox.FormattingEnabled = true;
            this.breadTypeBox.Items.AddRange(new object[] {
            "Regular",
            "Cheese Crust",
            "Flatbread",
            "Thin Crust"});
            this.breadTypeBox.Location = new System.Drawing.Point(6, 19);
            this.breadTypeBox.Name = "breadTypeBox";
            this.breadTypeBox.Size = new System.Drawing.Size(211, 21);
            this.breadTypeBox.TabIndex = 5;
            // 
            // breadBox
            // 
            this.breadBox.Controls.Add(this.breadTypeBox);
            this.breadBox.Location = new System.Drawing.Point(170, 22);
            this.breadBox.Name = "breadBox";
            this.breadBox.Size = new System.Drawing.Size(223, 59);
            this.breadBox.TabIndex = 6;
            this.breadBox.TabStop = false;
            this.breadBox.Text = "Bread Type";
            // 
            // okBtn
            // 
            this.okBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okBtn.Location = new System.Drawing.Point(69, 192);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(124, 30);
            this.okBtn.TabIndex = 7;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.Location = new System.Drawing.Point(220, 192);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(124, 30);
            this.cancelBtn.TabIndex = 8;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // customerNameBox
            // 
            this.customerNameBox.Location = new System.Drawing.Point(6, 29);
            this.customerNameBox.Name = "customerNameBox";
            this.customerNameBox.Size = new System.Drawing.Size(211, 20);
            this.customerNameBox.TabIndex = 9;
            this.customerNameBox.Tag = "";
            // 
            // customerBox
            // 
            this.customerBox.Controls.Add(this.customerNameBox);
            this.customerBox.Location = new System.Drawing.Point(170, 105);
            this.customerBox.Name = "customerBox";
            this.customerBox.Size = new System.Drawing.Size(223, 63);
            this.customerBox.TabIndex = 10;
            this.customerBox.TabStop = false;
            this.customerBox.Text = "Customer name";
            // 
            // EditorModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 251);
            this.Controls.Add(this.customerBox);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.breadBox);
            this.Controls.Add(this.ingredientsBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditorModal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Order";
            this.ingredientsBox.ResumeLayout(false);
            this.ingredientsBox.PerformLayout();
            this.breadBox.ResumeLayout(false);
            this.customerBox.ResumeLayout(false);
            this.customerBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox olivesBox;
        private System.Windows.Forms.CheckBox peppersBox;
        private System.Windows.Forms.CheckBox onionBox;
        private System.Windows.Forms.CheckBox pineappleBox;
        private System.Windows.Forms.GroupBox ingredientsBox;
        private System.Windows.Forms.CheckBox pepperoniBox;
        private System.Windows.Forms.ComboBox breadTypeBox;
        private System.Windows.Forms.GroupBox breadBox;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.TextBox customerNameBox;
        private System.Windows.Forms.GroupBox customerBox;
    }
}