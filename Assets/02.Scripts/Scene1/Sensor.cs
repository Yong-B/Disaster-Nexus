using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Sensor : MonoBehaviour
{
    private bool Food = false;
    private bool Medic = false;
    private bool Water = false;
    private bool Flash = false;
    private bool Passport = false;


    public TMP_Text FoodTxt;
    public TMP_Text MedicTxt;
    public TMP_Text WaterTxt;
    public TMP_Text FlashTxt;
    public TMP_Text PassportTxt;


    private void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.name == "Food")
        {
            Debug.Log("Food");
            Food = true;
            Destroy(coll.gameObject);

            ChangeText();
        }
        if (coll.gameObject.name == "Medic")
        {
            Debug.Log("Medic");
            Medic = true;
            Destroy(coll.gameObject);

            ChangeText();
        }
        if (coll.gameObject.name == "Water")
        {
            Debug.Log("Water");
            Water = true;
            Destroy(coll.gameObject);

            ChangeText();
        }
        if (coll.gameObject.name == "Flash")
        {
            Debug.Log("Flash");
            Flash = true;
            Destroy(coll.gameObject);

            ChangeText();
        }
        if (coll.gameObject.name == "Passport")
        {
            Debug.Log("Passport");
            Passport = true;
            Destroy(coll.gameObject);

            ChangeText();
        }
    }

    void ChangeText()
    {
        if (Food == true)
        {
            FoodTxt.text = "비상식량 챙기기 O";
        }
        if (Medic == true)
        {
            MedicTxt.text = "응급치료키트 챙기기 O";
        }
        if (Water == true)
        {
            WaterTxt.text = "물 챙기기 O";
        }
        if (Flash == true)
        {
            FlashTxt.text = "손전등 챙기기 O";
        }
        if (Passport == true)
        {
            PassportTxt.text = "여권 챙기기 O";
        }

        if (Food == true && Medic == true && Water == true && Flash == true && Passport == true)
        {
            GameManager.Instance.Quest2Clear();


        }
    }

}
