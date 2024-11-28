namespace FoodStore.Windows.Forms.Combos
{
	partial class frmManejadorDeProductos
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManejadorDeProductos));
			cbxCategoria = new ComboBox();
			label7 = new Label();
			label1 = new Label();
			cbxProductos = new ComboBox();
			btnOk = new Button();
			btnCancelar = new Button();
			nudCantidad = new NumericUpDown();
			label2 = new Label();
			((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
			SuspendLayout();
			// 
			// cbxCategoria
			// 
			cbxCategoria.BackColor = Color.FromArgb(222, 206, 5);
			cbxCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
			cbxCategoria.FormattingEnabled = true;
			cbxCategoria.Location = new Point(22, 47);
			cbxCategoria.Name = "cbxCategoria";
			cbxCategoria.Size = new Size(291, 33);
			cbxCategoria.TabIndex = 7;
			cbxCategoria.SelectedIndexChanged += cbxCategoria_SelectedIndexChanged;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.ForeColor = Color.FromArgb(222, 206, 5);
			label7.Location = new Point(22, 19);
			label7.Name = "label7";
			label7.Size = new Size(88, 25);
			label7.TabIndex = 5;
			label7.Text = "Categoria";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.ForeColor = Color.FromArgb(222, 206, 5);
			label1.Location = new Point(22, 166);
			label1.Name = "label1";
			label1.Size = new Size(83, 25);
			label1.TabIndex = 4;
			label1.Text = "Cantidad";
			// 
			// cbxProductos
			// 
			cbxProductos.BackColor = Color.FromArgb(222, 206, 5);
			cbxProductos.DropDownStyle = ComboBoxStyle.DropDownList;
			cbxProductos.FormattingEnabled = true;
			cbxProductos.Location = new Point(22, 123);
			cbxProductos.Name = "cbxProductos";
			cbxProductos.Size = new Size(291, 33);
			cbxProductos.TabIndex = 6;
			cbxProductos.SelectedIndexChanged += cbxProductos_SelectedIndexChanged;
			// 
			// btnOk
			// 
			btnOk.BackColor = Color.FromArgb(29, 30, 44);
			btnOk.FlatStyle = FlatStyle.Popup;
			btnOk.Image = (Image)resources.GetObject("btnOk.Image");
			btnOk.Location = new Point(165, 254);
			btnOk.Name = "btnOk";
			btnOk.Size = new Size(71, 67);
			btnOk.TabIndex = 35;
			btnOk.UseVisualStyleBackColor = false;
			btnOk.Click += btnOk_Click;
			// 
			// btnCancelar
			// 
			btnCancelar.BackColor = Color.FromArgb(29, 30, 44);
			btnCancelar.FlatStyle = FlatStyle.Popup;
			btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
			btnCancelar.Location = new Point(242, 254);
			btnCancelar.Name = "btnCancelar";
			btnCancelar.Size = new Size(71, 67);
			btnCancelar.TabIndex = 36;
			btnCancelar.UseVisualStyleBackColor = false;
			btnCancelar.Click += btnCancelar_Click;
			// 
			// nudCantidad
			// 
			nudCantidad.Location = new Point(111, 164);
			nudCantidad.Name = "nudCantidad";
			nudCantidad.Size = new Size(70, 31);
			nudCantidad.TabIndex = 37;
			nudCantidad.TextAlign = HorizontalAlignment.Center;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.ForeColor = Color.FromArgb(222, 206, 5);
			label2.Location = new Point(22, 95);
			label2.Name = "label2";
			label2.Size = new Size(85, 25);
			label2.TabIndex = 4;
			label2.Text = "Producto";
			// 
			// frmManejadorDeProductos
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(29, 30, 44);
			ClientSize = new Size(338, 347);
			ControlBox = false;
			Controls.Add(nudCantidad);
			Controls.Add(btnOk);
			Controls.Add(btnCancelar);
			Controls.Add(cbxProductos);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(cbxCategoria);
			Controls.Add(label7);
			Name = "frmManejadorDeProductos";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "frmManejadorDeProductos";
			((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private ComboBox cbxCategoria;
		private Label label7;
		private Label label1;
		private ComboBox cbxProductos;
		private Button btnOk;
		private Button btnCancelar;
		private NumericUpDown nudCantidad;
		private Label label2;
	}
}