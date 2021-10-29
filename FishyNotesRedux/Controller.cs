using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

// Program packages
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

        /// <summary>
        /// Controller class constructor
        /// </summary>
        public Controller()
        {
            _notes = new Dictionary<int, INoteData>();

            _noteLogics = new Dictionary<int, INoteLogic>();

            _fishyNoteForms = new Dictionary<int, FishyNote>();

            // Declare and instantiate a new FishyNotes called _fishyNotes
            FishyNotes _fishyNotes = new FishyNotes();

            // Run the application
            Application.Run(_fishyNotes);
        }
    }
}
