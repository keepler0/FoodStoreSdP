namespace FoodStore.Windows.Forms.Categorias
{
	partial class frmCategoriasAE
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCategoriasAE));
			btnOk = new Button();
			btnCancelar = new Button();
			label1 = new Label();
			txtCategoria = new TextBox();
			SuspendLayout();
			// 
			// btnOk
			// 
			btnOk.BackgroundImage = (Image)resources.GetObject("btnOk.BackgroundImage");
			btnOk.BackgroundImageLayout = ImageLayout.Center;
			btnOk.Location = new Point(132, 76);
			btnOk.Name = "btnOk";
			btnOk.Size = new Size(71, 67);
			btnOk.TabIndex = 17;
			btnOk.UseVisualStyleBackColor = true;
			btnOk.Click += btnOk_Click;
			// 
			// btnCancelar
			// 
			btnCancelar.BackgroundImage = (Image)resources.GetObject("btnCancelar.BackgroundImage");
			btnCancelar.BackgroundImageLayout = ImageLayout.Center;
			btnCancelar.Location = new Point(209, 76);
			btnCancelar.Name = "btnCancelar";
			btnCancelar.Size = new Size(71, 67);
			btnCancelar.TabIndex = 18;
			btnCancelar.UseVisualStyleBackColor = true;
			btnCancelar.Click += btnCancelar_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 9);
			label1.Name = "label1";
			label1.Size = new Size(88, 25);
			label1.TabIndex = 16;
			label1.Text = "Categoria";
			// 
			// txtCategoria
			// 
			txtCategoria.Location = new Point(12, 39);
			txtCategoria.Name = "txtCategoria";
			txtCategoria.Size = new Size(268, 31);
			txtCategoria.TabIndex = 19;
			// 
			// frmCategoriasAE
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(301, 158);
			ControlBox = false;
			Controls.Add(txtCategoria);
			Controls.Add(btnOk);
			Controls.Add(btnCancelar);
			Controls.Add(label1);
			Name = "frmCategoriasAE";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "frmCategoriasAE";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnOk;
		private Button btnCancelar;
		private Label label1;
		private TextBox txtCategoria;
	}
}