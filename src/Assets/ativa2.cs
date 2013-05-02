using UnityEngine;
using System.Collections;

public class ativa2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter(Collider c){
		if(c.gameObject.name.Equals("balao")){
			c.gameObject.rigidbody.transform.position = new Vector3(17.07464f,42.61946f,-1.34462f);
			c.gameObject.rigidbody.velocity = new Vector3(0,-9,0);
		}
	}
}
