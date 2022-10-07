using TMPro;

namespace StrategyPattern_1
{
    public class SpeekWithHumanVoiceBehavior : ISpeak
    {
        private TMP_Text text;

        public SpeekWithHumanVoiceBehavior(TMP_Text _text)
        {
            text = _text;
        }

        public void Speak()
        {
            ShowText(text, "Я Попугай, я говорю!");
        }

        public void ShowText(TMP_Text _text, string _message)
        {
            _text.gameObject.SetActive(true);
            _text.text = _message;
        }
    }
}
