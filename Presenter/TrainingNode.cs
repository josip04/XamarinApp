using System;
namespace projekt
{
	public class TrainingNode : Gtk.TreeNode
	{
		
		
		[Gtk.TreeNodeValue(Column = 0)]
		public String date;

		[Gtk.TreeNodeValue(Column = 1)]
		public String t_type;

		[Gtk.TreeNodeValue(Column = 2)]
		public String duration;

	

		public TrainingNode(Training t)
		{
			this.date = t.Date.ToShortDateString();
			this.t_type = t.T_type;
			this.duration = t.Duration;
		}
	}
}
