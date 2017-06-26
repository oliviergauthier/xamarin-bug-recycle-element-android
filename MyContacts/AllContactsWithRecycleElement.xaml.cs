
using Xamarin.Forms;

namespace MyContacts {
    public partial class AllContactsWithRecycleElement : ContentPage {
        public AllContactsWithRecycleElement() {
            InitializeComponent();

            BindingContext = SimpsonFactory.Characters;

		}
    }
}
