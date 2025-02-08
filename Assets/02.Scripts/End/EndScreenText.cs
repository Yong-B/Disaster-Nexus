using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class EndScreenText : MonoBehaviour
{
    public List<TextMeshProUGUI> textList;
    public float displayTime = 5f;
    private int currentIndex = 0;
    public GameObject replaygame;
    public GameObject exitgame;

    private void Start()
    {
        if (textList.Count > 0)
        {
            Invoke("ShowNextText", 3f);
        }
        else
        {
            Debug.LogWarning("Text List is empty!");
        }

        Invoke("ShowButton", 20.0f); // �ٽ��ϱ�&���� ��ư Ȱ��ȭ
    }

    private void ShowNextText()
    {
        if (currentIndex < textList.Count)
        {
            TextMeshProUGUI tmpText = textList[currentIndex];
            tmpText.gameObject.SetActive(true);

            Invoke("HideCurrentText", displayTime);
        }
        else
        {
            Debug.Log("Text display completed.");
        }
    }

    private void HideCurrentText()
    {
        if (currentIndex < textList.Count - 1)  // ���� ������ �ε��� ���� ������ �ؽ�Ʈ�� ������� �ʱ� ���� -1�� ����
        {
            TextMeshProUGUI tmpText = textList[currentIndex];
            tmpText.gameObject.SetActive(false);

            currentIndex++;
            ShowNextText();
        }
    }

    // �����̼� ���� �ٽ��ϱ�&�������� ��ư Ȱ��ȭ
    public void ShowButton()
    {
        replaygame.gameObject.SetActive(true);
        exitgame.gameObject.SetActive(true);
    }

}
