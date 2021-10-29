using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

// Program packages
using FishyNotesRedux.Interfaces;
using FishyNotesRedux.Logic;
using FishyNotesRedux.Storage;
using FishyNotesRedux.Delegators;

namespace FishyNotesRedux.Forms
{
    public partial class FishyNote : Form
    {
        // Declare INoteLogic for handling fishyNote form logic
        // Call it _noteLogic
        private INoteLogic _noteLogic;

        // Declare integer for keeping a record of this note's indetity for correct dictionary access
        // Call it _noteIndex
        private int _noteIndex;

        // Declare INoteData for keeping a record of the note form data
        // Call it _noteData
        private INoteData _noteData;

        // Declare a NoteDel delegate for holding a reference to the delegate that gives access to noteData setNote method
        // Call it _noteDel
        private NoteDel _noteDel;

        // Declare a GetNoteDel delegate for getting stored notes from data element
        private GetNoteDel _getNoteDel;

        private DictLenDel _dictLenDel;

        /// <summary>
        /// FishyNote class constructor
        /// </summary>
        public FishyNote()
        {
            InitializeComponent();
        }

        /// <summary>
        /// METHOD : init - class initialise method
        /// DESC : Initialises objects of this class type by setting variables, objects and class references to passed in parameter values
        /// </summary>
        /// <param name="pNoteIndex"> The index value for indetifying different forms and their data </param>
        /// <param name="pFishyNote"> The logic class for the fishy note form </param>
        /// <param name="pNoteData"> DataElement class that stores note data </param>
        /// <param name="pNoteDel"> Delegate that gives access to note data method - SetNote </param>
        /// <param name="pGetNoteDel"> Delegate for getting the note stored in the dictionary in data element </param>
        public void init(int pNoteIndex, INoteLogic pFishyNote, INoteData pNoteData, NoteDel pNoteDel, GetNoteDel pGetNoteDel, DictLenDel pDictLenDel)
        {
            // Set _noteIndex to pNoteIndex
            _noteIndex = pNoteIndex;

            // Set _noteLogic to pFishyNote
            _noteLogic = pFishyNote;

            // Set _noteData to pNoteData
            //_noteData = pNoteData;

            // Set _noteDel to pNoteDel
            _noteDel = pNoteDel;

            // Set _getNoteDel to pGetNoteDel
            _getNoteDel = pGetNoteDel;

            _dictLenDel = pDictLenDel;

            // Initialise note logic
            _noteLogic.Initialise(_noteIndex, _noteDel, _dictLenDel);

            // Display this form
            this.Show();
        }

        private void SaveNote(object sender, EventArgs e)
        {
            
        }

        private void ShowNote(object sender, EventArgs e)
        {
            //_noteLogic.ViewNote(_noteIndex);
            Console.WriteLine(_getNoteDel(_noteIndex));
        }

        private void updateText(object sender, EventArgs e)
        {
            // Call noteLogic changeNote method and pass it this note's noteIndex value and the contents of the richTextBox contents
            _noteLogic.ChangeNote(_noteIndex, richTextBox1.Text);
        }

        private void _next(object sender, EventArgs e)
        {
            //_noteIndex+=1;
            _noteIndex = _noteLogic.Index;
            Console.WriteLine("Index before changing : " + _noteIndex);
            _noteIndex = _noteLogic.NextNote();
            Console.WriteLine("Index after changing : " + _noteIndex);

            richTextBox1.Text = _getNoteDel(_noteIndex);
        }

        private void _previous(object sender, EventArgs e)
        {
            /*
            if(_noteIndex-1 <0)
            {
                _noteIndex = 0;
            }
            else
            {
                _noteIndex-=1;
            }
            */
            _noteIndex = _noteLogic.Index;
            Console.WriteLine("Index before changing : " + _noteIndex);
            _noteIndex = _noteLogic.PreviousNote();
            Console.WriteLine("Index after changing : " + _noteIndex);

            richTextBox1.Text = _getNoteDel(_noteIndex);
        }
    }
}
