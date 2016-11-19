using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	Rigidbody rb ;
	bool isStarted;
	bool isGameOver;
	float playerSpeed;
	float jumpPower;

	void Awake(){
		rb = GetComponent<Rigidbody>();
		playerSpeed = 10f;
		isStarted = true;
		isGameOver = false;
		jumpPower = 10;
		print("jumpPower = "+jumpPower);
	}


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		// add all the actions after the game was started by tap
		if(isStarted && !isGameOver){ 
			rb.velocity= new Vector3(0,0,playerSpeed);
		//add Jump
		if(Input.GetKeyDown(KeyCode.UpArrow)){
			rb.AddForce(new Vector3(rb.transform.position.x,jumpPower,rb.transform.position.z+2f));
		}

		if(Input.GetKeyDown(KeyCode.RightArrow)){
			print("Right desplacement");
			lerpRight();
		}

		if(Input.GetKeyDown(KeyCode.LeftArrow)){
			print("left desplacement");
			lerpLeft();
		}

		}

		if(Input.GetMouseButtonDown(0) && !isGameOver){
			isStarted = true;
		}


	}

	void lerpRight(){
		while(rb.transform.position.x < 2 ){
			Vector3 myPosition = rb.transform.position;
			Vector3 rightPos = new Vector3(rb.transform.position.x+2f, rb.transform.position.y,rb.transform.position.z);
			rb.transform.position = Vector3.Lerp(myPosition,rightPos,Time.deltaTime);

		}
	}

	void lerpLeft(){
		while(rb.transform.position.x > -2 ){
			Vector3 myPosition = rb.transform.position;
			Vector3 leftPos = new Vector3(rb.transform.position.x-2f, rb.transform.position.y,rb.transform.position.z);
			rb.transform.position = Vector3.Lerp(myPosition,leftPos,Time.deltaTime);
		}
	}

}
