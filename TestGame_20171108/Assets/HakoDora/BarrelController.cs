using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BarrelController : MonoBehaviour {

	private Rigidbody rigidbody;
	public float moveSpeed, rollSpeed, jumpSpeed;

	void Start(){
		rigidbody = GetComponent<Rigidbody>();
	}


//------------------------------------------------------------------
// 処理
//------------------------------------------------------------------
	private float stickLeftX, stickLeftY;
	private bool  isBtnA_Pushed = false;
	private void Update(){

		// 暫定横移動
		var velX = ( Mathf.Abs( stickLeftX ) > 0.3f ) ? stickLeftX * moveSpeed : rigidbody.velocity.x;
		var velY = ( isBtnA_Pushed )                  ? jumpSpeed              : rigidbody.velocity.y;
		if( isBtnA_Pushed ) isBtnA_Pushed = false;
		rigidbody.velocity = new Vector3( velX, velY, 0f );

		// ドラム缶らしく斜めに傾くやつ
		transform.rotation = Quaternion.AngleAxis( -126f, new Vector3( 1f, 0f, 0f ));

		// 横回転は後回し
		// transform.Rotate( new Vector3( -126f, 0f, x * rollSpeed ));
	}

	public void OnStickLeft( float x, float y ){
		stickLeftX = x;
		stickLeftY = y;
	}

	public void OnBtnA_Push(){
		isBtnA_Pushed = true;
	}


	public void Open(){

	}

	public void Close(){
		
	}

}