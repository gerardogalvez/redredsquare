using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Manager : MonoBehaviour {

    public GameObject scoreText;
    public GameObject mainmenuUI;

    // Use this for initialization
    void Start() {
        Time.timeScale = 0;
        scoreText.SetActive(false);
        mainmenuUI.SetActive(true);
    }

    public void Play()
    {
        StartCoroutine("fade");
        //mainmenuUI.SetActive(false);
        scoreText.SetActive(true);
        Time.timeScale = 1;
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
}
