using UnityEngine;
using System.Collections;

public class ativaBola : MonoBehaviour {
	
	GameObject seguraBola;
	GameObject pedra;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter(Collider c){
		 
		seguraBola = GameObject.Find("seguraBola");
		//seguraBola.transform.position = new Vector3(25.5003f, 58.83403f, 0.5591398f);
		DestroyObject(seguraBola);
		
		if(c.gameObject.name.Equals("Corpo")){
			pedra = GameObject.Find("Pedra");	
			pedra.GetComponent<AudioSource>().Play();
		}
	
		
	}

}
