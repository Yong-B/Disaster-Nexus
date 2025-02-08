using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toScene : MonoBehaviour
{
    public int targetSceneIndex;

    private void OnTriggerEnter(Collider coll)
    {
        if (coll.CompareTag("Player"))
        {
            FadeSceneMGR.Instance.GoToSceneAsync(targetSceneIndex);
        }
    }
}
