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
        // ��ƼŬ �ý��� ��Ȱ��ȭ
       
    }

    private void Update()
    {
        if (showButton.action.WasPressedThisFrame())
        {
            // ��ư�� ������ ��ƼŬ�� ���/����
            if (fireParticles.isPlaying)
                fireParticles.Stop();
            else
                fireParticles.Play();

            
           
        }
    }
}