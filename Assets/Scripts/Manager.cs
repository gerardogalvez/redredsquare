using UnityEngine;
using System.Collections;

public class Manager : MonoBehaviour {

    public GameObject scoreText;
    public GameObject mainmenuUI;

	// Use this for initialization
	void Start () {
        Time.timeScale = 0;
        scoreText.SetActive(false);
        mainmenuUI.SetActive(true);
	}
	
	public void Play()
    {
        mainmenuUI.SetActive(false);
        scoreText.SetActive(true);
        Time.timeScale = 1;
    }
}
