using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class c_wind : MonoBehaviour
{
    public AudioSource audio1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider coll){
        if(coll.gameObject.CompareTag("Player")){
            audio1.Play();
		}
	}
}
