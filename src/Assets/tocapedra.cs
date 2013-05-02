using UnityEngine;
using System.Collections;

public class tocapedra : MonoBehaviour {

	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	//Função chamada cada atualização da física, que roda bem mais rápido que o Update comum
	
	
	
		void OnTriggerEnter(Collider c){
		
		if(c.gameObject.name.Equals("Corpo")){
			this.GetComponent<AudioSource>().Play();
			c.GetComponent<AudioSource>().Play();
			c.GetComponent<CharacterMotor>().canControl = false;
			Invoke("resetaCena",1);
			
		}
		
			
	}
	
	void resetaCena(){
		
		Application.LoadLevel("gameover");
	}
	
}

