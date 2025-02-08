/*using System.Collections;
using UnityEngine;

public class CarControl2 : MonoBehaviour
{
    public float speed = 5f;
    public float stopTime = 5f; // �ν����� â���� ���� ������ ���ߴ� �ð�
    public float decelerationTime = 1f; // õõ�� ���ߴ� �� �ɸ��� �ð�

    private Rigidbody rb;
    private bool isStopping = false; // ���� ���¸� ��Ÿ���� ����

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        StartCoroutine(StopAfterSeconds(stopTime));
    }

    private void Update()
    {
        if (!isStopping) // ���� ���°� �ƴϸ�
        {
            Vector3 movement = transform.forward * speed * -1f; // ����
            rb.AddForce(movement, ForceMode.Acceleration);
        }
    }

    private IEnumerator StopAfterSeconds(float seconds)
    {
        yield return new WaitForSeconds(seconds);

        isStopping = true; // ���� ���·� ����

        float elapsedTime = 0f;
        Vector3 initialVelocity = rb.velocity;

        while (elapsedTime < decelerationTime) // ����
        {
            float progress = elapsedTime / decelerationTime;
            rb.velocity = Vector3.Lerp(initialVelocity, Vector3.zero, progress);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        rb.velocity = Vector3.zero; // ����
        rb.angularVelocity = Vector3.zero;
    }
}
*/