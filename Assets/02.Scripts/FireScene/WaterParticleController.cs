using UnityEngine;

public class WaterParticleController : MonoBehaviour
{
    public ParticleSystem waterParticles;
    private bool isTriggered;
    public GameObject towelTrigger;

    private void Start()
    {
        // ��ƼŬ �ý��� ��Ȱ��ȭ
        waterParticles.Stop();

    }

    private void OnTriggerEnter(Collider other)
    {
        // Water Trigger�� �浹�� ���
        if (other.CompareTag("Water Trigger"))
        {
            // ��ƼŬ �ý��� Ȱ��ȭ
            waterParticles.Play();
            isTriggered = true;
            towelTrigger.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Water Trigger�� �� �̻� �浹���� ���� ���
        if (other.CompareTag("Water Trigger"))
        {
            // ��ƼŬ �ý��� ��Ȱ��ȭ
            waterParticles.Stop();
            isTriggered = false;
            towelTrigger.SetActive(false);
        }
    }
}