using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorMadeira : MonoBehaviour {

	int hits = 0;
	public GameObject GameController;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	void OnCollisionEnter2D(Collision2D other)
	{
		if ((other.gameObject.tag == "Barco") || (other.gameObject.tag == "Background") || (other.gameObject.tag == "Obstacle"))
		{
			hits++;
		}
		if (hits == 3) 
		{
			Destroy (gameObject);
		
			Debug.Log ("Madeira Destruida");

		}

	}
}
