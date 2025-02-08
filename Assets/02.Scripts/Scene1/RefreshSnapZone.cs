using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RefreshSnapZone : MonoBehaviour
{
    public GameObject snapzone;
    private GameObject bag;

    void Start()
    {
        bag = GameObject.Find("Bag");
    }

    public void InSnapZone()
    {
        StartCoroutine(RefreshSnapzone());
    }

    IEnumerator RefreshSnapzone()
    {
        GameObject SZone = Instantiate(snapzone, this.transform.position, this.transform.rotation);
        
        SZone.transform.SetParent(bag.transform, false);
        SZone.transform.localPosition = new Vector3(0.065f, 0.06f, -0.054f);

        yield return new WaitForSeconds(1f);
        this.gameObject.SetActive(false);
        yield break;
    }
}
