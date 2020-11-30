using System;
using Gtk;


namespace projekt
{
	public partial class RowSelectedWindow : Gtk.Window 
	{

		NodeView node;
		Boolean isTrue;


		public RowSelectedWindow(object sender,string name,string lastname) :
				base(Gtk.WindowType.Toplevel)
		{
			this.Build();

			node = sender as NodeView;
			label2.Text = name;
			label4.Text = lastname;

			isTrue = DB.IsSelected(label2.Text, label4.Text);

			if (isTrue)
			{
				checkbutton1.Active = true;
			}
			else { 
				checkbutton1.Active = false;
			}

		}

		public void Save(object sender, EventArgs e)
		{

			if (checkbutton1.Active)
			{
				isTrue = true;
				DB.Check(label2.Text, label4.Text, isTrue);
				this.Destroy();
			}
			else{
				isTrue = false;
				DB.Check(label2.Text, label4.Text, isTrue);
				this.Destroy();
			}

		}

		public void Close(object sender, EventArgs e)
		{
			this.Destroy();
		}

	}
}
