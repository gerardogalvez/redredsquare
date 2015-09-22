using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class manageScore : MonoBehaviour {

    public Text scoreText;
    public Text highscoreText;
    public Text newHighscore;
    public static int score;
    public static int highscore;
    private bool hasAppeared;

    private string highscoreKey = "highscoreKey";

    private CanvasGroup newHighscoreCanvas;

    void Awake()
    {
        highscore = 0;
        newHighscoreCanvas = newHighscore.GetComponent<CanvasGroup>();
        //PlayerPrefs.DeleteAll();
    }

	// Use this for initialization
	void Start () {
        score = 0;
        highscore = PlayerPrefs.GetInt(highscoreKey, 0);

        scoreText.text = score.ToString();
        highscoreText.text = "HIGHSCORE " + highscore.ToString();
        hasAppeared = false;
	}

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();
        if (score > PlayerPrefs.GetInt(highscoreKey, 0) && !hasAppeared)
        {
            StartCoroutine("fadeInOut");
            hasAppeared = true;
        }
    }

    IEnumerator fadeInOut()
    {
        while (newHighscoreCanvas.alpha < 1)
        {
            newHighscoreCanvas.alpha += 0.02f;
            yield return null;
        }
        yield return new WaitForSeconds(10);
        while (newHighscoreCanvas.alpha > 0)
        {
            newHighscoreCanvas.alpha -= 0.02f;
            yield return null;
        }
    }
}