using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VentoTeste : MonoBehaviour
{
    [SerializeField] private GameObject northWind;
    [SerializeField] private GameObject southWind;
    [SerializeField] private GameObject eastWind;
    [SerializeField] private GameObject westWind;
    [SerializeField] private GameObject boat;
   




    // Use this for initialization
    void Start()
    {

    }

    void Update()
    {
        this.transform.position = boat.transform.position;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        
        
        RaycastHit2D hit = Physics2D.Raycast(southWind.transform.position, Vector2.up, Mathf.Infinity, 1 << LayerMask.NameToLayer("vela"));
        if (hit.collider.gameObject.tag == "AddMediumVelocity")
        {
            Debug.Log(hit.collider.name);

        }
    }
}