using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacles : MonoBehaviour {

	public GameObject Madeira;
	public GameObject Preda;
	public GameObject Corrente;
	public GameObject Redemoinho;
	public int madeiraMax = 0;
	public int predaMax = 8;
	public int correnteMax = 0;
	public int redemoinhoMax = 0;
	GameObject[] madeira;

	// Use this for initialization
	void Start () 
	{
		InvokeRepeating ("CriaMadeira", Random.Range (1.0f, 10.0f), Random.Range (1.0f, 1.0f));
		Invoke ("CriaPreda", Random.Range (1.0f, 3.0f));
		Invoke ("CriaPreda", Random.Range (1.0f, 3.0f));
		Invoke ("CriaPreda", Random.Range (1.0f, 3.0f));
		Invoke ("CriaPreda", Random.Range (1.0f, 3.0f));
		Invoke ("CriaPreda", Random.Range (1.0f, 3.0f));
		Invoke ("CriaPreda", Random.Range (1.0f, 3.0f));
		Invoke ("CriaPreda", Random.Range (1.0f, 3.0f));
		Invoke ("CriaPreda", Random.Range (1.0f, 3.0f));
		InvokeRepeating ("CriaCorrente", Random.Range (1.0f, 3.0f), Random.Range(1.0f,15.0f));
		InvokeRepeating ("CriaRedemoinho", Random.Range (1.0f, 3.0f), Random.Range(1.0f, 15.0f));
	}
		

	void CriaMadeira () 
	{
		madeira = GameObject.FindGameObjectsWithTag ("madeira");

		if (madeira.Length < 10) {
			Instantiate (Madeira, new Vector2 (Random.Range (-8.0f, 68.0f), Random.Range (-18.0f, 24.0f)), Quaternion.identity);

			Debug.Log ("Madeira criada");

		} else 
		{
			Debug.Log ("Número máximo de madeiras atingido");
		}



	}

	public void DiminuirMadeira()
	{
		this.madeiraMax = this.madeiraMax -10;
		Debug.Log ("Uma madeira foi removida");
}

	void CriaPreda()
	{
		Instantiate (Preda, new Vector2 (Random.Range (-14.0f, 59.0f), Random.Range (-17.0f, 24.0f)), Quaternion.identity);
	}

	void CriaCorrente()
	{
		if (correnteMax < 2) 
		{
			Instantiate (Corrente, new Vector2 (Random.Range (-14.0f, 59.0f), Random.Range (-17.0f, 24.0f)), Quaternion.identity);
			correnteMax++;
			Debug.Log ("Corrente criada");
			Invoke ("DestroiCorrente", Random.Range (15.0f, 15.0f));
		}
	}



	void CriaRedemoinho()
	{
		if (redemoinhoMax < 2) 
		{
			Instantiate (Redemoinho, new Vector2 (Random.Range (-14.0f, 59.0f), Random.Range (-17.0f, 24.0f)), Quaternion.identity);
			redemoinhoMax++;
			Debug.Log ("Redemoinho criado");
			Invoke ("DestroiRedemoinho", Random.Range (15.0f, 15.0f));
		}
	}

	void DestroiCorrente()
	{
		Destroy (Corrente);
		Debug.Log ("Corrente destruida");
	}

	void DestroiRedemoinho()
	{
		Destroy (Redemoinho);
		Debug.Log ("Redemoinho destruido");
	}
		
}
