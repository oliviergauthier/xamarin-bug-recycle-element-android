using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MyContacts {
    public partial class MainPage : ContentPage {
        public MainPage() {
            InitializeComponent();
        }

        void Handle_WorkingClicked(object sender, System.EventArgs e) {
            Navigation.PushAsync(new AllContacts());
        }

		void Handle_NotWorkingClicked(object sender, System.EventArgs e) {
            Navigation.PushAsync(new AllContactsWithRecycleElement());
		}
    }
}
