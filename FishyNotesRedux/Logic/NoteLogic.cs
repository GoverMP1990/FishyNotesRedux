using System;
using System.Collections.Generic;
using System.Text;

// Program packages
using FishyNotesRedux.Interfaces;
using FishyNotesRedux.Forms;
using FishyNotesRedux.Storage;
using FishyNotesRedux.Delegators;

namespace FishyNotesRedux.Logic
{
    class NoteLogic : INoteLogic
    {

        // Class variables

        // Declare new List<INoteData>
        // Call it "_notes"
        private List<INoteData> _notes;

        // Declare new integer for note identity
        // Call _noteIndex
        private int _noteIndex;

        // Declare delegate NoteDel called _noteDel
        private NoteDel _noteDel;

        // Declare delegate for DictLenDel called _dictLenDel
        private DictLenDel _dictLenDel;

        // Declare string for storing text data
        private string _noteText;

        /// <summary>
        /// Paramaterless constructor for NoteLogic class
        /// </summary>
        public NoteLogic()
        {

        }

        /// <summary>
        /// METHOD : Initialise
        /// DESC : Initialise this class with a list of notes
        /// </summary>
        /// <param name="pNoteIndex"> The index value for this note </param>
        public void Initialise(int pNoteIndex, NoteDel pNoteDel, DictLenDel pDictLen)
        {
            // Set _noteIndex to pNoteIndex
            _noteIndex = pNoteIndex;

            _noteDel = pNoteDel;

            _dictLenDel = pDictLen;

            Console.WriteLine("My index value is : " + _noteIndex);
        }

        /// <summary>
        /// METHOD : AddNote
        /// DESC : Open new form
        /// </summary>
        public void AddNote()
        {
            // Declare new _noteView
            // Call it "_noteView"
            // Instantiate new _noteView
            //FishyNote _noteView = new FishyNote();

            // Show _noteView
            //_noteView.Show();
        }

        /// <summary>
        /// METHOD : DeleteNote
        /// DESC : Deletes the note with the given index value
        /// </summary>
        /// <param name="pIndex"></param>
        public void DeleteNote(int pIndex)
        {

        }

        /// <summary>
        /// METHOD : ViewNote
        /// DESC : View the note for the current index value
        /// </summary>
        /// <param name="pIndex"></param>
        public void ViewNote(int pIndex)
        {
            
        }

        /// <summary>
        /// METHOD : ChangeNote
        /// DESC : Change the contents of the note for the given index value
        /// </summary>
        /// <param name="pIndex"></param>
        public void ChangeNote(int pIndex, string pText)
        {
            // Use the delegate for setting note text in the data element
            // Pass it the pIndex and pText parameters
            _noteDel(pIndex, pText);
        }

        public int NextNote()
        {


            if (_noteIndex+1 >= _dictLenDel(0))
            {
                _noteIndex = _dictLenDel(0) - 1;
            }
            else
            {
                _noteIndex += 1;
            }

            return _noteIndex;
        }

        public int PreviousNote()
        {
            if (_noteIndex - 1 < 0)
            {
                _noteIndex = 0;
            }
            else
            {
               _noteIndex -= 1;
            }

            return _noteIndex;
        }

        // Public property access for the _noteIndex value
        public int Index
        {
            get { return _noteIndex; }
            set { _noteIndex = value; }
        }
    }
}
