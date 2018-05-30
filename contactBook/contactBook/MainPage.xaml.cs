using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using contactBook.Model;
using contactBook.Services;
using Xamarin.Forms;

namespace contactBook
{
	public partial class MainPage : ContentPage
	{

	    private ObservableCollection<Contact> _contacts; 
		public MainPage()
		{
			InitializeComponent();
            _contacts = Contacts.contacts();
		    lstVIew.ItemsSource = _contacts;
		}

        private async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            var page = new ContactDetailPage();
            page.ButtonSave.Clicked +=  (s, f) =>
            {
                var contact = new Contact()
                {
                    FirstName=page.EntryFirst.Text,
                    LastName=page.EntryLast.Text,
                    PhoneNumber=page.EntryPhone.Text,
                    Email=page.EntryEmail.Text,
                    IsBlocked=page.SwitchBlocked.IsEnabled,

                };
                _contacts.Add(contact);
                Navigation.PopAsync();

            };
            await Navigation.PushAsync(page);



        }

        private async void lstVIew_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

            if (lstVIew.SelectedItem == null)
            {
                return ;
            }

            var selected = (Contact) e.SelectedItem;
            lstVIew.SelectedItem = null;
            var page = new ContactDetailPage(selected);
            
            page.ButtonSave.Clicked +=  (s, f) =>
            {
                var contact = new Contact()
                {
                    FirstName=page.EntryFirst.Text,
                    LastName=page.EntryLast.Text,
                    PhoneNumber=page.EntryPhone.Text,
                    Email=page.EntryEmail.Text,
                    IsBlocked=page.SwitchBlocked.IsEnabled,

                };                
                Navigation.PopAsync();
                
            };
            

            await Navigation.PushAsync(page);
            
        }

        private void MenuItem_Clicked(object sender, EventArgs e)
        {
            var selected = ((MenuItem)sender).CommandParameter as Contact;
            _contacts.Remove(selected);

        }
    }
}
