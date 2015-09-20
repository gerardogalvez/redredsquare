using UnityEngine;
using System.Collections;

public class particlesMovement : MonoBehaviour {

    public string sTagPlayer = "Player";
    public string sTagCamera = "MainCamera";
    public float fAceleration = 1.0f;
    public float fMaxDistFromCamera = 10.0f;
    public float fVelocity = 20.0f;

    private GameObject gPlayerObj;
    private GameObject gMainCamera;
    private int iPreviousScore = 0;

    void Awake()
    {
        gPlayerObj = GameObject.FindWithTag(sTagPlayer);
        gMainCamera = GameObject.FindWithTag(sTagCamera);

       
    }

   
	
	// Update is called once per frame
	void Update () {

        //Camera movement
        if (gMainCamera.transform.position.y - transform.position.y > fMaxDistFromCamera)
            gameObject.transform.position = new Vector2(gMainCamera.transform.position.x, gMainCamera.transform.position.y - fMaxDistFromCamera);
        else
            gameObject.transform.Translate(Vector2.up * fVelocity * Time.deltaTime);

        
        if(iPreviousScore != manageScore.score)
        {
            //Increase speed
            if (manageScore.score <= 100 && manageScore.score % 20 == 0)
            {
                fVelocity += fAceleration;
            }
        }
        iPreviousScore = manageScore.score;
    }
    
   
    
}
