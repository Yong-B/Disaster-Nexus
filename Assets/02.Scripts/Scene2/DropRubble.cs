using UnityEngine;

public class DropRubble : MonoBehaviour
{
    public Rigidbody objectBRigidbody; // B 오브젝트의 Rigidbody
    public Rigidbody objectCRigidbody; // C 오브젝트의 Rigidbody
    public AudioClip dropSound; // 재생할 소리 클립
    private AudioSource audioSource; // 오디오 소스 컴포넌트

    private void Start()
    {
        // 오디오 소스 컴포넌트 가져오기
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // B 오브젝트와 C 오브젝트의 Rigidbody의 중력 사용을 활성화
            objectBRigidbody.useGravity = true;
            objectCRigidbody.useGravity = true;

            // 지정된 오디오 클립 재생
            audioSource.clip = dropSound;
            audioSource.Play();
        }
    }
}