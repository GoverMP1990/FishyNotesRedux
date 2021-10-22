using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FishyNotesRedux.Interfaces;
using FishyNotesRedux.Logic;

namespace FishyNotesRedux
{
    public partial class FishyNotes : Form
    {

        List<INoteData> _notes;

        INoteLogic _noteLogic;

        public FishyNotes()
        {
            _notes = new List<INoteData>();

            _noteLogic = new NoteLogic();

            _noteLogic.Initialise(_notes);

            InitializeComponent();
        }

        private void NewNote(object sender, EventArgs e)
        {
            _noteLogic.AddNote();
        }
    }
}
