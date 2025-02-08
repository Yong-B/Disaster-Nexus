using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class ImpactSound : MonoBehaviour
{
    public AudioClip impactClip; // Inspector에서 설정할 사운드 클립
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.CompareTag("Plane"))
        {
            
            audioSource.clip = impactClip;
           
            audioSource.Play();
        }
    }
}