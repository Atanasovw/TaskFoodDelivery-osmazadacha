namespace FoodDelivery
{
    partial class Form1
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
            this.addButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.typedishcombobox = new System.Windows.Forms.ComboBox();
            this.pricetxtbox = new System.Windows.Forms.TextBox();
            this.grammagetxtbox = new System.Windows.Forms.TextBox();
            this.nametxtbox = new System.Windows.Forms.TextBox();
            this.namelbl = new System.Windows.Forms.Label();
            this.grammagelbl = new System.Windows.Forms.Label();
            this.pricelbl = new System.Windows.Forms.Label();
            this.idlabel = new System.Windows.Forms.Label();
            this.dishtypelbl = new System.Windows.Forms.Label();
            this.idtxtbox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.descriptionlbl = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.selectAllButton = new System.Windows.Forms.Button();
            this.findButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(33, 294);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(33, 342);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(75, 23);
            this.EditButton.TabIndex = 1;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(114, 294);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveButton.TabIndex = 2;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(114, 342);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 3;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            // 
            // typedishcombobox
            // 
            this.typedishcombobox.FormattingEnabled = true;
            this.typedishcombobox.Location = new System.Drawing.Point(124, 229);
            this.typedishcombobox.Name = "typedishcombobox";
            this.typedishcombobox.Size = new System.Drawing.Size(121, 24);
            this.typedishcombobox.TabIndex = 4;
            this.typedishcombobox.SelectedIndexChanged += new System.EventHandler(this.typedishcombobox_SelectedIndexChanged);
            // 
            // pricetxtbox
            // 
            this.pricetxtbox.Location = new System.Drawing.Point(124, 186);
            this.pricetxtbox.Name = "pricetxtbox";
            this.pricetxtbox.Size = new System.Drawing.Size(100, 22);
            this.pricetxtbox.TabIndex = 5;
            // 
            // grammagetxtbox
            // 
            this.grammagetxtbox.Location = new System.Drawing.Point(124, 138);
            this.grammagetxtbox.Name = "grammagetxtbox";
            this.grammagetxtbox.Size = new System.Drawing.Size(100, 22);
            this.grammagetxtbox.TabIndex = 6;
            // 
            // nametxtbox
            // 
            this.nametxtbox.Location = new System.Drawing.Point(124, 93);
            this.nametxtbox.Name = "nametxtbox";
            this.nametxtbox.Size = new System.Drawing.Size(100, 22);
            this.nametxtbox.TabIndex = 7;
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.Location = new System.Drawing.Point(27, 93);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(44, 16);
            this.namelbl.TabIndex = 9;
            this.namelbl.Text = "Name";
            // 
            // grammagelbl
            // 
            this.grammagelbl.AutoSize = true;
            this.grammagelbl.Location = new System.Drawing.Point(27, 138);
            this.grammagelbl.Name = "grammagelbl";
            this.grammagelbl.Size = new System.Drawing.Size(75, 16);
            this.grammagelbl.TabIndex = 10;
            this.grammagelbl.Text = "Grammage";
            // 
            // pricelbl
            // 
            this.pricelbl.AutoSize = true;
            this.pricelbl.Location = new System.Drawing.Point(30, 186);
            this.pricelbl.Name = "pricelbl";
            this.pricelbl.Size = new System.Drawing.Size(38, 16);
            this.pricelbl.TabIndex = 11;
            this.pricelbl.Text = "Price";
            // 
            // idlabel
            // 
            this.idlabel.AutoSize = true;
            this.idlabel.Location = new System.Drawing.Point(30, 52);
            this.idlabel.Name = "idlabel";
            this.idlabel.Size = new System.Drawing.Size(20, 16);
            this.idlabel.TabIndex = 12;
            this.idlabel.Text = "ID";
            // 
            // dishtypelbl
            // 
            this.dishtypelbl.AutoSize = true;
            this.dishtypelbl.Location = new System.Drawing.Point(30, 232);
            this.dishtypelbl.Name = "dishtypelbl";
            this.dishtypelbl.Size = new System.Drawing.Size(69, 16);
            this.dishtypelbl.TabIndex = 13;
            this.dishtypelbl.Text = "Type Dish";
            // 
            // idtxtbox
            // 
            this.idtxtbox.Location = new System.Drawing.Point(124, 45);
            this.idtxtbox.Name = "idtxtbox";
            this.idtxtbox.Size = new System.Drawing.Size(100, 22);
            this.idtxtbox.TabIndex = 15;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(296, 49);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(224, 320);
            this.textBox1.TabIndex = 6;
            // 
            // descriptionlbl
            // 
            this.descriptionlbl.AutoSize = true;
            this.descriptionlbl.Location = new System.Drawing.Point(293, 20);
            this.descriptionlbl.Name = "descriptionlbl";
            this.descriptionlbl.Size = new System.Drawing.Size(75, 16);
            this.descriptionlbl.TabIndex = 16;
            this.descriptionlbl.Text = "Description";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(551, 49);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(207, 324);
            this.listBox1.TabIndex = 17;
            // 
            // selectAllButton
            // 
            this.selectAllButton.Location = new System.Drawing.Point(33, 384);
            this.selectAllButton.Name = "selectAllButton";
            this.selectAllButton.Size = new System.Drawing.Size(75, 23);
            this.selectAllButton.TabIndex = 18;
            this.selectAllButton.Text = "Select All";
            this.selectAllButton.UseVisualStyleBackColor = true;
            this.selectAllButton.Click += new System.EventHandler(this.selectAllButton_Click);
            // 
            // findButton
            // 
            this.findButton.Location = new System.Drawing.Point(114, 384);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(75, 23);
            this.findButton.TabIndex = 19;
            this.findButton.Text = "Find";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.selectAllButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.descriptionlbl);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.idtxtbox);
            this.Controls.Add(this.dishtypelbl);
            this.Controls.Add(this.idlabel);
            this.Controls.Add(this.pricelbl);
            this.Controls.Add(this.grammagelbl);
            this.Controls.Add(this.namelbl);
            this.Controls.Add(this.nametxtbox);
            this.Controls.Add(this.grammagetxtbox);
            this.Controls.Add(this.pricetxtbox);
            this.Controls.Add(this.typedishcombobox);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.addButton);
            this.Name = "Form1";
            this.Text = "Restaurant БИВИК";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.ComboBox typedishcombobox;
        private System.Windows.Forms.TextBox pricetxtbox;
        private System.Windows.Forms.TextBox grammagetxtbox;
        private System.Windows.Forms.TextBox nametxtbox;
        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.Label grammagelbl;
        private System.Windows.Forms.Label pricelbl;
        private System.Windows.Forms.Label idlabel;
        private System.Windows.Forms.Label dishtypelbl;
        private System.Windows.Forms.TextBox idtxtbox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label descriptionlbl;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button selectAllButton;
        private System.Windows.Forms.Button findButton;
    }
}