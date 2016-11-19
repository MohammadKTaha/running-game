using UnityEngine;
using System.Collections;

public class BaloonController : MonoBehaviour {
	private float xDirictionSpeed;
	private float zDirictionSpeed;
	GameObject gObject;
	Rigidbody rBody ;
	void Awake(){
		zDirictionSpeed = 10f;
		xDirictionSpeed = 0f;
		gObject = GetComponent<GameObject>();
		rBody = GetComponent<Rigidbody>();

	}
	// Use this for initialization
	void Start () {
		rBody.velocity = new Vector3(xDirictionSpeed,0,zDirictionSpeed);
	}
	
	// Update is called once per frame
	void Update () {
	
	}


}
