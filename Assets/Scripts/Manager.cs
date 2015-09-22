using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Manager : MonoBehaviour {

    public GameObject gameUI;
    public GameObject mainmenuUI;
    public GameObject pauseUI;
    public GameObject countdownText;
    public GameObject resume;

    // Use this for initialization
    void Start() {
        Time.timeScale = 0;
        gameUI.SetActive(false);
        mainmenuUI.SetActive(true);
        pauseUI.SetActive(false);
    }

    public void Play()
    {
        StartCoroutine("fade");
        //mainmenuUI.SetActive(false);
        gameUI.SetActive(true);
        Time.timeScale = 1;
    }

    public void Pause()
    {
        gameUI.SetActive(false);
        pauseUI.SetActive(true);
        countdownText.SetActive(false);
        Time.timeScale = 0;
    }

    public void Resume()
    {
        StartCoroutine("countdown");
    }

    IEnumerator fade()
    {
        CanvasGroup canvasGroup = mainmenuUI.GetComponent<CanvasGroup>();
        while(canvasGroup.alpha>0)
        {
            canvasGroup.alpha -= 0.05f;
            yield return null;
        }
        mainmenuUI.SetActive(false);
        yield return null;
    }

    IEnumerator waitForRealSeconds(float time)
    {
        float start = Time.realtimeSinceStartup;
        while (Time.realtimeSinceStartup < start + time)
        {
            yield return null;
        }
    }

    IEnumerator countdown()
    {
        resume.SetActive(false);
        countdownText.SetActive(true);
        countdownText.GetComponent<Text>().text = "3";
        yield return StartCoroutine(waitForRealSeconds(1));
        countdownText.GetComponent<Text>().text = "2";
        yield return StartCoroutine(waitForRealSeconds(1));
        countdownText.GetComponent<Text>().text = "1";
        yield return StartCoroutine(waitForRealSeconds(1));
        resume.SetActive(true);
        countdownText.SetActive(false);
        pauseUI.SetActive(false);
        gameUI.SetActive(true);
        Time.timeScale = 1;
    }
}
