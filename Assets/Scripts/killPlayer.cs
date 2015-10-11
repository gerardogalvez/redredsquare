using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class killPlayer : MonoBehaviour {

    private string highscoreKey = "highscoreKey";
    public GameObject deadUI;
    private CanvasGroup cg;
    public Text scoreText;
    public Text score;
    public GameObject particles;
    public GameObject deathParticles;
    
    void Start()
    {
        deadUI.SetActive(false);
        cg = deadUI.GetComponent<CanvasGroup>();
        cg.alpha = 0;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "killObstacle" || other.gameObject.tag == "killParticles")
        {
            PlayerPrefs.SetInt("lastScore", manageScore.score);

            if (manageScore.score > manageScore.highscore)
            {
                PlayerPrefs.SetInt(highscoreKey, manageScore.score);
                scoreText.text = "NEW HIGHSCORE";
                Social.ReportScore(PlayerPrefs.GetInt(highscoreKey), "CgkIpqHGg_cBEAIQAQ", (bool success) => { });
            }
            else
            {
                scoreText.text = "SCORE";
            }
            Instantiate(deathParticles, this.transform.position, this.transform.rotation);
            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<BoxCollider2D>().enabled = false;
            GetComponent<Rigidbody2D>().gravityScale = 0;
            Camera.main.GetComponent<cameraMovement>().enabled = false;
            particles.GetComponent<particlesMovement>().enabled = false;
            score.text = manageScore.score.ToString();
            StartCoroutine("fadeIn");
        }
    }

    IEnumerator fadeIn()
    {
        yield return StartCoroutine(waitForRealSeconds(1));
        deadUI.SetActive(true);
        while(cg.alpha < 1)
        {
            cg.alpha += 0.05f;
            yield return null;
        }
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
}
