using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Enemy : MonoBehaviour {

	public int hp = 1;    // hp
	public float speed = 1; // 移動スピード

//------------------------------------------------------------------
// 初期化
//------------------------------------------------------------------
	public void Initialize(){

	}

//------------------------------------------------------------------
// 処理
//------------------------------------------------------------------
	void Update(){
		transform.position = new Vector3( transform.position.x,
		                                  transform.position.y - speed, 
										  transform.position.z );
	}	

	public void Dmage( int dmage ){
		hp -= 1; 
		if( hp <= 0 ) Death(); // ダメージの結果によっては死ぬ 
	}

	public void Death(){
		Debug.Log("破壊されました");
		Destroy( gameObject );
		SceneManager_Battle.Instance.CheckClear();
	}

}