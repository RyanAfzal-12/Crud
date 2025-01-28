namespace Crud
{
    partial class Employee
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            idtextbox = new TextBox();
            nametextbox = new TextBox();
            celltextbox = new TextBox();
            emailtextbox = new TextBox();
            addresstextbox = new TextBox();
            btn_insert = new Button();
            btn_search = new Button();
            btn_update = new Button();
            btn_delete = new Button();
            customerDataGridView = new DataGridView();
            btn_viewall = new Button();
            btn_clearall = new Button();
            ((System.ComponentModel.ISupportInitialize)customerDataGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(147, 62);
            label1.Name = "label1";
            label1.Size = new Size(32, 28);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(147, 111);
            label2.Name = "label2";
            label2.Size = new Size(66, 28);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(147, 170);
            label3.Name = "label3";
            label3.Size = new Size(45, 28);
            label3.TabIndex = 2;
            label3.Text = "Cell";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(147, 230);
            label4.Name = "label4";
            label4.Size = new Size(60, 28);
            label4.TabIndex = 3;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(147, 282);
            label5.Name = "label5";
            label5.Size = new Size(85, 28);
            label5.TabIndex = 4;
            label5.Text = "Address";
            // 
            // idtextbox
            // 
            idtextbox.Location = new Point(273, 62);
            idtextbox.Name = "idtextbox";
            idtextbox.Size = new Size(248, 31);
            idtextbox.TabIndex = 5;
            // 
            // nametextbox
            // 
            nametextbox.Location = new Point(273, 111);
            nametextbox.Name = "nametextbox";
            nametextbox.Size = new Size(248, 31);
            nametextbox.TabIndex = 6;
            // 
            // celltextbox
            // 
            celltextbox.Location = new Point(273, 170);
            celltextbox.Name = "celltextbox";
            celltextbox.Size = new Size(248, 31);
            celltextbox.TabIndex = 7;
            // 
            // emailtextbox
            // 
            emailtextbox.Location = new Point(273, 230);
            emailtextbox.Name = "emailtextbox";
            emailtextbox.Size = new Size(248, 31);
            emailtextbox.TabIndex = 8;
            // 
            // addresstextbox
            // 
            addresstextbox.Location = new Point(273, 282);
            addresstextbox.Name = "addresstextbox";
            addresstextbox.Size = new Size(248, 31);
            addresstextbox.TabIndex = 9;
            // 
            // btn_insert
            // 
            btn_insert.BackColor = Color.DarkGreen;
            btn_insert.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_insert.ForeColor = SystemColors.ControlLightLight;
            btn_insert.Location = new Point(12, 366);
            btn_insert.Name = "btn_insert";
            btn_insert.Size = new Size(96, 53);
            btn_insert.TabIndex = 10;
            btn_insert.Text = "Save";
            btn_insert.UseVisualStyleBackColor = false;
            btn_insert.Click += btn_insert_Click;
            // 
            // btn_search
            // 
            btn_search.BackColor = Color.MediumAquamarine;
            btn_search.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_search.ForeColor = SystemColors.ControlLightLight;
            btn_search.Location = new Point(147, 366);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(96, 53);
            btn_search.TabIndex = 11;
            btn_search.Text = "Search";
            btn_search.UseVisualStyleBackColor = false;
            btn_search.Click += btn_search_Click;
            // 
            // btn_update
            // 
            btn_update.BackColor = Color.Navy;
            btn_update.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_update.ForeColor = SystemColors.ControlLightLight;
            btn_update.Location = new Point(290, 366);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(96, 53);
            btn_update.TabIndex = 12;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.Crimson;
            btn_delete.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_delete.ForeColor = SystemColors.ControlLightLight;
            btn_delete.Location = new Point(425, 366);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(96, 53);
            btn_delete.TabIndex = 13;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // customerDataGridView
            // 
            customerDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            customerDataGridView.Location = new Point(1, -2);
            customerDataGridView.Name = "customerDataGridView";
            customerDataGridView.RowHeadersWidth = 62;
            customerDataGridView.Size = new Size(799, 213);
            customerDataGridView.TabIndex = 14;
            // 
            // btn_viewall
            // 
            btn_viewall.BackColor = Color.PaleVioletRed;
            btn_viewall.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_viewall.ForeColor = SystemColors.ButtonHighlight;
            btn_viewall.Location = new Point(553, 366);
            btn_viewall.Name = "btn_viewall";
            btn_viewall.Size = new Size(96, 53);
            btn_viewall.TabIndex = 15;
            btn_viewall.Text = "ViewAll";
            btn_viewall.UseVisualStyleBackColor = false;
            btn_viewall.Click += btn_viewall_Click;
            // 
            // btn_clearall
            // 
            btn_clearall.BackColor = Color.Teal;
            btn_clearall.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_clearall.ForeColor = SystemColors.ControlLightLight;
            btn_clearall.Location = new Point(673, 366);
            btn_clearall.Name = "btn_clearall";
            btn_clearall.Size = new Size(96, 53);
            btn_clearall.TabIndex = 16;
            btn_clearall.Text = "Clear";
            btn_clearall.UseVisualStyleBackColor = false;
            btn_clearall.Click += btn_clearall_Click;
            // 
            // Employee
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_clearall);
            Controls.Add(btn_viewall);
            Controls.Add(customerDataGridView);
            Controls.Add(btn_delete);
            Controls.Add(btn_update);
            Controls.Add(btn_search);
            Controls.Add(btn_insert);
            Controls.Add(addresstextbox);
            Controls.Add(emailtextbox);
            Controls.Add(celltextbox);
            Controls.Add(nametextbox);
            Controls.Add(idtextbox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Employee";
            Text = "Employee";
          //  Load += this.Employee_Load;
            ((System.ComponentModel.ISupportInitialize)customerDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox idtextbox;
        private TextBox nametextbox;
        private TextBox celltextbox;
        private TextBox emailtextbox;
        private TextBox addresstextbox;
        private Button btn_insert;
        private Button btn_search;
        private Button btn_update;
        private Button btn_delete;
        private DataGridView customerDataGridView;
        private Button btn_viewall;
        private Button btn_clearall;
    }
}