using System;
using System.Collections.Generic;

namespace projekt
{
	public class TrainingNodeStore : Gtk.NodeStore
	{
		public TrainingNodeStore(): base(typeof(TrainingNode))
		{
			
		}
		public void Add(Training t)
		{
			this.AddNode(new TrainingNode(t));
		}
		public void Dodaj(List<Training> training)
		{
			foreach (var v in training)
			{
				this.Add(v);
			}
		}
	}
}
