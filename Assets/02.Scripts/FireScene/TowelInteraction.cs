using UnityEngine;

public class TowelInteraction : MonoBehaviour
{
    public GameObject dryTowel;
    public GameObject wetTowel;
    private bool isWet = false;

    private void Start()
    {
        // ó������ ������ ������ Ȱ��ȭ�Ǿ�� �մϴ�.
        dryTowel.SetActive(true);
        wetTowel.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        // �� ��ƼŬ�� �浹 �� ���� �������� ����
        if (other.CompareTag("WaterParticle"))
        {
            if (!isWet)
            {
                // �տ��� ���� dryTowel ������Ʈ�� ��ġ�� ȸ���� ����
                Vector3 dryTowelPosition = dryTowel.transform.position;
                Quaternion dryTowelRotation = dryTowel.transform.rotation;

                dryTowel.SetActive(false);
                wetTowel.SetActive(true);
                isWet = true;

                // wetTowel�� dryTowel�� �ִ� ��ġ�� ȸ������ �̵�
                wetTowel.transform.position = dryTowelPosition;
                wetTowel.transform.rotation = dryTowelRotation;
            }
        }
    }


}