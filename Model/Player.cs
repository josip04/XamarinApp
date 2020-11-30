using System;

namespace projekt
{
	public class Player
	{
		private string name;
		private string lastName;
		private string phone;
		private DateTime dateOfBirth;
		private string adress;
		private Boolean selected;


		public Player(string name,string lastname,string phone,DateTime dateOfBirth,string adress,Boolean selected)
		{
			this.name = name;
			this.lastName = lastname;
			this.phone = phone;
			this.dateOfBirth = dateOfBirth;
			this.adress = adress;
			this.Selected = selected;
		}



		public string Name
		{
			get
			{
				return name;
			}

			set
			{
				name = value;
			}
		}

		public string LastName
		{
			get
			{
				return lastName;
			}

			set
			{
				lastName = value;
			}
		}

		public string Phone
		{
			get
			{
				return phone;
			}

			set
			{
				phone = value;
			}
		}

		public DateTime DateOfBirth
		{
			get
			{
				return dateOfBirth;
			}

			set
			{
				dateOfBirth = value;
			}
		}

		public string Adress
		{
			get
			{
				return adress;
			}

			set
			{
				adress = value;
			}
		}

		public bool Selected
		{
			get
			{
				return selected;
			}

			set
			{
				selected = value;
			}
		}
	}
}
