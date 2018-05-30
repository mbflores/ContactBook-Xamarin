using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using contactBook.Model;

namespace contactBook.Services
{
    class Contacts
    {

        public static ObservableCollection<Contact> contacts()
        {
            return new ObservableCollection<Contact>()
            {
                new Contact{Id=1,FirstName="Mel" , 
                    LastName="Flores", Email="melbryanflores316@hotmail.com",
                    IsBlocked=true,PhoneNumber="09159893167"},
                new Contact{Id=2,FirstName="Bryan" , 
                    LastName="Flores", Email="melbryanflores316@hotmail.com",
                    IsBlocked=true,PhoneNumber="09159893167"},
                new Contact{Id=3,FirstName="Mel Bryan" , 
                    LastName="Flores", Email="melbryanflores316@hotmail.com",
                    IsBlocked=true,PhoneNumber="09159893167"},
                new Contact{Id=4,FirstName="Mel Bryan123" , 
                    LastName="Flores", Email="melbryanflores316@hotmail.com",
                    IsBlocked=true,PhoneNumber="09159893167"},

            };
        }
    }
}
