using UnityEngine;
using System.Collections;
using GooglePlayGames;
using UnityEngine.SocialPlatforms;
using UnityEngine.UI;
public class ButtonRanking : MonoBehaviour
{

    //public Button btRanking;

	/*
    // Update is called once per frame
    void Update()
    {
        if (Social.localUser.authenticated)
        {
            btRanking.GetComponent<Image>().color = Color.white;
        }
        else
        {
            btRanking.GetComponent<Image>().color = Color.gray;

        }
    }
	*/
    public void openLeaderboards()
    {
        if (Social.localUser.authenticated)
        {
            ((PlayGamesPlatform)Social.Active).ShowLeaderboardUI("CgkIpqHGg_cBEAIQAQ");
        }
        else
        {
            Social.localUser.Authenticate((bool success) => { });
        }
    }
}
