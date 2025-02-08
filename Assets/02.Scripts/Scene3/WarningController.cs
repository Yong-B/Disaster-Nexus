using UnityEngine;

public class WarningController : MonoBehaviour
{
    public GameObject warningAsset; // "Warning" 에셋을 참조하는 GameObject입니다.
    public GameObject warningCanvas;

    private void Start()
    {
        warningAsset.SetActive(false); // 시작 시에는 Warning 에셋을 숨깁니다.
        warningCanvas.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            warningAsset.SetActive(true); // 트리거에 플레이어가 닿으면 Warning 에셋을 활성화합니다.
            warningCanvas.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            warningAsset.SetActive(false); // 트리거에서 플레이어가 떨어지면 Warning 에셋을 비활성화합니다.
            warningCanvas.SetActive(false);
        }
    }
}