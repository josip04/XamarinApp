using System;
namespace projekt
{
	public class Notifications
	{
		private string notification;

		public Notifications(string notification)
		{
			this.notification = notification;
		}

		public string Notification
		{
			get
			{
				return notification;
			}

			set
			{
				notification = value;
			}
		}
	}
}
