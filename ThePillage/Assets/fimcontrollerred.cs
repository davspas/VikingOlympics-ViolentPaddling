using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ArcadePUCCampinas;
using UnityEngine.SceneManagement;
public class fimcontrollerred : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (InputArcade.Apertou (0, EControle.VERMELHO)) {
			Voltar ();


		}

		if (InputArcade.Apertou (1, EControle.VERMELHO)) {
			Voltar ();


		}
		
	}
	public void Voltar()
	{
		SceneManager.LoadScene ("LevelOne");
	}
}
