using AE33.Models;


namespace AE33.Pages;

public partial class ChildPage : ContentPage
{
	public ChildModels child;
	string gender;
	public ChildPage()
	{
		InitializeComponent();
		childListView.ItemsSource = App.childRepo.GetAll();
	}
	protected override void OnAppearing()
	{
		base.OnAppearing();
        childListView.ItemsSource = App.childRepo.GetAll();
    }

	private void AddButton_Clicked(object sender, EventArgs e)
	{
		if (radiobutton_1.IsChecked) gender = radiobutton_1.Content.ToString();
		else gender=radiobutton2.Content.ToString();
		App.childRepo.Add(new Models.ChildModels { C_Name = childNameEntry.Text, C_L_Name = childLastNameEntry.Text ,C_Gender=gender});
        childListView.ItemsSource = App.childRepo.GetAll();
    }

	private void childListView_ItemTapped(object sender, ItemTappedEventArgs e)
	{

	}

	private void Delete_Clicked(object sender, EventArgs e)
	{
        var button = (Button)sender;
        child = (ChildModels)button.BindingContext;
        App.childRepo.Delete(child);
        childListView.ItemsSource = App.childRepo.GetAll();
    }
}