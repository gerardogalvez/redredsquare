using UnityEngine;
using System.Collections;

public class spawnShit : MonoBehaviour {
	
	public GameObject obstacle;
    public GameObject killObstacle;
    public GameObject[] gArrGoodObstacles;
    public GameObject[] gArrBadObstacles;
    private Vector3 pos;
    private Camera cam;
    private int iGoodObstaclesIndex, iSizeGoodObstacles;
    private int iBadObstaclesIndex, iSizeBadObstacles;
    private GameObject gObjTemp;
    void Awake()
    {
        cam = Camera.main;
        iSizeBadObstacles = gArrBadObstacles.Length;
        iSizeGoodObstacles = gArrGoodObstacles.Length;

        Vector3 vSpawn = new Vector3(cam.transform.position.x, cam.transform.position.y - 20.0f, cam.transform.position.z);
        //Spawn "good" and evil obstacles and save them into the array
        for(int iC = 0; iC < iSizeGoodObstacles; iC++)
        {
            gArrGoodObstacles[iC] = (GameObject)Instantiate(obstacle, vSpawn, cam.transform.rotation);
            gArrBadObstacles[iC] = (GameObject)Instantiate(killObstacle, vSpawn, cam.transform.rotation);
        }

        
        
    }

	// Use this for initialization
	void Start () {
		pos = new Vector3 (0, 15, 0);
		
        iGoodObstaclesIndex = 0;
        iBadObstaclesIndex = 0;
	}
	
	// Update is called once per frame
	void Update () {
		//Move camera upwards. This is in the "camera movement script"
		//cam.transform.Translate (0, 0.01f, 0); 
        
        
		/*if (Input.GetKeyDown ("space")) {
			//Instantiate obstacle between minimum and maximum position
			pos.x = (float)Random.Range(-1f, 3f);
			Instantiate(shit, pos, Quaternion.identity);

			//gg
			pos.y+=4.0f;
		}*/

        //If the camera is 15 distance from the spawn's shit point, then it should spawn shit and move the spawn point shit
        if(cam.transform.position.y > (pos.y -15)){
            pos.x = (float)Random.Range(-1f, 3f);
            int num = (int)Mathf.Floor(Random.Range(1, 100));
            if (num >= 1 && num <= 25)
            {
                //gObjTemp = gArrBadObstacles[iBadObstaclesIndex];
                //gObjTemp.transform.position = pos;
                //gObjTemp.transform.GetChild(1).gameObject.GetComponent<Collider2D>().enabled = true;
                //gObjTemp = gArrBadObstacles[iBadObstaclesIndex];
                gArrBadObstacles[iBadObstaclesIndex].transform.position = pos;
                gArrBadObstacles[iBadObstaclesIndex].transform.GetChild(1).gameObject.GetComponent<Collider2D>().enabled = true;
                iBadObstaclesIndex = (iBadObstaclesIndex + 1) % iSizeBadObstacles;
                //Instantiate(killObstacle, pos, Quaternion.identity);
            }
            else
            {
                //gObjTemp = gArrGoodObstacles[iGoodObstaclesIndex];
                //gObjTemp.transform.position = pos;
                //gObjTemp.transform.GetChild(1).gameObject.GetComponent<Collider2D>().enabled = true;
                gArrGoodObstacles[iGoodObstaclesIndex].transform.position = pos;
                gArrGoodObstacles[iGoodObstaclesIndex].transform.GetChild(1).gameObject.GetComponent<Collider2D>().enabled = true;
                iGoodObstaclesIndex = (iGoodObstaclesIndex + 1) % iSizeGoodObstacles;
                //Instantiate(obstacle, pos, Quaternion.identity);
            }

            pos.y += 4.0f; 
        }
	}
}
