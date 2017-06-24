using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VentoTeste : MonoBehaviour
{
	//OBJETOS  MARCADORES DE VENTO EM RELACAO AOS BARCOS
	[SerializeField] private GameObject WindPositionGreen;
	[SerializeField] private GameObject WindPositionRed;

	//OBJETOS DOS RAIOS DE VENTO
	[SerializeField] private GameObject northWind_Red;
	[SerializeField] private GameObject southWind_Red;
	[SerializeField] private GameObject eastWind_Red;
	[SerializeField] private GameObject westWind_Red;



    [SerializeField] private GameObject northWind_Green;
	[SerializeField] private GameObject southWind_Green;
	[SerializeField] private GameObject eastWind_Green;
	[SerializeField] private GameObject westWind_Green;

	//BARCOS
	[SerializeField] private GameObject boat_Green;
	[SerializeField] private GameObject boat_Red;
	public Image bussola;
	float smooth = 0.5f;

	//SCRIPT BARCO 1
	TesteMovimentoP2 scriptRedBoat;

	//SCRIP BARCO 2

	TesteMovimento scriptGreenBoat;

	//tempo de troca de ventos

	public float tempodetrocadovento;



	//randomizador

	private int whichwind;


    // Use this for initialization
    void Start()
    {
	scriptGreenBoat = boat_Green.GetComponent<TesteMovimento> ();
	scriptRedBoat = boat_Red.GetComponent<TesteMovimentoP2> ();
    
		InvokeRepeating ("WindManager", 5, tempodetrocadovento);


    }

    void Update()
    {
        WindPositionGreen.transform.position = boat_Green.transform.position;
		WindPositionRed.transform.position = boat_Red.transform.position;

		if (whichwind == 1) 
		{
			VentoNorte ();
			bussola.transform.localEulerAngles = new Vector3 (bussola.transform.localEulerAngles.x, bussola.transform.localEulerAngles.y, Mathf.Lerp(bussola.transform.localEulerAngles.z,180,Time.deltaTime*smooth));
			Debug.Log ("VENTO NORTE");
		}
		if (whichwind == 2) 
		{
			VentoSul ();
			bussola.transform.localEulerAngles = new Vector3 (bussola.transform.localEulerAngles.x,  Mathf.Lerp(bussola.transform.localEulerAngles.z,0,Time.deltaTime*smooth));
			Debug.Log ("VENTO SUL");
		}
		if (whichwind == 3) 
		{
			VentoLeste ();
			bussola.transform.localEulerAngles = new Vector3 (bussola.transform.localEulerAngles.x,  Mathf.Lerp(bussola.transform.localEulerAngles.z,60,Time.deltaTime*smooth));
			Debug.Log ("VENTO LESTE");
		}
		if (whichwind == 4) 
		{
			VentoOeste ();
			bussola.transform.localEulerAngles = new Vector3 (bussola.transform.localEulerAngles.x, Mathf.Lerp(bussola.transform.localEulerAngles.z,540,Time.deltaTime*smooth));
			Debug.Log ("VENTO OESTE");
		}

    }
   
   //Metodo que gerencia a chamada dos ventos

	public void WindManager()
	{
		whichwind = Random.Range (1, 4);


	}


	//METODO QUE APLICA O VENTO SUL
		void VentoSul()
	{
		//ScriptsParaVelocidade

	

		//Disparando o Raio Barco VelaVERDE
		RaycastHit2D hit = Physics2D.Raycast (southWind_Green.transform.position, Vector2.up, Mathf.Infinity, 1 << LayerMask.NameToLayer ("greensail"));
		//Verificando onde o Raio Colidiu e Adicionando/Removendo Velocidade
		if (hit) {
			if (hit.collider.gameObject.tag == "AddMediumVelocity") {
				scriptGreenBoat.AcelerarMedio ();


			}
			if (hit.collider.gameObject.tag == "AddHighVelocity") {
				scriptGreenBoat.AcelerarMuito ();

			}
			if (hit.collider.gameObject.tag == "RemoveMediumVelocity") {
				scriptGreenBoat.DesacelerarMedio ();

			}
			if (hit.collider.gameObject.tag == "RemoveHighVelocity") {
				scriptGreenBoat.DesacelerarMuito ();

			}

			if (hit.collider.gameObject.tag == "NoWind") {
			

			} 
		}
			
		//Disparando o Raio Barco VelaRED
		RaycastHit2D hitred = Physics2D.Raycast (southWind_Red.transform.position, Vector2.up, Mathf.Infinity, 1 << LayerMask.NameToLayer ("redsail"));
		//Verificando onde o Raio Colidiu e Adicionando/Removendo Velocidade
		if (hit) {
			if (hitred.collider.gameObject.tag == "AddMediumVelocity") {
				scriptRedBoat.AcelerarMedio ();

			}
			if (hitred.collider.gameObject.tag == "AddHighVelocity") {
				scriptRedBoat.AcelerarMuito ();

			}
			if (hitred.collider.gameObject.tag == "RemoveMediumVelocity") {
				scriptRedBoat.DesacelerarMedio ();

			}
			if (hitred.collider.gameObject.tag == "RemoveHighVelocity") {
				scriptRedBoat.DesacelerarMuito ();

			}
			if (hitred.collider.gameObject.tag == "NoWind") {
				
			}
		}

		if(!hit)
		{
			Debug.Log ("NADA");
		}
	}
		

			void VentoNorte()
	{
				
			

		//Disparando o Raio Barco VelaVERDE
		RaycastHit2D hit = Physics2D.Raycast (northWind_Green.transform.position, -Vector2.up, Mathf.Infinity, 1 << LayerMask.NameToLayer ("greensail"));
		//Verificando onde o Raio Colidiu e Adicionando/Removendo Velocidade
		if (hit) {
			if (hit.collider.gameObject.tag == "AddMediumVelocity") {
				scriptGreenBoat.AcelerarMedio ();


			}
			if (hit.collider.gameObject.tag == "AddHighVelocity") {
				scriptGreenBoat.AcelerarMuito ();

			}
			if (hit.collider.gameObject.tag == "RemoveMediumVelocity") {
				scriptGreenBoat.DesacelerarMedio ();

			}
			if (hit.collider.gameObject.tag == "RemoveHighVelocity") {
				scriptGreenBoat.DesacelerarMuito ();

			}

			if (hit.collider.gameObject.tag == "NoWind") {


			} 
		}

		//Disparando o Raio Barco VelaRED
		RaycastHit2D hitred = Physics2D.Raycast (northWind_Red.transform.position, -Vector2.up, Mathf.Infinity, 1 << LayerMask.NameToLayer ("redsail"));
		//Verificando onde o Raio Colidiu e Adicionando/Removendo Velocidade
		if (hit) {
			if (hitred.collider.gameObject.tag == "AddMediumVelocity") {
				scriptRedBoat.AcelerarMedio ();

			}
			if (hitred.collider.gameObject.tag == "AddHighVelocity") {
				scriptRedBoat.AcelerarMuito ();

			}
			if (hitred.collider.gameObject.tag == "RemoveMediumVelocity") {
				scriptRedBoat.DesacelerarMedio ();

			}
			if (hitred.collider.gameObject.tag == "RemoveHighVelocity") {
				scriptRedBoat.DesacelerarMuito ();

			}
			if (hitred.collider.gameObject.tag == "NoWind") {
				
			}
		}
		if(!hit)
		{
			Debug.Log ("NADA");
		}
	}

			void VentoLeste()
			{



				//Disparando o Raio Barco VelaVERDE
		RaycastHit2D hit = Physics2D.Raycast (eastWind_Green.transform.position, Vector2.left, Mathf.Infinity, 1 << LayerMask.NameToLayer ("greensail"));
				//Verificando onde o Raio Colidiu e Adicionando/Removendo Velocidade
				if (hit) {
					if (hit.collider.gameObject.tag == "AddMediumVelocity") {
						scriptGreenBoat.AcelerarMedio ();
						

					}
					if (hit.collider.gameObject.tag == "AddHighVelocity") {
						scriptGreenBoat.AcelerarMuito ();
						
					}
					if (hit.collider.gameObject.tag == "RemoveMediumVelocity") {
						scriptGreenBoat.DesacelerarMedio ();
						
					}
					if (hit.collider.gameObject.tag == "RemoveHighVelocity") {
						scriptGreenBoat.DesacelerarMuito ();
						
					}

					if (hit.collider.gameObject.tag == "NoWind") {

						
					} 
				}

				//Disparando o Raio Barco VelaRED
		RaycastHit2D hitred = Physics2D.Raycast (eastWind_Red.transform.position, Vector2.left, Mathf.Infinity, 1 << LayerMask.NameToLayer ("redsail"));
				//Verificando onde o Raio Colidiu e Adicionando/Removendo Velocidade
				if (hit) {
					if (hitred.collider.gameObject.tag == "AddMediumVelocity") {
						scriptRedBoat.AcelerarMedio ();
						

					}
					if (hitred.collider.gameObject.tag == "AddHighVelocity") {
						scriptRedBoat.AcelerarMuito ();
						
					}
					if (hitred.collider.gameObject.tag == "RemoveMediumVelocity") {
						scriptRedBoat.DesacelerarMedio ();
						
					}
					if (hitred.collider.gameObject.tag == "RemoveHighVelocity") {
						scriptRedBoat.DesacelerarMuito ();
						
					}
					if (hitred.collider.gameObject.tag == "NoWind") {
						
					}


		}
		if(!hit)
		{
			Debug.Log ("NADA");
		}
	}
	void VentoOeste()
	{



		//Disparando o Raio Barco VelaVERDE
		RaycastHit2D hit = Physics2D.Raycast (westWind_Green.transform.position, Vector2.right, Mathf.Infinity, 1 << LayerMask.NameToLayer ("greensail"));
		//Verificando onde o Raio Colidiu e Adicionando/Removendo Velocidade
		if (hit) {
			if (hit.collider.gameObject.tag == "AddMediumVelocity") {
				scriptGreenBoat.AcelerarMedio ();

			}
			if (hit.collider.gameObject.tag == "AddHighVelocity") {
				scriptGreenBoat.AcelerarMuito ();

			}
			if (hit.collider.gameObject.tag == "RemoveMediumVelocity") {
				scriptGreenBoat.DesacelerarMedio ();

			}
			if (hit.collider.gameObject.tag == "RemoveHighVelocity") {
				scriptGreenBoat.DesacelerarMuito ();

			}

			if (hit.collider.gameObject.tag == "NoWind") {


			} 
		}

		//Disparando o Raio Barco VelaRED
		RaycastHit2D hitred = Physics2D.Raycast (westWind_Red.transform.position, Vector2.right, Mathf.Infinity, 1 << LayerMask.NameToLayer ("redsail"));
		//Verificando onde o Raio Colidiu e Adicionando/Removendo Velocidade
		if (hit) {
			if (hitred.collider.gameObject.tag == "AddMediumVelocity") {
				scriptRedBoat.AcelerarMedio ();


			}
			if (hitred.collider.gameObject.tag == "AddHighVelocity") {
				scriptRedBoat.AcelerarMuito ();

			}
			if (hitred.collider.gameObject.tag == "RemoveMediumVelocity") {
				scriptRedBoat.DesacelerarMedio ();

			}
			if (hitred.collider.gameObject.tag == "RemoveHighVelocity") {
				scriptRedBoat.DesacelerarMuito ();

			}
			if (hitred.collider.gameObject.tag == "NoWind") {
				
			}


		}
		if(!hit)
		{
			Debug.Log ("NADA");
		}
	}

	}
    
