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
	
	}
}
