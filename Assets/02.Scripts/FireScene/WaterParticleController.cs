using UnityEngine;

public class WaterParticleController : MonoBehaviour
{
    public ParticleSystem waterParticles;
    private bool isTriggered;
    public GameObject towelTrigger;

    private void Start()
    {
        // 파티클 시스템 비활성화
        waterParticles.Stop();

    }

    private void OnTriggerEnter(Collider other)
    {
        // Water Trigger와 충돌한 경우
        if (other.CompareTag("Water Trigger"))
        {
            // 파티클 시스템 활성화
            waterParticles.Play();
            isTriggered = true;
            towelTrigger.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Water Trigger와 더 이상 충돌하지 않은 경우
        if (other.CompareTag("Water Trigger"))
        {
            // 파티클 시스템 비활성화
            waterParticles.Stop();
            isTriggered = false;
            towelTrigger.SetActive(false);
        }
    }
}