using TMPro;

namespace StrategyPattern_1
{
    public class CanNotBehavior : ICanNot
    {
        private TMP_Text text;

        public CanNotBehavior(TMP_Text _text)
        {
            text = _text;
        }

        public void CanNot()
        {
            ShowText(text, "Я Этого НЕ Умею!");
        }

        public void ShowText(TMP_Text _text, string _message)
        {
            _text.gameObject.SetActive(true);
            _text.text = _message;
        }
    }
}
