using UnityEngine;
using System.Collections;

public class ativabala : MonoBehaviour {
	
	public GameObject porta;
	public GameObject balao;
	public GameObject MainCamera;
	public float amplitude = 3;
	public float speed = 2;
	Vector3 startPos;
	public float tremedor;
	public bool fechado = true;
	private bool movimento = false;
	private float subir = 0.001f;
	
	
	
	// Use this for initialization
	void Start () {
		
		MainCamera = GameObject.Find("Main Camera");
		
	
	}
	
	// Update is called once per frame
	void Update () {
		
//		if(tremedor>0){
//			MainCamera.transform.position = new Vector3(
//				1.9f+Mathf.Sin(Random.Range(-1f,-1.2f)*Time.time),
//				43.5201f+Mathf.Sin(Random.Range(-1f,-1.2f)*Time.time),
//				-57.18781f);
//			tremedor--;
//		}
//		
//		if(movimento){
//			Vector3 cima = new Vector3(0,subir,0);
//			porta.transform.Translate(cima);
//			subir += 0.01f;
//			if(porta.transform.position.y > 23f){
//				movimento = false;
//			}
//		}
			
	}
		
	
	void OnTriggerEnter(Collider c){
		
		if(fechado){
			balao = GameObject.Find("balao");
			balao.rigidbody.isKinematic = false;
			balao.rigidbody.WakeUp();
		
			tremedor  = 50;
			porta.GetComponent<AudioSource>().Play();
			movimento = true;
			fechado= false;
		}		
		
	}
		
}
