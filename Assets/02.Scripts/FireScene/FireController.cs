using UnityEngine;
using System.Collections;


public class FireController : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("HoseTrigger"))
        {
            Invoke("ExFire", 7f);
        }
    }

    private void ExFire()
    {
        gameObject.SetActive(false);
    }
}
