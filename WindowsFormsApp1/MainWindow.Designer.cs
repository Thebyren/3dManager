namespace WindowsFormsApp1
{
    partial class MainWindow
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.DeleteModel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.extModel = new System.Windows.Forms.TextBox();
            this.lbExt = new System.Windows.Forms.Label();
            this.DescriptionModel = new System.Windows.Forms.RichTextBox();
            this.SizeModel = new System.Windows.Forms.TextBox();
            this.DateModel = new System.Windows.Forms.TextBox();
            this.NameModel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbSize = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbDescripcion = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.userControl11 = new WpfControlLibrary4.UserControl1();
            this.model_title_viewport = new System.Windows.Forms.Label();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.SearchText = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.UpdateModel = new System.Windows.Forms.Button();
            this.InsertModel = new System.Windows.Forms.Button();
            this.Filters = new System.Windows.Forms.ComboBox();
            this.SaveModel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // DeleteModel
            // 
            this.DeleteModel.Location = new System.Drawing.Point(423, 179);
            this.DeleteModel.Name = "DeleteModel";
            this.DeleteModel.Size = new System.Drawing.Size(368, 23);
            this.DeleteModel.TabIndex = 1;
            this.DeleteModel.Text = "eliminar modelo";
            this.DeleteModel.UseVisualStyleBackColor = true;
            this.DeleteModel.Click += new System.EventHandler(this.DeleteModel_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.extModel);
            this.panel1.Controls.Add(this.lbExt);
            this.panel1.Controls.Add(this.DescriptionModel);
            this.panel1.Controls.Add(this.SizeModel);
            this.panel1.Controls.Add(this.DateModel);
            this.panel1.Controls.Add(this.NameModel);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lbSize);
            this.panel1.Controls.Add(this.lbDate);
            this.panel1.Controls.Add(this.lbDescripcion);
            this.panel1.Controls.Add(this.lbName);
            this.panel1.Controls.Add(this.elementHost1);
            this.panel1.Controls.Add(this.model_title_viewport);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 426);
            this.panel1.TabIndex = 2;
            // 
            // extModel
            // 
            this.extModel.BackColor = System.Drawing.Color.AliceBlue;
            this.extModel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.extModel.Location = new System.Drawing.Point(164, 311);
            this.extModel.Name = "extModel";
            this.extModel.ReadOnly = true;
            this.extModel.Size = new System.Drawing.Size(238, 20);
            this.extModel.TabIndex = 15;
            // 
            // lbExt
            // 
            this.lbExt.AutoSize = true;
            this.lbExt.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lbExt.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExt.Location = new System.Drawing.Point(7, 311);
            this.lbExt.Name = "lbExt";
            this.lbExt.Size = new System.Drawing.Size(91, 24);
            this.lbExt.TabIndex = 14;
            this.lbExt.Text = "Extension";
            // 
            // DescriptionModel
            // 
            this.DescriptionModel.BackColor = System.Drawing.Color.AliceBlue;
            this.DescriptionModel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DescriptionModel.Location = new System.Drawing.Point(6, 373);
            this.DescriptionModel.Name = "DescriptionModel";
            this.DescriptionModel.ReadOnly = true;
            this.DescriptionModel.Size = new System.Drawing.Size(396, 50);
            this.DescriptionModel.TabIndex = 13;
            this.DescriptionModel.Text = "";
            // 
            // SizeModel
            // 
            this.SizeModel.BackColor = System.Drawing.Color.AliceBlue;
            this.SizeModel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SizeModel.Location = new System.Drawing.Point(164, 278);
            this.SizeModel.Name = "SizeModel";
            this.SizeModel.ReadOnly = true;
            this.SizeModel.Size = new System.Drawing.Size(238, 20);
            this.SizeModel.TabIndex = 12;
            // 
            // DateModel
            // 
            this.DateModel.BackColor = System.Drawing.Color.AliceBlue;
            this.DateModel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DateModel.Location = new System.Drawing.Point(164, 245);
            this.DateModel.Name = "DateModel";
            this.DateModel.ReadOnly = true;
            this.DateModel.Size = new System.Drawing.Size(238, 20);
            this.DateModel.TabIndex = 11;
            // 
            // NameModel
            // 
            this.NameModel.BackColor = System.Drawing.Color.AliceBlue;
            this.NameModel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameModel.Location = new System.Drawing.Point(164, 212);
            this.NameModel.Name = "NameModel";
            this.NameModel.ReadOnly = true;
            this.NameModel.Size = new System.Drawing.Size(238, 20);
            this.NameModel.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label4.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 24);
            this.label4.TabIndex = 9;
            // 
            // lbSize
            // 
            this.lbSize.AutoSize = true;
            this.lbSize.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lbSize.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSize.Location = new System.Drawing.Point(9, 278);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(47, 24);
            this.lbSize.TabIndex = 8;
            this.lbSize.Text = "peso";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lbDate.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.Location = new System.Drawing.Point(9, 245);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(149, 24);
            this.lbDate.TabIndex = 7;
            this.lbDate.Text = "Fecha de registro";
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.AutoSize = true;
            this.lbDescripcion.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lbDescripcion.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescripcion.Location = new System.Drawing.Point(9, 344);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(105, 24);
            this.lbDescripcion.TabIndex = 6;
            this.lbDescripcion.Text = "Descripcion";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lbName.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(9, 212);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(75, 24);
            this.lbName.TabIndex = 5;
            this.lbName.Text = "Nombre";
            // 
            // elementHost1
            // 
            this.elementHost1.BackColor = System.Drawing.Color.White;
            this.elementHost1.Location = new System.Drawing.Point(6, 3);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(396, 192);
            this.elementHost1.TabIndex = 4;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = this.userControl11;
            // 
            // model_title_viewport
            // 
            this.model_title_viewport.AutoSize = true;
            this.model_title_viewport.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.model_title_viewport.Location = new System.Drawing.Point(3, 207);
            this.model_title_viewport.Name = "model_title_viewport";
            this.model_title_viewport.Size = new System.Drawing.Size(0, 18);
            this.model_title_viewport.TabIndex = 3;
            // 
            // DataGridView
            // 
            this.DataGridView.BackgroundColor = System.Drawing.Color.MintCream;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(423, 213);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.Size = new System.Drawing.Size(368, 225);
            this.DataGridView.TabIndex = 3;
            // 
            // SearchText
            // 
            this.SearchText.Location = new System.Drawing.Point(423, 15);
            this.SearchText.Name = "SearchText";
            this.SearchText.Size = new System.Drawing.Size(284, 20);
            this.SearchText.TabIndex = 4;
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.SearchButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.SearchButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.SearchButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Location = new System.Drawing.Point(713, 12);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 5;
            this.SearchButton.Text = "Buscar";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // UpdateModel
            // 
            this.UpdateModel.Location = new System.Drawing.Point(423, 147);
            this.UpdateModel.Name = "UpdateModel";
            this.UpdateModel.Size = new System.Drawing.Size(368, 23);
            this.UpdateModel.TabIndex = 6;
            this.UpdateModel.Text = "actualizar datos del modelo";
            this.UpdateModel.UseVisualStyleBackColor = true;
            this.UpdateModel.Click += new System.EventHandler(this.UpdateModel_Click);
            // 
            // InsertModel
            // 
            this.InsertModel.Location = new System.Drawing.Point(423, 115);
            this.InsertModel.Name = "InsertModel";
            this.InsertModel.Size = new System.Drawing.Size(368, 23);
            this.InsertModel.TabIndex = 7;
            this.InsertModel.Text = "insertar nuevo modelo";
            this.InsertModel.UseVisualStyleBackColor = true;
            this.InsertModel.Click += new System.EventHandler(this.InsertModel_Click);
            // 
            // Filters
            // 
            this.Filters.AllowDrop = true;
            this.Filters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Filters.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filters.FormattingEnabled = true;
            this.Filters.Location = new System.Drawing.Point(424, 51);
            this.Filters.Name = "Filters";
            this.Filters.Size = new System.Drawing.Size(367, 22);
            this.Filters.TabIndex = 8;
            // 
            // SaveModel
            // 
            this.SaveModel.Location = new System.Drawing.Point(420, 83);
            this.SaveModel.Name = "SaveModel";
            this.SaveModel.Size = new System.Drawing.Size(368, 23);
            this.SaveModel.TabIndex = 9;
            this.SaveModel.Text = "Guardar modelo en otro lugar";
            this.SaveModel.UseVisualStyleBackColor = true;
            this.SaveModel.Click += new System.EventHandler(this.SaveModel_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SaveModel);
            this.Controls.Add(this.Filters);
            this.Controls.Add(this.InsertModel);
            this.Controls.Add(this.UpdateModel);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchText);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DeleteModel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private WpfControlLibrary4.UserControl1 userControl1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button DeleteModel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label model_title_viewport;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.TextBox SearchText;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private WpfControlLibrary4.UserControl1 userControl11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbSize;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbDescripcion;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.RichTextBox DescriptionModel;
        private System.Windows.Forms.TextBox SizeModel;
        private System.Windows.Forms.TextBox DateModel;
        private System.Windows.Forms.TextBox NameModel;
        private System.Windows.Forms.Button UpdateModel;
        private System.Windows.Forms.Button InsertModel;
        private System.Windows.Forms.ComboBox Filters;
        private System.Windows.Forms.Button SaveModel;
        private System.Windows.Forms.TextBox extModel;
        private System.Windows.Forms.Label lbExt;
    }
}

