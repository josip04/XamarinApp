using System;
using Gtk;


namespace projekt
{
	public partial class EditPlayerUpdateWindow : Gtk.Window
	{
		public string old_phone_number;
		NodeView node;

		public EditPlayerUpdateWindow(object sender,string name,string lastname,string phone,string date,string adress) 
			: base(Gtk.WindowType.Toplevel)
		{
			this.Build();
			node = sender as NodeView;

			entry1.Text = name;
			entry2.Text = lastname;
			entry3.Text = phone;
			old_phone_number = phone;
			entry4.Text = date;
			entry5.Text = adress;
		}

		public void Update(object sender, EventArgs e){
			DB.UpdatePlayer(entry1.Text,entry2.Text,entry3.Text,Convert.ToDateTime(entry4.Text),entry5.Text,old_phone_number);
			this.Destroy();

			PlayerNodeStore playerPresenter = new PlayerNodeStore();
			playerPresenter.Dodaj(DB.ReturnPlayers());
			node.NodeStore = playerPresenter;
			                                   
		}

	}
}
