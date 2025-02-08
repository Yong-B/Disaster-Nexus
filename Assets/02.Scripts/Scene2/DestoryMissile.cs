using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryMissile : MonoBehaviour
{
   
    

    void Start()
    {
     
    }
        

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
       
        
    }
}
   