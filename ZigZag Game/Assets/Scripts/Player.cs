using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float force;
    public bool changeDir;
    private Vector3 dir;
    private Rigidbody rb;
    // Use this for initialization
    void Start() {
        changeDir = false;
        rb = GetComponent<Rigidbody>();
        dir = new Vector3(0, 0, 0);

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -1)
        {
            this.transform.position = new Vector3(4.5f, 0.65f, 4.25f);
            rb.Sleep();
            dir = new Vector3(0, 0, 0);
        }

        if (Input.GetMouseButtonDown(0))
        {
            rb.Sleep();
            if (changeDir)
            {
                dir = new Vector3(0, 0, -1);
                changeDir = false;
            }
            else
            {
                dir = new Vector3(-1, 0, 0);
                changeDir = true;
            }
        }	
	}

    private void FixedUpdate()
    {
        rb.MovePosition(transform.position + dir * Time.deltaTime * force);
    }
}
