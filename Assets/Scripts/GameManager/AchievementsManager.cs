using UnityEngine;
using System.Collections;

public class AchievementsManager : MonoBehaviour
{


    void Start()
    {

        //Achievemnt of "Rookie"
        if (PlayerPrefs.GetInt("highscoreKey") >= 5)
        {
            setAchievement("CgkIpqHGg_cBEAIQAA", 100.0f);
            //Social.ReportProgress("CgkIpqHGg_cBEAIQAA",100.0f,(bool success)=>{});
        }

        //Achievement of "Beginner"
        if (PlayerPrefs.GetInt("highscoreKey") >= 15)
        {
            setAchievement("CgkIpqHGg_cBEAIQAg", 100.0f);
            //Social.ReportProgress("CgkIpqHGg_cBEAIQAg",100.0f,(bool success)=> {});
        }

        //Achievement of "Talented"
        if (PlayerPrefs.GetInt("highscoreKey") >= 30)
        {
            setAchievement("CgkIpqHGg_cBEAIQAw", 100.0f);
            //Social.ReportProgress ("CgkIpqHGg_cBEAIQAw", 100.0f, (bool success) => {});
        }

        //Achievement of "Experienced"
        if (PlayerPrefs.GetInt("highscoreKey") >= 50)
        {
            setAchievement("CgkIpqHGg_cBEAIQBA", 100.0f);
            //Social.ReportProgress ("CgkIpqHGg_cBEAIQBA", 100.0f, (bool success) => {});
        }

        //Achievement of "EXPERT"
        if (PlayerPrefs.GetInt("highscoreKey") >= 100)
        {
            setAchievement("CgkIpqHGg_cBEAIQBQ", 100.0f);
            //Social.ReportProgress ("CgkIpqHGg_cBEAIQBQ", 100.0f, (bool success) => {});
        }

        //Achievement of "LEGEND"
        if (PlayerPrefs.GetInt("highscoreKey") >= 250)
        {
            setAchievement("CgkIpqHGg_cBEAIQBg", 100.0f);
            //Social.ReportProgress ("CgkIpqHGg_cBEAIQBg", 100.0f, (bool success) => {});
        }

        //Achievement of "Godlike"
        if (PlayerPrefs.GetInt("highscoreKey") >= 500)
        {
            setAchievement("CgkIpqHGg_cBEAIQBw", 100.0f);
            //Social.ReportProgress ("CgkIpqHGg_cBEAIQBw", 100.0f, (bool success) => {});
        }

        //Achievement of "ANSWER TO THE ULTIMATE QUESTION OF LIFE, THE UNIVERSE, AND EVERYTHING"
        if (PlayerPrefs.GetInt("lastScore") == 42 || PlayerPrefs.GetInt("highscoreKey") == 42)
        {
            setAchievement("CgkIpqHGg_cBEAIQCA", 100.0f);
            //Social.ReportProgress ("CgkIpqHGg_cBEAIQCA", 100.0f, (bool success) => {});
        }

        //Achievement of "WINNER, WINNER, CHICKEN DINNER!"
        if (PlayerPrefs.GetInt("lastScore") == 21 || PlayerPrefs.GetInt("highscoreKey") == 21)
        {
            setAchievement("CgkIpqHGg_cBEAIQCQ", 100.0f);
            //Social.ReportProgress ("CgkIpqHGg_cBEAIQCQ ", 100.0f, (bool success) => {});
        }

		//Send highscoreKey
		Social.ReportScore(PlayerPrefs.GetInt("highscoreKey"), "CgkIpqHGg_cBEAIQAQ", (bool success) => { });
       

    }

    public void setAchievement(string sAchievementId, float fPercOfSuccess)
    {

        Social.ReportProgress(sAchievementId, fPercOfSuccess, (bool success) => { });
    }

}
