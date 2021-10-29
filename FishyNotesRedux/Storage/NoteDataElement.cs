using System;
using System.Collections.Generic;
using System.Text;

// Program packages
using FishyNotesRedux.Interfaces;

namespace FishyNotesRedux.Storage
{
    class NoteDataElement : INoteData
    {
        // Class variables

        // Declare dictionary for storing string data
        // Call it "_noteText"
        // Use int and string as key value pair
        private Dictionary<int, string> _noteText;

        /// <summary>
        /// Parameterless constructor for NoteDataElement class
        /// </summary>
        public NoteDataElement()
        {
            // Instantiate _noteText with new Dictionary<int, string>
            _noteText = new Dictionary<int, string>();

            Console.WriteLine("NoteData has been created");
        }

        /// <summary>
        /// METHOD : GetNote
        /// DESC : Returns the text data
        /// </summary>
        /// <returns> _noteText </returns>
        public string GetNote(int pKey)
        {
            // Return _noteText
            return _noteText[pKey];
        }

        /// <summary>
        /// METHOD : SetNote
        /// DESC : Sets the _noteText data to incoming paramater
        /// </summary>
        /// <param name="pKey"> Note index indentity </param>
        /// <param name="pText"> The text to be stored </param>
        public void SetNote(int pKey, string pText)
        {
            // Set _noteText
            _noteText[pKey] = pText;

            // Print confirmation
            //Console.WriteLine("Dictionary value : " + pKey + ", set to data : " + _noteText[pKey] + "( From parameter: " + pText + ")");
        }

        /// <summary>
        /// METHOD : Deletes a note from the dictionary
        /// DESC : Deletes an entry from the dictionary for the given key integer
        /// </summary>
        /// <param name="pKey"> The key for the selected entry </param>
        public void DelNote(int pKey)
        {
            
        }

        /// <summary>
        /// METHOD : GetLen
        /// DESC : returns the length of the dictionary
        /// </summary>
        /// <param name="pKey"></param>
        /// <returns></returns>
        public int GetLen(int pKey)
        {
            int _dictLength = _noteText.Count;
            return _dictLength;
        }

        public void DeleteNote(int pKey)
        {
            //_noteText.Remove(pKey);

            Console.WriteLine("Removing note : " + pKey);

            for(int i = pKey; i < _noteText.Count; i++)
            {
                Console.WriteLine("");
            }
        }
    }
}
