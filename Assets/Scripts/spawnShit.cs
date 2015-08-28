using UnityEngine;
using System.Collections;

public class spawnShit : MonoBehaviour {
	private Camera cam;
	public GameObject shit;
	private Vector3 pos;
	// Use this for initialization
	void Start () {
		pos = new Vector3 (0, -5, 0);
		cam = Camera.main;
	}
	
	// Update is called once per frame
	void Update () {
		//Move camera upwards
		cam.transform.Translate (0, 0.01f, 0);
		if (Input.GetKeyDown ("space")) {
			//Instantiate obstacle between minimum and maximum position
			pos.x = (float)Random.Range(-1f, 3f);
			Instantiate(shit, pos, Quaternion.identity);

			//gg
			pos.y+=2.5f;;
		}
	}
}
