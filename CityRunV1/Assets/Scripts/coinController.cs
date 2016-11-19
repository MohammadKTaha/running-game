using UnityEngine;
using System.Collections;

public class coinController : MonoBehaviour {
	public AudioSource audioSource;
	static bool isCoinTaken;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	if(isCoinTaken){
			audioSource.PlayOneShot(audioSource.clip);
			isCoinTaken = false;
	}

	}

	void OnTriggerEnter(Collider other) {
	if(other.tag == "Player")
		isCoinTaken = true;
        Destroy(this.gameObject);

		if(this.gameObject != null){
			Destroy(this.gameObject, 5f);
		}
    }
}
