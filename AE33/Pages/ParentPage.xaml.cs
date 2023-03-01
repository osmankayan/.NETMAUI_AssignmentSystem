using AE33.Models;

namespace AE33.Pages;

public partial class ParentPage : ContentPage
{
	public ParentModels parent;
	public ParentPage()
	{
		InitializeComponent();
		parentListView.ItemsSource = App.parentRepo.GetAll();
	}
	protected override void OnAppearing()
	{
		base.OnAppearing();
        parentListView.ItemsSource = App.parentRepo.GetAll();
        
    }

	private void AddButton_Clicked(object sender, EventArgs e)
	{
		App.parentRepo.Add(new Models.ParentModels { P_Name = parentNameEntry.Text, P_L_Name = parentLastNameEntry.Text, P_Tel = telNoEntry.Text });
        parentListView.ItemsSource = App.parentRepo.GetAll();
    }

	private void parentListView_ItemTapped(object sender, ItemTappedEventArgs e)
	{

	}

	private void Delete_Clicked(object sender, EventArgs e)
	{
        var button = (Button)sender;
        parent = (ParentModels)button.BindingContext;
        App.parentRepo.Delete(parent);
        parentListView.ItemsSource = App.parentRepo.GetAll();
    }
}