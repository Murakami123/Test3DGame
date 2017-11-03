using UnityEngine;
using UnityEngine.Events;


//------------------------------------------------------------------
// 入力
//------------------------------------------------------------------
[System.Serializable]
public class XboxControllerManager : MonoBehaviour {
	public void InputController( XBoxInputType inputType ){
		if( Input.GetKey( KeyCode.Joystick1Button0) ) inputType.ButtonA.Invoke();
		if( Input.GetKey( KeyCode.Joystick1Button1) ) inputType.ButtonB.Invoke();
		if( Input.GetKey( KeyCode.Joystick1Button2) ) inputType.ButtonX.Invoke();
		if( Input.GetKey( KeyCode.Joystick1Button3) ) inputType.ButtonY.Invoke();
		if( Input.GetKey( KeyCode.Joystick1Button4) ) inputType.ButtonLB.Invoke();
		if( Input.GetKey( KeyCode.Joystick1Button5) ) inputType.ButtonRB.Invoke();
		if( Input.GetKey( KeyCode.Joystick1Button6) ) inputType.ButtonBACK.Invoke();
		if( Input.GetKey( KeyCode.Joystick1Button7) ) inputType.ButtonSTART.Invoke();
		if( Input.GetKey( KeyCode.Joystick1Button8) ) inputType.StickLeftPush.Invoke();
		if( Input.GetKey( KeyCode.Joystick1Button9) ) inputType.StickRightPush.Invoke();
		// LT,RTは設定しないと取得できない
		// if( Input.GetKey( KeyCode.Joystick1Button4) ) inputType.ButtonLT.Invoke();
		// if( Input.GetKey( KeyCode.Joystick1Button6) ) inputType.ButtonRT.Invoke();
		
		var HoricontalInput = Input.GetAxis("Horizontal");
		var VerticalInput   = Input.GetAxis("Vertical");
		if( HoricontalInput != 0.0f || VerticalInput != 0.0f ) inputType.StickLeft.Invoke( HoricontalInput, VerticalInput );

	}
}

//------------------------------------------------------------------
// コントローラからのあらゆる入力を受け付けるコレクションクラス
//------------------------------------------------------------------
[System.Serializable]
public class XBoxInputType {
	public UnityEvent ButtonA, ButtonB,  ButtonX,  ButtonY,
	ButtonLT, ButtonLB, ButtonRT, ButtonRB, ButtonBACK, ButtonSTART, 
	StickLeftPush, StickRightPush; 

	[System.Serializable]
	public class UnityEvent_float_float : UnityEvent<float, float>  {
		// 引数を持つUnityEventは継承したものでないと使えないらしい。
		// なので継承したクラス。
	}
	public UnityEvent_float_float StickLeft, StickRight, DirectionPad; 
}

