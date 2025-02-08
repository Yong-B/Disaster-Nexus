using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShelterNav : MonoBehaviour
{

    private void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.CompareTag("Player"))
        {
            GameManager.Instance.CityNav1();
        }
    }


    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
