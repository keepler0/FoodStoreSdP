namespace FoodStore.Windows.UsersControls
{
	partial class ucProducto
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

		#region Código generado por el Diseñador de componentes

		/// <summary> 
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			lblAgregar = new Label();
			lblPrecioProducto = new Label();
			lblNombreProducto = new Label();
			picImagenProducto = new PictureBox();
			((System.ComponentModel.ISupportInitialize)picImagenProducto).BeginInit();
			SuspendLayout();
			// 
			// lblAgregar
			// 
			lblAgregar.AutoSize = true;
			lblAgregar.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblAgregar.Location = new Point(75, 355);
			lblAgregar.Name = "lblAgregar";
			lblAgregar.Size = new Size(134, 45);
			lblAgregar.TabIndex = 0;
			lblAgregar.Text = "Agregar";
			// 
			// lblPrecioProducto
			// 
			lblPrecioProducto.AutoSize = true;
			lblPrecioProducto.Font = new Font("Segoe UI", 10F);
			lblPrecioProducto.Location = new Point(101, 309);
			lblPrecioProducto.Name = "lblPrecioProducto";
			lblPrecioProducto.Size = new Size(66, 28);
			lblPrecioProducto.TabIndex = 0;
			lblPrecioProducto.Text = "Precio";
			// 
			// lblNombreProducto
			// 
			lblNombreProducto.AutoSize = true;
			lblNombreProducto.Font = new Font("Segoe UI", 10F);
			lblNombreProducto.Location = new Point(101, 270);
			lblNombreProducto.Name = "lblNombreProducto";
			lblNombreProducto.Size = new Size(85, 28);
			lblNombreProducto.TabIndex = 0;
			lblNombreProducto.Text = "Nombre";
			// 
			// picImagenProducto
			// 
			picImagenProducto.Location = new Point(19, 18);
			picImagenProducto.Name = "picImagenProducto";
			picImagenProducto.Size = new Size(243, 249);
			picImagenProducto.TabIndex = 1;
			picImagenProducto.TabStop = false;
			// 
			// ucProducto
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(picImagenProducto);
			Controls.Add(lblNombreProducto);
			Controls.Add(lblPrecioProducto);
			Controls.Add(lblAgregar);
			Name = "ucProducto";
			Size = new Size(283, 441);
			((System.ComponentModel.ISupportInitialize)picImagenProducto).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Label lblPrecioProducto;
		private Label lblNombreProducto;
		private PictureBox picImagenProducto;
		public Label lblAgregar;
	}
}
