using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;

namespace PDC03_MODULE2test
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class activity5 : ContentPage
	{
		ObservableCollection<employee> employees = new ObservableCollection<employee>();
		public ObservableCollection<employee> Employees {  get { return employees; } }

		public activity5 ()
		{
			InitializeComponent ();

			{

				lst.ItemsSource = employees;
				employees.Add(new employee { DisplayName = "Juan Dela Cruz", Position="President", ProfileImage ="img1.jpg"});
                employees.Add(new employee { DisplayName = "Peter", Position ="Vice President", ProfileImage ="img2.jpg" });
                employees.Add(new employee { DisplayName = "Mary", Position = "Secretary", ProfileImage ="img3.jpg" });

                wrk.ItemsSource = employees;
                employees.Add(new employee { DisplayName = "Meow", Position = "President" });
                employees.Add(new employee { DisplayName = "Woof", Position = "Vice President" });
                employees.Add(new employee { DisplayName = "Moo", Position = "Secretary"});
            }
		}
	}
}