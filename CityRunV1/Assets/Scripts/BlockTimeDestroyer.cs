using UnityEngine;
using System.Collections;

public class BlockTimeDestroyer : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerExit(Collider other) {
        // Destroy everything that leaves the trigger
         if(other.tag=="Player"){
			Destroy(transform.parent.gameObject,1f);
        }

    }
}
