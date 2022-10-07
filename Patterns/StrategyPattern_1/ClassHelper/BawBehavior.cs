using TMPro;

namespace StrategyPattern_1
{
    public class BawBehavior : ISpeak
    {
        private TMP_Text text;

        public BawBehavior(TMP_Text _text)
        {
            text = _text;
        }

        public void Speak()
        {
            ShowText(text, "Гав Гав сучары");
        }

        public void ShowText(TMP_Text _text, string _message)
        {
            _text.gameObject.SetActive(true);
            _text.text = _message;
        }
    }
}
