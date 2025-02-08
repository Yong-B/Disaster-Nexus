using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartRoket : MonoBehaviour
{
    public AudioSource audioSource_Scene2;
    public AudioClip missile_bgm;

    public GameObject missile;
    public Transform startMissileZone;
    public float missileSpeed = 10f;

    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            audioSource_Scene2.clip = missile_bgm;
            audioSource_Scene2.Play();
            Invoke("ShutMissile", 4.5f);

            GetComponent<Collider>().enabled = false;
        }
    }

    private void ShutMissile()
    {
        Debug.Log("Shut");

        Instantiate(missile, startMissileZone.transform.position, startMissileZone.transform.rotation);

    }
}
