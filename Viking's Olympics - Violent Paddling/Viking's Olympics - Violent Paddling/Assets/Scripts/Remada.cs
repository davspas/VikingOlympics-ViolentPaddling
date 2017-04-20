using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Remada : MonoBehaviour {

	public	float  forcaremada =  0.5f;
	private bool vivo;
		
	// Use this for initialization
	void Start () {
		vivo = true;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public bool taVivo()
	{
		return vivo;
	}
}
