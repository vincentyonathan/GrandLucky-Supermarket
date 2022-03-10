namespace GrandLuckySupermarket
{
    partial class ProductForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button14 = new System.Windows.Forms.Button();
            this.AS = new System.Windows.Forms.ComboBox();
            this.Product = new Guna.UI2.WinForms.Guna2DataGridView();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.CatCB = new System.Windows.Forms.ComboBox();
            this.button10 = new System.Windows.Forms.Button();
            this.ProductPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.ProductQty = new Guna.UI2.WinForms.Guna2TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.ProductName = new Guna.UI2.WinForms.Guna2TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.ProductId = new Guna.UI2.WinForms.Guna2TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Product)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button14);
            this.panel1.Controls.Add(this.AS);
            this.panel1.Controls.Add(this.Product);
            this.panel1.Controls.Add(this.button13);
            this.panel1.Controls.Add(this.button12);
            this.panel1.Controls.Add(this.button11);
            this.panel1.Controls.Add(this.CatCB);
            this.panel1.Controls.Add(this.button10);
            this.panel1.Controls.Add(this.ProductPrice);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.ProductQty);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.ProductName);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.ProductId);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Location = new System.Drawing.Point(169, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1118, 683);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(405, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 39);
            this.label1.TabIndex = 20;
            this.label1.Text = "Manage Products";
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.White;
            this.button14.FlatAppearance.BorderSize = 0;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.ForeColor = System.Drawing.Color.RoyalBlue;
            this.button14.Location = new System.Drawing.Point(838, 101);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(101, 27);
            this.button14.TabIndex = 19;
            this.button14.Text = "Refresh";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // AS
            // 
            this.AS.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AS.ForeColor = System.Drawing.Color.RoyalBlue;
            this.AS.FormattingEnabled = true;
            this.AS.Items.AddRange(new object[] {
            "Admin",
            "Seller"});
            this.AS.Location = new System.Drawing.Point(605, 101);
            this.AS.Name = "AS";
            this.AS.Size = new System.Drawing.Size(227, 27);
            this.AS.TabIndex = 18;
            this.AS.Text = "Select Categories";
            this.AS.SelectedIndexChanged += new System.EventHandler(this.AS_SelectedIndexChanged);
            this.AS.SelectionChangeCommitted += new System.EventHandler(this.AS_SelectionChangeCommitted);
            // 
            // Product
            // 
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            this.Product.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.Product.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Product.BackgroundColor = System.Drawing.Color.White;
            this.Product.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Product.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Product.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Product.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.Product.ColumnHeadersHeight = 25;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Product.DefaultCellStyle = dataGridViewCellStyle18;
            this.Product.EnableHeadersVisualStyles = false;
            this.Product.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Product.Location = new System.Drawing.Point(477, 133);
            this.Product.Name = "Product";
            this.Product.RowHeadersVisible = false;
            this.Product.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.Product.RowTemplate.Height = 24;
            this.Product.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Product.Size = new System.Drawing.Size(616, 524);
            this.Product.TabIndex = 17;
            this.Product.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.Product.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.Product.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.Product.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.Product.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.Product.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.Product.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Product.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Product.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Product.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.Product.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.Product.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.Product.ThemeStyle.HeaderStyle.Height = 25;
            this.Product.ThemeStyle.ReadOnly = false;
            this.Product.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.Product.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Product.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.Product.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.Product.ThemeStyle.RowsStyle.Height = 24;
            this.Product.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Product.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.Product.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Product_CellContentClick);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.White;
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.ForeColor = System.Drawing.Color.RoyalBlue;
            this.button13.Location = new System.Drawing.Point(183, 493);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(109, 46);
            this.button13.TabIndex = 16;
            this.button13.Text = "Edit";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.White;
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.ForeColor = System.Drawing.Color.RoyalBlue;
            this.button12.Location = new System.Drawing.Point(314, 493);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(109, 46);
            this.button12.TabIndex = 15;
            this.button12.Text = "Delete";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.White;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.Color.RoyalBlue;
            this.button11.Location = new System.Drawing.Point(52, 493);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(109, 46);
            this.button11.TabIndex = 14;
            this.button11.Text = "Add";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // CatCB
            // 
            this.CatCB.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatCB.ForeColor = System.Drawing.Color.RoyalBlue;
            this.CatCB.FormattingEnabled = true;
            this.CatCB.Items.AddRange(new object[] {
            "Admin",
            "Seller"});
            this.CatCB.Location = new System.Drawing.Point(178, 421);
            this.CatCB.Name = "CatCB";
            this.CatCB.Size = new System.Drawing.Size(227, 27);
            this.CatCB.TabIndex = 13;
            this.CatCB.Text = "Select Categories";
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Transparent;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Location = new System.Drawing.Point(24, 407);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(148, 51);
            this.button10.TabIndex = 12;
            this.button10.Text = "Category";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // ProductPrice
            // 
            this.ProductPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProductPrice.DefaultText = "";
            this.ProductPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ProductPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ProductPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProductPrice.DisabledState.Parent = this.ProductPrice;
            this.ProductPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProductPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProductPrice.FocusedState.Parent = this.ProductPrice;
            this.ProductPrice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProductPrice.HoverState.Parent = this.ProductPrice;
            this.ProductPrice.Location = new System.Drawing.Point(183, 345);
            this.ProductPrice.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ProductPrice.Name = "ProductPrice";
            this.ProductPrice.PasswordChar = '\0';
            this.ProductPrice.PlaceholderText = "";
            this.ProductPrice.SelectedText = "";
            this.ProductPrice.ShadowDecoration.Parent = this.ProductPrice;
            this.ProductPrice.Size = new System.Drawing.Size(222, 30);
            this.ProductPrice.TabIndex = 11;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Transparent;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(14, 332);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(162, 43);
            this.button9.TabIndex = 10;
            this.button9.Text = "Price";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // ProductQty
            // 
            this.ProductQty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProductQty.DefaultText = "";
            this.ProductQty.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ProductQty.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ProductQty.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProductQty.DisabledState.Parent = this.ProductQty;
            this.ProductQty.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProductQty.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProductQty.FocusedState.Parent = this.ProductQty;
            this.ProductQty.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductQty.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProductQty.HoverState.Parent = this.ProductQty;
            this.ProductQty.Location = new System.Drawing.Point(183, 274);
            this.ProductQty.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ProductQty.Name = "ProductQty";
            this.ProductQty.PasswordChar = '\0';
            this.ProductQty.PlaceholderText = "";
            this.ProductQty.SelectedText = "";
            this.ProductQty.ShadowDecoration.Parent = this.ProductQty;
            this.ProductQty.Size = new System.Drawing.Size(222, 30);
            this.ProductQty.TabIndex = 9;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Transparent;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(24, 261);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(152, 54);
            this.button8.TabIndex = 8;
            this.button8.Text = "Qty";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // ProductName
            // 
            this.ProductName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProductName.DefaultText = "";
            this.ProductName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ProductName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ProductName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProductName.DisabledState.Parent = this.ProductName;
            this.ProductName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProductName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProductName.FocusedState.Parent = this.ProductName;
            this.ProductName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProductName.HoverState.Parent = this.ProductName;
            this.ProductName.Location = new System.Drawing.Point(183, 206);
            this.ProductName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ProductName.Name = "ProductName";
            this.ProductName.PasswordChar = '\0';
            this.ProductName.PlaceholderText = "";
            this.ProductName.SelectedText = "";
            this.ProductName.ShadowDecoration.Parent = this.ProductName;
            this.ProductName.Size = new System.Drawing.Size(222, 30);
            this.ProductName.TabIndex = 7;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(24, 193);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(152, 53);
            this.button7.TabIndex = 6;
            this.button7.Text = "Name";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // ProductId
            // 
            this.ProductId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProductId.DefaultText = "";
            this.ProductId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ProductId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ProductId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProductId.DisabledState.Parent = this.ProductId;
            this.ProductId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProductId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProductId.FocusedState.Parent = this.ProductId;
            this.ProductId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProductId.HoverState.Parent = this.ProductId;
            this.ProductId.Location = new System.Drawing.Point(183, 146);
            this.ProductId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ProductId.Name = "ProductId";
            this.ProductId.PasswordChar = '\0';
            this.ProductId.PlaceholderText = "";
            this.ProductId.SelectedText = "";
            this.ProductId.ShadowDecoration.Parent = this.ProductId;
            this.ProductId.Size = new System.Drawing.Size(222, 30);
            this.ProductId.TabIndex = 5;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(24, 133);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(152, 43);
            this.button6.TabIndex = 4;
            this.button6.Text = "ID";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.button1.Location = new System.Drawing.Point(33, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "Sellers";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.button2.Location = new System.Drawing.Point(12, 183);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 68);
            this.button2.TabIndex = 1;
            this.button2.Text = "Categories";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.button5.Location = new System.Drawing.Point(1241, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(59, 36);
            this.button5.TabIndex = 3;
            this.button5.Text = "X";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label6.Location = new System.Drawing.Point(40, 720);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 28);
            this.label6.TabIndex = 34;
            this.label6.Text = "Logout";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 787);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Product)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button10;
        private Guna.UI2.WinForms.Guna2TextBox ProductPrice;
        private System.Windows.Forms.Button button9;
        private Guna.UI2.WinForms.Guna2TextBox ProductQty;
        private System.Windows.Forms.Button button8;
        private Guna.UI2.WinForms.Guna2TextBox ProductName;
        private System.Windows.Forms.Button button7;
        private Guna.UI2.WinForms.Guna2TextBox ProductId;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.ComboBox AS;
        private Guna.UI2.WinForms.Guna2DataGridView Product;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.ComboBox CatCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
    }
}