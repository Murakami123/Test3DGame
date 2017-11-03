using UnityEngine;
using UnityEngine.UI;
using System.Collections;

// namespace inbe_da{
	
	public class BulletSc : MonoBehaviour {

		public float speed; // 飛んでいくスピード
		public float dmage; // 与えるダメージ

	//------------------------------------------------------------------
	// 初期化
	//------------------------------------------------------------------
		public void Initialize( float _speed, int _dmage){
			speed = _speed;
			dmage = _dmage;
		}

	//------------------------------------------------------------------
	// 処理
	//------------------------------------------------------------------
		void Update(){
			transform.position = new Vector3( transform.position.x,
											transform.position.y + speed, 
											transform.position.z );
		}

		private void OnCollisionEnter2D(Collision2D other){
			Debug.Log("弾が何かとぶつかった");
			// ぶつかったオブジェクトのDmageメソッドを引き起こす
			try{
				other.gameObject.SendMessage( "Dmage", dmage );
			} catch ( System.Exception ){
			}
			Destroy( gameObject );
		}
	}
// }