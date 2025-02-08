using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovieTheaterLights : MonoBehaviour
{
    public List<Light> movieLights;
    public float duration = 5f;

    private List<float> startIntensities = new List<float>();
    private List<float> targetIntensities = new List<float>();
    private float timer = 0f;
    private bool isFading = false;

    private void Start()
    {
        Invoke("StartMovie", 5f);
        Debug.Log("��ŸƮ");

        foreach (Light light in movieLights)
        {
            startIntensities.Add(light.intensity);
            targetIntensities.Add(0f);
        }
    }

    private void Update()
    {
        if (isFading)
        {
            timer += Time.deltaTime;
            float t = Mathf.Clamp01(timer / duration);


            for (int i = 0; i < movieLights.Count; i++)
            {
                movieLights[i].intensity = Mathf.Lerp(startIntensities[i], targetIntensities[i], t);
            }

            if (t >= 1f)
            {
                // ���� ������ ������ ���̵� ����
                isFading = false;
            }
        }
    }


    public void StartMovie()
    {
        isFading = true;
        timer = 0f;
    }
}
