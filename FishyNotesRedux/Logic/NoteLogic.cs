using System;
using System.Collections.Generic;
using System.Text;
using FishyNotesRedux.Interfaces;
using FishyNotesRedux.Forms;

namespace FishyNotesRedux.Logic
{
    class NoteLogic : INoteLogic
    {

        // Class variables

        // Declare new List<INoteData>
        // Call it "_notes"
        private List<INoteData> _notes;

        /// <summary>
        /// Paramaterless constructor for NoteLogic class
        /// </summary>
        public NoteLogic()
        {
            // Instantiate _notes 
            ///_notes = new List<INoteData>();
        }

        /// <summary>
        /// METHOD : Initialise
        /// DESC : Initialise this class with a list of notes
        /// </summary>
        /// <param name="pNotes"></param>
        public void Initialise(List<INoteData> pNotes)
        {
            // Set _notes to pNotes
            _notes = pNotes;
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
            FishyNote _noteView = new FishyNote();

            // Show _noteView
            _noteView.Show();
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
        public void ChangeNote(int pIndex)
        {

        }
    }
}
