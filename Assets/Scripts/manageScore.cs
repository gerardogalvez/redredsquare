using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class manageScore : MonoBehaviour {

    public Text scoreText;
    public static int score;

	// Use this for initialization
	void Start () {
        score = 0;
        scoreText.text = "Score: " + score.ToString();
	}

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + score.ToString();
    }
}