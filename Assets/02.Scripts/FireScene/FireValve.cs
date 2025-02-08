using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireValve : MonoBehaviour
{
    private Animator anim;


    void Start()
    {
        anim = GetComponent<Animator>();
        anim.Play("FireValve");
    }

    void Update()
    {

    }

    public void Valve()
    {
        anim.SetTrigger("FireTurn");
        GameManager.Instance.FireQuest2Clear();
    }
}
