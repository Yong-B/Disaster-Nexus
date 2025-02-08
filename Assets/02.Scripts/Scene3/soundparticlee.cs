using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundParticlee : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip airWarning;
    public GameObject particle1;
    public GameObject particle2;
    public GameObject smoke;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        Invoke("WarningSound", 5f);
    }

    private void WarningSound()
    {
        audioSource.clip = airWarning;
        audioSource.Play();

        particle1.SetActive(true);
        particle2.SetActive(true);


        Invoke("ActivateSmoke", 4f);
    }

    private void ActivateSmoke()
    {
        smoke.SetActive(true);
    }
}