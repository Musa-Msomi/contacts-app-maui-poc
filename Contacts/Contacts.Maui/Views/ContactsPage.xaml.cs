namespace Contacts.Maui.Views;

public partial class ContactsPage : ContentPage
{
	public ContactsPage()
	{
		InitializeComponent();

        List<string> contacts = new List<string>()
    {
        "James Maddsion","David De Gea","Kevin De Bruyne", "Romelu Lukaku"
    };

        listContacts.ItemsSource = contacts;
    }


}
