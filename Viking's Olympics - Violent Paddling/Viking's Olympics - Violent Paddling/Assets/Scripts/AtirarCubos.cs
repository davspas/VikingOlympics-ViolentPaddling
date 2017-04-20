using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AtirarCubos : MonoBehaviour {

	public Transform posDisparo;
	public GameObject projetil;
	public float forca = 10f;
	public int municao = 30;
	public Text textMunicao;

	void Update () {		
		// atirar os cubos
		if (Input.GetButtonDown("Fire1") && municao > 0) {
			Vector3 pos = posDisparo.position;
			Quaternion rot = posDisparo.rotation;
			GameObject disparo = Instantiate (projetil, pos, rot) as GameObject;
			Vector3 vetorForca = posDisparo.forward * forca;
			Rigidbody rbDisparo = disparo.GetComponent<Rigidbody> ();
			rbDisparo.AddForce (vetorForca, ForceMode.Impulse);
			municao--;
		}

		// alerta de baixa munição
		if (municao == 5) {
			textMunicao.color = Color.yellow;
		}
		// fim da munição
		if (municao == 0) {
			Debug.Log ("PLAYER ESTÁ SEM MUNIÇÃO");
			textMunicao.color = Color.red;
		}
		textMunicao.text = "Munição: " + municao;
	}

}
