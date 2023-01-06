using System;
using UnityEngine;

namespace CorutinesAndEvents.Scripts
{
    public class EventsSample : MonoBehaviour
    {
        public event Action MyEmptyEvent; 
        public event Action<int> MyIntEvent;
        private int i = 0;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.K))
            {
                MyEmptyEvent?.Invoke(); 
            }

            if (Input.GetKeyDown(KeyCode.F))
            {
                MyIntEvent?.Invoke(i);
                i++;
            }
        }
    }
}