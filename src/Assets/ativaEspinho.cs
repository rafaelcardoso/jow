using UnityEngine;
using System.Collections;

public class ativaEspinho : MonoBehaviour {
	
	public GameObject BarraArmadilha;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		
		
	}
	
	void OnTriggerEnter(Collider c){
		
		BarraArmadilha = GameObject.Find("BarraArmadilha");
		espinho espinhoScript = BarraArmadilha.GetComponent<espinho>();
        espinhoScript.move = true;
		Debug.Log("ola");
		
		
		
	}
	
	
}
