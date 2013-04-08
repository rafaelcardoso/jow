using UnityEngine;
using System.Collections;

public class gameover : MonoBehaviour {
	public GUISkin skin;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	
	}
	void OnGUI(){
		
		
		GUI.skin=this.skin;
	
			
		GUILayout.BeginArea(new Rect(0,0,Screen.width+400,Screen.height-50));
		
		
		GUILayout.BeginVertical();
		GUILayout.FlexibleSpace();
		GUILayout.BeginHorizontal();
		GUILayout.FlexibleSpace();
		GUILayout.BeginVertical();
		GUILayout.FlexibleSpace();
		if (GUILayout.Button("Tentar Novamente")){
		Application.LoadLevel("projeto8");			
		}
		GUILayout.EndVertical();
		GUILayout.FlexibleSpace();
		GUILayout.EndHorizontal();
		GUILayout.FlexibleSpace();		
		GUILayout.EndVertical();
		
		GUILayout.EndArea();
		
	}
}
