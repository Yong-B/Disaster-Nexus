using UnityEngine;

public class Particle : MonoBehaviour
{
    public float appearanceDuration = 2.0f; // ��ƼŬ�� ��Ÿ���� �� �ɸ��� �ð� (��)

    private ParticleSystem particleSystem; // ��ƼŬ �ý��� ������Ʈ
    private float particleTime = 0f; // ��� �ð� ����
    private bool hasStarted = false;

    void Start()
    {
        particleSystem = GetComponent<ParticleSystem>();
        // ��ƼŬ �ý����� ���� ũ�⸦ 0���� ����
        var mainModule = particleSystem.main;
        mainModule.startSize = 0f;
        particleSystem.Stop();
    }

    void Update()
    {
        if (!hasStarted)
        {
            particleTime += Time.deltaTime;
            if (particleTime >= 3f)
            {
                StartParticle();
                hasStarted = true;
                var mainModule = particleSystem.main;
                float targetSize = 35.0f; // ��ǥ ũ�⸦ 35�� ����
                mainModule.startSize = Mathf.Lerp(0f, targetSize, particleTime / appearanceDuration);
            }
        }
    }

    // ��ƼŬ �ý����� ������
    private void StartParticle()
    {
        particleSystem.Play();
    }
}