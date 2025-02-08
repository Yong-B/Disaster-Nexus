using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CprButton : MonoBehaviour
{
    private bool B1 = false;
    private bool B2 = false;
    private bool B3 = false;
    private bool B4 = false;

    public void ClickBtn()
    {
        GameObject clickObject = EventSystem.current.currentSelectedGameObject;

        if (clickObject.name == "CPR1")
        {
            B1 = true;
            Debug.Log("B1 true");
        }


        if (B1 == true)
        {
            if (clickObject.name == "CPR2")
            {
                B2 = true;
                Debug.Log("B2 true");
            }

            if (B2 == false)
            {
                if (clickObject.name == "CPR3" || clickObject.name == "CPR4")
                {
                    B1 = false;
                    B2 = false;
                    B3 = false;
                    B4 = false;
                }
            }
        }

        if (B1 == true && B2 == true)
        {
            if (clickObject.name == "CPR3")
            {
                B3 = true;
                Debug.Log("B3 true");
            }

            if (B3 == false)
            {
                if (clickObject.name == "CPR4")
                {
                    B1 = false;
                    B2 = false;
                    B3 = false;
                    B4 = false;
                }
            }

        }



        if (B1 == true && B2 == true && B3 == true)
        {
            if (clickObject.name == "CPR4")
            {
                B4 = true;
                Debug.Log("B4 true");
            }
        }



        if (B1 == true && B2 == true && B3 == true && B4 == true)
        {
            
        }
    }
}
