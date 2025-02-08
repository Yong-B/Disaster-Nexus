using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class OffButton : MonoBehaviour, IPointerExitHandler
{
    public void OnPointerExit(PointerEventData eventData)
    {
        SetAlpha(transform, 0f);
    }

    private void SetAlpha(Transform currentTransform, float alphaValue)
    {
        Image image = currentTransform.GetComponent<Image>();
        TextMeshProUGUI tmp = currentTransform.GetComponent<TextMeshProUGUI>();
        RawImage rawImage = currentTransform.GetComponent<RawImage>();

        if (image != null)
        {
            Color color = image.color;
            color.a = alphaValue;
            image.color = color;
        }

        if (tmp != null)
        {
            Color color = tmp.color;
            color.a = alphaValue;
            tmp.color = color;
        }

        if (rawImage != null)
        {
            Color color = rawImage.color;
            color.a = alphaValue;
            rawImage.color = color;
        }

        // 자식 오브젝트들도 동일한 처리를 하기 위해 재귀 호출
        for (int i = 0; i < currentTransform.childCount; i++)
        {
            Transform child = currentTransform.GetChild(i);
            SetAlpha(child, alphaValue);
        }
    }
}
