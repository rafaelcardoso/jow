using UnityEngine;
using System.Collections;

public class aumentar : MonoBehaviour {
	
	private float tamanho;
	public GameObject teto;
	public bool mover = false;
	

	// Use this for initialization
	void Start () {
		teto = GameObject.Find("teto");
	}
	
	// Update is called once per frame
	void Update () {
		
		
		if(mover){
			teto.transform.localScale = new Vector3(teto.transform.localScale.x,Time.fixedDeltaTime*tamanho,teto.transform.localScale.z);
			tamanho += 2;
		}
		
	}
	
	
	
	void OnTriggerEnter(Collider c){
		
		
		if(c.gameObject.name.Equals("Corpo")){
			
			mover = true;
			
			
		}
	}
}
