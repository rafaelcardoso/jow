using UnityEngine;
using System.Collections;

public class fim : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	
	
	void OnTriggerEnter(Collider c){
		Application.LoadLevel("menu");	
	}
}
