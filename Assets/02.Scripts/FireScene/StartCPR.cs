using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartCPR : MonoBehaviour
{
    private void OnTriggerEnter(Collider coll)
    {
        if (coll.CompareTag("Player"))
        {
            GameManager.Instance.FireQuest6Clear();
        }
        gameObject.SetActive(false);
    }
}
