using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlatFormCreater : MonoBehaviour {
	private Vector3 lastPosition;
	public GameObject street0 ;
	public GameObject street1 ;
	public GameObject street2 ;
	public GameObject street3 ;
	public GameObject street4 ;
	public GameObject street;
	public GameObject coin;
	private float size; 

	//obisticals
	public GameObject roadBlocker;
	public GameObject cone;
	public GameObject garbageContainer;
	public GameObject trashCan;

	//vehicles
	public GameObject redCar;
	public GameObject taxi;
	public GameObject yellowCar;
	public GameObject transportVehicle;
	public GameObject boxCar;
	public GameObject bus;
	public GameObject baloon;
	// Use this for initialization

	Dictionary<int, GameObject> latestTheeObesticals;// the newest one is number 2 the older is number 1 the oldest is 0


	void Start () {
		//rbody = GetComponent<Rigidbody>();

		if(latestTheeObesticals == null){
			print("dictionary intilizing");
			latestTheeObesticals = new Dictionary<int, GameObject>();
			latestTheeObesticals.Add(0,null);
			latestTheeObesticals.Add(1,null);
			latestTheeObesticals.Add(2,null);
		}
		street = street0;
		lastPosition = street.transform.position;
		size =  street.transform.localScale.z;


			generateBlocksRandomly();
		
	}
	
	// Update is called once per frame
	void Update () {
		InvokeRepeating("generateBlocksRandomly",0.1f,5f);
	}

	public void generateBlocksRandomly(){
		Vector3 currentPosition = lastPosition;
		currentPosition.z += size;
		lastPosition = currentPosition;
		chooseRandomStreetType();
		Instantiate(street,lastPosition,Quaternion.identity);
	}

	void chooseRandomStreetType(){
		int tandomStreetOption = Random.Range(0,6);
		switch(tandomStreetOption){

			case 0: 
				street = street0;
				Invoke("generateCoins",0.01f);
				Invoke("generateStaticObisticale",0.01f);
			break;
			case 1:
				street = street1;
				Invoke("generateCoins",0.01f);
				Invoke("generateStaticObisticale",0.01f);
			break;
			case 2: 
				street = street2;
				Invoke("generateStaticObisticale",0.01f);
				Invoke("generateCoins",0.01f);
			break;
			case 3: 
				street = street3;
				Invoke("generateCoins",0.01f);
				Invoke("generateStaticObisticale",0.01f);
			break;
			case 4:
				street = street4;
				Invoke("generateCoins",0.01f);
			break;
			default:
				street = street0;
				Invoke("generateCoins",0.01f);
				Invoke("generateStaticObisticale",0.01f);
			break;
		}
	}

	void generateCoins(){

		int random = Random.Range(0,8);
		switch(random){
		case 0 : 
			for(int i=0;i<2;i++){
				Instantiate(coin,new Vector3(lastPosition.x,lastPosition.y, lastPosition.z+(Constants.COINS_OFFSIT)*i),Quaternion.identity);
			}
		break;
		case 1 :
			for(int i=0;i<10;i++){
				Instantiate(coin,new Vector3(lastPosition.x+2f,lastPosition.y, lastPosition.z+(Constants.COINS_OFFSIT)*i),Quaternion.identity);
				Instantiate(coin,new Vector3(lastPosition.x-2f,lastPosition.y, lastPosition.z+(Constants.COINS_OFFSIT)*i),Quaternion.identity);
				Instantiate(coin,new Vector3(lastPosition.x,lastPosition.y, lastPosition.z+(Constants.COINS_OFFSIT)*i),Quaternion.identity);
			} 
		break;
		case 2 :
			for(int i=0;i<10;i++){
				Instantiate(coin,new Vector3(lastPosition.x+2f,lastPosition.y, lastPosition.z+(Constants.COINS_OFFSIT)*i),Quaternion.identity);
			} 
		break;
		case 3 :
			for(int i=0;i<10;i++){
				Instantiate(coin,new Vector3(lastPosition.x-2f,lastPosition.y, lastPosition.z+(Constants.COINS_OFFSIT)*i),Quaternion.identity);
			} 
		break;

		case 4 :
			for(int i=0;i<10;i++){
				Instantiate(coin,new Vector3(lastPosition.x+2f,lastPosition.y, lastPosition.z+(Constants.COINS_OFFSIT)*i),Quaternion.identity);
				Instantiate(coin,new Vector3(lastPosition.x-2f,lastPosition.y, lastPosition.z+(Constants.COINS_OFFSIT)*i),Quaternion.identity);
			} 
		break;

		default:
		break;

		}

	}

	public void generateStaticObisticale(){
		int randomStaticCase = Random.Range(0,8);
		GameObject[] gameObjects= new GameObject[2];
		switch(randomStaticCase){
			case(0):

			break;

			case(1)://001
				
				gameObjects[0]=chooseStaticObistical();
				print("now reArranging - 1");
				rearrangeLatestTheeObisticals(gameObjects[0]);
				if(latestTheeObesticals.ContainsKey(1)){
					print("obsticale length"+(latestTheeObesticals[1] as GameObject ).transform.localScale.z);
					Instantiate(gameObjects[0],new Vector3(lastPosition.x+2f,lastPosition.y+1.6f, lastPosition.z+(latestTheeObesticals[1] as GameObject ).transform.localScale.z),Quaternion.identity);
				}else{
					Instantiate(gameObjects[0],new Vector3(lastPosition.x+2f,lastPosition.y+1.6f, lastPosition.z),Quaternion.identity);
				}
			break;

			case(2):
				gameObjects[0] = chooseStaticObistical();
				print("now reArranging - 2");
				rearrangeLatestTheeObisticals(gameObjects[0]);

				if(latestTheeObesticals.ContainsKey(1)){
					print("obsticale length"+(latestTheeObesticals[1] as GameObject ).transform.localScale.z);
					Instantiate(gameObjects[0],new Vector3(lastPosition.x+2f,lastPosition.y+1.6f, lastPosition.z+(latestTheeObesticals[1] as GameObject ).transform.localScale.z),Quaternion.identity);

				}else{
					Instantiate(gameObjects[0],new Vector3(lastPosition.x+2f,lastPosition.y+1.6f, lastPosition.z),Quaternion.identity);
				}
			break;

			case(3):
				gameObjects[0] = chooseStaticObistical();
				gameObjects[1] = chooseStaticObistical();
				print("now reArranging - 3");
				rearrangeLatestTheeObisticals(gameObjects[0]);
				if(latestTheeObesticals.ContainsKey(0)){
					print("obsticale length"+(latestTheeObesticals[1] as GameObject ).transform.localScale.z);
					Instantiate(gameObjects[0],new Vector3(lastPosition.x+2f,lastPosition.y+1.6f, lastPosition.z+(latestTheeObesticals[1] as GameObject ).transform.localScale.z),Quaternion.identity);
				}else{
					Instantiate(gameObjects[0],new Vector3(lastPosition.x+2f,lastPosition.y+1.6f, lastPosition.z),Quaternion.identity);
				}
			break;

			case(4):

			break;

			default:
			break;
			//Instantiate(chooseStaticObistical())
		}
	}



	public GameObject chooseStaticObistical(){

		int type = Random.Range(0,6);
		if(type <= 5){
		int vehicleType = Random.Range(0,6);

			switch(vehicleType){

				case(0):
					return bus;
				break;

				case(1):
					return transportVehicle;
				break;

				case(2):
					return taxi;
				break;

				case(3):
					return boxCar;
				break;

				case(4):
					return yellowCar;
				break;

				case(5):
					return redCar;
				break;

				default:
					return bus;
				break;

			}
			
			}else{//TODO
			return bus;
			}
			

		
	}

	private void rearrangeLatestTheeObisticals(GameObject newestObistical){
		print("Debug - 1");
		if(latestTheeObesticals[2] != null && latestTheeObesticals[1] != null ){
			GameObject temp2 = latestTheeObesticals[2];
			GameObject temp1 = latestTheeObesticals[1];

			latestTheeObesticals[0]=temp1;
			latestTheeObesticals[1] =temp2;
			latestTheeObesticals[2]=newestObistical;
		}else if(latestTheeObesticals[2] != null && latestTheeObesticals[1] == null ){
			GameObject temp2 = latestTheeObesticals[2];
			latestTheeObesticals[1] =temp2;
			latestTheeObesticals[2] = newestObistical;
		}else if(latestTheeObesticals[2] == null && latestTheeObesticals[1] == null ){

			print("adding ----> "+newestObistical.tag);
			latestTheeObesticals[2] = newestObistical;


		}
	}
}
