using UnityEngine;
using System.Collections;

public class tiro : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter(Collider c){
		
		if(c.gameObject.name.Equals("Corpo")){
			this.GetComponent<AudioSource>().Play();
			c.GetComponent<AudioSource>().Play();
			c.GetComponent<CharacterMotor>().canControl = false;
			Invoke("resetaCena", 2);
			
		}
		
			
	}
	
	void resetaCena(){
		
		Application.LoadLevel("gameover");
	}
}
