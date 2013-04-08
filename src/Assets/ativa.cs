using UnityEngine;
using System.Collections;

public class ativa : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter(Collider c){
		if(c.gameObject.name.Equals("bala")){
			c.gameObject.rigidbody.transform.position = new Vector3(20.8507f,16.28969f,1.132459f);
			c.gameObject.rigidbody.velocity = new Vector3(0,-5,0);
		}
	}
}
