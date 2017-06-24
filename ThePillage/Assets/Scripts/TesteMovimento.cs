using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ArcadePUCCampinas;

public class TesteMovimento : MonoBehaviour {

	public float velocidade;
	public GameObject VikingDTopGreen;
	public GameObject VikingDCenterGreen;
	public GameObject VikingDBottomGreen;
	public GameObject VikingETopGreen;
	public GameObject VikingECenterGreen;
	public GameObject VikingEBottomGreen;
	[SerializeField] private GameObject sail;
	public float velocidaderotacao;
	public float rotacaozlateral;
	public float rotacaozvertical;

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

		{
			rb.AddRelativeForce (Vector3.up * velocidade * 1f);
		}



		float combinadadireita = 0;
		float combinadaesquerda = 0;

		//rotacaovertical

	
		rotacaozlateral += InputArcade.Eixo(1, EEixo.HORIZONTAL) * velocidaderotacao;
		    rotacaozlateral = Mathf.Clamp(rotacaozlateral * velocidaderotacao, -35f,35f);
		sail.transform.localEulerAngles = new Vector3 (transform.localEulerAngles.x, transform.localEulerAngles.y, rotacaozlateral);

		//rotacaovertical
		//rotacaozvertical += InputArcade.Eixo(1, EEixo.VERTICAL) * velocidaderotacao;
		//rotacaozvertical = Mathf.Clamp(rotacaozvertical * velocidaderotacao, -35f,35f);
		//sail.transform.localEulerAngles = new Vector3 (transform.localEulerAngles.x, transform.localEulerAngles.y, rotacaoz);




		//rotacao viking

		//rotacao para direita
		if (InputArcade.Apertou(1, EControle.VERDE) && remadaD1.taVivo ()) {
			combinadadireita += remadaD1.forcaremada;

		}
		if (InputArcade.Apertou(1, EControle.VERMELHO) && remadaD2.taVivo ()) {
			combinadadireita += remadaD2.forcaremada;

		}
		if (InputArcade.Apertou(1, EControle.PRETO) && remadaD3.taVivo ()) {
			combinadadireita += remadaD3.forcaremada;

		}




		//rotacao para esquerda
		if (InputArcade.Apertou(1, EControle.AZUL) && remadaE1.taVivo())
		{
			combinadaesquerda += remadaE1.forcaremada;

		}
		if (InputArcade.Apertou(1, EControle.AMARELO) && remadaE2.taVivo())
		{
			combinadaesquerda += remadaE2.forcaremada;

		}
		if (InputArcade.Apertou(1, EControle.BRANCO)&& remadaE3.taVivo())
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
			rb.AddRelativeForce (-Vector3.up * velocidade);
		} else
		{
		}
	}
	public void DesacelerarMuito()
	{
		if (rb.velocity.magnitude >= 3) {
			this.rb.AddRelativeForce (-Vector3.up * velocidade * 2f);
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
