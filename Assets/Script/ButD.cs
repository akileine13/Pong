using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButD : MonoBehaviour {

	private int score = 0;
	public GameObject Projecil;
	// Use this for initialization
	void Start()
	{
	}

	// Update is called once per frame
	void OnTriggerEnter2D(Collider2D Col)
	{
		GameObject.Find("Eject").GetComponent<Direction>().goingDroite = false;
		score += 1;
		GameObject.Find("ScoreD").GetComponent<TextMesh>().text = "" + score;
		Instantiate(Projecil, GameObject.Find("Eject").GetComponent<Transform>().transform.position, Quaternion.identity);
		Destroy(Col.gameObject);
	}
}
