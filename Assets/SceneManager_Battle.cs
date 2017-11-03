using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SceneManager_Battle : MonoBehaviour {

//------------------------------------------------------------------
// シングルトン
//------------------------------------------------------------------
	public static SceneManager_Battle Instance;
	private SceneManager_Battle(){
		if( Instance == null ) Instance = this;
	}

//------------------------------------------------------------------
// 初期化
//------------------------------------------------------------------
	public void Initialize(){

	}

	[SerializeField] XboxControllerManager controlManager;
	[SerializeField] XBoxInputType inputType;
	void Update(){
		controlManager.InputController( inputType );	
	}

//------------------------------------------------------------------
// ゲームクリア処理
//------------------------------------------------------------------
	[SerializeField] GameObject clearText;
	public void CheckClear(){
		StartCoroutine(CheckClearCo());
	} 

	IEnumerator CheckClearCo(){
		yield return new WaitForSeconds( 0.5f );
		GameObject[] enemyUnits = GameObject.FindGameObjectsWithTag("Enemy");
		if (enemyUnits.Length == 0) {
			Debug.Log("GameClear!!");
			clearText.SetActive( true );
		} else {
			Debug.Log("未クリア。敵の数：" + (enemyUnits.Length).ToString() );			
		}
	}

//------------------------------------------------------------------
// ボタン
//------------------------------------------------------------------
	public void OnOKTouch(){

	}

}