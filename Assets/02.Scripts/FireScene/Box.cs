using UnityEngine;

public class ColliderInteraction : MonoBehaviour
{
    void Start()
    {
        if (gameObject.tag != "Box")
        {
            // �� ������Ʈ�� Ư���� �ݶ��̴��� �ƴ� ��� IsTrigger�� Ȱ��ȭ�մϴ�.
            GetComponent<BoxCollider>().isTrigger = true;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Box")
        {
            // Ư�� �� �ݶ��̴� ���� ����
            Debug.Log("Special colliders collided!");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag != "Box")
        {
            // �� ���� �ݶ��̴��鿡 ���� ����
            Debug.Log("Trigger detected with other colliders!");
        }
    }
}