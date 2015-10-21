using UnityEngine;
using System.Collections;

public class gameDifficulty : MonoBehaviour {

    public static gameDifficulty instance;
    public float fDifficulty = 2.5f;

    private bool bGo1, bGo2, bGo3;
	void Awake()
    {
        instance = this;
        bGo1 = true;
        bGo2 = true;
        bGo3 = true;
       
    }

    public void setDifficulty()
    {
        if(bGo3)
        {
            if (manageScore.score <= 300)
            {
                if (bGo2 && manageScore.score <= 200)
                {
                    if (bGo3 && manageScore.score >= 100)
                    {
                        fDifficulty = 3.0f;
                        bGo3 = false;
                    }

                }
                else
                {
                    fDifficulty = 3.5f;
                    bGo2 = false;
                }
            }
            else
            {
                fDifficulty = 4.0f;
                bGo3 = false;
            }
        }        
    }
}
