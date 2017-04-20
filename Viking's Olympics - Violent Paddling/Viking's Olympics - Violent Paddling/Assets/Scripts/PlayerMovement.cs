using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float velocidadeMovimento = 15f;

	void Update () {
		//movimentacao
		float h = Input.GetAxis("Horizontal");
		float v = Input.GetAxis("Vertical");
		GetComponent<Rigidbody> ().AddForce (transform.forward * v * velocidadeMovimento, ForceMode.Acceleration);
		transform.Rotate (new Vector3 (0, h * (velocidadeMovimento/3), 0));

		// caso o player cair arena ele é destruído
		if (transform.position.y < -40) {
			Destroy (gameObject);
			Debug.Log ("PLAYER DESTRUÍDO PORQUE CAIU NO VOID");
		}
	}

	void OnCollisionEnter(Collision col) {
		if (col.gameObject.CompareTag ("Inimigo")) {
			Destroy (gameObject);
			Debug.Log ("PLAYER DESTRUÍDO POR UM INIMIGO");
		}
	}

	void OnDestroy() {
		Debug.Log ("GAME OVER!");
	}
		
}
