
// This file has been generated by the GUI designer. Do not modify.
namespace projekt
{
	public partial class EditPlayerUpdateWindow
	{
		private global::Gtk.VBox vbox1;

		private global::Gtk.HBox hbox1;

		private global::Gtk.VBox vbox7;

		private global::Gtk.HBox hbox8;

		private global::Gtk.Label label6;

		private global::Gtk.HBox hbox7;

		private global::Gtk.Label label1;

		private global::Gtk.Entry entry1;

		private global::Gtk.VBox vbox2;

		private global::Gtk.HBox hbox2;

		private global::Gtk.Label label2;

		private global::Gtk.Entry entry2;

		private global::Gtk.HBox hbox3;

		private global::Gtk.Label label3;

		private global::Gtk.Entry entry3;

		private global::Gtk.HBox hbox4;

		private global::Gtk.Label label4;

		private global::Gtk.Entry entry4;

		private global::Gtk.VBox vbox3;

		private global::Gtk.HBox hbox5;

		private global::Gtk.Label label5;

		private global::Gtk.Entry entry5;

		private global::Gtk.HBox hbox6;

		private global::Gtk.Button button1;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget projekt.EditPlayerUpdateWindow
			this.Name = "projekt.EditPlayerUpdateWindow";
			this.Title = global::Mono.Unix.Catalog.GetString("Update");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			this.Modal = true;
			// Container child projekt.EditPlayerUpdateWindow.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.vbox7 = new global::Gtk.VBox();
			this.vbox7.Name = "vbox7";
			this.vbox7.Spacing = 6;
			// Container child vbox7.Gtk.Box+BoxChild
			this.hbox8 = new global::Gtk.HBox();
			this.hbox8.Name = "hbox8";
			this.hbox8.Spacing = 6;
			// Container child hbox8.Gtk.Box+BoxChild
			this.label6 = new global::Gtk.Label();
			this.label6.Name = "label6";
			this.label6.Xpad = 20;
			this.label6.Ypad = 20;
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString("Please enter new data here:");
			this.hbox8.Add(this.label6);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox8[this.label6]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			this.vbox7.Add(this.hbox8);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox7[this.hbox8]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox7.Gtk.Box+BoxChild
			this.hbox7 = new global::Gtk.HBox();
			this.hbox7.Name = "hbox7";
			this.hbox7.Spacing = 6;
			// Container child hbox7.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label();
			this.label1.Name = "label1";
			this.label1.Xpad = 40;
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("Name:");
			this.hbox7.Add(this.label1);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.label1]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			// Container child hbox7.Gtk.Box+BoxChild
			this.entry1 = new global::Gtk.Entry();
			this.entry1.WidthRequest = 200;
			this.entry1.CanFocus = true;
			this.entry1.Name = "entry1";
			this.entry1.IsEditable = true;
			this.entry1.InvisibleChar = '●';
			this.hbox7.Add(this.entry1);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.entry1]));
			w4.Position = 1;
			w4.Expand = false;
			w4.Fill = false;
			this.vbox7.Add(this.hbox7);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox7[this.hbox7]));
			w5.Position = 1;
			w5.Expand = false;
			w5.Fill = false;
			this.hbox1.Add(this.vbox7);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.vbox7]));
			w6.Position = 0;
			this.vbox1.Add(this.hbox1);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox1]));
			w7.Position = 0;
			w7.Expand = false;
			w7.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.vbox2 = new global::Gtk.VBox();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.label2 = new global::Gtk.Label();
			this.label2.Name = "label2";
			this.label2.Xpad = 31;
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("Lastname:");
			this.hbox2.Add(this.label2);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.label2]));
			w8.Position = 0;
			w8.Expand = false;
			w8.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.entry2 = new global::Gtk.Entry();
			this.entry2.WidthRequest = 200;
			this.entry2.CanFocus = true;
			this.entry2.Name = "entry2";
			this.entry2.IsEditable = true;
			this.entry2.InvisibleChar = '●';
			this.hbox2.Add(this.entry2);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.entry2]));
			w9.Position = 1;
			w9.Expand = false;
			w9.Fill = false;
			this.vbox2.Add(this.hbox2);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox2]));
			w10.Position = 0;
			w10.Expand = false;
			w10.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox3 = new global::Gtk.HBox();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.label3 = new global::Gtk.Label();
			this.label3.Name = "label3";
			this.label3.Xpad = 40;
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("Phone:");
			this.hbox3.Add(this.label3);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.label3]));
			w11.Position = 0;
			w11.Expand = false;
			w11.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.entry3 = new global::Gtk.Entry();
			this.entry3.WidthRequest = 200;
			this.entry3.CanFocus = true;
			this.entry3.Name = "entry3";
			this.entry3.IsEditable = true;
			this.entry3.InvisibleChar = '●';
			this.hbox3.Add(this.entry3);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.entry3]));
			w12.Position = 1;
			w12.Expand = false;
			w12.Fill = false;
			this.vbox2.Add(this.hbox3);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox3]));
			w13.Position = 1;
			w13.Expand = false;
			w13.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox4 = new global::Gtk.HBox();
			this.hbox4.Name = "hbox4";
			this.hbox4.Spacing = 6;
			// Container child hbox4.Gtk.Box+BoxChild
			this.label4 = new global::Gtk.Label();
			this.label4.Name = "label4";
			this.label4.Xpad = 24;
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString("Date of Birth:");
			this.hbox4.Add(this.label4);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.label4]));
			w14.Position = 0;
			w14.Expand = false;
			w14.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.entry4 = new global::Gtk.Entry();
			this.entry4.WidthRequest = 200;
			this.entry4.CanFocus = true;
			this.entry4.Name = "entry4";
			this.entry4.IsEditable = true;
			this.entry4.InvisibleChar = '●';
			this.hbox4.Add(this.entry4);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.entry4]));
			w15.Position = 1;
			w15.Expand = false;
			w15.Fill = false;
			this.vbox2.Add(this.hbox4);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox4]));
			w16.Position = 2;
			w16.Expand = false;
			w16.Fill = false;
			this.vbox1.Add(this.vbox2);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.vbox2]));
			w17.Position = 1;
			w17.Expand = false;
			w17.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.vbox3 = new global::Gtk.VBox();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			// Container child vbox3.Gtk.Box+BoxChild
			this.hbox5 = new global::Gtk.HBox();
			this.hbox5.Name = "hbox5";
			this.hbox5.Spacing = 6;
			// Container child hbox5.Gtk.Box+BoxChild
			this.label5 = new global::Gtk.Label();
			this.label5.Name = "label5";
			this.label5.Xpad = 40;
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString("Adress:");
			this.hbox5.Add(this.label5);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.label5]));
			w18.Position = 0;
			w18.Expand = false;
			w18.Fill = false;
			// Container child hbox5.Gtk.Box+BoxChild
			this.entry5 = new global::Gtk.Entry();
			this.entry5.WidthRequest = 200;
			this.entry5.CanFocus = true;
			this.entry5.Name = "entry5";
			this.entry5.IsEditable = true;
			this.entry5.InvisibleChar = '●';
			this.hbox5.Add(this.entry5);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.entry5]));
			w19.Position = 1;
			w19.Expand = false;
			w19.Fill = false;
			this.vbox3.Add(this.hbox5);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.hbox5]));
			w20.Position = 0;
			w20.Expand = false;
			w20.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.hbox6 = new global::Gtk.HBox();
			this.hbox6.Name = "hbox6";
			this.hbox6.Spacing = 6;
			// Container child hbox6.Gtk.Box+BoxChild
			this.button1 = new global::Gtk.Button();
			this.button1.WidthRequest = 65;
			this.button1.CanFocus = true;
			this.button1.Name = "button1";
			this.button1.UseUnderline = true;
			this.button1.Label = global::Mono.Unix.Catalog.GetString("Update");
			this.hbox6.Add(this.button1);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.button1]));
			w21.Position = 1;
			w21.Fill = false;
			this.vbox3.Add(this.hbox6);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.hbox6]));
			w22.Position = 1;
			w22.Expand = false;
			w22.Fill = false;
			this.vbox1.Add(this.vbox3);
			global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.vbox3]));
			w23.Position = 2;
			w23.Expand = false;
			w23.Fill = false;
			this.Add(this.vbox1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 400;
			this.DefaultHeight = 300;
			this.Show();
			this.button1.Clicked += new global::System.EventHandler(this.Update);
		}
	}
}