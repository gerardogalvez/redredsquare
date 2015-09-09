using UnityEngine;
using System.Collections;

public class spawnShit : MonoBehaviour {
	private Camera cam;
	public GameObject shit;
	private Vector3 pos;
	// Use this for initialization
	void Start () {
		pos = new Vector3 (0, 15, 0);
		cam = Camera.main;
	}
	
	// Update is called once per frame
	void Update () {
		//Move camera upwards. This is in the "camera movement script"
		//cam.transform.Translate (0, 0.01f, 0); 
        
        
		if (Input.GetKeyDown ("space")) {
			//Instantiate obstacle between minimum and maximum position
			pos.x = (float)Random.Range(-1f, 3f);
			Instantiate(shit, pos, Quaternion.identity);

			//gg
			pos.y+=4.0f;
		}

        //If the camera is 15 distance from the spawn's shit point, then it should spawn shit and move the spawn point shit
        if(cam.transform.position.y > (pos.y -15)){
            pos.x = (float)Random.Range(-1f, 3f);
            Instantiate(shit, pos, Quaternion.identity);
            pos.y += 4.0f; 
        }
	}
}
