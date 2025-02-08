using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FadeSceneMGR : MonoBehaviour
{
    private static FadeSceneMGR instance;

    public FadeScene fadeScreen;

    private void Awake()
    {
            instance = this;
            DontDestroyOnLoad(gameObject);
    }

    public static FadeSceneMGR Instance
    {
        get
        {
            if (instance == null)
            {
 
                GameObject managerObj = new GameObject("FadeSceneMGR");
                instance = managerObj.AddComponent<FadeSceneMGR>();
                DontDestroyOnLoad(managerObj);
            }
            return instance;
        }
    }

    public void GoToSceneAsync(int sceneIndex)
    {
        StartCoroutine(GoToSceneAsyncRoutine(sceneIndex));
    }

    IEnumerator GoToSceneAsyncRoutine(int screenIndex)
    {
        fadeScreen.FadeOut();

        AsyncOperation operation = SceneManager.LoadSceneAsync(screenIndex);
        operation.allowSceneActivation = false;

        float timer = 0;
        while (timer <= fadeScreen.fadeDuration && !operation.isDone)
        {
            timer += Time.deltaTime;
            yield return null;
        }

        operation.allowSceneActivation = true;
    }
}
