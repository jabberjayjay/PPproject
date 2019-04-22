using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rock : Platform {

    // variables that are adjustable from within Unity Editor
    [SerializeField] Vector3 topPosition;
    [SerializeField] Vector3 bottomPosition;
    [SerializeField] float speed;

	// Use this for initialization
	void Start () {

        StartCoroutine(Move(bottomPosition));
		
	}
	
	// Update is called once per frame
	protected override void Update () {

        base.Update();
		
	}


    IEnumerator Move(Vector3 target)
    {
        while (Mathf.Abs((target - transform.localPosition).y) > 0.20f)
        {
            // ternary expression
            Vector3 direction = target.y == topPosition.y ? Vector3.up : Vector3.down;


           transform.localPosition += speed * direction * Time.deltaTime;

            yield return null;
        }

        print("Reached the target");

        yield return new WaitForSeconds(0.5f);

        Vector3 newTarget = target.y == topPosition.y ? bottomPosition : topPosition;

        // Ienumerator calls itself with unity StartCoroutine
        StartCoroutine(Move(newTarget));
    }
}



