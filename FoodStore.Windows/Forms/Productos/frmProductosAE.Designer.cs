namespace FoodStore.Windows.Forms.Productos
{
	partial class frmProductosAE
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductosAE));
			picImagen = new PictureBox();
			tbxMarca = new TextBox();
			label1 = new Label();
			tbxDescripcion = new TextBox();
			label2 = new Label();
			tbxStock = new TextBox();
			label3 = new Label();
			tbxStockMin = new TextBox();
			label4 = new Label();
			tbxPrecioUnitario = new TextBox();
			label5 = new Label();
			tbxPrecioFinal = new TextBox();
			label6 = new Label();
			cbxCategoria = new ComboBox();
			label7 = new Label();
			label8 = new Label();
			cbxSubCategoria = new ComboBox();
			dateTimePicker = new DateTimePicker();
			label9 = new Label();
			label10 = new Label();
			tbxCodigo = new TextBox();
			btnOk = new Button();
			btnCancelar = new Button();
			button1 = new Button();
			openFileDialog1 = new OpenFileDialog();
			label11 = new Label();
			label12 = new Label();
			((System.ComponentModel.ISupportInitialize)picImagen).BeginInit();
			SuspendLayout();
			// 
			// picImagen
			// 
			picImagen.Location = new Point(461, 12);
			picImagen.Name = "picImagen";
			picImagen.Size = new Size(432, 430);
			picImagen.SizeMode = PictureBoxSizeMode.StretchImage;
			picImagen.TabIndex = 0;
			picImagen.TabStop = false;
			// 
			// tbxMarca
			// 
			tbxMarca.BackColor = Color.FromArgb(222, 206, 5);
			tbxMarca.BorderStyle = BorderStyle.None;
			tbxMarca.Location = new Point(12, 37);
			tbxMarca.Name = "tbxMarca";
			tbxMarca.Size = new Size(183, 24);
			tbxMarca.TabIndex = 1;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.ForeColor = Color.White;
			label1.Location = new Point(12, 9);
			label1.Name = "label1";
			label1.Size = new Size(60, 25);
			label1.TabIndex = 2;
			label1.Text = "Marca";
			// 
			// tbxDescripcion
			// 
			tbxDescripcion.BackColor = Color.FromArgb(222, 206, 5);
			tbxDescripcion.BorderStyle = BorderStyle.None;
			tbxDescripcion.Location = new Point(12, 99);
			tbxDescripcion.Name = "tbxDescripcion";
			tbxDescripcion.Size = new Size(376, 24);
			tbxDescripcion.TabIndex = 1;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.ForeColor = Color.White;
			label2.Location = new Point(12, 71);
			label2.Name = "label2";
			label2.Size = new Size(104, 25);
			label2.TabIndex = 2;
			label2.Text = "Descripcion";
			// 
			// tbxStock
			// 
			tbxStock.BackColor = Color.FromArgb(222, 206, 5);
			tbxStock.BorderStyle = BorderStyle.None;
			tbxStock.Location = new Point(12, 225);
			tbxStock.Name = "tbxStock";
			tbxStock.Size = new Size(121, 24);
			tbxStock.TabIndex = 1;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.ForeColor = Color.White;
			label3.Location = new Point(12, 197);
			label3.Name = "label3";
			label3.Size = new Size(55, 25);
			label3.TabIndex = 2;
			label3.Text = "Stock";
			// 
			// tbxStockMin
			// 
			tbxStockMin.BackColor = Color.FromArgb(222, 206, 5);
			tbxStockMin.BorderStyle = BorderStyle.None;
			tbxStockMin.Location = new Point(206, 225);
			tbxStockMin.Name = "tbxStockMin";
			tbxStockMin.Size = new Size(121, 24);
			tbxStockMin.TabIndex = 1;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.ForeColor = Color.White;
			label4.Location = new Point(206, 197);
			label4.Name = "label4";
			label4.Size = new Size(121, 25);
			label4.TabIndex = 2;
			label4.Text = "Stock minimo";
			// 
			// tbxPrecioUnitario
			// 
			tbxPrecioUnitario.BackColor = Color.FromArgb(222, 206, 5);
			tbxPrecioUnitario.BorderStyle = BorderStyle.None;
			tbxPrecioUnitario.Location = new Point(40, 287);
			tbxPrecioUnitario.Name = "tbxPrecioUnitario";
			tbxPrecioUnitario.Size = new Size(121, 24);
			tbxPrecioUnitario.TabIndex = 1;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.ForeColor = Color.White;
			label5.Location = new Point(12, 259);
			label5.Name = "label5";
			label5.Size = new Size(125, 25);
			label5.TabIndex = 2;
			label5.Text = "Precio unitario";
			// 
			// tbxPrecioFinal
			// 
			tbxPrecioFinal.BackColor = Color.FromArgb(222, 206, 5);
			tbxPrecioFinal.BorderStyle = BorderStyle.None;
			tbxPrecioFinal.Location = new Point(206, 287);
			tbxPrecioFinal.Name = "tbxPrecioFinal";
			tbxPrecioFinal.Size = new Size(121, 24);
			tbxPrecioFinal.TabIndex = 1;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.ForeColor = Color.White;
			label6.Location = new Point(206, 259);
			label6.Name = "label6";
			label6.Size = new Size(98, 25);
			label6.TabIndex = 2;
			label6.Text = "Precio final";
			// 
			// cbxCategoria
			// 
			cbxCategoria.BackColor = Color.FromArgb(222, 206, 5);
			cbxCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
			cbxCategoria.FormattingEnabled = true;
			cbxCategoria.Location = new Point(12, 161);
			cbxCategoria.Name = "cbxCategoria";
			cbxCategoria.Size = new Size(182, 33);
			cbxCategoria.TabIndex = 3;
			cbxCategoria.SelectedIndexChanged += cbxCategoria_SelectedIndexChanged;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.ForeColor = Color.White;
			label7.Location = new Point(12, 133);
			label7.Name = "label7";
			label7.Size = new Size(88, 25);
			label7.TabIndex = 2;
			label7.Text = "Categoria";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.ForeColor = Color.White;
			label8.Location = new Point(206, 133);
			label8.Name = "label8";
			label8.Size = new Size(126, 25);
			label8.TabIndex = 2;
			label8.Text = "Sub-Categoria";
			// 
			// cbxSubCategoria
			// 
			cbxSubCategoria.BackColor = Color.FromArgb(222, 206, 5);
			cbxSubCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
			cbxSubCategoria.FormattingEnabled = true;
			cbxSubCategoria.Location = new Point(206, 161);
			cbxSubCategoria.Name = "cbxSubCategoria";
			cbxSubCategoria.Size = new Size(182, 33);
			cbxSubCategoria.TabIndex = 3;
			cbxSubCategoria.SelectedIndexChanged += cbxSubCategoria_SelectedIndexChanged;
			// 
			// dateTimePicker
			// 
			dateTimePicker.CalendarFont = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
			dateTimePicker.Format = DateTimePickerFormat.Short;
			dateTimePicker.Location = new Point(12, 349);
			dateTimePicker.Name = "dateTimePicker";
			dateTimePicker.Size = new Size(315, 31);
			dateTimePicker.TabIndex = 4;
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.ForeColor = Color.White;
			label9.Location = new Point(12, 321);
			label9.Name = "label9";
			label9.Size = new Size(183, 25);
			label9.TabIndex = 2;
			label9.Text = "Fecha de vencimiento";
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.ForeColor = Color.White;
			label10.Location = new Point(12, 383);
			label10.Name = "label10";
			label10.Size = new Size(71, 25);
			label10.TabIndex = 6;
			label10.Text = "Codigo";
			// 
			// tbxCodigo
			// 
			tbxCodigo.BackColor = Color.FromArgb(222, 206, 5);
			tbxCodigo.BorderStyle = BorderStyle.None;
			tbxCodigo.Location = new Point(12, 411);
			tbxCodigo.Name = "tbxCodigo";
			tbxCodigo.Size = new Size(183, 24);
			tbxCodigo.TabIndex = 5;
			// 
			// btnOk
			// 
			btnOk.BackColor = Color.FromArgb(29, 30, 44);
			btnOk.FlatStyle = FlatStyle.Popup;
			btnOk.Image = (Image)resources.GetObject("btnOk.Image");
			btnOk.Location = new Point(739, 499);
			btnOk.Name = "btnOk";
			btnOk.Size = new Size(71, 67);
			btnOk.TabIndex = 7;
			btnOk.UseVisualStyleBackColor = false;
			btnOk.Click += btnOk_Click;
			// 
			// btnCancelar
			// 
			btnCancelar.BackColor = Color.FromArgb(29, 30, 44);
			btnCancelar.FlatStyle = FlatStyle.Popup;
			btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
			btnCancelar.Location = new Point(816, 499);
			btnCancelar.Name = "btnCancelar";
			btnCancelar.Size = new Size(71, 67);
			btnCancelar.TabIndex = 8;
			btnCancelar.UseVisualStyleBackColor = false;
			btnCancelar.Click += btnCancelar_Click;
			// 
			// button1
			// 
			button1.BackColor = Color.FromArgb(222, 206, 5);
			button1.FlatStyle = FlatStyle.Flat;
			button1.Location = new Point(461, 448);
			button1.Name = "button1";
			button1.Size = new Size(432, 33);
			button1.TabIndex = 7;
			button1.Text = "Buscar";
			button1.TextAlign = ContentAlignment.TopCenter;
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// openFileDialog1
			// 
			openFileDialog1.FileName = "openFileDialog1";
			// 
			// label11
			// 
			label11.AutoSize = true;
			label11.ForeColor = Color.White;
			label11.Location = new Point(12, 290);
			label11.Name = "label11";
			label11.Size = new Size(22, 25);
			label11.TabIndex = 2;
			label11.Text = "$";
			// 
			// label12
			// 
			label12.AutoSize = true;
			label12.ForeColor = Color.White;
			label12.Location = new Point(178, 290);
			label12.Name = "label12";
			label12.Size = new Size(22, 25);
			label12.TabIndex = 2;
			label12.Text = "$";
			// 
			// frmProductosAE
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(29, 30, 44);
			ClientSize = new Size(899, 578);
			Controls.Add(button1);
			Controls.Add(btnOk);
			Controls.Add(btnCancelar);
			Controls.Add(label10);
			Controls.Add(tbxCodigo);
			Controls.Add(dateTimePicker);
			Controls.Add(cbxSubCategoria);
			Controls.Add(cbxCategoria);
			Controls.Add(label8);
			Controls.Add(label9);
			Controls.Add(label12);
			Controls.Add(label11);
			Controls.Add(label6);
			Controls.Add(label7);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(tbxPrecioFinal);
			Controls.Add(label3);
			Controls.Add(tbxPrecioUnitario);
			Controls.Add(label2);
			Controls.Add(tbxStockMin);
			Controls.Add(label1);
			Controls.Add(tbxStock);
			Controls.Add(tbxDescripcion);
			Controls.Add(tbxMarca);
			Controls.Add(picImagen);
			MaximumSize = new Size(921, 634);
			MinimumSize = new Size(921, 634);
			Name = "frmProductosAE";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "frmProductosAE";
			((System.ComponentModel.ISupportInitialize)picImagen).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private PictureBox picImagen;
		private TextBox tbxMarca;
		private Label label1;
		private TextBox tbxDescripcion;
		private Label label2;
		private TextBox tbxStock;
		private Label label3;
		private TextBox tbxStockMin;
		private Label label4;
		private TextBox tbxPrecioUnitario;
		private Label label5;
		private TextBox tbxPrecioFinal;
		private Label label6;
		private ComboBox cbxCategoria;
		private Label label7;
		private Label label8;
		private ComboBox cbxSubCategoria;
		private DateTimePicker dateTimePicker;
		private Label label9;
		private Label label10;
		private TextBox tbxCodigo;
		private Button btnOk;
		private Button btnCancelar;
		private Button button1;
		private OpenFileDialog openFileDialog1;
		private Label label11;
		private Label label12;
	}
}