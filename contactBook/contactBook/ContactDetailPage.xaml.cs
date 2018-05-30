using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using contactBook.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace contactBook
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ContactDetailPage : ContentPage
	{


	    public EntryCell EntryFirst
	    {
	        get { return Fname; }
	         }
	    public EntryCell EntryLast
	    {
	        get { return Lname; }
	    }
	    public EntryCell EntryPhone
	    {
	        get { return Phone; }
	    }
	    public EntryCell EntryEmail
	    {
	        get { return Email; }
	    }
	    public SwitchCell SwitchBlocked
	    {
	        get { return Blocked; }
	    }

	    public Button ButtonSave
	    {
	        get { return BtnSave; }
	    }
		public ContactDetailPage (Contact contact=null)
		{
            
			InitializeComponent ();
		    if (contact == null)
		    {
		        return;
		    }

		    BindingContext = contact;
		}

      
    }
}