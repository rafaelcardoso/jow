using UnityEngine;
using System.Collections;

public class kill : MonoBehaviour {
	
	public bool move = false;
	public GameObject player;
	// Use this for initialization
	void Start () {
		player = GameObject.Find("Corpo");
	}
	
	// Update is called once per frame
	void Update () {
		
		if(move){
			Debug.Log("mooove"+Time.deltaTime);
			Quaternion rot = transform.rotation;
			player.transform.rotation = rot * Quaternion.Euler(0, 90, 0); 

		}
		
	}
	
	void OnTriggerEnter(Collider c){
		
		if(c.gameObject.name.Equals("Corpo")){
			move = true;
			c.GetComponent<AudioSource>().Play();
			c.GetComponent<CharacterMotor>().canControl = false;
			Invoke("resetaCena", 2);
			
			
		}
		
			
	}
	
	void resetaCena(){
		
		Application.LoadLevel("gameover");
	}
}
