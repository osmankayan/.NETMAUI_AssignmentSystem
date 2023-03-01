using AE33.DataTransActions;
using AE33.Models;

namespace AE33;

public partial class App : Application
{
	public static BaseRepository<ChildModels> childRepo;
	public static BaseRepository<ParentModels> parentRepo;
	public static BaseRepository<AssignmentModels> assignmentRepo;
	public App(BaseRepository<ChildModels> child, BaseRepository<ParentModels> parent, BaseRepository<AssignmentModels> assignment)
	{
		InitializeComponent();
		childRepo = child;
		parentRepo = parent;
		assignmentRepo = assignment;

		MainPage = new AppShell();
	}
}
