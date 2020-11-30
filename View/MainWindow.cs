using System;
using Gtk;
using projekt;
using System.Collections.Generic;


	public partial class MainWindow : Gtk.Window
	{
		
		PlayerNodeStore playerPresenter = new PlayerNodeStore();
		TrainingNodeStore trainingPresenter = new TrainingNodeStore();
		NotificationNodeStore notification = new NotificationNodeStore();	

		public MainWindow() : base(Gtk.WindowType.Toplevel)
		{
			Build();
			this.DeleteEvent += this.OnDeleteEvent;
			UpdateCombobox(null,null);


			/*Player -> Edit player VIEW - Node Store*/
			
			playerPresenter.Dodaj(DB.ReturnPlayers());
			nodeview1.NodeStore = playerPresenter;
			nodeview1.AppendColumn("Name", new Gtk.CellRendererText(), "text", 0);
			nodeview1.AppendColumn("Lastname", new Gtk.CellRendererText(), "text", 1);
			nodeview1.AppendColumn("Phone", new Gtk.CellRendererText(), "text", 2);
			nodeview1.AppendColumn("Date of Birth", new Gtk.CellRendererText(), "text", 3);
			nodeview1.AppendColumn("Adress", new Gtk.CellRendererText(), "text", 4);
			
			/***END***/
			
			/*Seasson -> Start season VIEW - Node Store*/
			nodeview2.NodeStore = playerPresenter;
			nodeview2.AppendColumn("Name", new Gtk.CellRendererText(), "text", 0);
			nodeview2.AppendColumn("Lastname", new Gtk.CellRendererText(), "text", 1);
			
			/***END***/

			/*Seasson -> Edit season VIEW - Node Store*/
			nodeview4.NodeStore = playerPresenter;
			nodeview4.AppendColumn("Name", new Gtk.CellRendererText(), "text", 0);
			nodeview4.AppendColumn("Lastname", new Gtk.CellRendererText(), "text", 1);
			//nodeview4.NodeSelection.Changed += this.RowSelected4;
			/***END***/


			/*Training -> New Training*/
			nodeview6.AppendColumn("Name", new Gtk.CellRendererText(), "text", 0);
			nodeview6.AppendColumn("Lastname", new Gtk.CellRendererText(), "text", 1);
			

			nodeview7.NodeStore = trainingPresenter;
			nodeview7.AppendColumn("Date", new Gtk.CellRendererText(), "text", 0);
			nodeview7.AppendColumn("Type of training", new Gtk.CellRendererText(), "text", 1);
			nodeview7.AppendColumn("Duration", new Gtk.CellRendererText(), "text",2);
			/***END***/


			/*Notifications -> View*/
			
			nodeview8.NodeStore = notification;
			nodeview8.AppendColumn("List of notifications", new Gtk.CellRendererText(), "text", 0);
			/***END***/


			/*Records of presence -> View*/
			
			nodeview3.AppendColumn("Name", new Gtk.CellRendererText(), "text", 0);
			nodeview3.AppendColumn("Lastname", new Gtk.CellRendererText(), "text", 1);
			nodeview3.AppendColumn("Phone", new Gtk.CellRendererText(), "text", 2);
			nodeview3.AppendColumn("Date of Birth", new Gtk.CellRendererText(), "text", 3);
			nodeview3.AppendColumn("Adress", new Gtk.CellRendererText(), "text", 4);
			
			
			//MainWindow()  **END**
	}
		
		//default metoda
		protected void OnDeleteEvent(object sender, DeleteEventArgs a)
		{
			Application.Quit();
			a.RetVal = true;
		}


		//File->Exit
		protected void OnExit(object sender, EventArgs e)
		{
			Application.Quit();
		}









		

		/*Player->New player (tab1) VIEW*/
		protected void OnNewPlayer(object sender, EventArgs e)
		{
			notebook1.CurrentPage = 1;
			this.Title = "Add new player";

		}
		protected void OnSavePlayer(object sender, EventArgs e)
		{

			
			if (entry1.Text != "" && entry3.Text != "" && entry5.Text != "" && entry2.Text != "" && entry5.Text != ""){
				Player player = new Player(entry1.Text, entry3.Text, entry5.Text,Convert.ToDateTime(entry2.Text),entry4.Text,Convert.ToBoolean(0));
				DB.SavePlayer(player);
				
				nodeview6.NodeSelection.Changed -= this.OnRowSelected3;
				DB.UpdatePlayersInSeasson(nodeview1);
				nodeview6.NodeSelection.Changed += this.OnRowSelected3;


				Dialog dialog = new Gtk.MessageDialog(this, DialogFlags.Modal, MessageType.Info, ButtonsType.Ok, "Data saved!                                    ");
				dialog.Run();
				dialog.Destroy();
			}

			else {
				Dialog dialog = new Gtk.MessageDialog(this, DialogFlags.Modal, MessageType.Warning, ButtonsType.Ok, "Please insert the data!");
				dialog.Run();
				dialog.Destroy();
			}
			
			
		}

		/***END***/









		/* New player -> Edit player*/
		protected void OnEditPlayer(object sender, EventArgs e)
		{
			notebook1.CurrentPage = 2;
			this.Title = "Edit player";
			
			
		}

		protected void OnClickDelete(object sender, EventArgs args) { 
			var selectedPlayer = (PlayerNode)nodeview1.NodeSelection.SelectedNode;
			
			Dialog dialog = new Gtk.MessageDialog(this, DialogFlags.Modal, MessageType.Warning, ButtonsType.OkCancel, "You will delete selected record.Are you sure?");
			ResponseType response = (ResponseType)dialog.Run();
			if (response == ResponseType.Ok)
			{
				DB.DeletePlayer(selectedPlayer.name, selectedPlayer.lastname, selectedPlayer.phone);
				dialog.Destroy();

				nodeview6.NodeSelection.Changed -= this.OnRowSelected3;
				DB.UpdatePlayersInSeasson(nodeview1);
				nodeview6.NodeSelection.Changed += this.OnRowSelected3;
			}
			else
			{
				dialog.Destroy();
			}
			
			
		}
		protected void OnButtonUpdate(object sender, EventArgs e)
		{
			var selectedPlayer = (PlayerNode)nodeview1.NodeSelection.SelectedNode;
			if (selectedPlayer==null){
				Dialog dialog = new Gtk.MessageDialog(this, DialogFlags.Modal, MessageType.Info, ButtonsType.Ok, "Please select row for Update.");
				dialog.Run();
				dialog.Destroy();
			}
			else { 
				EditPlayerUpdateWindow window = new EditPlayerUpdateWindow(nodeview1, selectedPlayer.name, selectedPlayer.lastname, selectedPlayer.phone, selectedPlayer.dateOfBirth, selectedPlayer.adress);
			}
		}
		
		/*** END ***/













		/* Seasson -> Start seasson*/
		protected void OnSeasonStart(object sender, EventArgs e)
		{
			notebook1.CurrentPage = 3;
			this.Title = "Start season";
			nodeview2.NodeSelection.Changed -= this.RowSelected2;
			DB.UpdatePlayersInSeasson(nodeview2);
			nodeview2.NodeSelection.Changed += this.RowSelected2;
			
		}
		protected void OnSaveSeasson(object sender, EventArgs e)
		{
		if (entry7.Text!="" && entry9.Text!="" && entry10.Text!="" && entry6.Text != "" && entry11.Text != "")
			{
			DB.SaveSeasson(entry7.Text, Convert.ToDateTime(entry9.Text), Convert.ToDateTime(entry10.Text),Convert.ToInt32(entry6.Text),Convert.ToInt32(entry11.Text));
			}
		else
			{
			Dialog dialog = new Gtk.MessageDialog(this, DialogFlags.Modal, MessageType.Warning, ButtonsType.Ok, "Please insert the data!");
			dialog.Run();
			dialog.Destroy();
			}
			
		}
		
	protected void RowSelected2(object sender, EventArgs e){
		
			var selectedPlayer = (PlayerNode)nodeview2.NodeSelection.SelectedNode;
			RowSelectedWindow window = new RowSelectedWindow(nodeview2, selectedPlayer.name, selectedPlayer.lastname);

		}
		/***END***/
		









		/* Seasson -> Edit seasson*/
		protected void OnSeasonEdit(object sender, EventArgs e)
		{
			notebook1.CurrentPage = 4;
			this.Title = "Edit season";
			entry17.Text = DB.ReturnSeassonName();
			nodeview4.NodeSelection.Changed -= this.RowSelected4;
			DB.UpdatePlayersInSeasson(nodeview4);
			nodeview4.NodeSelection.Changed += this.RowSelected4;
		}

		protected void OnUpdateSeasson(object sender, EventArgs e)
		{
			if (entry13.Text != "" && entry14.Text != "")
			{
				DB.UpdateSeasson(entry17.Text, Convert.ToInt32(entry13.Text), Convert.ToInt32(entry14.Text));
			}
			else
			{
				Dialog dialog = new Gtk.MessageDialog(this, DialogFlags.Modal, MessageType.Warning, ButtonsType.Ok, "Please insert the data!");
				dialog.Run();
				dialog.Destroy();
			}

		}

		protected void RowSelected4(object sender, EventArgs e)
		{

			var selectedPlayer = (PlayerNode)nodeview4.NodeSelection.SelectedNode;
			RowSelectedWindow window = new RowSelectedWindow(nodeview4, selectedPlayer.name, selectedPlayer.lastname);

		}
		
		/***END***/

		









		/* Training -> Start training*/
		protected void OnStartTraining(object sender, EventArgs e)
		{
			nodeview6.NodeSelection.Changed -= this.OnRowSelected3;
				
			PlayerNodeStore presenter = new PlayerNodeStore();
			presenter.Dodaj(DB.ReturnPlayersForTraining());
			nodeview6.NodeStore = presenter;

			trainingPresenter.Clear();
			trainingPresenter.Dodaj(DB.ReturnTrainings());
			nodeview7.NodeStore = trainingPresenter;	

			nodeview6.NodeSelection.Changed += this.OnRowSelected3;
			notebook1.CurrentPage = 5;
			this.Title = "Start training";
		}


		protected void OnRowSelected3(object sender, EventArgs e)
		{
			string text = comboboxentry1.ActiveText;
			if (text == "")
			{
				Dialog dialog = new Gtk.MessageDialog(this, DialogFlags.Modal, MessageType.Warning, ButtonsType.Ok, "Please insert type of training!");
				dialog.Run();
				dialog.Destroy();
			}
			else {
			var selectedPlayer = (PlayerNode)nodeview6.NodeSelection.SelectedNode;
			RowSelectedTrainingWindow window = new RowSelectedTrainingWindow(nodeview6, selectedPlayer.name, selectedPlayer.lastname, text);
			}
			

		}

		protected void SaveTraining(object sender,EventArgs e) {

			if (entry2.Text != "" && comboboxentry1.ActiveText!="" && entry8.Text != ""){
				Training t = new Training(Convert.ToDateTime(entry16.Text), comboboxentry1.ActiveText, entry8.Text);
				DB.InsertTraining(t);
				UpdateCombobox(null, null);

				trainingPresenter.Clear();
				trainingPresenter.Dodaj(DB.ReturnTrainings());
				nodeview7.NodeStore = trainingPresenter;
		}
			else
			{
				Dialog dialog = new Gtk.MessageDialog(this, DialogFlags.Modal, MessageType.Warning, ButtonsType.Ok, "Please insert the data!");
				dialog.Run();
				dialog.Destroy();
			}
				
	
		}

		protected void UpdateCombobox(object sender, EventArgs e){
		
		ListStore model = new ListStore(typeof(string));
		comboboxentry1.Model = model; 

		List<string> list = new List<string>();
		list = DB.ReturnTypeOfTrainings();

		foreach (var tip in list)
		{
			comboboxentry1.AppendText(tip);
		}
	}
		/***END***/
		protected void OnAddNewType(object sender, EventArgs e) { }

		
		










		/* Notifications -> View*/
		protected void OnView(object sender, EventArgs e)
		{	
			
			notebook1.CurrentPage = 6;
			this.Title = "View notifications";

			int numOfPlayers = DB.ReturnNumOfPlayers();
			int numOfTrainings = DB.ReturnNumOfTrainings();
			int numOfMaxPlayers = DB.ReturnMax_players();
			int numOfMaxTrainings = DB.ReturmMax_trainings();

			if (numOfPlayers > numOfMaxPlayers && numOfTrainings > numOfMaxTrainings){ 
				notification.Dodaj(DB.ReturnAllNotifications());
				nodeview8.NodeStore = notification;
			}
			else if ( numOfPlayers > numOfMaxPlayers)
			{
				notification.Dodaj(DB.ReturnNotification(2));
				nodeview8.NodeStore = notification;
			}
			else if (numOfTrainings > numOfMaxTrainings)
			{
				notification.Dodaj(DB.ReturnNotification(1));
				nodeview8.NodeStore = notification;
			}
			

		}

		protected void OnClear(object sender, EventArgs e)
		{
			notification.Clear();
		}
		

		/***END***/










		
		//Records of presence -> View
		protected void OnViewRercords(object sender, EventArgs e)
		{
			notebook1.CurrentPage = 7;
			this.Title = "View records of presence";
			nodeview3.NodeSelection.Changed -= this.OnRowSelected;
			DB.UpdatePlayersInSeasson(nodeview3);
			nodeview3.NodeSelection.Changed += this.OnRowSelected;
			label23.Text = Convert.ToString(DB.ReturnNumOfTrainings());
			
		}






		
		protected void OnRowSelected(object sender, EventArgs e) { 
			
			var selectedPlayer = (PlayerNode)nodeview3.NodeSelection.SelectedNode;
			int PlayerID = DB.ReturnPlayerId(selectedPlayer.name, selectedPlayer.lastname);
			int num = DB.RetunNumberOfPlayerIDs(PlayerID);
			label9.Text = Convert.ToString(num);


			

			float percentage = (((float)num / (float)DB.ReturnNumOfTrainings())*100);	

			label27.Text = Convert.ToString(percentage+"%");
				
		}
}

