using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Whirl : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnTriggerEnter2D(Collider2D col)
	{
		

			if (col.gameObject.name == "BoatP1Green") 
			{
				col.GetComponent<TesteMovimento>().Whirl();
			}

		if (col.gameObject.name == "BoatP2Red") 
		{
			col.GetComponent<TesteMovimentoP2>().Whirl();
		}
	}
}
