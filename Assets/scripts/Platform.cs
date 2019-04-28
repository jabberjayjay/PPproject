using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour {

    [SerializeField] float objectSpeed = 1;
    [SerializeField] float resetPosition = 50;
    [SerializeField] float appearPosition = -60;
    int worldCnt = 0;
    private int yPlatform =1;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	protected virtual void Update () {

        Debug.Log(GameManager.instance.GameOver.ToString());
        if (!GameManager.instance.GameOver)
        {
            // every update frame platform moves 
            transform.Translate(Vector3.right * (objectSpeed * Time.deltaTime));

            if (transform.localPosition.x >= resetPosition)
            {


                Vector3 newPos = new Vector3(appearPosition, transform.position.y, transform.position.z);
                //if (worldCnt %3==0)
                //    newPos = new Vector3(appearPosition, yPlatform + worldCnt, transform.position.z);

                //worldCnt++;
                transform.position = newPos;
            }
        }
     
    }
}
