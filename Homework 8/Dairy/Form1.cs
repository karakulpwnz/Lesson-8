using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using Newtonsoft.Json.Linq;



namespace Dairy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblResult.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            
            //пытаюсь десериализовать json
            Notes newNotes = JsonConvert.DeserializeObject<Notes>("Notes.json");



            //Notes myCollection = new Notes();
            //myCollection.myNotes = new List<Note>();
            //Note newNote = new Note(txtDate.Text, txtPlace.Text, txtTitle.Text, txtNote.Text);

            ////notes.Add(newNote);

            //List<Note> notes = new List<Note>();

            ////Note note = JsonConvert.DeserializeObject<Note>("Notes.json");

            //StreamReader file = new StreamReader("Notes.json");
            //while (!file.EndOfStream)
            //{
            //    JsonSerializer serializer = new JsonSerializer();
            //    Note note = (Note)serializer.Deserialize(file, typeof(Note));
            //    notes.Add(note);
            //}

            ////JObject rss = JObject.Parse("Notes.json");
            ////StreamWriter jsonFile = new StreamWriter("newNote.json", false);
            ////JsonSerializer json = new JsonSerializer();
            ////json.Serialize(jsonFile, newNote);
            ////jsonFile.Close();
        }
    }
}
