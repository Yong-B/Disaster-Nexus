 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAnim : MonoBehaviour
{
    private Animator anim;


    void Start()
    {
        anim = GetComponent<Animator>();
        anim.Play("Idle");
    }

    void Update()
    {
        
    }

    public void openClosetR()
    {
        anim.SetTrigger("openClosetR");
    }
    public void openClosetL()
    {
        anim.SetTrigger("openClosetL");
    }
    public void openHall()
    {
        anim.SetTrigger("openHall");
    }
    public void openRoom()  // 화재에서 쓰일 모든 문 애니메이션은 이걸로 통일
    {
        anim.SetTrigger("openRoom");
    }
    public void openToilet()
    {
        anim.SetTrigger("openToilet");
    }
    public void openFridgeR()
    {
        anim.SetTrigger("openFridgeR");
    }
    public void openFridgeL()
    {
        anim.SetTrigger("openFridgeL");
    }
}
