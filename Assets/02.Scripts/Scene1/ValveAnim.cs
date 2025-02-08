using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValveAnim : MonoBehaviour
{
    private Animator anim;
    

    void Start()
    {
        anim = GetComponent<Animator>();
        anim.Play("ValveIDLE");
    }

    void Update()
    {

    }

    public void Valve()
    {
        anim.SetTrigger("Turn");
        GameManager.Instance.Quest3Clear();
    }
}
