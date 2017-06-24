using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RamGreen : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D (Collider2D col)
	{
		if (col.gameObject.tag == "viking") {
			col.GetComponent<Remada> ().Morreu ();
			GetComponentInParent<TesteMovimento> ().Bump ();
		}

		if (col.gameObject.name == "BoatP2Red") 

			{
			GetComponentInParent<TesteMovimento> ().Bump ();
			}
				
	
	}
}
