using UnityEngine;
using System.Collections;

public class carController : MonoBehaviour {
	Rigidbody rb ;
	// Use this for initialization
	void Awake(){
		rb = GetComponent<Rigidbody>();
	}
	void Start () {
		rb.velocity= new Vector3(0f,0f,-10f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
