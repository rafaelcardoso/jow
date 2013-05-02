using UnityEngine;
using System.Collections;

public class detectaPorta : MonoBehaviour {


	void Start () {
	
	}
	
	
	void Update () {
		
	}
	
	
	
	void FixedUpdate() {
		
		
	}
	
	
	void OnTriggerEnter(Collider c){
		
		Debug.Log("stone trigger with: " + c.name);
		
		if(c.gameObject.name.Equals("Corpo")){
			this.GetComponent<AudioSource>().Play();
		//c.GetComponent<AudioSource>().Play();
			c.GetComponent<CharacterMotor>().canControl = false;
			Invoke("resetaCena", 2);
			
		}
		
			
	}
	
	void resetaCena(){
		
		Application.LoadLevel("gameover");
	}
	
}

