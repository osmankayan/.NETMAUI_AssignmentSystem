using AE33.Models;

namespace AE33.Pages;

public partial class AssignPage : ContentPage
{
	List<AssignmentModels> assignment = new List<AssignmentModels>();
	int childID;
	int parentID;
	public AssignPage()
	{
		InitializeComponent();
		ListView_Children.ItemsSource = App.childRepo.GetAll();
		ListView_Parent.ItemsSource = App.parentRepo.GetAll();
	}
	protected override void OnAppearing()
	{
		base.OnAppearing();
        ListView_Children.ItemsSource = App.childRepo.GetAll();
        ListView_Parent.ItemsSource = App.parentRepo.GetAll();
    }

	private void ListView_Children_ItemTapped(object sender, ItemTappedEventArgs e)
	{
		var picker = (ChildModels)e.Item;
		childID = picker.C_ID;
	}

	private void ListView_Parent_ItemTapped(object sender, ItemTappedEventArgs e)
	{
		var picker=(ParentModels)e.Item;
		parentID = picker.P_ID;
	}

	private void Add_Button_Clicked(object sender, EventArgs e)
	{
		App.assignmentRepo.Add(new Models.AssignmentModels { C_ID = childID, P_ID = parentID });
		//assignment.Add(new Models.AssignmentModels { C_ID = childID, P_ID = parentID });
		
        
       

    }
}