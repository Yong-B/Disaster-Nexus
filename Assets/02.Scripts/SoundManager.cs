using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip airWarning;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        Invoke("WarningSound", 5f);
    }

    private void WarningSound()
    {
        audioSource.clip = airWarning;
        audioSource.Play(); //Àç»ý
    }
}
