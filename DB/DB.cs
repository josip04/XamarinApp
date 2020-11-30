using System;
using Gtk;
using System.Data.SQLite;
using System.Collections.Generic;


namespace projekt
{
	public static class DB
	{
		static SQLiteConnection conn = new SQLiteConnection("Data Source=projekt.db");
		public static void CreateDB()
		{
			
			conn.Open();
			SQLiteCommand cmd = conn.CreateCommand();
			cmd.CommandText = "CREATE TABLE IF NOT EXISTS players (" +
				"id integer primary key autoincrement," +
				"name nvarchar(20)," +
				" lastname nvarchar(30)," +
				"phone nvarchar(20), " +
				"dateOfBirth datetime, " +
				"adress nvarchar(30),"+
				"selected boolean)";

			cmd.ExecuteNonQuery();

			SQLiteCommand cmd2 = conn.CreateCommand();
			cmd2.CommandText = "CREATE TABLE IF NOT EXISTS seassons (" +
				"id integer primary key autoincrement," +
				"name nvarchar(20)," +
				"start datetime, " +
				"finish datetime, " +
				"max_trainings int not null, " +
				"max_players int not null)";

			cmd2.ExecuteNonQuery();


			SQLiteCommand cmd4 = conn.CreateCommand();
			cmd4.CommandText = "CREATE TABLE IF NOT EXISTS training_type (" +
				"id integer primary key autoincrement," +
				"type_t nvarchar(20))";

			cmd4.ExecuteNonQuery();

			SQLiteCommand cmd5 = conn.CreateCommand();
			cmd5.CommandText = "CREATE TABLE IF NOT EXISTS activity (" +
				"id integer primary key autoincrement," +
				"id_player nvarchar(20)," +
				"id_type_t nvarchar(20))";

			cmd5.ExecuteNonQuery();

			SQLiteCommand cmd6 = conn.CreateCommand();
			cmd6.CommandText = "CREATE TABLE IF NOT EXISTS training (" +
				"id integer primary key autoincrement," +
				"date datetime," +
				"type_t nvarchar(20)," +
				"duration  nvarchar(20))";

			cmd6.ExecuteNonQuery();

			conn.Close();
			cmd.Dispose();
			cmd2.Dispose();
			cmd4.Dispose();
			cmd5.Dispose();
			cmd6.Dispose();
		}

		public static void SavePlayer(Player p)
		{

			conn.Open();
			SQLiteCommand cmd = conn.CreateCommand();
			cmd.CommandText = @"INSERT INTO players (name,lastname,phone,dateOfBirth,adress,selected) VALUES ('" + p.Name + "','" + p.LastName + "','" + p.Phone + "','" + p.DateOfBirth.ToFileTime() + "','" + p.Adress + "','" + p.Selected + "')";

			cmd.ExecuteNonQuery();
			conn.Close();
			cmd.Dispose();
		}




		public static List<Player> ReturnPlayers()
		{
			List<Player> lista = new List<Player>();
			conn.Open();
			SQLiteCommand cmd = conn.CreateCommand();
			cmd.CommandText = "SELECT*FROM players";
			SQLiteDataReader reader = cmd.ExecuteReader();

			while (reader.Read())
			{
				Player player = new Player(reader.GetString(1), reader.GetString(2), reader.GetString(3), DateTime.FromFileTime(reader.GetInt64(4)), reader.GetString(5),Convert.ToBoolean(reader.GetString(6)));
				lista.Add(player);
			}
			conn.Close();
			cmd.Dispose();
			return lista;
		}

		public static void DeletePlayer(string name, string lastname, string phone)
		{
			conn.Open();
			SQLiteCommand cmd = conn.CreateCommand();
			cmd.CommandText = String.Format("DELETE FROM players WHERE name='{0}' AND lastname='{1}' AND phone='{2}'", name, lastname, phone);
			cmd.ExecuteNonQuery();
			conn.Close();
			cmd.Dispose();
		}
		public static void UpdatePlayer(string name, string lastname, string phone, DateTime date, string adress, string old_phone_number)
		{
			conn.Open();
			SQLiteCommand cmd = conn.CreateCommand();
			cmd.CommandText = String.Format("UPDATE players SET name='{0}',lastname='{1}',phone='{2}',dateOfBirth='{3}',adress='{4}' WHERE phone='{5}'", name, lastname, phone, date.ToFileTime(), adress, old_phone_number);
			cmd.ExecuteNonQuery();

			conn.Close();
			cmd.Dispose();
		}

		//SEASSON

		public static void SaveSeasson(string name, DateTime start, DateTime finish, int alert1, int alert2)
		{
			conn.Open();


			SQLiteCommand cmd2 = conn.CreateCommand();
			cmd2.CommandText = "DELETE FROM seassons WHERE id='1'";
			cmd2.ExecuteNonQuery();


			SQLiteCommand cmd = conn.CreateCommand();
			cmd.CommandText = String.Format("INSERT INTO seassons (id,name,start,finish,max_trainings,max_players) VALUES ('1','{0}','{1}','{2}','{3}','{4}')", name, start, finish, alert1, alert2);
			cmd.ExecuteNonQuery();
			conn.Close();
			cmd.Dispose();
			cmd2.Dispose();
		}




		public static void Check(string name, string lastname, Boolean isTrue)
		{
			conn.Open();
			SQLiteCommand cmd = conn.CreateCommand();
			cmd.CommandText = String.Format("UPDATE players SET selected='{0}' WHERE name='{1}' AND lastname='{2}' ", isTrue, name, lastname);

			cmd.ExecuteNonQuery();
			conn.Close();
			cmd.Dispose();
		}

		public static Boolean IsSelected(string name, string lastname)
		{
			
			Boolean isTrue;
			conn.Open();
			SQLiteCommand cmd = conn.CreateCommand();
			cmd.CommandText = String.Format("SELECT selected FROM players WHERE name='{0}' AND lastname='{1}' ", name, lastname);
			isTrue = (Boolean)cmd.ExecuteScalar();


			conn.Close();
			cmd.Dispose();

			return isTrue;
		}

		//Edit Seasson

		public static string ReturnSeassonName()
		{
			conn.Open();
			string name;
			SQLiteCommand cmd = conn.CreateCommand();
			cmd.CommandText = "SELECT name FROM seassons WHERE id='1' ";
			name = (string)cmd.ExecuteScalar();
			cmd.ExecuteNonQuery();
			conn.Close();
			cmd.Dispose();
			return name;
		}

		public static void UpdateSeasson(string name, int alert1, int alert2)
		{
			conn.Open();

			SQLiteCommand cmd = conn.CreateCommand();
			cmd.CommandText = String.Format("UPDATE seassons SET max_trainings='{0}',max_players='{1}',name='{2}' WHERE id='1'", alert1, alert2, name);

			cmd.ExecuteNonQuery();
			conn.Close();
			cmd.Dispose();
		}

		public static void UpdatePlayersInSeasson(object sender) { 
			PlayerNodeStore playerPresenter = new PlayerNodeStore();
			NodeView node = sender as NodeView;
			playerPresenter.Dodaj(DB.ReturnPlayers());
			node.NodeStore = playerPresenter;

		}

		/***END***/




		//Training  


		public static void InsertTraining(Training t) { 
		
			conn.Open();
			SQLiteCommand cmd = conn.CreateCommand();

			cmd.CommandText = String.Format("INSERT INTO training (date,type_t,duration) VALUES ('{0}','{1}','{2}') ",t.Date.ToFileTime(),t.T_type,t.Duration);
			cmd.ExecuteNonQuery();

			conn.Close();
			cmd.Dispose();
		}

		public static List<Training> ReturnTrainings()
		{
			List<Training> lista = new List<Training>();
			conn.Open();
			SQLiteCommand cmd = conn.CreateCommand();
			cmd.CommandText = "SELECT*FROM training";
			SQLiteDataReader reader = cmd.ExecuteReader();

			while (reader.Read())
			{
				Training training = new Training( DateTime.FromFileTime(reader.GetInt64(1)), reader.GetString(2),reader.GetString(3));

				lista.Add(training);


			}
			conn.Close();
			cmd.Dispose();
			return lista;
		}

		public static List<Player> ReturnPlayersForTraining()
		{
			List<Player> lista = new List<Player>();
			conn.Open();
			SQLiteCommand cmd = conn.CreateCommand();
			cmd.CommandText = "SELECT*FROM players";
			SQLiteDataReader reader = cmd.ExecuteReader();

			while (reader.Read())
			{
				Player player = new Player(reader.GetString(1), reader.GetString(2), reader.GetString(3), DateTime.FromFileTime(reader.GetInt64(4)), reader.GetString(5), Convert.ToBoolean(reader.GetString(6)));
				if (player.Selected == true) { 
					lista.Add(player);
				}

			}
			conn.Close();
			cmd.Dispose();
			return lista;
		}




		public static void InsertTypeOfTraining(string type_t)
		{
			
			conn.Open();
			SQLiteCommand cmd = conn.CreateCommand();
			cmd.CommandText = String.Format("INSERT INTO training_type (type_t) VALUES ('{0}')",type_t);
			cmd.ExecuteNonQuery();


			conn.Close();
			cmd.Dispose();

		}



		public static string CheckTypeOfTraining(string type_t) { 
			conn.Open();
			SQLiteCommand cmd = conn.CreateCommand();

			cmd.CommandText = String.Format("SELECT type_t FROM training_type WHERE type_t='{0}'", type_t);
			string return_type = Convert.ToString(cmd.ExecuteScalar());

			cmd.Dispose();
			conn.Close();

			return return_type;
		}



		public static int ReturnPlayerId(string name, string lastname)
		{
			int id;
			conn.Open();
			SQLiteCommand cmd = conn.CreateCommand();
			cmd.CommandText = String.Format("SELECT id FROM players WHERE name='{0}' AND lastname='{1}' ", name, lastname);
			id = Convert.ToInt32(cmd.ExecuteScalar());


			conn.Close();
			cmd.Dispose();

			return id;
		}


		public static int ReturnTypeOfTrainingId(string type_t)
		{
			int id;
			conn.Open();
			SQLiteCommand cmd = conn.CreateCommand();
			cmd.CommandText = String.Format("SELECT id FROM training_type WHERE type_t='{0}'  ",type_t );
			id = Convert.ToInt32(cmd.ExecuteScalar());


			conn.Close();
			cmd.Dispose();

			return id;
		}


		public static List<string> ReturnTypeOfTrainings()
		{
			List<string> lista = new List<string>();
			conn.Open();
			SQLiteCommand cmd = conn.CreateCommand();
			cmd.CommandText = "SELECT type_t FROM training_type";
			SQLiteDataReader reader = cmd.ExecuteReader();

			while (reader.Read())
			{
				string tip = reader.GetString(0);
				lista.Add(tip);


			}
			conn.Close();
			cmd.Dispose();
			return lista;
		}


		/***END***/




		//Notifications  

		//vrati notifikacije koje će se trebati prikazati ako je uvjet zadovoljen


		public static List<Notifications> ReturnNotification(int id)
		{															
			List<Notifications> lista = new List<Notifications>();
			conn.Open();
			SQLiteCommand cmd = conn.CreateCommand();
			cmd.CommandText = string.Format("SELECT*FROM notifications WHERE id='{0}'", id);
			SQLiteDataReader reader = cmd.ExecuteReader();

			while (reader.Read())
			{
				Notifications notifications = new Notifications(reader.GetString(1));
				lista.Add(notifications);
			}
			conn.Close();
			cmd.Dispose();
			return lista;
		}


		public static List<Notifications> ReturnAllNotifications()
		{
			List<Notifications> lista = new List<Notifications>();
			conn.Open();
			SQLiteCommand cmd = conn.CreateCommand();
			cmd.CommandText = string.Format("SELECT*FROM notifications");
			SQLiteDataReader reader = cmd.ExecuteReader();

			while (reader.Read())
			{
				Notifications notifications = new Notifications(reader.GetString(1));
				lista.Add(notifications);
			}
			conn.Close();
			cmd.Dispose();
			return lista;
		}




		public static int ReturnNumOfPlayers()
		{
			conn.Open();
			int numOfPlayers;
			SQLiteCommand cmd = conn.CreateCommand();
			cmd.CommandText = "SELECT COUNT(*) FROM players WHERE selected='True'";
			numOfPlayers = Convert.ToInt32(cmd.ExecuteScalar());

			conn.Close();
			cmd.Dispose();
			return numOfPlayers;
		}

		public static int ReturnNumOfTrainings()
		{
			conn.Open();
			int numOfTrainings;
			SQLiteCommand cmd = conn.CreateCommand();
			cmd.CommandText = "SELECT COUNT(*) FROM training";
			numOfTrainings = Convert.ToInt32(cmd.ExecuteScalar());

			conn.Close();
			cmd.Dispose();
			return numOfTrainings;
		}

		public static int ReturmMax_trainings()
		{
			conn.Open();
			int num;
			SQLiteCommand cmd = conn.CreateCommand();
			cmd.CommandText = "SELECT max_trainings FROM seassons WHERE id=1";
			num = Convert.ToInt32(cmd.ExecuteScalar());

			conn.Close();
			cmd.Dispose();
			return num;
		}

		public static int ReturnMax_players(){
			conn.Open();
			int num;
			SQLiteCommand cmd = conn.CreateCommand();
			cmd.CommandText = "SELECT max_players FROM seassons WHERE id=1";
			num = Convert.ToInt32(cmd.ExecuteScalar());

			conn.Close();
			cmd.Dispose();
			return num;
		}



		/***END***/




		//Za tablicu Activity metoda za unos ID-a igrača i tipa treninga



		public static void InsertActivity(string playerID,string typeOfTraining_ID) { 

			conn.Open();

			SQLiteCommand cmd = conn.CreateCommand();

			cmd.CommandText = String.Format("INSERT INTO activity (id_player,id_type_t) VALUES ('{0}','{1}')", playerID,typeOfTraining_ID);
			cmd.ExecuteNonQuery();

			cmd.Dispose();
			conn.Close();
		}



		public static int RetunNumberOfPlayerIDs(int PlayerID)
		{
			
			conn.Open();

			SQLiteCommand cmd = conn.CreateCommand();

			cmd.CommandText = String.Format("SELECT COUNT(*) FROM activity WHERE id_player='{0}'",PlayerID);
			int IDs = Convert.ToInt32(cmd.ExecuteScalar());

			cmd.Dispose();
			conn.Close();

			return IDs;
		}

	}
}

