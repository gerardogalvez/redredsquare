using UnityEngine;
using System.Collections;

public class destroyShit : MonoBehaviour {

	private Camera cam;

	// Use this for initialization
	void Start () {
		cam = Camera.main;
	}
	
	// Update is called once per frame
	void Update () {
		if (cam.transform.position.y - this.transform.position.y > 12)
			Destroy (this.gameObject);
	}
}
