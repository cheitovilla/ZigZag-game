using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerCamera : MonoBehaviour {

    public GameObject player;
    private Vector3 posIni;

	// Use this for initialization
	void Start ()
    {
        posIni = this.gameObject.transform.position - player.transform.position;	
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.position = player.transform.position + posIni;
	}
}
