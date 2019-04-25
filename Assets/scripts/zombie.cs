using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombie : MonoBehaviour {

    private Animator anim;
    private Rigidbody rigidbody;

    private bool jump = false;
    // Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        rigidbody = GetComponent<Rigidbody>();
		
	}
	
	// Update is called once per frame
	void Update () {

        // if (Input.GetMousButtonDown(0)) {
        //if(Time%2 != 1)

        //int val = Random.Range(1, 10);
        //if (Input.GetMouseButtonDown(0))
        //{
        //    anim.Play("Jump");
        //}

        anim.Play("Idle");
        anim.Play("Idle");
        anim.Play("Idle");
        anim.Play("Jump");
        jump = true;
        transform.position = new Vector3(transform.position.x, transform.position.y, 10);
       

        if (transform.position.x < -4)
        {
            transform.position = new Vector3(-4, transform.position.y, 10);
        }

        if (transform.position.x > 19)
        {
            transform.position = new Vector3(19, transform.position.y, 10);
        }

    }


    void FixedUpdate()
    {

        if(jump == true)
        {
            jump = false;
        }
    }
}
