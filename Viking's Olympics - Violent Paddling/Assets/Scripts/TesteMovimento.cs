using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TesteMovimento : MonoBehaviour {

	public float velocidade;
	public GameObject VikingDTopGreen;
	public GameObject VikingDCenterGreen;
	public GameObject VikingDBottomGreen;
	public GameObject VikingETopGreen;
	public GameObject VikingECenterGreen;
	public GameObject VikingEBottomGreen;

	Rigidbody2D rb;
	Remada remadaD1;
	Remada remadaD2;
	Remada remadaD3;
	Remada remadaE1;
	Remada remadaE2;
	Remada remadaE3;
	// Use this for initialization
	void Start () 
	{
		rb = GetComponent<Rigidbody2D> ();
		remadaD1 = VikingDTopGreen.GetComponent<Remada> ();
		remadaD2 = VikingDCenterGreen.GetComponent<Remada> ();
		remadaD3 = VikingDBottomGreen.GetComponent<Remada> ();

		remadaE1 = VikingETopGreen.GetComponent<Remada> ();
		remadaE2 = VikingECenterGreen.GetComponent<Remada> ();
		remadaE3 = VikingEBottomGreen.GetComponent<Remada> ();



	}

	// Update is called once per frame
	void Update ()
	{

		float combinadadireita = 0;
		float combinadaesquerda = 0;

		//vento simulado

		rb.AddRelativeForce (Vector3.up * velocidade);


		//rotacao viking

		//rotacao para direita
		if (Input.GetKeyDown ("a") && remadaD1.taVivo ()) {
			combinadadireita += remadaD1.forcaremada;

		}
		if (Input.GetKeyDown ("s") && remadaD2.taVivo ()) {
			combinadadireita += remadaD2.forcaremada;

		}
		if (Input.GetKeyDown ("d") && remadaD3.taVivo ()) {
			combinadadireita += remadaD3.forcaremada;

		}




		//rotacao para esquerda
		if (Input.GetKeyDown("z") && remadaE1.taVivo())
		{
			combinadaesquerda += remadaE1.forcaremada;

		}
		if (Input.GetKeyDown("x") && remadaE2.taVivo())
		{
			combinadaesquerda += remadaE2.forcaremada;

		}
		if (Input.GetKeyDown("c") && remadaE3.taVivo())
		{
			combinadaesquerda += remadaE3.forcaremada;

		}

		rb.AddTorque (combinadaesquerda);
		rb.AddTorque (-combinadadireita);
	}
}
