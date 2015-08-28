using UnityEngine;
using System.Collections;

public class playerMovement : MonoBehaviour {
	public float fSensibility = 100.0f;
	public float fMaxDistance = 100.0f;
	
	private Vector3 v3RatonPos, v3RatonPosInit, v3RatonPosFin;
	
	
	
	
	void Update () {
		
		//Establecer la posicion inicial y final de cuando arrastra el dedo por la pantalla.
		//***************************************************************************************
		if (Input.GetMouseButtonDown(0)){ //Cuando se presiona la pantalla..
			
			//Guarda la posicion donde se presiono la pantalla como posicion inicial del gesto.
			v3RatonPosInit = getRatonPos ();
			
		} else if (Input.GetMouseButtonUp(0)) { //De otro modo, cuando se deje de tocar la pantalla..
			
			// Guarda la posicion donde se dejo de presionar como posicion final del gesto.
			v3RatonPosFin = getRatonPos(); 
			Debug.Log ("Magnitude de la fuerza: " + (getDirection().normalized *fSensibility * getPercDis(fMaxDistance)).magnitude);
			gameObject.GetComponent<Rigidbody2D>().AddForce(getDirection().normalized * getPercDis(fMaxDistance) * fSensibility);
		}
		//***************************************************************************************
		
		
		
		
		
		
	}
	float getPercDis(float fMaxDis){
		float distance = (v3RatonPosFin - v3RatonPosInit).magnitude;
		if (distance > fMaxDis)
			distance = fMaxDis;
		
		float percDist = distance * 100 / fMaxDis;
		return percDist;
	}
	
	Vector3 getDirection(){
		Vector3 v3Dir = v3RatonPosFin - v3RatonPosInit;
		return v3Dir;
	}
	
	
	
	
	Vector3 getRatonPos(){
		
		v3RatonPos = Input.mousePosition; //Tomar la posicion donde esta el mouse (en pixeles).
		v3RatonPos.z = 10.0f; //Transformar la profundidad a la misma que la de la camara.
		v3RatonPos = Camera.main.ScreenToWorldPoint (v3RatonPos); // Convertir el vector a unidades de unity 
		return v3RatonPos; //Regresar la posicion del "Raton" utilizable.
	}
}
