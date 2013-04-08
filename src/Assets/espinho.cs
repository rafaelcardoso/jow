using UnityEngine;
using System.Collections;

public class espinho : MonoBehaviour {
	
	public float up = 5f;
	public float speed = 200;
	public bool move = false;
	
	Vector3 startPos;
	Vector3 endPos;
	float pos;
	
	// Use this for initialization
	void Start () {
		
		this.startPos = this.transform.position;
		this.endPos = startPos + Vector3.up * up;
		pos = 0;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
		if(this.move){
			
			pos = Mathf.Clamp01(pos + speed * Time.fixedDeltaTime); 
			
			Vector3 newPos = Vector3.Lerp(startPos, endPos, pos);
			
			Vector3 moveDirection = newPos - this.transform.position;
			this.transform.Translate(moveDirection);
			
		}
		
	
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
