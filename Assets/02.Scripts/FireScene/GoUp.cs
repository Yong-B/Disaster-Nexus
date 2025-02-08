using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoUp : MonoBehaviour
{
    private void OnTriggerEnter(Collider coll)
    {
        if (coll.CompareTag("Player"))
        {
            GameManager.Instance.FireQuest4Clear();
        }
        gameObject.SetActive(false);
    }
}
