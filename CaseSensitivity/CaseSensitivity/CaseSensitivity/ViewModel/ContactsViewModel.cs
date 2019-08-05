using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Grouping
{
    public class ContactsViewModel
    {
        #region Properties

        public ObservableCollection<Contacts> ContactsInfo { get; set; }

        public Command<object> TapCommand
        {
            get { return tapCommand; }
            set { tapCommand = value; }
        }

        #endregion

        #region Constructor

        public ContactsViewModel()
        {
            tapCommand = new Command<object>(OnTapped);
            ContactsInfo = new ObservableCollection<Contacts>(GetItems());
        }

        #endregion

        #region Methods

        public ObservableCollection<Contacts> GetItems(Contacts contacts = null)
        {
            var contactsinfo = new ObservableCollection<Contacts>();
            Random r = new Random(0123456789);
            for (int i = 0; i < CustomerNames.Count(); i++)
            {
                //if (i < 20)
                {
                    var contact = new Contacts(CustomerNames[i], r.Next(879, 987) + " - " + r.Next(78987, 99989).ToString());
                    contactsinfo.Add(contact);
                }
            }
            return contactsinfo;
        }

        private void OnTapped(object obj)
        {
            Application.Current.MainPage.DisplayAlert("FooterItem", "Tapped Item is Footer", "OK");
        }

        #endregion

        #region Fields

        Random random = new Random();
        private Command<object> tapCommand;

        string[] CustomerNames = new string[] {
            "Kyle",
            "Gina",
            "Irene",
            "kYLe",
            "KAtie",
            "ginA",
            "ireNE",
            "KaTie",
            "MichaEL",
            "MIchaEL",
            "Oscar",
            "OSCAr",
            //"Ralph",
            //"Torrey",
        };

        #endregion
    }
}

