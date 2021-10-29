using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Program packages
using FishyNotesRedux.Interfaces;
using FishyNotesRedux.Logic;
using FishyNotesRedux.Storage;
using FishyNotesRedux.Delegators;
using FishyNotesRedux.Forms;

namespace FishyNotesRedux
{
    public partial class FishyNotes : Form
    {

        // Declare new _noteLogic
        INoteLogic _noteLogic;

        // Declare new _fishyNote
        FishyNote _noteView;

        // Delcare int for tracking note identity
        int _noteIndex = 0;

        // Declare new note delegator for storing note tet in NoteDataElement
        NoteDel _noteDel;

        // Declare delegate for getting note from data element
        GetNoteDel _getNoteDel;

        // Declare new note data element
        INoteData _noteData;

        // Declare delegate for retrieving dictionary length
        DictLenDel _dictLenDel;

        // Declare delegate for deleting notes
        DeleteNoteDelegate _deleteNoteDelegate;

        /// <summary>
        /// FishyNotes class constructor
        /// </summary>
        public FishyNotes()
        {
            // Instantiate _noteData
            _noteData = new NoteDataElement();

            // Assign _noteDel delegate to _noteData.SetNote method
            _noteDel = _noteData.SetNote;

            // Assign _getNoteDel delegate to _noteData.GetNote method
            _getNoteDel = _noteData.GetNote;

            // Assign _dictLenDel to _noteData.GetLen method
            _dictLenDel = _noteData.GetLen;

            _deleteNoteDelegate = _noteData.DeleteNote;

            InitializeComponent();
        }

        /// <summary>
        /// METHOD: NewNote
        /// DESC: Creates and launches a new fishyNote form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewNote(object sender, EventArgs e)
        {
            // Instantiate _noteLogic
            _noteLogic = new NoteLogic();

            // Instantiate _noteView with new FishyNote
            _noteView = new FishyNote();

            // Initialise _noteView by calling its init method and passing:
            // _noteIndex, _noteLogic, _noteLogic, _noteData, _noteDel
            _noteView.init(_noteIndex, _noteLogic, _noteData, _noteDel, _getNoteDel, _dictLenDel, _deleteNoteDelegate);

            // Increment noteIndex value
            _noteIndex++;

            //Console.WriteLine("Note index value: " + _noteIndex);
        }


        private void PrintDictLen(object sender, EventArgs e)
        {
            Console.WriteLine("Dictionary length : " + _dictLenDel(0));
        }
    }
}
