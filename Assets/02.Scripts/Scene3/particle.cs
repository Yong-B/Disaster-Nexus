using UnityEngine;

public class Particle : MonoBehaviour
{
    public float appearanceDuration = 2.0f; // 파티클이 나타나는 데 걸리는 시간 (초)

    private ParticleSystem particleSystem; // 파티클 시스템 컴포넌트
    private float particleTime = 0f; // 경과 시간 저장
    private bool hasStarted = false;

    void Start()
    {
        particleSystem = GetComponent<ParticleSystem>();
        // 파티클 시스템의 시작 크기를 0으로 설정
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
                float targetSize = 35.0f; // 목표 크기를 35로 지정
                mainModule.startSize = Mathf.Lerp(0f, targetSize, particleTime / appearanceDuration);
            }
        }
    }

    // 파티클 시스템을 시작함
    private void StartParticle()
    {
        particleSystem.Play();
    }
}