using System;
using System.Collections.Generic;

namespace projekt
{
	public class NotificationNodeStore : Gtk.NodeStore
	{
		public NotificationNodeStore() : base(typeof(NotificationNode))
		{

		}
		public void Add(Notifications n)
		{
			this.AddNode(new NotificationNode(n));
		}
		public void Dodaj(List<Notifications> notification)
		{
			foreach (var v in notification)
			{
				this.Add(v);
			}
		}


	}
}

