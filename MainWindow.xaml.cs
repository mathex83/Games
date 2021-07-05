using System.Windows;
using System.Windows.Controls;

namespace Diablo3
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			foreach (TextBox tb in gemGrid.Children)
			{
				tb.AddHandler(LostFocusEvent, new RoutedEventHandler(UpdateTbs));
			}
		}

		private void UpdateTbs(object sender, RoutedEventArgs e)
		{
			TextBox tb = sender as TextBox;
			switch (tb.Name)
			{
				case "b1":
					b2.Text = (int.Parse(b1.Text) * 3).ToString();
					b3.Text = (int.Parse(b2.Text) * 3).ToString();
					b4.Text = (int.Parse(b3.Text) * 3).ToString();
					b5.Text = (int.Parse(b4.Text) * 3).ToString();
					b6.Text = (int.Parse(b5.Text) * 3).ToString();
					b7.Text = (int.Parse(b6.Text) * 3).ToString();
					b8.Text = (int.Parse(b7.Text) * 3).ToString();
					b9.Text = (int.Parse(b8.Text) * 3).ToString();
					break;
				case "b2":
					b1.Text = (int.Parse(b2.Text) / 3).ToString();
					b3.Text = (int.Parse(b2.Text) * 3).ToString();
					b4.Text = (int.Parse(b3.Text) * 3).ToString();
					b5.Text = (int.Parse(b4.Text) * 3).ToString();
					b6.Text = (int.Parse(b5.Text) * 3).ToString();
					b7.Text = (int.Parse(b6.Text) * 3).ToString();
					b8.Text = (int.Parse(b7.Text) * 3).ToString();
					b9.Text = (int.Parse(b8.Text) * 3).ToString();
					break;
				case "b3":
					b2.Text = (int.Parse(b3.Text) / 3).ToString();
					b1.Text = (int.Parse(b2.Text) / 3).ToString();
					b4.Text = (int.Parse(b3.Text) * 3).ToString();
					b5.Text = (int.Parse(b4.Text) * 3).ToString();
					b6.Text = (int.Parse(b5.Text) * 3).ToString();
					b7.Text = (int.Parse(b6.Text) * 3).ToString();
					b8.Text = (int.Parse(b7.Text) * 3).ToString();
					b9.Text = (int.Parse(b8.Text) * 3).ToString();
					break;
				case "b4":
					b3.Text = (int.Parse(b4.Text) / 3).ToString();
					b2.Text = (int.Parse(b3.Text) / 3).ToString();
					b1.Text = (int.Parse(b2.Text) / 3).ToString();
					b5.Text = (int.Parse(b4.Text) * 3).ToString();
					b6.Text = (int.Parse(b5.Text) * 3).ToString();
					b7.Text = (int.Parse(b6.Text) * 3).ToString();
					b8.Text = (int.Parse(b7.Text) * 3).ToString();
					b9.Text = (int.Parse(b8.Text) * 3).ToString();
					break;
				case "b5":
					b4.Text = (int.Parse(b5.Text) / 3).ToString();
					b3.Text = (int.Parse(b4.Text) / 3).ToString();
					b2.Text = (int.Parse(b3.Text) / 3).ToString();
					b1.Text = (int.Parse(b2.Text) / 3).ToString();
					b6.Text = (int.Parse(b5.Text) * 3).ToString();
					b7.Text = (int.Parse(b6.Text) * 3).ToString();
					b8.Text = (int.Parse(b7.Text) * 3).ToString();
					b9.Text = (int.Parse(b8.Text) * 3).ToString();
					break;
				case "b6":
					b5.Text = (int.Parse(b6.Text) / 3).ToString();
					b4.Text = (int.Parse(b5.Text) / 3).ToString();
					b3.Text = (int.Parse(b4.Text) / 3).ToString();
					b2.Text = (int.Parse(b3.Text) / 3).ToString();
					b1.Text = (int.Parse(b2.Text) / 3).ToString();					
					b7.Text = (int.Parse(b6.Text) * 3).ToString();
					b8.Text = (int.Parse(b7.Text) * 3).ToString();
					b9.Text = (int.Parse(b8.Text) * 3).ToString();
					break;
				case "b7":
					b6.Text = (int.Parse(b7.Text) / 3).ToString();
					b5.Text = (int.Parse(b6.Text) / 3).ToString();
					b4.Text = (int.Parse(b5.Text) / 3).ToString();
					b3.Text = (int.Parse(b4.Text) / 3).ToString();
					b2.Text = (int.Parse(b3.Text) / 3).ToString();
					b1.Text = (int.Parse(b2.Text) / 3).ToString();
					b8.Text = (int.Parse(b7.Text) * 3).ToString();
					b9.Text = (int.Parse(b8.Text) * 3).ToString();
					break;
				case "b8":
					b7.Text = (int.Parse(b8.Text) / 3).ToString();
					b6.Text = (int.Parse(b7.Text) / 3).ToString();
					b5.Text = (int.Parse(b6.Text) / 3).ToString();
					b4.Text = (int.Parse(b5.Text) / 3).ToString();
					b3.Text = (int.Parse(b4.Text) / 3).ToString();
					b2.Text = (int.Parse(b3.Text) / 3).ToString();
					b1.Text = (int.Parse(b2.Text) / 3).ToString();
					b9.Text = (int.Parse(b8.Text) * 3).ToString();
					break;
				case "b9":
					b8.Text = (int.Parse(b9.Text) / 3).ToString();
					b7.Text = (int.Parse(b8.Text) / 3).ToString();
					b6.Text = (int.Parse(b7.Text) / 3).ToString();
					b5.Text = (int.Parse(b6.Text) / 3).ToString();
					b4.Text = (int.Parse(b5.Text) / 3).ToString();
					b3.Text = (int.Parse(b4.Text) / 3).ToString();
					b2.Text = (int.Parse(b3.Text) / 3).ToString();
					b1.Text = (int.Parse(b2.Text) / 3).ToString();
					break;
			}
		}
	}
}
