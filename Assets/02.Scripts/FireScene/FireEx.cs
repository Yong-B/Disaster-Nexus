using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireEx : MonoBehaviour
{
    public GameObject hoseTrigger; // HoseTrigger 오브젝트를 Inspector에서 할당해주어야 합니다.

    // Start is called before the first frame update
    

    // 트리거 안으로 들어갈 때 호출되는 함수
    void OnTriggerEnter(Collider other)
    {
        // 충돌한 오브젝트가 Player인 경우 HoseTrigger 오브젝트를 활성화시킴
        if (other.CompareTag("Player"))
        {
            hoseTrigger.SetActive(true);
        }
    }
    
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            hoseTrigger.SetActive(false);
        }
    }
}
