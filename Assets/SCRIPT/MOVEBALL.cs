using System.Collections;
using System.Collections.Generic;

using UnityEngine;



public class MOVEBALL : MonoBehaviour
{
    
    float speed = 4f;
    

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            float horizontalInput = Input.GetAxis("Horizontal");
            float vertecalInput = Input.GetAxis("Vertical");

            
            transform.Translate(Vector3.right * horizontalInput *speed * Time.deltaTime);
            transform.Translate(Vector3.forward * vertecalInput * speed * Time.deltaTime);
            
           
        
        
    }
   void OnCollisionEnter(Collision collision)
    {
        // إذا كان الكائن المتصادم معه هو "Cube"
        if (collision.gameObject.CompareTag("Cube"))
        {
            // تنفيذ شيء معين عند التصادم مع الكائن الذي يحمل الوسم "Cube"
            EndGame("GAME OVER");
        }
    }
     void EndGame(string message)
    {
  
        Debug.Log(message);

  

        Time.timeScale = 0;  

        
        Application.Quit();

        
    }
}
     

