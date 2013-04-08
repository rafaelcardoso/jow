using UnityEngine;
using System.Collections;

public class creditos : MonoBehaviour {
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
			
		
		
		
		GUILayout.BeginVertical();
		GUILayout.FlexibleSpace();
		
		GUILayout.Label("Grupo do Projeto");
		GUILayout.Label("Adelson Barreto");
		GUILayout.Label("Marcelo Vanderley");
		GUILayout.Label("Rafael Cardoso");
		GUILayout.Label("Rogerio Nunes");
		GUILayout.Label("Thiago Siqueira");
		
		if (GUILayout.Button("Voltar")){
		Application.LoadLevel("menu");			
		}
		
		
		GUILayout.FlexibleSpace();
		GUILayout.EndVertical();
		
		GUILayout.EndArea();
		
	}
}
