

namespace FoodStore.Windows.Helpers
{
	public static class MessageHelper
	{
		public static void Error(string m)
		{
			MessageBox.Show(m, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		internal static void Information(string v)
		{
			MessageBox.Show(v, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		public static DialogResult Question(string v)
		{
			return MessageBox.Show(v, "Confirmar",
				   MessageBoxButtons.YesNo,
				   MessageBoxIcon.Question,
				   MessageBoxDefaultButton.Button2);
		}
	}
}
