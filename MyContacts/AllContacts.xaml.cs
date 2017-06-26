using Xamarin.Forms;

namespace MyContacts {
    public partial class AllContacts : ContentPage {

        public AllContacts() {
            InitializeComponent();

            BindingContext = SimpsonFactory.Characters;

        }

    }
}
