using UnityEngine;

namespace Assigment26
{
    public class Kangaroo : Creature, IJumpable, IRunnable
    {
        public void Jump()
        {
            Debug.Log("Kangaroo jumps.");
        }

        public void Run()
        {
            Debug.Log("Kangaroo runs.");
        }
        public override void Speak()
        {
            Debug.Log("Kangaroo says: Hop!");
        }
    }
}