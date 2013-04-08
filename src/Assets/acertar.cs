using UnityEngine;
using System.Collections;

public class acertar : MonoBehaviour {
	
	public GameObject jogador;

	// Use this for initialization
	
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter(Collider c){
		
		if(c.gameObject.name.Equals("Corpo")){
			
			c.GetComponent<AudioSource>().Play();
			c.GetComponent<CharacterMotor>().canControl = false;
			Invoke("resetaCena", 2);
			
		}
		
			
	}
	
	void resetaCena(){
		
		Application.LoadLevel("gameover");
	}
}
