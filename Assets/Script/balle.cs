using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balle : MonoBehaviour
{


	public float Speed = 15f;
	// Use this for initialization
	void Start()
	{
		if (GameObject.Find("Eject").GetComponent<Direction>().goingDroite)
		{
			GetComponent<Rigidbody2D>().velocity = Vector2.right * Speed;
		}
		else
		{
			GetComponent<Rigidbody2D>().velocity = -Vector2.right * Speed;
		}
	}

	// Update is called once per frame
	void Update()
	{

	}
	float HitFactor(Vector2 BallPosition, Vector2 BarrePositon, float BarreHeight)
	{
		return (BallPosition.y - BarrePositon.y) / BarreHeight;
	}

	void OnCollisionEnter2D(Collision2D Col)
	{
		if (Col.gameObject.name == "barreG")
		{
			float y = HitFactor(transform.position, Col.transform.position, Col.collider.bounds.size.y);
			Vector2 Dir = new Vector2(1, y).normalized;
			GetComponent<Rigidbody2D>().velocity = Dir * Speed;
		}


		if (Col.gameObject.name == "barreD")
		{
			float y = HitFactor(transform.position, Col.transform.position, Col.collider.bounds.size.y);
			Vector2 Dir = new Vector2(-1, y).normalized;
			GetComponent<Rigidbody2D>().velocity = Dir * Speed;
		}
	}
}
