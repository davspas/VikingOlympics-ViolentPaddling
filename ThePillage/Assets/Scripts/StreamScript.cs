using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StreamScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.tag == "Barco") {
			Quaternion rotacaoinicial = this.transform.rotation;
			Vector2 direcao = new Vector2 (this.transform.position.x, this.transform.position.y);
		
			col.GetComponent<Transform> ().transform.rotation = rotacaoinicial;
			col.GetComponent<Rigidbody2D> ().AddForce (direcao * 50f, ForceMode2D.Impulse);
			Debug.Log ("STREEEEAAAAM");
		}
	}
}
