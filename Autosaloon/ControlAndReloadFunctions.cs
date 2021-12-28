using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autosaloon
{
    public interface ControlAndReloadFunctions
    {
        bool TextBoxDataChecked();
        int ParserAutoIDTextBox(string parseText);
        void ReloadData();
    }
}
