using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour {


	private bool venceuVerde;
	private bool venceuVermelho;
	public int vidas = 1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void PerderVida()
	{
		this.vidas = this.vidas - 1;
	}

	void OnTriggerEnter2D (Collider2D col)
	{
		if (col.gameObject.tag == "greenram") 
		{
			col.GetComponentInParent<TesteMovimento> ().Bump ();
			venceuVermelho = false;
			venceuVerde = true;
			PerderVida ();
		}

		if (col.gameObject.tag == "redram") 
		{
			col.GetComponentInParent<TesteMovimentoP2> ().Bump ();
			venceuVermelho = true;
			venceuVerde = false;
			PerderVida ();
		}
	}

	public bool ganhandoverde()
	{
		return venceuVerde;
	}
	public bool ganhandovermelho()
	{
		return venceuVermelho;
	}




}
