using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nc : MonoBehaviour
{
    public float delay; // 사라지는 시간

    void Start()
    {
        Destroy(gameObject, delay);
    }
}



/*public enum State
    {
        WALK,
        RUN
    }

    public State state = State.WALK;

    private Animator anim;

    void Start ()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        
        if (state == State.WALK)
        {
            anim.SetBool("IsTrace", false);
        }
        else if (state == State.RUN)
        {
            anim.SetBool("IsTrace", true);
        }
    }
    public void SetRunState()
    {
        state = State.RUN;
    }
    */