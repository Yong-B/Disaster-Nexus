using UnityEngine;

public class gasmaskUI : MonoBehaviour
{
    // ���� ���� �� �ʿ��� �κ��� �����մϴ�.
    private bool gasmaskSocket = false; // 



    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("gas mask"))
        {
            gasmaskSocket = true;

            GameManager.Instance.S3Quest3Clear();
        }
    }


    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("gas mask"))
        {
            gasmaskSocket = false;
        }
        
    }


}