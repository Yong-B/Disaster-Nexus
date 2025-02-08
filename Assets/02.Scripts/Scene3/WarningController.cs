using UnityEngine;

public class WarningController : MonoBehaviour
{
    public GameObject warningAsset; // "Warning" ������ �����ϴ� GameObject�Դϴ�.
    public GameObject warningCanvas;

    private void Start()
    {
        warningAsset.SetActive(false); // ���� �ÿ��� Warning ������ ����ϴ�.
        warningCanvas.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            warningAsset.SetActive(true); // Ʈ���ſ� �÷��̾ ������ Warning ������ Ȱ��ȭ�մϴ�.
            warningCanvas.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            warningAsset.SetActive(false); // Ʈ���ſ��� �÷��̾ �������� Warning ������ ��Ȱ��ȭ�մϴ�.
            warningCanvas.SetActive(false);
        }
    }
}