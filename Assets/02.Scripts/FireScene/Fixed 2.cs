using System.Collections;
using UnityEngine;

public class Fixed2 : MonoBehaviour
{
    public Transform targetTransform; // 추적할 오브젝트의 Transform 컴포넌트
    public Vector3 additionalPosition; // 인스펙터 창에서 추가로 이동할 위치 값
    public Vector3 additionalRotation; // 인스펙터 창에서 추가로 회전할 값
    public AudioClip soundEffect; // 인스펙터 창에서 설정할 수 있는 효과음 클립
    private AudioSource audioSource;

    private void Start()
    {
        // AudioSource 컴포넌트를 가져옵니다. 없다면 추가합니다.
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        // 효과음 클립을 지정합니다.
        audioSource.clip = soundEffect;
    }

    IEnumerator MoveAndAttach(Rigidbody target)
    {
        // 추적할 오브젝트의 위치와 회전으로 이동
        transform.position = targetTransform.position + additionalPosition;
        transform.rotation = targetTransform.rotation * Quaternion.Euler(additionalRotation);

        yield return new WaitForFixedUpdate();

        // Fixed Joint 컴포넌트가 없으면 추가
        if (gameObject.GetComponent<FixedJoint>() == null)
        {
            FixedJoint fj = gameObject.AddComponent<FixedJoint>();
            fj.connectedBody = target; // 대상 리지드바디와 연결

            // 충돌 시 효과음을 재생합니다.
            audioSource.Play();
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Clip2")
        {
            StartCoroutine(MoveAndAttach(collision.rigidbody)); // 코루틴 시작
        }
    }
}














/*
using System.Collections;
using UnityEngine;

public class Fixed2 : MonoBehaviour
{
    IEnumerator MoveAndAttach(Rigidbody target)
    {
        yield return new WaitForFixedUpdate();

        if (gameObject.GetComponent<FixedJoint>() == null)
        {
            FixedJoint fj = gameObject.AddComponent<FixedJoint>();
            fj.connectedBody = target;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Clip2")
        {
            StartCoroutine(MoveAndAttach(collision.rigidbody));
        }
    }
}
*/