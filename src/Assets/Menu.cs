using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {
	public GUISkin skin;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	
	}
	void OnGUI(){
		
		
		GUI.skin=this.skin;
	GUILayout.BeginArea(new Rect(-400,0,Screen.width,Screen.height));
			
		
		
		
		GUILayout.BeginVertical();
		GUILayout.FlexibleSpace();
		GUILayout.BeginHorizontal();
		GUILayout.FlexibleSpace();
		GUILayout.BeginVertical();
		
		
		if (GUILayout.Button("Iniciar Jogo")){
		Application.LoadLevel("projeto8");			
		}
		if (GUILayout.Button("Creditos")){
		Application.LoadLevel("creditos");			
		}
		if (GUILayout.Button("Sair do Jogo")){
		Application.Quit();		
			Application.CancelQuit();
		}
		
		GUILayout.EndVertical();
		GUILayout.FlexibleSpace();
		GUILayout.EndHorizontal();
		GUILayout.FlexibleSpace();		
		GUILayout.EndVertical();
		
		GUILayout.EndArea();
		
	}
}
