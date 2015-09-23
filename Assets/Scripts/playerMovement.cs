using UnityEngine;
using System.Collections;

public class playerMovement : MonoBehaviour {
	public float fMaxStrength = 1500.0f;
	public float fMaxDistMouseMove = 10.0f; //Max distance in units of unity that needs to be moved the mouse in order to achieve the max strength

    private Vector3 v3RatonPosInit, v3RatonPosFin;
	
	void Update () {
        if (Time.timeScale > 0)
        {
            //Establecer la posicion inicial y final de cuando arrastra el dedo por la pantalla.
            //***************************************************************************************
            if (Input.GetMouseButtonDown(0))
            { //Cuando se presiona la pantalla..

                //Guarda la posicion donde se presiono la pantalla como posicion inicial del gesto.
                v3RatonPosInit = getRatonPos();

            }
            else if (Input.GetMouseButtonUp(0))
            { //De otro modo, cuando se deje de tocar la pantalla..

                // Guarda la posicion donde se dejo de presionar como posicion final del gesto.
                v3RatonPosFin = getRatonPos();

                //Debug.Log ("Magnitude de la fuerza: " + (getDirection().normalized *fSensibility * getPercDis(fMaxDistance)).magnitude);
                gameObject.GetComponent<Rigidbody2D>().AddForce(getDirection().normalized * getPercDis(fMaxDistMouseMove) * fMaxStrength);
                //Debug.Log("Force added: " + (getDirection().normalized * getPercDis(fMaxDistMouseMove) * fMaxStrength));
            }
            //**************************************************************************************
            fMaxStrength = 1500;
        }
        else
        {
            fMaxStrength = 0;
        }
	}

	float getPercDis(float fMaxDis){
		float distance = (v3RatonPosFin - v3RatonPosInit).magnitude;
        
        if (distance > fMaxDis)
        {
            distance = fMaxDis;
        }
			
        //Debug.Log("Mouse's movement distance: " + distance);
        float percDist = distance / fMaxDis;
        //Debug.Log("Percentage of distance returned: " + percDist);
		return percDist;
	}
	
	Vector3 getDirection(){
		Vector3 v3Dir = v3RatonPosFin - v3RatonPosInit;
		return v3Dir;
	}

	Vector3 getRatonPos(){

        Vector3 v3RatonPos;
		v3RatonPos = Input.mousePosition; //Tomar la posicion donde esta el mouse (en pixeles).
		v3RatonPos.z = 10.0f; //Transformar la profundidad a la misma que la de la camara.
		v3RatonPos = Camera.main.ScreenToWorldPoint (v3RatonPos); // Convertir el vector a unidades de unity 
		return v3RatonPos; //Regresar la posicion del "Raton" utilizable.
	}

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Middle")
        {
            manageScore.score++;
            GetComponent<AudioSource>().Play();
            //Disable collider so that it only increases score one time
            other.enabled = false;
        } 
    }

}