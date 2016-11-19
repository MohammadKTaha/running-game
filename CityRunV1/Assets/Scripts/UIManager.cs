using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class UIManager : MonoBehaviour {

	public static UIManager instance;
	public Text highestScore;
	public Text currentScore;

	void Awake(){
		if(instance == null){
			instance = this;
		}
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
