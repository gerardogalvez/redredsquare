using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class manageScore : MonoBehaviour {

    public Text scoreText;
    public Text highscoreText;
    public static int score;
    public static int highscore;

    private string highscoreKey = "highscoreKey";

    void Awake()
    {
        highscore = 0;
    }

	// Use this for initialization
	void Start () {
        score = 0;
        highscore = PlayerPrefs.GetInt(highscoreKey, 0);

        scoreText.text = score.ToString();
        highscoreText.text = "Highscore: " + highscore.ToString();
	}

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();
    }
}