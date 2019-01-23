using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeControl : MonoBehaviour {
    Rigidbody rb;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        int a = 1;
        
        rb.gameObject.SetActive(false);

        rb.gameObject.SetActive(true);

        float b = 3.2f;
    }
}
