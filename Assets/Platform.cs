using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour {

    [SerializeField] float objectSpeed = 1;
    private float resetPosition = 50;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        // every update frame platform moves 
        transform.Translate(Vector3.right * (objectSpeed * Time.deltaTime));

        if(transform.localPosition.x >= resetPosition)
        {
            Vector3 newPos = new Vector3(-60, transform.position.y, transform.position.z);

            transform.position = newPos;
        }


    }
}
