using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ArcadePUCCampinas;

public class TesteMovimentoP2 : MonoBehaviour {

	public float velocidade;
	public GameObject VikingDTopRed;
	public GameObject VikingDCenterRed;
	public GameObject VikingDBottomRed;
	public GameObject VikingETopRed;
	public GameObject VikingECenterRed;
	public GameObject VikingEBottomRed;
	[SerializeField] private GameObject sail;
	public float velocidaderotacao;
	public float rotacaoz;

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

		{
			rb.AddRelativeForce (Vector3.up * velocidade * 1f);
		}

		float combinadadireita = 0;
		float combinadaesquerda = 0;

		//vento simulado




		//rotacao vela



		rotacaoz += InputArcade.Eixo(0, EEixo.HORIZONTAL) * velocidaderotacao;
		rotacaoz = Mathf.Clamp(rotacaoz * velocidaderotacao, -35f,35f);
		sail.transform.localEulerAngles = new Vector3 (transform.localEulerAngles.x, transform.localEulerAngles.y, rotacaoz);


		//rotacao para direita
		if (InputArcade.Apertou(0, EControle.VERDE) && remadaD1.taVivo ()) {
			combinadadireita += remadaD1.forcaremada;

		}
		if (InputArcade.Apertou(0, EControle.VERMELHO) && remadaD2.taVivo ()) {
			combinadadireita += remadaD2.forcaremada;

		}
		if (InputArcade.Apertou(0, EControle.PRETO) && remadaD3.taVivo ()) {
			combinadadireita += remadaD3.forcaremada;

		}




		//rotacao para esquerda
		if (InputArcade.Apertou(0, EControle.AZUL) && remadaE1.taVivo())
		{
			combinadaesquerda += remadaE1.forcaremada;

		}
		if (InputArcade.Apertou(0, EControle.AMARELO) && remadaE2.taVivo())
		{
			combinadaesquerda += remadaE2.forcaremada;

		}
		if (InputArcade.Apertou(0, EControle.BRANCO) && remadaE3.taVivo())
		{
			combinadaesquerda += remadaE3.forcaremada;

		}

		rb.AddTorque (combinadaesquerda);
		rb.AddTorque (-combinadadireita);
	}
	public void AcelerarMedio()
	{
		rb.AddRelativeForce (Vector3.up * velocidade);
	}
	public void AcelerarMuito()
	{
		rb.AddRelativeForce (Vector3.up * velocidade * 2f);
	}
	public void DesacelerarMedio()
	{
		if (rb.velocity.magnitude >= 1) {
			rb.AddRelativeForce (Vector3.down * velocidade);
		} else 
		{
		}
	}
	public void DesacelerarMuito()
	{
		if (rb.velocity.magnitude >= 3) {
			rb.AddRelativeForce (Vector3.down * velocidade * 2f);
		} else
		{
		}
	}

	public void Bump()

	{
		rb.AddRelativeForce (Vector3.down * 500, ForceMode2D.Impulse);
		Debug.Log ("BUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUMMMMMP");
}

	public void Whirl()
	{



		float forcadegiro = Random.Range (20000, 30000);
		rb.AddTorque (forcadegiro);

		rb.AddRelativeForce (Vector3.up * 1000, ForceMode2D.Impulse);
		Debug.Log ("GIRAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" + forcadegiro);
	}
}
