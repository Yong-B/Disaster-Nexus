using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.Instance.S3Quest1Clear();
        }
    }

}