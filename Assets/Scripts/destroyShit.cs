using UnityEngine;
using System.Collections;

public class destroyShit : MonoBehaviour {

    //private Camera cam; 
    private GameObject gParticles;
    private float fDistDestroy = 18.0f;
    private BoxCollider2D myCollider;
   // private bool bGo;
	// Use this for initialization
	void Start () {
        //cam = Camera.main;
        gParticles = GameObject.FindWithTag("killParticles");
        myCollider = gameObject.transform.GetChild(1).gameObject.GetComponent<BoxCollider2D>();
    }
	
	// Update is called once per frame
	void Update () {
        if (gParticles.transform.position.y - this.transform.position.y > fDistDestroy)
            myCollider.enabled = true;
	}
}
