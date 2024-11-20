namespace FoodStore.Windows.Forms
{
	partial class frmPrincipal
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
			btnPaises = new Button();
			btnprovincias = new Button();
			btnLocalidades = new Button();
			btnEmpleado = new Button();
			btnCategorias = new Button();
			btnSubCategorias = new Button();
			btnEmpresas = new Button();
			button1 = new Button();
			btnProductos = new Button();
			SuspendLayout();
			// 
			// btnPaises
			// 
			btnPaises.Location = new Point(12, 12);
			btnPaises.Name = "btnPaises";
			btnPaises.Size = new Size(112, 34);
			btnPaises.TabIndex = 0;
			btnPaises.Text = "pais";
			btnPaises.UseVisualStyleBackColor = true;
			btnPaises.Click += btnPaises_Click;
			// 
			// btnprovincias
			// 
			btnprovincias.Location = new Point(12, 52);
			btnprovincias.Name = "btnprovincias";
			btnprovincias.Size = new Size(112, 34);
			btnprovincias.TabIndex = 0;
			btnprovincias.Text = "Provincias";
			btnprovincias.UseVisualStyleBackColor = true;
			btnprovincias.Click += btnprovincias_Click;
			// 
			// btnLocalidades
			// 
			btnLocalidades.Location = new Point(12, 92);
			btnLocalidades.Name = "btnLocalidades";
			btnLocalidades.Size = new Size(112, 34);
			btnLocalidades.TabIndex = 0;
			btnLocalidades.Text = "Localidades";
			btnLocalidades.UseVisualStyleBackColor = true;
			btnLocalidades.Click += btnLocalidades_Click;
			// 
			// btnEmpleado
			// 
			btnEmpleado.Location = new Point(12, 132);
			btnEmpleado.Name = "btnEmpleado";
			btnEmpleado.Size = new Size(112, 34);
			btnEmpleado.TabIndex = 0;
			btnEmpleado.Text = "Empleados";
			btnEmpleado.UseVisualStyleBackColor = true;
			btnEmpleado.Click += btnEmpleado_Click;
			// 
			// btnCategorias
			// 
			btnCategorias.Location = new Point(12, 172);
			btnCategorias.Name = "btnCategorias";
			btnCategorias.Size = new Size(112, 34);
			btnCategorias.TabIndex = 0;
			btnCategorias.Text = "Categorias";
			btnCategorias.UseVisualStyleBackColor = true;
			btnCategorias.Click += btnCategorias_Click;
			// 
			// btnSubCategorias
			// 
			btnSubCategorias.Location = new Point(12, 212);
			btnSubCategorias.Name = "btnSubCategorias";
			btnSubCategorias.Size = new Size(112, 34);
			btnSubCategorias.TabIndex = 0;
			btnSubCategorias.Text = "sub-categorias";
			btnSubCategorias.UseVisualStyleBackColor = true;
			btnSubCategorias.Click += btnSubCategorias_Click;
			// 
			// btnEmpresas
			// 
			btnEmpresas.Location = new Point(12, 252);
			btnEmpresas.Name = "btnEmpresas";
			btnEmpresas.Size = new Size(112, 34);
			btnEmpresas.TabIndex = 0;
			btnEmpresas.Text = "Empresas";
			btnEmpresas.UseVisualStyleBackColor = true;
			btnEmpresas.Click += btnEmpresas_Click;
			// 
			// button1
			// 
			button1.Location = new Point(12, 292);
			button1.Name = "button1";
			button1.Size = new Size(112, 34);
			button1.TabIndex = 0;
			button1.Text = "Clientes";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// btnProductos
			// 
			btnProductos.Location = new Point(12, 332);
			btnProductos.Name = "btnProductos";
			btnProductos.Size = new Size(112, 34);
			btnProductos.TabIndex = 0;
			btnProductos.Text = "Inventario";
			btnProductos.UseVisualStyleBackColor = true;
			btnProductos.Click += btnProductos_Click;
			// 
			// frmPrincipal
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(btnLocalidades);
			Controls.Add(btnprovincias);
			Controls.Add(btnProductos);
			Controls.Add(button1);
			Controls.Add(btnEmpresas);
			Controls.Add(btnSubCategorias);
			Controls.Add(btnCategorias);
			Controls.Add(btnEmpleado);
			Controls.Add(btnPaises);
			Name = "frmPrincipal";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "frmPrincipal";
			ResumeLayout(false);
		}

		#endregion

		private Button btnPaises;
		private Button btnprovincias;
		private Button btnLocalidades;
		private Button btnEmpleado;
		private Button btnCategorias;
		private Button btnSubCategorias;
		private Button btnEmpresas;
		private Button button1;
		private Button btnProductos;
	}
}