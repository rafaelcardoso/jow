using UnityEngine;
using System.Collections;

public class Elevador2 : MonoBehaviour {

	//amplitude e velocidade do movimento do elevator
	public float amplitude = 50f;
	public float speed = 10f;
	
	//posição inicial do elevador
	Vector3 startPos;
	
	//Função chamada no início do jogo antes de qualquer Update
	void Start () {
		//guarda a posição inicial do elevator
		this.startPos = this.transform.position;
	}
	
	
	void Update () {
		//é perigoso mudar a posição (transform.position) de um rigidbody na função Update quando ele estiver interagindo fisicamente com outro objeto
		
		//this.transform.position = startPos + new Vector3(0,1,0) * Mathf.Sin(Time.time * speed) * amplitude;
	}
	
	
	//Função chamada cada atualização da física, que roda bem mais rápido que o Update comum
	void FixedUpdate() {
		
		//na função Update pode-se utilizar Time.time e Time.deltaTime
		//na função FixedUpdate pode-se utilizar Time.fixedTime e Time.fixedDeltaTime
		
		//vetor apontando para cima
		Vector3 cima = new Vector3(2,0,0);
		
		//movimento controlado pela função seno
		Vector3 movement = cima * Mathf.Cos(Time.fixedTime * speed) * amplitude;
		
		//posição onde o elevator deve estar nesse momento
		Vector3 newPos = startPos + movement;
		
		//movimento que o elevator deve fazer
		Vector3 moveDirection = newPos - this.transform.position;
		
		//translada o objeto
		//em interações físicas é mais seguro que alterar diretamente o transform.position
		this.transform.Translate(moveDirection);
	}
}
