using UnityEngine;
using System.Collections;

public class morrer : MonoBehaviour {
	
	public bool tremer;
	
	public AudioSource audio;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		audio.Play();
		
		//this.transform.position = new Vector3(Mathf.Sin(Random.Range(0f,0.2f)*Time.time),Mathf.Sin(Random.Range(0f,0.2f)*Time.time),0f);
	
	}
}
