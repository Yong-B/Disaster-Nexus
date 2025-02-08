using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectChanger : MonoBehaviour
{
    public GameObject newObjectPrefab; // πŸ≤‹ ø¿∫Í¡ß∆Æ¿« «¡∏Æ∆’

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "PlayerHand")
        {
            ChangeObject();
        }
    }

    void ChangeObject()
    {
        
        Vector3 position = transform.position;
        Quaternion rotation = transform.rotation;

        Destroy(gameObject);

        Instantiate(newObjectPrefab, position, rotation);
    }
}