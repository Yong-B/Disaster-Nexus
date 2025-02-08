/*using System.Collections;
using UnityEngine;

public class CarControl2 : MonoBehaviour
{
    public float speed = 5f;
    public float stopTime = 5f; // 인스펙터 창에서 조정 가능한 멈추는 시간
    public float decelerationTime = 1f; // 천천히 멈추는 데 걸리는 시간

    private Rigidbody rb;
    private bool isStopping = false; // 정지 상태를 나타내는 변수

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        StartCoroutine(StopAfterSeconds(stopTime));
    }

    private void Update()
    {
        if (!isStopping) // 정지 상태가 아니면
        {
            Vector3 movement = transform.forward * speed * -1f; // 전진
            rb.AddForce(movement, ForceMode.Acceleration);
        }
    }

    private IEnumerator StopAfterSeconds(float seconds)
    {
        yield return new WaitForSeconds(seconds);

        isStopping = true; // 정지 상태로 설정

        float elapsedTime = 0f;
        Vector3 initialVelocity = rb.velocity;

        while (elapsedTime < decelerationTime) // 감속
        {
            float progress = elapsedTime / decelerationTime;
            rb.velocity = Vector3.Lerp(initialVelocity, Vector3.zero, progress);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        rb.velocity = Vector3.zero; // 정지
        rb.angularVelocity = Vector3.zero;
    }
}
*/