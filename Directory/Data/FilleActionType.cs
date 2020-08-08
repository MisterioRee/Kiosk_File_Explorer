using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiosk_File_Explorer.Directory.Data
{
    public enum FileActionType
    {
        /// <summary>
        /// Action to Copy Directory OR File(s) 
        /// </summary>
        Copy,
        /// <summary>
        /// Action to Cut Directory OR File(s)
        /// </summary>
        Cut
    }
}
