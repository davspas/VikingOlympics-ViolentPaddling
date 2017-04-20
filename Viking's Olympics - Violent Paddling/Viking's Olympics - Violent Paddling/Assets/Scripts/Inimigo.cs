using UnityEngine;
using System.Collections;

public class Inimigo : MonoBehaviour {

	public GameObject listaObjetos;
	public float distanciaPerseguir = 10.0f; // distancia que inicia a perseguição
	public float velocidade = 1;

	private GameObject objetoParaPerseguir;
	private Rigidbody rbInimigo;
	private bool perseguindo = false;

	void Start () {
		rbInimigo = GetComponent<Rigidbody> ();
		velocidade += Random.Range (0, 2.5f); // deixar a velocidade um pouco variável
	}

	void Update () {
		// achar um alvo para perseguir
		ProcurarObjetoMaisProximo ();

		// olhar para o alvo
		if (objetoParaPerseguir != null) {
			OlharParaAlvo (objetoParaPerseguir);
		}

		// perseguir objeto
		if (perseguindo && objetoParaPerseguir != null) {
			PerseguirObjeto (objetoParaPerseguir);
		}

		// caso o inimigo saia da arena, ele é removido
		if (transform.position.y < 0) {
			Destroy (gameObject);
		}
	}

	void PerseguirObjeto(GameObject alvo) {
		if (!alvo) {
			perseguindo = false;
		} else {
			transform.position = Vector3.MoveTowards (transform.position, alvo.transform.position, Time.deltaTime * 2);
		}
	}

	void OlharParaAlvo(GameObject alvo) {
		Vector3 pos = alvo.transform.position;
		pos.y = transform.position.y;
		Vector3 lookAtPos = pos - transform.position;
		Quaternion newRot = Quaternion.LookRotation (lookAtPos);
		transform.rotation = Quaternion.Lerp (transform.rotation, newRot ,Time.deltaTime * 3);
		float angle = Quaternion.Angle (transform.rotation, newRot);
		if (angle < 10) {
			perseguindo = true;
		} else {
			perseguindo = false;
		}
	}

	void ProcurarObjetoMaisProximo() {
		float distanciaObjetoPerseguindo = 1000f;
		foreach (Transform alvo in listaObjetos.transform) {
			float distanciaAlvoLoop = Vector3.Distance (transform.position, alvo.transform.position);
			if (distanciaAlvoLoop <= distanciaPerseguir) {
				if (distanciaAlvoLoop < distanciaObjetoPerseguindo) {
					objetoParaPerseguir = alvo.gameObject;
					distanciaObjetoPerseguindo = distanciaAlvoLoop;
				}
			}
		}
	}

	void OnDestroy() {
		Debug.Log ("INIMIGO DESTRUÍDO");
	}
}
