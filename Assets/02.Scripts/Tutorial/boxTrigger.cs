using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Box"))
        {
            GameManager.Instance.TutorQuest2Clear();
            
        }
        
    }

    
   
}
