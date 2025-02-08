using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorCtrl : MonoBehaviour
{
    public Transform CameraTr;
    public List<Transform> UiTrs; 
    public float OnDist = 4f;
    public float OffDist = 4f;
    public float UpdateInterval = 0.5f;

    private bool CheckDist = false;

    void Start()
    {
        StartCoroutine(CheckPlayerDistance());
    }

    IEnumerator CheckPlayerDistance()
    {
        CheckDist = true;

        while (CheckDist)
        {
            
            for (int i = 0; i < UiTrs.Count; i++)
            {
                Transform UiTr = UiTrs[i];
                float distance = Vector3.Distance(CameraTr.position, UiTr.position);

                if (distance < OnDist)
                {
                    UiTr.gameObject.SetActive(true);
                    Debug.Log(UiTr.name + " ON");
                }
                else if (distance >= OffDist)
                {
                    UiTr.gameObject.SetActive(false);
                    Debug.Log(UiTr.name + " OFF");
                }
                else
                {
                    StopCheckingDistance();
                    Debug.Log(UiTr.name + " ELSE");
                }
            }

            yield return new WaitForSeconds(UpdateInterval);
        }
    }

    public void StopCheckingDistance()
    {
        CheckDist = false;
    }

}
