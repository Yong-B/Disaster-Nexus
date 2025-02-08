using System.Collections;
using UnityEngine;

public class Fixed2 : MonoBehaviour
{
    public Transform targetTransform; // ������ ������Ʈ�� Transform ������Ʈ
    public Vector3 additionalPosition; // �ν����� â���� �߰��� �̵��� ��ġ ��
    public Vector3 additionalRotation; // �ν����� â���� �߰��� ȸ���� ��
    public AudioClip soundEffect; // �ν����� â���� ������ �� �ִ� ȿ���� Ŭ��
    private AudioSource audioSource;

    private void Start()
    {
        // AudioSource ������Ʈ�� �����ɴϴ�. ���ٸ� �߰��մϴ�.
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        // ȿ���� Ŭ���� �����մϴ�.
        audioSource.clip = soundEffect;
    }

    IEnumerator MoveAndAttach(Rigidbody target)
    {
        // ������ ������Ʈ�� ��ġ�� ȸ������ �̵�
        transform.position = targetTransform.position + additionalPosition;
        transform.rotation = targetTransform.rotation * Quaternion.Euler(additionalRotation);

        yield return new WaitForFixedUpdate();

        // Fixed Joint ������Ʈ�� ������ �߰�
        if (gameObject.GetComponent<FixedJoint>() == null)
        {
            FixedJoint fj = gameObject.AddComponent<FixedJoint>();
            fj.connectedBody = target; // ��� ������ٵ�� ����

            // �浹 �� ȿ������ ����մϴ�.
            audioSource.Play();
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Clip2")
        {
            StartCoroutine(MoveAndAttach(collision.rigidbody)); // �ڷ�ƾ ����
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