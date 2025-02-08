using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class encounterFire : MonoBehaviour
{
    private void OnTriggerEnter(Collider coll)
    {
        if (coll.CompareTag("Player"))
        {
            GameManager.Instance.FireQuest5Clear();
        }
        gameObject.SetActive(false);
    }
}
