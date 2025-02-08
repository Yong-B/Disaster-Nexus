using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireEx : MonoBehaviour
{
    public GameObject hoseTrigger; // HoseTrigger ������Ʈ�� Inspector���� �Ҵ����־�� �մϴ�.

    // Start is called before the first frame update
    

    // Ʈ���� ������ �� �� ȣ��Ǵ� �Լ�
    void OnTriggerEnter(Collider other)
    {
        // �浹�� ������Ʈ�� Player�� ��� HoseTrigger ������Ʈ�� Ȱ��ȭ��Ŵ
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
