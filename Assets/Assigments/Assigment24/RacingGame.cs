using UnityEngine;
namespace Assigment24
{
    public class RacingGame : MonoBehaviour
    {
        public RaceState raceState;

        void Update(){
           
            SimulateRace();
        }
        public void SimulateRace()
        {
            switch (raceState)
            {
                case RaceState.Start:
                    print("The race is about to begin. Get ready!");
                    break;
                case RaceState.Accelerate:
                    print("You press the gas pedal. The car speeds up!");
                    break;
                case RaceState.Turn:
                    print("You approach a sharp turn. Be careful not tocrash!");
                    break;
                 case RaceState.Crash:
                    print("You hit a barrier. The race is over.");
                    break;
                 case RaceState.Finish:
                    print("You crossed the finish line. Well done!");
                    break;
                default :
                    print("This state is not defined. Something is wrong.");
                    break;
                
            }
        }
        
    }
    
}