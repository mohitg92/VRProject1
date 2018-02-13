using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodFallScript : MonoBehaviour {

//	public GameObject food;
//	private Rigidbody rigidb;
//
//
//	// Use this for initialization
//	void Start () {
//		rigidb = GetComponent<Rigidbody> ();
//	}
//	
//	// Update is called once per frame
//	void Update () {
//		if (rigidb.tag == "foodfall") {
//			rigidb.useGravity = true;
//			rigidb.isKinematic = false;
//		}
//
//	}
	void start(){
		
	}


	private float fallSpeed = 0.03f;      //How fast should the object fall
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.down * fallSpeed * Time.deltaTime, Space.World);
	}

	void OntriggerEnter(Collider other){
		Destroy (gameObject);
	}


}
