using System;
namespace ChapterOne
{
    delegate void MyDelegate(string message);

    class EventPublisher
    {      
        public event MyDelegate MyEvent;

        public void TriggerEvent(string message)
        {
            MyEvent?.Invoke(message);
        }
    }
}

