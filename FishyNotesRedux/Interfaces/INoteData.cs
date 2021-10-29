using System;
using System.Collections.Generic;
using System.Text;

namespace FishyNotesRedux.Interfaces
{
    public interface INoteData
    {

        // Return note string text data
        public string GetNote(int pKey);

        // Set note string text data
        public void SetNote(int pKey, string pText);

        // Delete note
        public void DelNote(int pKey);

        public int GetLen(int pKey);

        public void DeleteNote(int pKey);
    }
}
