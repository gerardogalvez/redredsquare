using UnityEngine;
using System.Collections;
using GooglePlayGames;
using UnityEngine.SocialPlatforms;
public class gameState : MonoBehaviour {

	public static gameState gamestate;
	
	void Awake()
	{
		if(gamestate == null)
		{
            gamestate = this;
            DontDestroyOnLoad(gameObject);
            PlayGamesPlatform.DebugLogEnabled = true;
            PlayGamesPlatform.Activate();
        }
        else if(gamestate != this)
        {
            Destroy(gameObject);
        }

        
		
		
	}
	// Use this for initialization
	void Start () {
        ((PlayGamesPlatform)Social.Active).Authenticate((bool success) => { }, true);
        if (!Social.localUser.authenticated)
        {
            StartCoroutine(waitToAuth());
        }
    }

    IEnumerator waitToAuth()
    {
        yield return StartCoroutine(waitForRealSeconds(4f));
        Social.localUser.Authenticate((bool success) => { });
    }

    IEnumerator waitForRealSeconds(float fTime)
    {
        float fInit = Time.realtimeSinceStartup;

        while(Time.realtimeSinceStartup - fInit <= fTime)
        {
           yield return null;
        }
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
            Application.Quit();
    }
}
