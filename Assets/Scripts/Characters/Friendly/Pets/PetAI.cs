using UnityEngine;
using System.Collections;

public class PetAI : MonoBehaviour {
	public Transform target;
	public int moveSpeed;
	public int roationSpeed;
	public int maxDistance; 
	private Transform myTransform;
	
	
	
	void Awake(){
		
		myTransform=transform;
			
	}
	
	// Use this for initialization
	void Start () {
		
	GameObject go = GameObject.FindGameObjectWithTag("Enemy"); 
		
		target=go.transform;
		
		maxDistance=2;
	}
	
	// Update is called once per frame
	void Update () {
	Debug.DrawLine (target.position,myTransform.position,Color.yellow);
	
		//look	at target
		
		myTransform.rotation=Quaternion.Slerp(myTransform.rotation, Quaternion.LookRotation(target.position - myTransform.position ),roationSpeed * Time.deltaTime );
		
		
		if(Vector3.Distance (target.position, myTransform.position )> maxDistance){
		//Move to target
	
		myTransform.position +=  myTransform.forward * moveSpeed *Time.deltaTime;
		}
		
		
	}
	
}


	
	
	
