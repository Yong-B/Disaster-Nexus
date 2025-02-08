using UnityEngine;

public class gasmaskUI : MonoBehaviour
{
    // 변수 선언 등 필요한 부분은 생략합니다.
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