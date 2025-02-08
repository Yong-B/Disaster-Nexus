using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShelterNav2 : MonoBehaviour
{
    private void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.CompareTag("Player"))
        {
            GameManager.Instance.CityNav2();
        }
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
