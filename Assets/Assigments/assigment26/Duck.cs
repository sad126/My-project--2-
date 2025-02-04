using UnityEngine;

namespace Assigment26
{
    public class Duck : Creature, ISwimmable, IRunnable
    {
        public void Swim()
        {
            Debug.Log("Duck swims.");
        }

        public void Run()
        {
            Debug.Log("Duck runs.");
        }
        public override void Speak()
        {
            Debug.Log("Duck says: Hop!");
        }
    }
}