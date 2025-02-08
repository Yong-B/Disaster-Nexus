using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HandleTemp : MonoBehaviour
{
    public Transform CameraTr;
    public Transform FireParticleTr;
    public Transform SafeUiTr;
    public Transform WarnUiTr;
    public float OnDist = 5f;
    public float OffDist = 5f;
    private float UpdateInterval = 0.1f;

    private bool CheckDist = false;
    private bool CheckDist2 = false;

    void Start()
    {
        StartCoroutine(CheckPlayerDistance());
        StartCoroutine(CheckPlayerDistance2());
    }

    // 안전ui 코루틴
    IEnumerator CheckPlayerDistance()
    {
        CheckDist = true;

        while (CheckDist)
        {
            float fireParticleDistance = Vector3.Distance(SafeUiTr.position, FireParticleTr.position);
            float distance = Vector3.Distance(CameraTr.position, SafeUiTr.position);

            if (distance < OnDist && fireParticleDistance < OnDist)
            {
                SafeUiTr.gameObject.SetActive(false);
            }
            else if (distance < OnDist)
            {
                SafeUiTr.gameObject.SetActive(true);
            }
            else if (distance >= OffDist)
            {
                SafeUiTr.gameObject.SetActive(false);
            }
            else
            {
                StopCheckingDistance();
                Debug.Log("SafeStop");
            }

            yield return new WaitForSeconds(UpdateInterval);
        }
    }

    // 위험ui 코루틴
    IEnumerator CheckPlayerDistance2()
    {
        CheckDist2 = true;

        while (CheckDist2)
        {
            float fireParticleDistance = Vector3.Distance(WarnUiTr.position, FireParticleTr.position); // 여기서 두 번째 UiTr 사용
            float distance = Vector3.Distance(CameraTr.position, WarnUiTr.position);

            if (distance < OnDist && fireParticleDistance < OnDist)
            {
                WarnUiTr.gameObject.SetActive(true);
            }
            else if (distance < OnDist)
            {
                WarnUiTr.gameObject.SetActive(false);
            }
            else if (distance >= OffDist)
            {
                WarnUiTr.gameObject.SetActive(false);
            }
            else
            {
                StopCheckingDistance2();
                Debug.Log("WarnStop");
            }

            yield return new WaitForSeconds(UpdateInterval);
        }
    }


    public void StopCheckingDistance()
    {
        CheckDist = false;
    }

    public void StopCheckingDistance2()
    {
        CheckDist2 = false;
    }
}




/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HandleTemp : MonoBehaviour
{
    public Transform CameraTr;
    public List<Transform> FireParticleTrs;
    public List<Transform> SafeUiTrs;
    public List<Transform> WarnUiTrs;
    public List<Transform> UiTrs;
    public float OnDist = 5f;
    public float OffDist = 5f;
    private float UpdateInterval = 0.1f;

    private bool CheckDist = false;
    private bool CheckDist2 = false;
    private bool CheckDist3 = false;

    void Start()
    {
        StartCoroutine(CheckPlayerDistance());
        StartCoroutine(CheckPlayerDistance2());
        StartCoroutine(CheckPlayerDistance3());
    }


    // 안전ui 코루틴
    IEnumerator CheckPlayerDistance()
    {
        CheckDist = true;

        while (CheckDist)
        {
            for (int f = 0; f < FireParticleTrs.Count; f++)
            {
                Transform FireParticleTr = FireParticleTrs[f];

                for (int i = 0; i < SafeUiTrs.Count; i++)
                {
                    Transform UiTr = SafeUiTrs[i];
                    float fireParticleDistance = Vector3.Distance(UiTr.position, FireParticleTr.position);
                    float distance = Vector3.Distance(CameraTr.position, UiTr.position);

                    if (distance < OnDist && fireParticleDistance < OnDist)
                    {
                        UiTr.gameObject.SetActive(false);
                    }
                    else if (distance < OnDist)
                    {
                        UiTr.gameObject.SetActive(true);
                    }
                    else if (distance >= OffDist)
                    {
                        UiTr.gameObject.SetActive(false);
                    }
                    else
                    {
                        StopCheckingDistance();
                        Debug.Log("SafeStop");
                    }
                }
            }
            yield return new WaitForSeconds(UpdateInterval);
        }
    }

    // 위험ui 코루틴
    IEnumerator CheckPlayerDistance2()
    {
        CheckDist2 = true;

        while (CheckDist2)
        {
            for (int f = 0; f < FireParticleTrs.Count; f++)
            {
                Transform FireParticleTr = FireParticleTrs[f];

                for (int i = 0; i < WarnUiTrs.Count; i++)
                {
                    Transform UiTr = WarnUiTrs[i];
                    float fireParticleDistance = Vector3.Distance(UiTr.position, FireParticleTr.position);
                    float distance = Vector3.Distance(CameraTr.position, UiTr.position);

                    if (distance < OnDist && fireParticleDistance < OnDist)
                    {
                        UiTr.gameObject.SetActive(true);
                    }
                    else if (distance < OnDist)
                    {
                        UiTr.gameObject.SetActive(false);
                    }
                    else if (distance >= OffDist)
                    {
                        UiTr.gameObject.SetActive(false);
                    }
                    else
                    {
                        StopCheckingDistance2();
                        Debug.Log("WarnStop");
                    }
                }
            }
            yield return new WaitForSeconds(UpdateInterval);
        }
    }


    // 일반 버튼들 거리에 따라 on off
    IEnumerator CheckPlayerDistance3()
    {
        CheckDist3 = true;

        while (CheckDist3)
        {

            for (int i = 0; i < UiTrs.Count; i++)
            {
                Transform UiTr = UiTrs[i];
                float distance = Vector3.Distance(CameraTr.position, UiTr.position);

                if (distance < OnDist)
                {
                    UiTr.gameObject.SetActive(true);
                }
                else if (distance >= OffDist)
                {
                    UiTr.gameObject.SetActive(false);
                }
                else
                {
                    StopCheckingDistance3();
                }
            }
            yield return new WaitForSeconds(UpdateInterval);
        }
    }

    public void StopCheckingDistance()
    {
        CheckDist = false;
    }

    public void StopCheckingDistance2()
    {
        CheckDist2 = false;
    }

    public void StopCheckingDistance3()
    {
        CheckDist3 = false;
    }
}
*/



/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HandleTemp : MonoBehaviour
{
    public Transform CameraTr;
    public float OnDist = 4f;
    public float OffDist = 4f;
    private float UpdateInterval = 0.3f;

    private bool CheckDist = false;
    private bool CheckDist2 = false;
    private bool CheckDist3 = false;

    public string fireTag = "FireTr";
    public string safeTag = "SafeTr";
    public string warnTag = "WarnTr";
    public string btnTag = "BtnTr";

    void Start()
    {
        StartCoroutine(CheckPlayerDistance());
        StartCoroutine(CheckPlayerDistance2());
        StartCoroutine(CheckPlayerDistance3());
    }

    IEnumerator CheckPlayerDistance()
    {
        CheckDist = true;
        Debug.Log("A1");

        while (CheckDist)
        {
            GameObject[] fireParticles = GameObject.FindGameObjectsWithTag(fireTag);
            GameObject[] safeUis = GameObject.FindGameObjectsWithTag(safeTag);
            Debug.Log("A2");
            foreach (GameObject fireParticle in fireParticles)
            {
                foreach (GameObject safeUi in safeUis)
                {
                    float fireParticleDistance = Vector3.Distance(safeUi.transform.position, fireParticle.transform.position);
                    float distance = Vector3.Distance(CameraTr.position, safeUi.transform.position);
                    Debug.Log("A3");
                    if (distance < OnDist && fireParticleDistance < OnDist)
                    {
                        safeUi.SetActive(false);
                        Debug.Log("A4");

                    }
                    else if (distance < OnDist)
                    {
                        safeUi.SetActive(true);
                        Debug.Log("A5");
                    }
                    else if (distance >= OffDist)
                    {
                        safeUi.SetActive(false);
                        Debug.Log("A6");
                    }
                    else
                    {
                        StopCheckingDistance();
                        Debug.Log("SafeStop");
                    }
                }
            }

            yield return new WaitForSeconds(UpdateInterval);
            Debug.Log("A7");
        }
    }

    IEnumerator CheckPlayerDistance2()
    {
        CheckDist2 = true;
        Debug.Log("B1");

        while (CheckDist2)
        {
            GameObject[] fireParticles = GameObject.FindGameObjectsWithTag(fireTag);
            GameObject[] warnUis = GameObject.FindGameObjectsWithTag(warnTag);
            Debug.Log("B2");
            foreach (GameObject fireParticle in fireParticles)
            {
                foreach (GameObject warnUi in warnUis)
                {
                    float fireParticleDistance = Vector3.Distance(warnUi.transform.position, fireParticle.transform.position);
                    float distance = Vector3.Distance(CameraTr.position, warnUi.transform.position);
                    Debug.Log("B3");
                    if (distance < OnDist && fireParticleDistance < OnDist)
                    {
                        warnUi.SetActive(true);
                        Debug.Log("B4");
                    }
                    else if (distance < OnDist)
                    {
                        warnUi.SetActive(false);
                        Debug.Log("B5");
                    }
                    else if (distance >= OffDist)
                    {
                        warnUi.SetActive(false);
                        Debug.Log("B6");
                    }
                    else
                    {
                        StopCheckingDistance2();
                        Debug.Log("WarnStop");
                    }
                }
            }

            yield return new WaitForSeconds(UpdateInterval);
            Debug.Log("B7");
        }
    }

    IEnumerator CheckPlayerDistance3()
    {
        CheckDist3 = true;
        Debug.Log("C1");
        while (CheckDist3)
        {
            GameObject[] btnObjects = GameObject.FindGameObjectsWithTag("BtnTr");
            Debug.Log("C2");
            foreach (GameObject btnObject in btnObjects)
            {
                float distance = Vector3.Distance(CameraTr.position, btnObject.transform.position);
                Debug.Log("C3");
                if (distance < OnDist)
                {
                    btnObject.SetActive(true);
                    Debug.Log("C4");
                }
                else if (distance >= OffDist)
                {
                    btnObject.SetActive(false);
                    Debug.Log("C5");
                }
                else
                {
                    StopCheckingDistance3();
                    Debug.Log("BtnStop");
                }
            }

            yield return new WaitForSeconds(UpdateInterval);
            Debug.Log("C6");
        }
    }

    public void StopCheckingDistance()
    {
        CheckDist = false;
    }

    public void StopCheckingDistance2()
    {
        CheckDist2 = false;
    }

    public void StopCheckingDistance3()
    {
        CheckDist3 = false;
    }
}

*/
