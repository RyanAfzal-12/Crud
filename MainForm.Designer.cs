namespace Crud
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
            btn_employee = new Button();
            btn_product = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btn_employee
            // 
            btn_employee.BackColor = Color.SteelBlue;
            btn_employee.ForeColor = SystemColors.ControlLightLight;
            btn_employee.Location = new Point(197, 187);
            btn_employee.Name = "btn_employee";
            btn_employee.Size = new Size(123, 92);
            btn_employee.TabIndex = 1;
            btn_employee.Text = "Employee";
            btn_employee.UseVisualStyleBackColor = false;
            btn_employee.Click += this.btn_employee_Click;

            // btn_product
            // 
            btn_product.BackColor = Color.SteelBlue;
            btn_product.ForeColor = SystemColors.ControlLightLight;
            btn_product.Location = new Point(530, 187);
            btn_product.Name = "btn_product";
            btn_product.Size = new Size(123, 92);
            btn_product.TabIndex = 2;
            btn_product.Text = "Product";
            btn_product.UseVisualStyleBackColor = false;
            btn_product.Click += btn_product_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(352, 45);
            label1.Name = "label1";
            label1.Size = new Size(132, 32);
            label1.TabIndex = 3;
            label1.Text = "Main Form";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(880, 504);
            Controls.Add(label1);
            Controls.Add(btn_product);
            Controls.Add(btn_employee);
            Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

       // private Button btn_employee;
        private Button btn_employee;
        private Button btn_product;
        private Label label1;
    }
}