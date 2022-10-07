using TMPro;

namespace StrategyPattern_1
{
    public class SleepBehavior : ISleep
    {
        private TMP_Text text;

        public SleepBehavior(TMP_Text _text)
        {
            text = _text;
        }

        public void Sleep()
        {
            ShowText(text, "я Ћюблю спать!");
        }

        public void ShowText(TMP_Text _text, string _message)
        {
            _text.gameObject.SetActive(true);
            _text.text = _message;
        }
    }
}
