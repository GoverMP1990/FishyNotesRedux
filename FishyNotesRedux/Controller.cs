using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using FishyNotesRedux.Interfaces;
using FishyNotesRedux.Forms;

namespace FishyNotesRedux
{
    public class Controller
    {
        // Class variables
        Dictionary<int, INoteData> _notes;

        Dictionary<int, INoteLogic> _noteLogics;

        Dictionary<int, FishyNote> _fishyNoteForms;

        public Controller()
        {
            _notes = new Dictionary<int, INoteData>();

            _noteLogics = new Dictionary<int, INoteLogic>();

            _fishyNoteForms = new Dictionary<int, FishyNote>();

            FishyNotes _fishyNotes = new FishyNotes();

            Application.Run(_fishyNotes);
        }
    }
}
