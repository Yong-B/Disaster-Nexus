using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorQ1Trigger : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.Instance.TutorQuest1Clear();

        }

    }

}
