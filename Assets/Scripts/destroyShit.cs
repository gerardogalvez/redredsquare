using UnityEngine;
using System.Collections;

public class destroyShit : MonoBehaviour {

    //private Camera cam; 
    private GameObject gParticles;
    private float fDistDestroy = 30.0f;
	// Use this for initialization
	void Start () {
        //cam = Camera.main;
        gParticles = GameObject.FindWithTag("killParticles");
	}
	
	// Update is called once per frame
	void Update () {
		if (gParticles.transform.position.y - this.transform.position.y > fDistDestroy)
			Destroy (this.gameObject);
	}
}
