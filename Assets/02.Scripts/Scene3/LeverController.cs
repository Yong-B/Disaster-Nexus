using UnityEngine;

public class LeverController : MonoBehaviour
{
    public Transform doorTransform;
    public float doorOpenY = 10.01f;
    public float doorClosedY = -10.51f;
    public float doorMoveDuration = 10f; // 문의 이동에 걸리는 시간

    public AudioSource audioSource;
    private bool leverPulled = false;
    private bool doorMoving = false;
    private Vector3 initialDoorPosition; // 문의 초기 위치

    private void Start()
    {
        initialDoorPosition = doorTransform.position;
        audioSource = GetComponent<AudioSource>(); // AudioSource 컴포넌트 가져오기
        audioSource.playOnAwake = false; // playOnAwake를 비활성화하여 초기 재생 방지
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("LeverTrigger"))
        {
            if (!doorMoving)
            {
                leverPulled = true;
                StartCoroutine(MoveDoor(doorClosedY));
                PlaySound();
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("LeverTrigger"))
        {
            if (!doorMoving)
            {
                leverPulled = false;
                StartCoroutine(MoveDoor(doorOpenY));
                PlaySound();
            }
        }
    }


    private System.Collections.IEnumerator MoveDoor(float targetY)
    {
        doorMoving = true;
        float startY = doorTransform.position.y;
        float elapsedTime = 0f;

        while (elapsedTime < doorMoveDuration)
        {
            elapsedTime += Time.deltaTime;
            float newY = Mathf.Lerp(startY, targetY, elapsedTime / doorMoveDuration);
            doorTransform.position = new Vector3(doorTransform.position.x, newY, doorTransform.position.z);
            yield return null;
        }

        doorTransform.position = new Vector3(doorTransform.position.x, targetY, doorTransform.position.z);
        doorMoving = false;
        GameManager.Instance.S3Quest2Clear();
    }
    private void PlaySound()
    {
        if (!audioSource.isPlaying)
        {
            audioSource.Play();
        }
    }


}