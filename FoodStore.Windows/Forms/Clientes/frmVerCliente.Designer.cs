namespace FoodStore.Windows.Forms.Clientes
{
	partial class frmVerCliente
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
			lblNombre = new Label();
			label = new Label();
			lblDireccion = new Label();
			label5 = new Label();
			lblNumero = new Label();
			label2 = new Label();
			lblTelefono = new Label();
			lblSalir = new Label();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 9);
			label1.Name = "label1";
			label1.Size = new Size(160, 25);
			label1.TabIndex = 0;
			label1.Text = "Nombre y apellido";
			// 
			// lblNombre
			// 
			lblNombre.AutoSize = true;
			lblNombre.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblNombre.Location = new Point(70, 36);
			lblNombre.Name = "lblNombre";
			lblNombre.Size = new Size(102, 45);
			lblNombre.TabIndex = 0;
			lblNombre.Text = "label1";
			// 
			// label
			// 
			label.AutoSize = true;
			label.Location = new Point(12, 81);
			label.Name = "label";
			label.Size = new Size(85, 25);
			label.TabIndex = 0;
			label.Text = "Direccion";
			// 
			// lblDireccion
			// 
			lblDireccion.AutoSize = true;
			lblDireccion.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblDireccion.Location = new Point(70, 106);
			lblDireccion.Name = "lblDireccion";
			lblDireccion.Size = new Size(102, 45);
			lblDireccion.TabIndex = 0;
			lblDireccion.Text = "label1";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(12, 159);
			label5.Name = "label5";
			label5.Size = new Size(77, 25);
			label5.TabIndex = 0;
			label5.Text = "Numero";
			// 
			// lblNumero
			// 
			lblNumero.AutoSize = true;
			lblNumero.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblNumero.Location = new Point(70, 184);
			lblNumero.Name = "lblNumero";
			lblNumero.Size = new Size(102, 45);
			lblNumero.TabIndex = 0;
			lblNumero.Text = "label1";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(12, 237);
			label2.Name = "label2";
			label2.Size = new Size(79, 25);
			label2.TabIndex = 0;
			label2.Text = "Telefono";
			// 
			// lblTelefono
			// 
			lblTelefono.AutoSize = true;
			lblTelefono.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblTelefono.Location = new Point(70, 262);
			lblTelefono.Name = "lblTelefono";
			lblTelefono.Size = new Size(102, 45);
			lblTelefono.TabIndex = 0;
			lblTelefono.Text = "label1";
			// 
			// lblSalir
			// 
			lblSalir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			lblSalir.AutoSize = true;
			lblSalir.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblSalir.Location = new Point(520, 396);
			lblSalir.Name = "lblSalir";
			lblSalir.Size = new Size(103, 45);
			lblSalir.TabIndex = 0;
			lblSalir.Text = "SALIR";
			lblSalir.Click += lblSalir_Click;
			// 
			// frmVerCliente
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(250, 255, 145);
			ClientSize = new Size(635, 450);
			Controls.Add(lblSalir);
			Controls.Add(lblTelefono);
			Controls.Add(label2);
			Controls.Add(lblNumero);
			Controls.Add(label5);
			Controls.Add(lblDireccion);
			Controls.Add(label);
			Controls.Add(lblNombre);
			Controls.Add(label1);
			Name = "frmVerCliente";
			Text = "frmVerCliente";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label lblNombre;
		private Label label;
		private Label lblDireccion;
		private Label label5;
		private Label lblNumero;
		private Label label2;
		private Label lblTelefono;
		private Label lblSalir;
	}
}