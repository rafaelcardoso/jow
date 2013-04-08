using UnityEngine;
using System.Collections;

public class VoltarParaTelaInicial : MonoBehaviour {
	public GUISkin skin;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnGUI(){
		
		
		GUI.skin=this.skin;
	GUILayout.BeginArea(new Rect(0,0,Screen.width,Screen.height));
			
		
		
		
		GUILayout.BeginHorizontal();
		GUILayout.FlexibleSpace();
		
		if (GUILayout.Button("Desistir")){
		Application.LoadLevel("menu");			
		}
		GUILayout.FlexibleSpace();
		GUILayout.EndHorizontal();
		
		GUILayout.EndArea();
		
	}
}
