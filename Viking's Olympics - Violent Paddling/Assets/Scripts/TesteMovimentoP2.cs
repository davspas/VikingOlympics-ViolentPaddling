using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TesteMovimentoP2 : MonoBehaviour {

	public float velocidade;
	public GameObject VikingDTopRed;
	public GameObject VikingDCenterRed;
	public GameObject VikingDBottomRed;
	public GameObject VikingETopRed;
	public GameObject VikingECenterRed;
	public GameObject VikingEBottomRed;

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
		remadaD1 = VikingDTopRed.GetComponent<Remada> ();
		remadaD2 = VikingDCenterRed.GetComponent<Remada> ();
		remadaD3 = VikingDBottomRed.GetComponent<Remada> ();

		remadaE1 = VikingETopRed.GetComponent<Remada> ();
		remadaE2 = VikingECenterRed.GetComponent<Remada> ();
		remadaE3 = VikingEBottomRed.GetComponent<Remada> ();



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
		if (Input.GetKeyDown ("u") && remadaD1.taVivo ()) {
			combinadadireita += remadaD1.forcaremada;

		}
		if (Input.GetKeyDown ("i") && remadaD2.taVivo ()) {
			combinadadireita += remadaD2.forcaremada;

		}
		if (Input.GetKeyDown ("o") && remadaD3.taVivo ()) {
			combinadadireita += remadaD3.forcaremada;

		}




		//rotacao para esquerda
		if (Input.GetKeyDown("j") && remadaE1.taVivo())
		{
			combinadaesquerda += remadaE1.forcaremada;

		}
		if (Input.GetKeyDown("k") && remadaE2.taVivo())
		{
			combinadaesquerda += remadaE2.forcaremada;

		}
		if (Input.GetKeyDown("l") && remadaE3.taVivo())
		{
			combinadaesquerda += remadaE3.forcaremada;

		}

		rb.AddTorque (combinadaesquerda);
		rb.AddTorque (-combinadadireita);
	}
}
