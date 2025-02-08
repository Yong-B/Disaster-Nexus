using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wettowelTrigger : MonoBehaviour
{
    public GameObject wettowel;
    private void OnTriggerEnter(Collider coll)
    {
        if (coll.CompareTag("wettowel"))
        {
            wettowel.gameObject.SetActive(false);
            GameManager.Instance.FireQuest3Clear();
        }
    }
}
