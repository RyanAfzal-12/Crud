namespace Crud
{
    partial class Product
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
            label6 = new Label();
            idtxt = new TextBox();
            titletxt = new TextBox();
            pricetxt = new TextBox();
            stocktxt = new TextBox();
            companytxt = new TextBox();
            expirytxt = new TextBox();
            btn_save = new Button();
            btn_search = new Button();
            btn_update = new Button();
            btn_delete = new Button();
            productDataGridView = new DataGridView();
            btn_viewall = new Button();
            btn_clear = new Button();
            ((System.ComponentModel.ISupportInitialize)productDataGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(196, 63);
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
            label2.Location = new Point(196, 119);
            label2.Name = "label2";
            label2.Size = new Size(51, 28);
            label2.TabIndex = 1;
            label2.Text = "Title";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(196, 175);
            label3.Name = "label3";
            label3.Size = new Size(56, 28);
            label3.TabIndex = 2;
            label3.Text = "Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(196, 233);
            label4.Name = "label4";
            label4.Size = new Size(61, 28);
            label4.TabIndex = 3;
            label4.Text = "Stock";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(196, 301);
            label5.Name = "label5";
            label5.Size = new Size(98, 28);
            label5.TabIndex = 4;
            label5.Text = "Company";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(196, 360);
            label6.Name = "label6";
            label6.Size = new Size(67, 28);
            label6.TabIndex = 5;
            label6.Text = "Expiry";
            // 
            // idtxt
            // 
            idtxt.Location = new Point(319, 57);
            idtxt.Name = "idtxt";
            idtxt.Size = new Size(308, 31);
            idtxt.TabIndex = 6;
            // 
            // titletxt
            // 
            titletxt.Location = new Point(319, 113);
            titletxt.Name = "titletxt";
            titletxt.Size = new Size(308, 31);
            titletxt.TabIndex = 7;
            // 
            // pricetxt
            // 
            pricetxt.Location = new Point(319, 175);
            pricetxt.Name = "pricetxt";
            pricetxt.Size = new Size(308, 31);
            pricetxt.TabIndex = 8;
            // 
            // stocktxt
            // 
            stocktxt.Location = new Point(319, 233);
            stocktxt.Name = "stocktxt";
            stocktxt.Size = new Size(308, 31);
            stocktxt.TabIndex = 9;
            // 
            // companytxt
            // 
            companytxt.Location = new Point(319, 295);
            companytxt.Name = "companytxt";
            companytxt.Size = new Size(308, 31);
            companytxt.TabIndex = 10;
            // 
            // expirytxt
            // 
            expirytxt.Location = new Point(319, 354);
            expirytxt.Name = "expirytxt";
            expirytxt.Size = new Size(308, 31);
            expirytxt.TabIndex = 11;
            // 
            // btn_save
            // 
            btn_save.BackColor = Color.SteelBlue;
            btn_save.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_save.ForeColor = SystemColors.ControlLightLight;
            btn_save.Location = new Point(22, 418);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(89, 50);
            btn_save.TabIndex = 12;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = false;
            btn_save.Click += btn_save_Click;
            // 
            // btn_search
            // 
            btn_search.BackColor = Color.LightSlateGray;
            btn_search.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_search.ForeColor = SystemColors.ControlLightLight;
            btn_search.Location = new Point(168, 418);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(89, 50);
            btn_search.TabIndex = 13;
            btn_search.Text = "Search";
            btn_search.UseVisualStyleBackColor = false;
            btn_search.Click += btn_search_Click;
            // 
            // btn_update
            // 
            btn_update.BackColor = Color.Navy;
            btn_update.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_update.ForeColor = SystemColors.ControlLightLight;
            btn_update.Location = new Point(319, 418);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(89, 50);
            btn_update.TabIndex = 14;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.IndianRed;
            btn_delete.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_delete.ForeColor = SystemColors.ControlLightLight;
            btn_delete.Location = new Point(451, 418);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(89, 50);
            btn_delete.TabIndex = 15;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // productDataGridView
            // 
            productDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productDataGridView.Location = new Point(-2, 5);
            productDataGridView.Name = "productDataGridView";
            productDataGridView.RowHeadersWidth = 62;
            productDataGridView.Size = new Size(866, 222);
            productDataGridView.TabIndex = 16;
            // 
            // btn_viewall
            // 
            btn_viewall.BackColor = Color.Olive;
            btn_viewall.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_viewall.ForeColor = SystemColors.ControlLightLight;
            btn_viewall.Location = new Point(580, 418);
            btn_viewall.Name = "btn_viewall";
            btn_viewall.Size = new Size(89, 50);
            btn_viewall.TabIndex = 18;
            btn_viewall.Text = "ViewAll";
            btn_viewall.UseVisualStyleBackColor = false;
            btn_viewall.Click += btn_viewall_Click;
            // 
            // btn_clear
            // 
            btn_clear.BackColor = Color.LightSeaGreen;
            btn_clear.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_clear.ForeColor = SystemColors.ControlLightLight;
            btn_clear.Location = new Point(725, 418);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(89, 50);
            btn_clear.TabIndex = 19;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = false;
            btn_clear.Click += btn_clear_Click;
            // 
            // Product
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(865, 490);
            Controls.Add(btn_clear);
            Controls.Add(btn_viewall);
            Controls.Add(productDataGridView);
            Controls.Add(btn_delete);
            Controls.Add(btn_update);
            Controls.Add(btn_search);
            Controls.Add(btn_save);
            Controls.Add(expirytxt);
            Controls.Add(companytxt);
            Controls.Add(stocktxt);
            Controls.Add(pricetxt);
            Controls.Add(titletxt);
            Controls.Add(idtxt);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Product";
            Text = "Product";
            ((System.ComponentModel.ISupportInitialize)productDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox idtxt;
        private TextBox titletxt;
        private TextBox pricetxt;
        private TextBox stocktxt;
        private TextBox companytxt;
        private TextBox expirytxt;
        private Button btn_save;
        private Button btn_search;
        private Button btn_update;
        private Button btn_delete;
        private DataGridView productDataGridView;
        private Button btn_viewall;
        private Button btn_clear;
    }
}