using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlerD : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	public float Vitesse = 15f;
	// Update is called once per frame
	void Update()
	{

		if (Input.GetKey(KeyCode.P))
		{
			transform.Translate(Vector2.up * Vitesse * Time.deltaTime);
		}

		if (Input.GetKey(KeyCode.M))
		{
			transform.Translate(-Vector2.up * Vitesse * Time.deltaTime);
		}

	}
}
