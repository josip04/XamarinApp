using System;
namespace projekt
{
	public class NotificationNode : Gtk.TreeNode
	{

		[Gtk.TreeNodeValue(Column = 0)]
		public String notification;


		public NotificationNode(Notifications n)
		{
			this.notification = n.Notification;
		}

	}
}
