using System;

namespace MyLibrary
{
    public delegate void KeypressDelegate(char key);
    public delegate void QuitDelegate();
  public  class KeyStrokeHandler
    {
        public KeypressDelegate OnKey;
        public QuitDelegate OnQuitting;
       public void Run()
        {
            Console.WriteLine("Keystroke handler is running, press q to quit");
            while (true)
            {
                char key = Console.ReadKey(true).KeyChar;
                if ('q' == key)
                {
                    if (OnQuitting != null)
                        OnQuitting();
                    break;
                }

                if (null != OnKey)
                    OnKey(key);
            }
        }
    }
}
