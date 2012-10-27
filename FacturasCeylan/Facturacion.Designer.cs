namespace FacturasCeylan
{
    partial class Facturacion
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Facturacion));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RFCdata = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.Accept = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DomLabel = new System.Windows.Forms.Label();
            this.RFCLabel = new System.Windows.Forms.Label();
            this.ClienteLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AListadoArt = new System.Windows.Forms.DataGridView();
            this.NameArt = new System.Windows.Forms.Label();
            this.AArtName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.APrecio = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.ACant = new System.Windows.Forms.NumericUpDown();
            this.AType = new System.Windows.Forms.ComboBox();
            this.AAdd = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AListadoArt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.APrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ACant)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "FERRETERIA CEYLAN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "RFC:";
            // 
            // RFCdata
            // 
            this.RFCdata.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.RFCdata.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RFCdata.Location = new System.Drawing.Point(93, 57);
            this.RFCdata.MaxLength = 13;
            this.RFCdata.Name = "RFCdata";
            this.RFCdata.Size = new System.Drawing.Size(229, 29);
            this.RFCdata.TabIndex = 4;
            // 
            // search
            // 
            this.search.Image = ((System.Drawing.Image)(resources.GetObject("search.Image")));
            this.search.Location = new System.Drawing.Point(338, 52);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(48, 37);
            this.search.TabIndex = 6;
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // Accept
            // 
            this.Accept.Enabled = false;
            this.Accept.Location = new System.Drawing.Point(367, 223);
            this.Accept.Name = "Accept";
            this.Accept.Size = new System.Drawing.Size(75, 23);
            this.Accept.TabIndex = 7;
            this.Accept.Text = "Aceptar";
            this.Accept.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DomLabel);
            this.groupBox1.Controls.Add(this.RFCLabel);
            this.groupBox1.Controls.Add(this.ClienteLabel);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 118);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Cliente";
            // 
            // DomLabel
            // 
            this.DomLabel.AutoSize = true;
            this.DomLabel.Location = new System.Drawing.Point(78, 82);
            this.DomLabel.Name = "DomLabel";
            this.DomLabel.Size = new System.Drawing.Size(35, 13);
            this.DomLabel.TabIndex = 12;
            this.DomLabel.Text = "NULL";
            // 
            // RFCLabel
            // 
            this.RFCLabel.AutoSize = true;
            this.RFCLabel.Location = new System.Drawing.Point(78, 57);
            this.RFCLabel.Name = "RFCLabel";
            this.RFCLabel.Size = new System.Drawing.Size(35, 13);
            this.RFCLabel.TabIndex = 11;
            this.RFCLabel.Text = "NULL";
            // 
            // ClienteLabel
            // 
            this.ClienteLabel.AutoSize = true;
            this.ClienteLabel.Location = new System.Drawing.Point(78, 31);
            this.ClienteLabel.Name = "ClienteLabel";
            this.ClienteLabel.Size = new System.Drawing.Size(35, 13);
            this.ClienteLabel.TabIndex = 10;
            this.ClienteLabel.Text = "NULL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Domicilio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "RFC:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cliente:";
            // 
            // AListadoArt
            // 
            this.AListadoArt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AListadoArt.Location = new System.Drawing.Point(12, 429);
            this.AListadoArt.Name = "AListadoArt";
            this.AListadoArt.ReadOnly = true;
            this.AListadoArt.Size = new System.Drawing.Size(426, 192);
            this.AListadoArt.TabIndex = 9;
            // 
            // NameArt
            // 
            this.NameArt.AutoSize = true;
            this.NameArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameArt.Location = new System.Drawing.Point(8, 355);
            this.NameArt.Name = "NameArt";
            this.NameArt.Size = new System.Drawing.Size(70, 20);
            this.NameArt.TabIndex = 10;
            this.NameArt.Text = "Articulo :";
            // 
            // AArtName
            // 
            this.AArtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.AArtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AArtName.Location = new System.Drawing.Point(95, 352);
            this.AArtName.Name = "AArtName";
            this.AArtName.Size = new System.Drawing.Size(331, 26);
            this.AArtName.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 392);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Precio:";
            // 
            // APrecio
            // 
            this.APrecio.DecimalPlaces = 2;
            this.APrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.APrecio.Location = new System.Drawing.Point(95, 387);
            this.APrecio.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.APrecio.Name = "APrecio";
            this.APrecio.Size = new System.Drawing.Size(114, 26);
            this.APrecio.TabIndex = 13;
            this.APrecio.ThousandsSeparator = true;
            this.APrecio.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 317);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Cantidad:";
            // 
            // ACant
            // 
            this.ACant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ACant.Location = new System.Drawing.Point(93, 315);
            this.ACant.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ACant.Name = "ACant";
            this.ACant.Size = new System.Drawing.Size(78, 26);
            this.ACant.TabIndex = 15;
            this.ACant.ThousandsSeparator = true;
            // 
            // AType
            // 
            this.AType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AType.FormattingEnabled = true;
            this.AType.Items.AddRange(new object[] {
            "PZ",
            "MT",
            "KG"});
            this.AType.Location = new System.Drawing.Point(201, 313);
            this.AType.Name = "AType";
            this.AType.Size = new System.Drawing.Size(121, 28);
            this.AType.TabIndex = 16;
            // 
            // AAdd
            // 
            this.AAdd.Location = new System.Drawing.Point(367, 389);
            this.AAdd.Name = "AAdd";
            this.AAdd.Size = new System.Drawing.Size(75, 23);
            this.AAdd.TabIndex = 17;
            this.AAdd.Text = "Añadir";
            this.AAdd.UseVisualStyleBackColor = true;
            this.AAdd.Click += new System.EventHandler(this.AAdd_Click);
            // 
            // Facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 633);
            this.Controls.Add(this.AAdd);
            this.Controls.Add(this.AType);
            this.Controls.Add(this.ACant);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.APrecio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AArtName);
            this.Controls.Add(this.NameArt);
            this.Controls.Add(this.AListadoArt);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Accept);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RFCdata);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Facturacion";
            this.Text = "Facturacion";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AListadoArt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.APrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ACant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox RFCdata;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button Accept;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label ClienteLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label DomLabel;
        private System.Windows.Forms.Label RFCLabel;
        private System.Windows.Forms.DataGridView AListadoArt;
        private System.Windows.Forms.Label NameArt;
        private System.Windows.Forms.TextBox AArtName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown APrecio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown ACant;
        private System.Windows.Forms.ComboBox AType;
        private System.Windows.Forms.Button AAdd;
    }
}

