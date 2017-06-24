using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public GameObject teste;
	public Camera mainCamera;

	[SerializeField] private GameObject boatGreen;
	[SerializeField] private GameObject boatRed;
	[SerializeField] float offsetCamDistance;
	float smooth = 0.5f;
	// Use this for initialization
	void Start () {




		mainCamera.enabled = true;


	}
	
	// Update is called once per frame
	void Update () {


		teste.gameObject.transform.position = 0.5f*(boatGreen.transform.position + boatRed.transform.position);
			{

			if (Vector2.Distance (boatGreen.transform.position, boatRed.transform.position) >30) 
			{
				mainCamera.fieldOfView = Mathf.Lerp(mainCamera.fieldOfView,150f,Time.deltaTime*smooth);
			} 

			if (Vector2.Distance (boatGreen.transform.position, boatRed.transform.position) >25 && Vector2.Distance (boatGreen.transform.position, boatRed.transform.position) < 30) 
			{
				mainCamera.fieldOfView = Mathf.Lerp(mainCamera.fieldOfView,135f,Time.deltaTime*smooth);
			} 

			if (Vector2.Distance (boatGreen.transform.position, boatRed.transform.position) >20 && Vector2.Distance (boatGreen.transform.position, boatRed.transform.position) < 25) 
		{
			mainCamera.fieldOfView = Mathf.Lerp(mainCamera.fieldOfView,130f,Time.deltaTime*smooth);
		} 
			if (Vector2.Distance (boatGreen.transform.position, boatRed.transform.position) > 15 && Vector2.Distance (boatGreen.transform.position, boatRed.transform.position) < 20) 
		{
			mainCamera.fieldOfView = Mathf.Lerp(mainCamera.fieldOfView,120,Time.deltaTime*smooth);
		} 
			if (Vector2.Distance (boatGreen.transform.position, boatRed.transform.position) > 10 && Vector2.Distance (boatGreen.transform.position, boatRed.transform.position) < 15) 
			{
				mainCamera.fieldOfView = Mathf.Lerp(mainCamera.fieldOfView,100f,Time.deltaTime*smooth);
			} 
			if (Vector2.Distance (boatGreen.transform.position, boatRed.transform.position) < 10 ) 
			{
				mainCamera.fieldOfView = Mathf.Lerp(mainCamera.fieldOfView,95f,Time.deltaTime*smooth);
			} 



		}
	}
			}

