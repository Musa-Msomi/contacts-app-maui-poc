namespace Contacts.Maui.Views;

public partial class ContactsPage : ContentPage
{
    public ContactsPage()
    {
        InitializeComponent();

        List<Contact> contacts = new()
    {
        new Contact { Name="James Maddsion", Email="madders@spurs.com" },
        new Contact { Name="David De Gea", Email="ddg@manutd.com" },
        new Contact { Name = "Kevin De Bruyne", Email = "kdb@mancity.com" },
        new Contact { Name = "Romelu Lukaku", Email = "rlukaku@asroma.com" },
    };

        listContacts.ItemsSource = contacts;
    }

    public class Contact
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }

    private async void listContacts_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if(listContacts.SelectedItem is not null)
        {
            // logic
            await Shell.Current.GoToAsync(nameof(EditContactPage));
        }
        

        
    }

    private void listContacts_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        // deselecting
        listContacts.SelectedItem = null;
    }
}
