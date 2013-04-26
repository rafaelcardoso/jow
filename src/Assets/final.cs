using UnityEngine;
using System.Collections;

public class final : MonoBehaviour {

	public Texture black;

	float alpha = 0f;
	bool end = false;
	
	// Use this for initialization
	void OnGUI () {
		if(end){
			Color color = GUI.color;
			color.a = this.alpha;
			GUI.color = color;
			GUI.DrawTexture(new Rect(0,0,Screen.width,Screen.height), black);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
		if(end){
			alpha = Mathf.Clamp01(alpha + 1 * Time.deltaTime);
			
			if(alpha == 1f){
				Application.LoadLevel("menu");
			}
		}
	
	
	
	}
	
	void OnTriggerEnter(Collider c){
		
			end = true;
			
		
		
	}
	
	
}
