using TMPro;

namespace StrategyPattern_1
{
    public class EatBehavior : IEat
    {
        private TMP_Text text;

        public EatBehavior(TMP_Text _text)
        {
            text = _text;
        }

        public void Eat()
        {
            ShowText(text, "Я Люблю Кушать!");
        }

        public void ShowText(TMP_Text _text, string _message)
        {
            _text.gameObject.SetActive(true);
            _text.text = _message;
        }
    }
}
