using System;
using System.Collections.Generic;
using System.Text;
using FishyNotesRedux.Interfaces;

namespace FishyNotesRedux.Storage
{
    class NoteDataElement : INoteData
    {
        // Class variables

        // Declare string for storing text data
        // Call it "_noteText"
        private string _noteText;

        /// <summary>
        /// Parameterless constructor for NoteDataElement class
        /// </summary>
        public NoteDataElement()
        {

        }

        /// <summary>
        /// METHOD : GetNote
        /// DESC : Returns the text data
        /// </summary>
        /// <returns> _noteText </returns>
        public string GetNote()
        {
            // Return _noteText
            return _noteText;
        }

        /// <summary>
        /// METHOD : SetNote
        /// DESC : Sets the _noteText data to incoming paramater
        /// </summary>
        /// <param name="pText"> Incoming note data </param>
        public void SetNote(string pText)
        {
            // Set _noteText
            _noteText = pText;
        }
    }
}
