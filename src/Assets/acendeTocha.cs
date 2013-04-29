using UnityEngine;
using System.Collections;

public class acendeTocha : MonoBehaviour {
	
	
	GameObject particula;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
		void OnTriggerEnter(Collider c) {
		
		
		
			
			particula = GameObject.Find("fogoTocha").gameObject;
			particula.GetComponent<ParticleSystem>().playOnAwake = true;
			particula.GetComponent<ParticleSystem>().Play();
			Debug.Log(this.name);
			
		
	}
}
