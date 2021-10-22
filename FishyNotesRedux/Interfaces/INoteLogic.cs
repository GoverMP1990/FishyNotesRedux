using System;
using System.Collections.Generic;
using System.Text;

namespace FishyNotesRedux.Interfaces
{
    interface INoteLogic
    {

        // Initialise method
        // Initialise class with a list of INoteData type objects
        public void Initialise(List<INoteData> pNotes);

        // Add note method
        // Create a new blank note
        public void AddNote();

        // Delete note method
        // Delete the note that is currently open
        public void DeleteNote(int pIndex);

        // View note method
        // TBA
        public void ViewNote(int pIndex);

        // Change existing note
        // Update the contents of the open note
        public void ChangeNote(int pIndex);
    }
}
