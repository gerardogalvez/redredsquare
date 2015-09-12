using UnityEngine;
using System.Collections;

public class cameraMovement : MonoBehaviour {

    public float cameraSpeed = 0.01f; //Camera upward movement speed
    public float cameraTime = 0.02f; //Time that takes to get to the player
    public float distanceFromPlayer = 5.0f; //max distance that must be from the player

    private GameObject gPlayer;
	// Use this for initialization
	void Awake () {
        gPlayer = GameObject.FindWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {

        //If the player position is more than 10 units away form the camera, then the camera is going to follow him smoothly
        if(gPlayer.transform.position.y > (transform.position.y + distanceFromPlayer)){
            Vector3 gPlayerPosToFollow = new Vector3(transform.position.x, gPlayer.transform.position.y - distanceFromPlayer, transform.position.z);
            transform.position = Vector3.Lerp(transform.position, gPlayerPosToFollow, cameraSpeed);

        }else
            transform.Translate(0.0f, cameraSpeed, 0.0f);
	}
}
