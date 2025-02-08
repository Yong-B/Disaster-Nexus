using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fixed : MonoBehaviour
{
    // Inspector���� ��ġ�� ȸ�� ���� ������ �� �ִ� public ����
    public Vector3 position;
    public Quaternion rotation;
    public AudioClip soundEffect; // Inspector���� ������ �� �ִ� ȿ���� Ŭ��
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

    private IEnumerator MoveAndAttach(Rigidbody target)
    {
        // �� ������Ʈ�� ����ڰ� ������ ��ġ�� �̵�
        transform.position = position;

        // �� ������Ʈ�� ����ڰ� ������ ȸ�� ������ ȸ��
        transform.rotation = rotation;

        yield return new WaitForFixedUpdate();

        // Fixed Joint ������Ʈ�� ���� ���ٸ� �߰��ϰ� Ÿ�ٰ� ����
        if (gameObject.GetComponent<FixedJoint>() == null)
        {
            FixedJoint fj = gameObject.AddComponent<FixedJoint>(); // ����
            fj.connectedBody = target;

            // �浹 �� ȿ������ ����մϴ�.
            audioSource.Play();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Clip")
        {
            StartCoroutine(MoveAndAttach(collision.rigidbody));
        }
    }
}




/*
       private void OnCollisionEnter(Collision collision)
       // �浹�� ������Ʈ�� "Clip" �±׸� ������ �ִ��� Ȯ��
       if (collision.gameObject.tag == "Clip")
       {
           // ������Ʈ�� �̹� Fixed Joint�� �ִ��� Ȯ��
           if (gameObject.GetComponent<FixedJoint>() == null)
           {
               // Fixed Joint�� ������ �߰�
               FixedJoint fj = gameObject.AddComponent<FixedJoint>();
               fj.connectedBody = collision.rigidbody;
               transform.position = collision.transform.position;
               Debug.Log("�浹");
           }
       }
       */