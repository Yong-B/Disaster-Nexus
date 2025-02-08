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

        Invoke("ShowButton", 20.0f); // 다시하기&종료 버튼 활성화
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
        if (currentIndex < textList.Count - 1)  // 제일 마지막 인덱스 값을 가지는 텍스트는 사라지지 않기 위해 -1을 해줌
        {
            TextMeshProUGUI tmpText = textList[currentIndex];
            tmpText.gameObject.SetActive(false);

            currentIndex++;
            ShowNextText();
        }
    }

    // 나레이션 이후 다시하기&게임종료 버튼 활성화
    public void ShowButton()
    {
        replaygame.gameObject.SetActive(true);
        exitgame.gameObject.SetActive(true);
    }

}
