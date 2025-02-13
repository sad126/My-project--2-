using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assigment27
{
    public class TEST : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            int a = 0;
            int b  = 0;
            add(a);
            print(a);
            refadd(ref b);
            print(b);
            int outI = 5;
            outadd(out outI);
            print(outI);
        }
        public void add(int item){
            item += 10;
        }
        public void refadd(ref int item){
            item +=10;
        } 
        public void outadd(out int item){
            item = 0; 
            item +=10;
        }

    }
}