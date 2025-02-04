using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assigment26
{
    public class CreatureManager : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            List <Creature> creatures = new List<Creature>();
            creatures.Add(new Kangaroo());
            creatures.Add(new Duck());
            List<IRunnable> runnables = new List<IRunnable>();
            List<IJumpable> jumpables = new List<IJumpable>();
            List<ISwimmable> swimmables = new List<ISwimmable>();
            runnables.Add(new Kangaroo());
            jumpables.Add(new Kangaroo());
            runnables.Add(new Duck());
            swimmables.Add(new Duck());
            foreach(Creature item in creatures){
                item.Speak();
            }
            foreach(IRunnable item in runnables){
                item.Run();
            }
            foreach(IJumpable item in jumpables){
                item.Jump();
            }
            foreach(ISwimmable item in swimmables){
                item.Swim();
            }
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}