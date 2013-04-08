using UnityEngine;
using System.Collections;


public class correBola : MonoBehaviour {
	
	public float speed  = 1; // just increase speed value to go faster
	public Vector3 vSpeed;
	public GameObject seguraBola;
	public GameObject corpo;
	
	void Start () {

		this.corpo = GameObject.Find("Corpo");
		
	}
	
	// Update is called once per frame
	void Update () {
		
		this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, 0.09948632f);
		
		/*if(this.transform.position.x > 9){
			this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, 0f);
			vSpeed = speed * new Vector3(-3,0,0);
    		this.rigidbody.MovePosition(rigidbody.position + vSpeed * Time.deltaTime);	
		}*/
		
		
		
		
	}
	
	 void FixedUpdate () {
		if(this.transform.position.x>-24f){
			this.rigidbody.AddForce(Vector3.left * 4);	
		}else{
			this.rigidbody.Sleep();
		}
        
    }
	
	void OnCollisionEnter(Collision c) {
		
		
		if(c.gameObject.name.Equals("Corpo") ||c.gameObject.name.Equals("Braco")||c.gameObject.name.Equals("Revolver")||c.gameObject.name.Equals("Cano")||c.gameObject.name.Equals("Bracoparado")||c.gameObject.name.Equals("cabeca")||c.gameObject.name.Equals("Chapeu")||c.gameObject.name.Equals("Borda")||c.gameObject.name.Equals("nariz") ){
			
			
			corpo.GetComponent<AudioSource>().Play();
			corpo.GetComponent<CharacterMotor>().canControl = false;
			Invoke("resetaCena", 2);
			
		}
	}
	
	void resetaCena(){
		
		Application.LoadLevel("gameover");
	}
}
