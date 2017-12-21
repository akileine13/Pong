using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrontolerG : MonoBehaviour {

	public float Vitesse = 15f;
	// Use this for initialization
	
	
	// Update is called once per frame
	void Update ()
	{

		if (Input.GetKey(KeyCode.A)) 
		{
			transform.Translate(Vector2.up * Vitesse * Time.deltaTime);
		}

		if (Input.GetKey(KeyCode.Q)) 
		{
			transform.Translate(-Vector2.up * Vitesse * Time.deltaTime);
		}

	}
}
