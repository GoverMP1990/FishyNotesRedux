using System;
using System.Collections.Generic;
using System.Text;

namespace FishyNotesRedux.Interfaces
{
    interface INoteData
    {

        // Return note string text data
        public string GetNote();

        // Set note string text data
        public void SetNote(string pText);
    }
}
