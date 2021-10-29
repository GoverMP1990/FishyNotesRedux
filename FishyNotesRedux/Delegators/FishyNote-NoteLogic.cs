using System;
using System.Collections.Generic;
using System.Text;

namespace FishyNotesRedux.Delegators
{

    public delegate String ADelegate(int arg);

    public delegate void NoteDel(int key, string data);

    public delegate string GetNoteDel(int key);

    public delegate int DictLenDel(int key);

    public delegate void DeleteNoteDelegate(int key);
}
