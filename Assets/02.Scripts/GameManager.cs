using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject Q1;
    public GameObject Q2;
    public GameObject Q3;
    public GameObject Q4;
    public GameObject Q5;
    public GameObject Q6;
    public GameObject Q7;
    public GameObject Q8;

    public GameObject food;
    public GameObject medic;
    public GameObject water;
    public GameObject flash;
    public GameObject passport;
    public GameObject soccerball;
    public GameObject gamegi;

    public GameObject valveBtn;
    public GameObject valve;

    public GameObject bag;
    public GameObject bagsocket;

    public GameObject teleport2;
    public GameObject teleport22;

    public GameObject ch1;
    public GameObject ch2;

    public GameObject Door1;
    public GameObject Door2; // ��2�� �̵��ϱ� ���� �� ���̶���Ʈ ǥ��

    public GameObject End1;
    public GameObject End2;

    public GameObject TutorQ1;
    public GameObject TutorQ2;
    public GameObject TutorQ3;

    public GameObject Tutordoor1;
    public GameObject Tutordoor2;

    public GameObject Tutordoor1Text;
    public GameObject Tutordoor2Text;



    #region �̱���
    // �̱��� ������ ����ϱ� ���� �ν��Ͻ� ����
    private static GameManager _instance;
    // �ν��Ͻ��� �����ϱ� ���� ������Ƽ
    public static GameManager Instance
    {
        get
        {
            // �ν��Ͻ��� ���� ��쿡 �����Ϸ� �ϸ� �ν��Ͻ��� �Ҵ����ش�.
            if (!_instance)
            {
                _instance = FindObjectOfType(typeof(GameManager)) as GameManager;

                if (_instance == null)
                    Debug.Log("no Singleton obj");
            }
            return _instance;
        }
    }

    private void Awake()
    {
            _instance = this;
    }
    #endregion


    // �� ��

    public void Quest1Clear()
    {
        Q1.gameObject.SetActive(false);
        Q2.gameObject.SetActive(true);
    }
    public void Quest2Clear()
    {
        Q2.gameObject.SetActive(false);
        Q3.gameObject.SetActive(true);
        valveBtn.gameObject.SetActive(true);
        valve.GetComponent<Outline>().enabled = true;
        bag.GetComponent<XRGrabInteractable>().enabled = true;
    }
    public void Quest3Clear()
    {
        Q3.gameObject.SetActive(false);
        Q4.gameObject.SetActive(true);
    }
    public void Quest4Clear()
    {
        Q4.gameObject.SetActive(false);
        Q5.gameObject.SetActive(true);
    }
    public void Quest5Clear()
    {
        Q5.gameObject.SetActive(false);
        Q6.gameObject.SetActive(true);
    }

    public void Quest6Clear()
    {
        Q6.gameObject.SetActive(false);
        Q7.gameObject.SetActive(true);
        teleport2.gameObject.SetActive(true);
        teleport22.gameObject.SetActive(true);
        Door1.GetComponent<Outline>().enabled = true;
        Door2.GetComponent<Outline>().enabled = true;
        bagsocket.gameObject.SetActive(true);
    }

    public void ShowOutline()
    {
        food.GetComponent<Outline>().enabled = true;
        medic.GetComponent<Outline>().enabled = true;
        water.GetComponent<Outline>().enabled = true;
        flash.GetComponent<Outline>().enabled = true;
        passport.GetComponent<Outline>().enabled = true;
        soccerball.GetComponent<Outline>().enabled = true;
        gamegi.GetComponent<Outline>().enabled = true;
    }
    

    //����

    public void CityNav1()
    {
        Q1.gameObject.SetActive(false);
        Q2.gameObject.SetActive(true);

        ch1.gameObject.SetActive(false);
    }

    public void CityNav2()
    {
        Q2.gameObject.SetActive(false);
        Q3.gameObject.SetActive(true);

        ch2.gameObject.SetActive(false);
    }


    // ���Ǽ�

    public void S3Quest1Clear()
    {
        Q1.gameObject.SetActive(false);
        Q2.gameObject.SetActive(true);
    }

    public void S3Quest2Clear()
    {
        Q2.gameObject.SetActive(false);
        Q3.gameObject.SetActive(true);
    }

    public void S3Quest3Clear()
    {
        Q3.gameObject.SetActive(false);
        Q4.gameObject.SetActive(true);

        End1.gameObject.SetActive(true);
        End2.gameObject.SetActive(true);    // Ŭ���� ��Ż Ȱ��ȭ
    }


    // ȭ��
    public void FireQuest1Clear()
    {
        Q1.gameObject.SetActive(false);
        Q2.gameObject.SetActive(true);
        valve.GetComponent<Outline>().enabled = true;
    }

    public void FireQuest2Clear()
    {
        Q2.gameObject.SetActive(false);
        Q3.gameObject.SetActive(true);
    }

    public void FireQuest3Clear()
    {
        Q3.gameObject.SetActive(false);
        Q4.gameObject.SetActive(true);
    }

    public void FireQuest4Clear()
    {
        Q4.gameObject.SetActive(false);
        Q5.gameObject.SetActive(true);
    }

    public void FireQuest5Clear()
    {
        Q5.gameObject.SetActive(false);
        Q6.gameObject.SetActive(true);
    }

    public void FireQuest6Clear()
    {
        Q6.gameObject.SetActive(false);
        
    }

   


    //Ʃ�丮��

    public void TutorQuest1Clear()
    {

        TutorQ1.gameObject.SetActive(false);
        TutorQ2.gameObject.SetActive(true);
    }
    public void TutorQuest2Clear()
    {

        TutorQ2.gameObject.SetActive(false);
        TutorQ3.gameObject.SetActive(true);
        Tutordoor1.gameObject.SetActive(true);
        Tutordoor2.gameObject.SetActive(true);
        Tutordoor1Text.gameObject.SetActive(true);
        Tutordoor2Text.gameObject.SetActive(true);
    }
}
