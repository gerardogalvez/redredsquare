using UnityEngine;
using System.Collections;

public class killPlayer : MonoBehaviour {

    private string highscoreKey = "highscoreKey";

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "killObstacle" || other.gameObject.tag == "killParticles")
        {
            if (manageScore.score > manageScore.highscore)
                PlayerPrefs.SetInt(highscoreKey, manageScore.score);

            Application.LoadLevel(Application.loadedLevel);
        }
    }
}
