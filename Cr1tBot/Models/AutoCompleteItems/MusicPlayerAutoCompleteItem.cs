using System;
using FastColoredTextBoxNS;

namespace Cr1tBot.Models.AutoCompleteItems
{
    public class MusicPlayerAutoCompleteItem : AutocompleteItem
    {
        private string _text;

        public MusicPlayerAutoCompleteItem(string text)
            : base(text)
        {
            _text = text;
        }
        public override CompareResult Compare(string fragmentText)
        {
            var isMain = fragmentText.EndsWith("musicPlayer.", StringComparison.OrdinalIgnoreCase);
            if (!isMain)
                return CompareResult.Hidden;
            return CompareResult.Visible;
        }
        public override string GetTextForReplace()
        {
            return "{musicPlayer." + _text + "}";
        }
    }
}
