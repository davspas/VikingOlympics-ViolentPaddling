using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using ArcadePUCCampinas;

public class fimcontroller : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (InputArcade.Apertou (0, EControle.VERDE)) {
			Voltar ();
		
		
		}

		if (InputArcade.Apertou (1, EControle.VERDE)) {
			Voltar ();


		}
	}

	public void Voltar()
	{
		SceneManager.LoadScene ("LevelOne");
	}
}
