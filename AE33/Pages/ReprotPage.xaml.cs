using AE33.Models;

namespace AE33.Pages;

public partial class ReprotPage : ContentPage
{
    public AssignmentModels assignment;
	public ReprotPage()
	{
		InitializeComponent();
		ListView_Reprot.ItemsSource = App.assignmentRepo.GetAll();
	}
    protected override void OnAppearing()
    {
        base.OnAppearing();
        ListView_Reprot.ItemsSource = App.assignmentRepo.GetAll();
    }

  

    //private void Delete_Clicked(object sender, EventArgs e)
    //{
    //    var button = (Button)sender;
    //    assignment = (AssignmentModels)button.BindingContext;
    //    App.assignmentRepo.Delete(assignment);
    //    ListView_Reprot.ItemsSource = App.assignmentRepo.GetAll();

    //}
}