using UnityEngine;
using System.Collections;

public class Projetil : MonoBehaviour {
	void OnCollisionEnter(Collision col) {
		if (col.gameObject.name == "Piso") {
			Destroy (gameObject, 0.5f);
		}
		if (col.gameObject.CompareTag ("Inimigo")) {
			Destroy (gameObject);
			Destroy (col.gameObject);
		}
	}
}