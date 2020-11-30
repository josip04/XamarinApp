using System;
namespace projekt
{
	public class Training
	{
		DateTime date;
		string t_type;
		string duration;


		public Training(DateTime date,string t_type,string duration)
		{
			this.date = date;
			this.t_type = t_type;
			this.duration = duration;
		}

		public DateTime Date
		{
			get
			{
				return date;
			}

			set
			{
				date = value;
			}
		}

		public string T_type
		{
			get
			{
				return t_type;
			}

			set
			{
				t_type = value;
			}
		}

		public string Duration
		{
			get
			{
				return duration;
			}

			set
			{
				duration = value;
			}
		}
	}
}
