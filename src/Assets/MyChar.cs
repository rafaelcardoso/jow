using UnityEngine;
using System.Collections;

//controla um personagem com os componentes CharacterController e CharacterMotor
public class MyChar : MonoBehaviour {
	
	//número de moedas coletadas
	public int coins = 0;
	public GameObject corpo;
	
	//variável que guarda o componente CharacterMotor existente nesse objeto
	CharacterMotor motor;
	
	//função chamada no início do jogo antes de qualquer Update
	void Start () {
		//preenche a variável com o CharacterMotor
		this.motor = this.GetComponent<CharacterMotor>();
		this.corpo = GameObject.Find("Corpo");
	}
	
	//função chamada a cada frames
	void Update () {
		
		this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, 0f);
		//a função Input.GetAxis(...) funciona ao mesmo tempo para setas do teclado, WASD, joysticks e volantes
		
		//movimento horizontal
		//retorna -1 se o jogador pressionar pra esquerda
		//retorna +1 se o jogador pressionar pra direita
		//retorna  0 se o jogador não pressionar nada
		float h = Input.GetAxis("Horizontal");
		if(h == -1){
	
			corpo.transform.rotation = new Quaternion(0f,-180f,0f,0f);
		
			
		}else if(h == 1){
			corpo.transform.rotation = new Quaternion(0f,0f,0f,0f);
			
		}
		
		//movimento vertical
		//retorna -1 se o jogador pressionar pra baixo
		//retorna +1 se o jogador pressionar pra cima
		//retorna  0 se o jogador não pressionar nada
		float v = Input.GetAxis("Vertical");
		
		//passa o movimento horizontal (esquerda/direita) para a componente X do movimento do CharacterMotor
		motor.inputMoveDirection = new Vector3(h,0,0);
		
		//se o eixo vertical é positivo (jogador está pressionando para cima) ativa (ou não) o pulo do CharacterMotor
		if(v > 0){
			motor.inputJump = true;
		}else{
			motor.inputJump = false;
		}
		
	}
	
	//Função chamada a cada frame para desenhar elementos 2D na tela
	void OnGUI(){
		//desenha 2 labels, um abaixo do outro
		GUI.Label(new Rect(5,5,100,20),"Moedas:"+coins);
		GUI.Label(new Rect(5,25,100,20),"Life: 50%");
	}
	
	//essa função é chamada quando há colisão envolvendo collider não trigger
	void OnCollisionEnter(Collision collision){
		
	}
	
	//essa função é chamda quando há colisão envolvendo collider trigger
	void OnTriggerEnter(Collider other){
		//se eu colidi com uma moeda
		if(other.name.Equals("Coin")){
			//destroi o gameObject da moeda
			Destroy(other.gameObject);
			//incrementa minha contagem de moedas
			this.coins++;
		}
	}
	
}
