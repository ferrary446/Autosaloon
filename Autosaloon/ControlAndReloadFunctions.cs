
namespace Autosaloon
{
    // Interface pro povinne použití ty funkce
    public interface ControlAndReloadFunctions
    {
        bool TextBoxDataChecked();
        int ParserAutoIDTextBox(string parseText);
        void ReloadData();
    }
}
