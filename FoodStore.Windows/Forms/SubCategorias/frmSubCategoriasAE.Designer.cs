namespace FoodStore.Windows.Forms.SubCategorias
{
	partial class frmSubCategoriasAE
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
			cbxCategorias = new ComboBox();
			btnAgregarCategoria = new Button();
			btnOk = new Button();
			btnCancelar = new Button();
			label2 = new Label();
			label1 = new Label();
			tbxSubCategoria = new TextBox();
			SuspendLayout();
			// 
			// cbxCategorias
			// 
			cbxCategorias.DropDownStyle = ComboBoxStyle.DropDownList;
			cbxCategorias.FormattingEnabled = true;
			cbxCategorias.Location = new Point(12, 37);
			cbxCategorias.Name = "cbxCategorias";
			cbxCategorias.Size = new Size(268, 33);
			cbxCategorias.TabIndex = 14;
			cbxCategorias.SelectedIndexChanged += cbxCategorias_SelectedIndexChanged;
			// 
			// btnAgregarCategoria
			// 
			btnAgregarCategoria.Location = new Point(286, 37);
			btnAgregarCategoria.Name = "btnAgregarCategoria";
			btnAgregarCategoria.Size = new Size(40, 33);
			btnAgregarCategoria.TabIndex = 11;
			btnAgregarCategoria.UseVisualStyleBackColor = true;
			btnAgregarCategoria.Click += btnAgregarCategoria_Click;
			// 
			// btnOk
			// 
			btnOk.Location = new Point(132, 138);
			btnOk.Name = "btnOk";
			btnOk.Size = new Size(71, 67);
			btnOk.TabIndex = 12;
			btnOk.Text = "Ok";
			btnOk.UseVisualStyleBackColor = true;
			btnOk.Click += btnOk_Click;
			// 
			// btnCancelar
			// 
			btnCancelar.Location = new Point(209, 138);
			btnCancelar.Name = "btnCancelar";
			btnCancelar.Size = new Size(71, 67);
			btnCancelar.TabIndex = 13;
			btnCancelar.Text = "Cancelar";
			btnCancelar.UseVisualStyleBackColor = true;
			btnCancelar.Click += btnCancelar_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(12, 73);
			label2.Name = "label2";
			label2.Size = new Size(116, 25);
			label2.TabIndex = 9;
			label2.Text = "Subcategoria";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 9);
			label1.Name = "label1";
			label1.Size = new Size(88, 25);
			label1.TabIndex = 10;
			label1.Text = "Categoria";
			// 
			// tbxSubCategoria
			// 
			tbxSubCategoria.Location = new Point(12, 101);
			tbxSubCategoria.Name = "tbxSubCategoria";
			tbxSubCategoria.Size = new Size(268, 31);
			tbxSubCategoria.TabIndex = 8;
			// 
			// frmSubCategoriasAE
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(250, 255, 145);
			ClientSize = new Size(338, 221);
			ControlBox = false;
			Controls.Add(cbxCategorias);
			Controls.Add(btnAgregarCategoria);
			Controls.Add(btnOk);
			Controls.Add(btnCancelar);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(tbxSubCategoria);
			MaximumSize = new Size(360, 277);
			MinimumSize = new Size(360, 277);
			Name = "frmSubCategoriasAE";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "frmSubCategoriasAE";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ComboBox cbxCategorias;
		private Button btnAgregarCategoria;
		private Button btnOk;
		private Button btnCancelar;
		private Label label2;
		private Label label1;
		private TextBox tbxSubCategoria;
	}
}