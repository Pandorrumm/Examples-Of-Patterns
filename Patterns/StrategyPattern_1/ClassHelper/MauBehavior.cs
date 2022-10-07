using TMPro;

namespace StrategyPattern_1
{
    public class MauBehavior : ISpeak
    {
        private TMP_Text text;

        public MauBehavior(TMP_Text _text)
        {
            text = _text;
        }

        public void Speak()
        {
            ShowText(text, "Ìÿó Ìÿó Ìóððð, ÿ ìÿóêàþ");
        }

        public void ShowText(TMP_Text _text, string _message)
        {
            _text.gameObject.SetActive(true);
            _text.text = _message;
        }
    }
}
