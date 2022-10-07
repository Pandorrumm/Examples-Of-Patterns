using TMPro;

namespace StrategyPattern_1
{
    public class SwimBehavior :ISwim
    {
        private TMP_Text text;

        public SwimBehavior(TMP_Text _text)
        {
            text = _text;
        }

        public void Swim()
        {
            ShowText(text, "Я Умею плавать!");
        }

        public void ShowText(TMP_Text _text, string _message)
        {
            _text.gameObject.SetActive(true);
            _text.text = _message;
        }
    }
}
