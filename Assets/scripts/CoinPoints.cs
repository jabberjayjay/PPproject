using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPoints : MonoBehaviour {


    
    [SerializeField] private AudioClip sfxCoin;


    private AudioSource audioSource;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnCollisionEnter(Collision collision)
    {

   

        if(collision.transform.tag == "Player")
        {
            audioSource = GetComponent<AudioSource>();



            audioSource.PlayOneShot(sfxCoin);

            KeepScore.Score += 100;
            Debug.Log("Coin hit");
           

            Destroy(gameObject);

            
            
        }
    }
}
