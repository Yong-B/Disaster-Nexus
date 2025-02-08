using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScreenText : MonoBehaviour
{
    public List<TextMeshProUGUI> textList;
    public float displayTime = 5f;
    private int currentIndex = 0;
    public int targetSceneIndex;

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
            Debug.Log("H2");
        }
    }

    private void HideCurrentText()
    {
        if (currentIndex < textList.Count - 1)
        {
            TextMeshProUGUI tmpText = textList[currentIndex];
            tmpText.gameObject.SetActive(false);

            currentIndex++;
            ShowNextText();
        }
        else
        {
            FadeSceneMGR.Instance.GoToSceneAsync(targetSceneIndex);
        }
    }

}
