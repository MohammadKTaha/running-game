using UnityEngine;
using System.Collections;

public class ScoreManager : MonoBehaviour {

	public int currentScore;
	public int highestScore;
	public ScoreManager instance;
	void Awake(){

		if(instance == null){
			instance = this;
		}


	}
	// Use this for initialization
	void Start () {
		currentScore = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void incrimintScore(){
		currentScore +=1; 
	}

	public void startCountingScore(){
		InvokeRepeating("incrimintScore",1,1);
	}

	public void stopScore(){
		CancelInvoke("startCountingScore");
		CancelInvoke("incrimintScore");
		PlayerPrefs.SetInt("currentScore",currentScore);

		if(PlayerPrefs.HasKey("highestScore")){
			highestScore = PlayerPrefs.GetInt("highestScore");
			if(highestScore > currentScore){

			}else{
				highestScore = currentScore;
				PlayerPrefs.SetInt("highestScore",highestScore);
			}
		}else{
			PlayerPrefs.SetInt("highestScore",currentScore);
		}

	}




}
