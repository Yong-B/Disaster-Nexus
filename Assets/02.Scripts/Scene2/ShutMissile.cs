using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShutMissile : MonoBehaviour
{
    public float missileSpeed = 10f;

    void Start()
    {
        this.GetComponent<Rigidbody>().AddForce(transform.forward * missileSpeed);
    }

}
