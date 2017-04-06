using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TesteMovimento : MonoBehaviour {

	public float qtde = 1000.0f;


	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		float h = Input.GetAxis ("Horizontal") * qtde * Time.deltaTime;

	}
}
