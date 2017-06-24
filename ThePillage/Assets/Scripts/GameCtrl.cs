using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameCtrl : MonoBehaviour {

	public GameObject final;

	// Use this for initialization
	void Start () {

		 
	}
	
	// Update is called once per frame
	void Update () {

		if (final.GetComponent<Obstaculo> ().vidas == 0 && final.GetComponent<Obstaculo> ().ganhandoverde () == true) 
		{
			Debug.Log ("Vitoria VERDE!");
			SceneManager.LoadScene ("fimVerde");
		}

		if (final.GetComponent<Obstaculo> ().vidas == 0 && final.GetComponent<Obstaculo> ().ganhandovermelho () == true) 
		{
			SceneManager.LoadScene ("fimvermelho");
			Debug.Log ("Vitoria VERMELHO!");
		}


	}
}
