using UnityEngine;
using System.Collections;
using GooglePlayGames;
using UnityEngine.SocialPlatforms;
using UnityEngine.UI;
public class ButtonAchivements : MonoBehaviour
{

    //public Button btAchievements;
	
	/*
    // Update is called once per frame
    void Update()
    {
        if (Social.localUser.authenticated)
        {
            btAchievements.GetComponent<Image>().color = Color.white;
        }
        else
        {
            btAchievements.GetComponent<Image>().color = Color.gray;

        }
    }
	*/

    public void openAchievements()
    {
        if (Social.localUser.authenticated)
        {
            Social.Active.ShowAchievementsUI();
        }
        else
        {
            Social.localUser.Authenticate((bool success) => { });
        }
    }
}
