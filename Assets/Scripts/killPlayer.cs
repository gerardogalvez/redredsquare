using UnityEngine;
using System.Collections;

public class killPlayer : MonoBehaviour {
	
	void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "killObstacle")
        {
            Application.LoadLevel(Application.loadedLevel);
        }
    }
}
