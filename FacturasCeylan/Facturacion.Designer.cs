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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.TelLabel = new System.Windows.Forms.Label();
            this.EstadoLabel = new System.Windows.Forms.Label();
            this.DelMunLabel = new System.Windows.Forms.Label();
            this.CPLabel = new System.Windows.Forms.Label();
            this.NumIntLabel = new System.Windows.Forms.Label();
            this.NumLabel = new System.Windows.Forms.Label();
            this.CalleLabel = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ColLabel = new System.Windows.Forms.Label();
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
            this.FACTURAR = new System.Windows.Forms.Button();
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
            this.label1.Location = new System.Drawing.Point(188, 9);
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
            this.RFCdata.Size = new System.Drawing.Size(424, 29);
            this.RFCdata.TabIndex = 0;
            // 
            // search
            // 
            this.search.Image = ((System.Drawing.Image)(resources.GetObject("search.Image")));
            this.search.Location = new System.Drawing.Point(527, 52);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(111, 37);
            this.search.TabIndex = 1;
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.EmailLabel);
            this.groupBox1.Controls.Add(this.TelLabel);
            this.groupBox1.Controls.Add(this.EstadoLabel);
            this.groupBox1.Controls.Add(this.DelMunLabel);
            this.groupBox1.Controls.Add(this.CPLabel);
            this.groupBox1.Controls.Add(this.NumIntLabel);
            this.groupBox1.Controls.Add(this.NumLabel);
            this.groupBox1.Controls.Add(this.CalleLabel);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.ColLabel);
            this.groupBox1.Controls.Add(this.RFCLabel);
            this.groupBox1.Controls.Add(this.ClienteLabel);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(626, 207);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Cliente";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(426, 133);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(19, 13);
            this.EmailLabel.TabIndex = 28;
            this.EmailLabel.Text = "----";
            // 
            // TelLabel
            // 
            this.TelLabel.AutoSize = true;
            this.TelLabel.Location = new System.Drawing.Point(426, 108);
            this.TelLabel.Name = "TelLabel";
            this.TelLabel.Size = new System.Drawing.Size(19, 13);
            this.TelLabel.TabIndex = 27;
            this.TelLabel.Text = "----";
            // 
            // EstadoLabel
            // 
            this.EstadoLabel.AutoSize = true;
            this.EstadoLabel.Location = new System.Drawing.Point(426, 82);
            this.EstadoLabel.Name = "EstadoLabel";
            this.EstadoLabel.Size = new System.Drawing.Size(19, 13);
            this.EstadoLabel.TabIndex = 26;
            this.EstadoLabel.Text = "----";
            // 
            // DelMunLabel
            // 
            this.DelMunLabel.AutoSize = true;
            this.DelMunLabel.Location = new System.Drawing.Point(426, 57);
            this.DelMunLabel.Name = "DelMunLabel";
            this.DelMunLabel.Size = new System.Drawing.Size(19, 13);
            this.DelMunLabel.TabIndex = 25;
            this.DelMunLabel.Text = "----";
            // 
            // CPLabel
            // 
            this.CPLabel.AutoSize = true;
            this.CPLabel.Location = new System.Drawing.Point(426, 31);
            this.CPLabel.Name = "CPLabel";
            this.CPLabel.Size = new System.Drawing.Size(19, 13);
            this.CPLabel.TabIndex = 24;
            this.CPLabel.Text = "----";
            // 
            // NumIntLabel
            // 
            this.NumIntLabel.AutoSize = true;
            this.NumIntLabel.Location = new System.Drawing.Point(78, 157);
            this.NumIntLabel.Name = "NumIntLabel";
            this.NumIntLabel.Size = new System.Drawing.Size(19, 13);
            this.NumIntLabel.TabIndex = 23;
            this.NumIntLabel.Text = "----";
            // 
            // NumLabel
            // 
            this.NumLabel.AutoSize = true;
            this.NumLabel.Location = new System.Drawing.Point(78, 133);
            this.NumLabel.Name = "NumLabel";
            this.NumLabel.Size = new System.Drawing.Size(19, 13);
            this.NumLabel.TabIndex = 22;
            this.NumLabel.Text = "----";
            // 
            // CalleLabel
            // 
            this.CalleLabel.AutoSize = true;
            this.CalleLabel.Location = new System.Drawing.Point(78, 108);
            this.CalleLabel.Name = "CalleLabel";
            this.CalleLabel.Size = new System.Drawing.Size(19, 13);
            this.CalleLabel.TabIndex = 21;
            this.CalleLabel.Text = "----";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(292, 133);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 13);
            this.label15.TabIndex = 20;
            this.label15.Text = "Correo:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(292, 108);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 13);
            this.label14.TabIndex = 19;
            this.label14.Text = "Telefono:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(292, 82);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "Estado:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(292, 57);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Delegacion / Municipio:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(292, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Codigo Postal:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 157);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Numero Int:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Numero:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Calle:";
            // 
            // ColLabel
            // 
            this.ColLabel.AutoSize = true;
            this.ColLabel.Location = new System.Drawing.Point(78, 82);
            this.ColLabel.Name = "ColLabel";
            this.ColLabel.Size = new System.Drawing.Size(19, 13);
            this.ColLabel.TabIndex = 12;
            this.ColLabel.Text = "----";
            // 
            // RFCLabel
            // 
            this.RFCLabel.AutoSize = true;
            this.RFCLabel.Location = new System.Drawing.Point(78, 57);
            this.RFCLabel.Name = "RFCLabel";
            this.RFCLabel.Size = new System.Drawing.Size(19, 13);
            this.RFCLabel.TabIndex = 11;
            this.RFCLabel.Text = "----";
            // 
            // ClienteLabel
            // 
            this.ClienteLabel.AutoSize = true;
            this.ClienteLabel.Location = new System.Drawing.Point(78, 31);
            this.ClienteLabel.Name = "ClienteLabel";
            this.ClienteLabel.Size = new System.Drawing.Size(19, 13);
            this.ClienteLabel.TabIndex = 10;
            this.ClienteLabel.Text = "----";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Colonia:";
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
            this.AListadoArt.Location = new System.Drawing.Point(17, 428);
            this.AListadoArt.Name = "AListadoArt";
            this.AListadoArt.ReadOnly = true;
            this.AListadoArt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AListadoArt.Size = new System.Drawing.Size(621, 118);
            this.AListadoArt.TabIndex = 9;
            this.AListadoArt.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.AListadoArt_UserDeletingRow);
            // 
            // NameArt
            // 
            this.NameArt.AutoSize = true;
            this.NameArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameArt.Location = new System.Drawing.Point(13, 362);
            this.NameArt.Name = "NameArt";
            this.NameArt.Size = new System.Drawing.Size(70, 20);
            this.NameArt.TabIndex = 10;
            this.NameArt.Text = "Articulo :";
            // 
            // AArtName
            // 
            this.AArtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.AArtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AArtName.Location = new System.Drawing.Point(100, 359);
            this.AArtName.Name = "AArtName";
            this.AArtName.Size = new System.Drawing.Size(526, 26);
            this.AArtName.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 399);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Precio:";
            // 
            // APrecio
            // 
            this.APrecio.DecimalPlaces = 2;
            this.APrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.APrecio.Location = new System.Drawing.Point(100, 394);
            this.APrecio.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.APrecio.Name = "APrecio";
            this.APrecio.Size = new System.Drawing.Size(309, 26);
            this.APrecio.TabIndex = 5;
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
            this.label7.Location = new System.Drawing.Point(13, 324);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Cantidad:";
            // 
            // ACant
            // 
            this.ACant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ACant.Location = new System.Drawing.Point(98, 322);
            this.ACant.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ACant.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ACant.Name = "ACant";
            this.ACant.Size = new System.Drawing.Size(273, 26);
            this.ACant.TabIndex = 2;
            this.ACant.ThousandsSeparator = true;
            this.ACant.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // AType
            // 
            this.AType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AType.FormattingEnabled = true;
            this.AType.Items.AddRange(new object[] {
            "PZ",
            "MT",
            "KG"});
            this.AType.Location = new System.Drawing.Point(515, 320);
            this.AType.Name = "AType";
            this.AType.Size = new System.Drawing.Size(111, 28);
            this.AType.TabIndex = 3;
            // 
            // AAdd
            // 
            this.AAdd.Location = new System.Drawing.Point(509, 394);
            this.AAdd.Name = "AAdd";
            this.AAdd.Size = new System.Drawing.Size(117, 23);
            this.AAdd.TabIndex = 6;
            this.AAdd.Text = "Añadir";
            this.AAdd.UseVisualStyleBackColor = true;
            this.AAdd.Click += new System.EventHandler(this.AAdd_Click);
            // 
            // FACTURAR
            // 
            this.FACTURAR.Location = new System.Drawing.Point(357, 552);
            this.FACTURAR.Name = "FACTURAR";
            this.FACTURAR.Size = new System.Drawing.Size(285, 34);
            this.FACTURAR.TabIndex = 7;
            this.FACTURAR.Text = "FACTURAR";
            this.FACTURAR.UseVisualStyleBackColor = true;
            this.FACTURAR.Click += new System.EventHandler(this.FACTURAR_Click);
            // 
            // Facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(654, 595);
            this.Controls.Add(this.FACTURAR);
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label ClienteLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ColLabel;
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
        private System.Windows.Forms.Button FACTURAR;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label TelLabel;
        private System.Windows.Forms.Label EstadoLabel;
        private System.Windows.Forms.Label DelMunLabel;
        private System.Windows.Forms.Label CPLabel;
        private System.Windows.Forms.Label NumIntLabel;
        private System.Windows.Forms.Label NumLabel;
        private System.Windows.Forms.Label CalleLabel;
    }
}

