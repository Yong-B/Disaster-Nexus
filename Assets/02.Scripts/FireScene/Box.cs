using UnityEngine;

public class ColliderInteraction : MonoBehaviour
{
    void Start()
    {
        if (gameObject.tag != "Box")
        {
            // 이 오브젝트가 특별한 콜라이더가 아닌 경우 IsTrigger를 활성화합니다.
            GetComponent<BoxCollider>().isTrigger = true;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Box")
        {
            // 특정 두 콜라이더 간의 로직
            Debug.Log("Special colliders collided!");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag != "Box")
        {
            // 그 외의 콜라이더들에 대한 로직
            Debug.Log("Trigger detected with other colliders!");
        }
    }
}