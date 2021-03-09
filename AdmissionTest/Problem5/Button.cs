using System;

namespace Problem5
{
    public delegate void Del(string str);
    class Button
    {
        public event Del OnClick;

        public void Click()
        {
       
            OnClick("hello");
        }

        protected virtual void OnClicked(string str)
        {
            OnClick?.Invoke(str);
        }

    }

   
}
