using System;
using System.Collections.Generic;

namespace projekt
{
	public class PlayerNodeStore : Gtk.NodeStore
	{
		public PlayerNodeStore(): base(typeof(PlayerNode))
		{
			
		}
		public void Add(Player p)
		{
			this.AddNode(new PlayerNode(p));
		}
		public void Dodaj(List<Player> player)
		{
			foreach (var v in player)
			{
				this.Add(v);
			}
		}


	}
}

