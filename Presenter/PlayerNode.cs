using System;
namespace projekt
{
	public class PlayerNode : Gtk.TreeNode
	{

		[Gtk.TreeNodeValue(Column = 0)]
		public String name;

		[Gtk.TreeNodeValue(Column = 1)]
		public String lastname;

		[Gtk.TreeNodeValue(Column = 2)]
		public String phone;

		[Gtk.TreeNodeValue(Column = 3)]
		public string dateOfBirth;

		[Gtk.TreeNodeValue(Column = 4)]
		public String adress;




		public PlayerNode(Player p)
		{
			this.name = p.Name;
			this.lastname = p.LastName;
			this.phone = p.Phone;
			this.dateOfBirth = p.DateOfBirth.ToShortDateString();
			this.adress = p.Adress;

		}
	}
}
