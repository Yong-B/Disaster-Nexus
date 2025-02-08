using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameMenuMGR : MonoBehaviour
{

    public Transform head;
    public float spawnDistance = 0.5f;
    public GameObject menu;
    public InputActionProperty showButton;


    // Update is called once per frame
    void Update()
    {
        if (showButton.action.WasPressedThisFrame())
        {
            menu.SetActive(!menu.activeSelf);

            menu.transform.position = head.position + new Vector3(head.forward.x, -0.25f, head.forward.z).normalized * spawnDistance;
        }

        menu.transform.LookAt(new Vector3(head.position.x, menu.transform.position.y, head.position.z));
        menu.transform.forward *= -1;
    }

}
