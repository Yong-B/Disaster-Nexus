using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fixed : MonoBehaviour
{
    // Inspector에서 위치와 회전 값을 설정할 수 있는 public 변수
    public Vector3 position;
    public Quaternion rotation;
    public AudioClip soundEffect; // Inspector에서 설정할 수 있는 효과음 클립
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

    private IEnumerator MoveAndAttach(Rigidbody target)
    {
        // 이 오브젝트를 사용자가 설정한 위치로 이동
        transform.position = position;

        // 이 오브젝트를 사용자가 설정한 회전 값으로 회전
        transform.rotation = rotation;

        yield return new WaitForFixedUpdate();

        // Fixed Joint 컴포넌트가 아직 없다면 추가하고 타겟과 연결
        if (gameObject.GetComponent<FixedJoint>() == null)
        {
            FixedJoint fj = gameObject.AddComponent<FixedJoint>(); // 고정
            fj.connectedBody = target;

            // 충돌 시 효과음을 재생합니다.
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
       // 충돌한 오브젝트가 "Clip" 태그를 가지고 있는지 확인
       if (collision.gameObject.tag == "Clip")
       {
           // 오브젝트에 이미 Fixed Joint가 있는지 확인
           if (gameObject.GetComponent<FixedJoint>() == null)
           {
               // Fixed Joint가 없으면 추가
               FixedJoint fj = gameObject.AddComponent<FixedJoint>();
               fj.connectedBody = collision.rigidbody;
               transform.position = collision.transform.position;
               Debug.Log("충돌");
           }
       }
       */