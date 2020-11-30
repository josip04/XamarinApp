using System;
using Gtk;
namespace projekt
{
	public partial class RowSelectedTrainingWindow : Gtk.Window
	{
		NodeView node;
		int player_ID;
		int typeOfTraining_ID;

		public RowSelectedTrainingWindow(object sender, string name, string lastname,string combo) :
				base(Gtk.WindowType.Toplevel)
		{
			this.Build();
			node = sender as NodeView;
			label4.Text = name;
			label5.Text = lastname;
			label7.Text = combo;

		
			player_ID = DB.ReturnPlayerId(name,lastname);
			typeOfTraining_ID = DB.ReturnTypeOfTrainingId(combo);


			string type = DB.CheckTypeOfTraining(label7.Text);
			if (label7.Text != type) { 
				DB.InsertTypeOfTraining(label7.Text);
			}




		}


		public void Save(object sender, EventArgs e)
		{


			Dialog dialog = new Gtk.MessageDialog(this, DialogFlags.Modal, MessageType.Info, ButtonsType.OkCancel, "Are you sure?You will save data about presence for this player.");
			ResponseType response = (ResponseType)dialog.Run();
			if (response == ResponseType.Ok)
			{
				DB.InsertActivity(player_ID.ToString(),typeOfTraining_ID.ToString()); 
				dialog.Destroy();

				this.Destroy();
			}
			else {
				dialog.Destroy();
			}



		}


		public void Close(object sender, EventArgs e)
		{
			this.Destroy();
		}



	}
}

