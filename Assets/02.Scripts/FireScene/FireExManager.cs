using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class FireExManager : MonoBehaviour
{
    public ParticleSystem fireParticles;
    public InputActionProperty showButton;

    // Update is called once per frame
    private void Start()
    {
        // 파티클 시스템 비활성화
       
    }

    private void Update()
    {
        if (showButton.action.WasPressedThisFrame())
        {
            // 버튼을 누르면 파티클을 재생/정지
            if (fireParticles.isPlaying)
                fireParticles.Stop();
            else
                fireParticles.Play();

            
           
        }
    }
}