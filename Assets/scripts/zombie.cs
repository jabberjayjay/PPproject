using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombie : MonoBehaviour {

    Animator anim;
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
		
	}
	
	// Update is called once per frame
	void Update () {

        // if (Input.GetMousButtonDown(0)) {
        //if(Time%2 != 1)

        int val = Random.Range(1, 10);
        if (Input.GetMouseButtonDown(0))
        {
            anim.Play("Jump");
        }
        
		
	}
}
