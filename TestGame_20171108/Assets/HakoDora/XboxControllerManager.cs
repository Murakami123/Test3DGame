using UnityEngine;
using UnityEngine.Events;


//------------------------------------------------------------------
// 入力
//------------------------------------------------------------------
[System.Serializable]
public class XboxControllerManager : MonoBehaviour {
	public void InputController( XBoxInputType inputType ){
		if( Input.GetKey    ( KeyCode.Joystick1Button0) ) inputType.buttonA_Class.ButtonA.Invoke();
		if( Input.GetKeyUp  ( KeyCode.Joystick1Button0) ) inputType.buttonA_Class.ButtonA_Up.Invoke();
		if( Input.GetKeyDown( KeyCode.Joystick1Button0) ) inputType.buttonA_Class.ButtonA_Down.Invoke();

		if( Input.GetKey    ( KeyCode.Joystick1Button1) ) inputType.buttonB_Class.ButtonB.Invoke();
		if( Input.GetKeyUp  ( KeyCode.Joystick1Button1) ) inputType.buttonB_Class.ButtonB_Up.Invoke();
		if( Input.GetKeyDown( KeyCode.Joystick1Button1) ) inputType.buttonB_Class.ButtonB_Down.Invoke();

		if( Input.GetKey    ( KeyCode.Joystick1Button2) ) inputType.buttonX_Class.ButtonX.Invoke();
		if( Input.GetKeyUp  ( KeyCode.Joystick1Button2) ) inputType.buttonX_Class.ButtonX_Up.Invoke();
		if( Input.GetKeyDown( KeyCode.Joystick1Button2) ) inputType.buttonX_Class.ButtonX_Down.Invoke();

		if( Input.GetKey    ( KeyCode.Joystick1Button3) ) inputType.buttonY_Class.ButtonY.Invoke();
		if( Input.GetKeyUp  ( KeyCode.Joystick1Button3) ) inputType.buttonY_Class.ButtonY_Up.Invoke();
		if( Input.GetKeyDown( KeyCode.Joystick1Button3) ) inputType.buttonY_Class.ButtonY_Down.Invoke();

		if( Input.GetKey    ( KeyCode.Joystick1Button4) ) inputType.buttonLB_Class.ButtonLB.Invoke();
		if( Input.GetKeyUp  ( KeyCode.Joystick1Button4) ) inputType.buttonLB_Class.ButtonLB_Up.Invoke();
		if( Input.GetKeyDown( KeyCode.Joystick1Button4) ) inputType.buttonLB_Class.ButtonLB_Down.Invoke();

		if( Input.GetKey    ( KeyCode.Joystick1Button5) ) inputType.buttonRB_Class.ButtonRB.Invoke();
		if( Input.GetKeyUp  ( KeyCode.Joystick1Button5) ) inputType.buttonRB_Class.ButtonRB_Up.Invoke();
		if( Input.GetKeyDown( KeyCode.Joystick1Button5) ) inputType.buttonRB_Class.ButtonRB_Down.Invoke();

		if( Input.GetKey    ( KeyCode.Joystick1Button6) ) inputType.buttonBACK_Class.ButtonBACK.Invoke();
		if( Input.GetKeyUp  ( KeyCode.Joystick1Button6) ) inputType.buttonBACK_Class.ButtonBACK_Up.Invoke();
		if( Input.GetKeyDown( KeyCode.Joystick1Button6) ) inputType.buttonBACK_Class.ButtonBACK_Down.Invoke();

		if( Input.GetKey    ( KeyCode.Joystick1Button7) ) inputType.buttonSTART_Class.ButtonSTART.Invoke();
		if( Input.GetKeyUp  ( KeyCode.Joystick1Button7) ) inputType.buttonSTART_Class.ButtonSTART_Up.Invoke();
		if( Input.GetKeyDown( KeyCode.Joystick1Button7) ) inputType.buttonSTART_Class.ButtonSTART_Down.Invoke();

		if( Input.GetKey    ( KeyCode.Joystick1Button8) ) inputType.stickLeft_Class.StickLeftPush.Invoke();
		if( Input.GetKeyUp  ( KeyCode.Joystick1Button8) ) inputType.stickLeft_Class.StickLeftPush_Up.Invoke();
		if( Input.GetKeyDown( KeyCode.Joystick1Button8) ) inputType.stickLeft_Class.StickLeftPush_Down.Invoke();

		if( Input.GetKey    ( KeyCode.Joystick1Button9) ) inputType.stickRight_Class.StickRightPush.Invoke();
		if( Input.GetKeyUp  ( KeyCode.Joystick1Button9) ) inputType.stickRight_Class.StickRightPush_Up.Invoke();
		if( Input.GetKeyDown( KeyCode.Joystick1Button9) ) inputType.stickRight_Class.StickRightPush_Down.Invoke();
		// LT,RTは設定しないと取得できない
		// if( Input.GetKey( KeyCode.Joystick1Button4) ) inputType.ButtonLT.Invoke();
		// if( Input.GetKey( KeyCode.Joystick1Button6) ) inputType.ButtonRT.Invoke();
		
		var HorizontalInput = Input.GetAxis("Horizontal");
		var VerticalInput   = Input.GetAxis("Vertical");
		if( HorizontalInput != 0.0f || VerticalInput != 0.0f ) inputType.stickLeft_Class.StickLeft.Invoke( HorizontalInput, VerticalInput );


		// // ここ要調整
		// var TrigerInput = Input.GetAxis("Triger");

		// var HoricontalKeyInput = Input.GetAxis("HorizontalKey");
		// if( HoricontalKeyInput != 0.0f ) inputType.StickRight.Invoke( HoricontalKeyInput, 2f );

		// var VerticalKeyInput = Input.GetAxis("VerticalKey");
		// if( VerticalKeyInput != 0.0f ) inputType.DirectionPad.Invoke( VerticalKeyInput, 2f );
	}
}

//------------------------------------------------------------------
// コントローラからのあらゆる入力を受け付けるコレクションクラス
//------------------------------------------------------------------
[System.Serializable]
public class XBoxInputType {

	public ButtonA_Class buttonA_Class;
	[System.Serializable] 
	public class ButtonA_Class{
		public UnityEvent ButtonA, ButtonA_Up,  ButtonA_Down; 
	} 

	public ButtonB_Class buttonB_Class;
	[System.Serializable] 
	public class ButtonB_Class{
		public UnityEvent ButtonB, ButtonB_Up,  ButtonB_Down; 
	} 

	public ButtonX_Class buttonX_Class;
	[System.Serializable] 
	public class ButtonX_Class{
		public UnityEvent ButtonX, ButtonX_Up,  ButtonX_Down; 
	} 

	public ButtonY_Class buttonY_Class;
	[System.Serializable] 
	public class ButtonY_Class{
		public UnityEvent ButtonY, ButtonY_Up,  ButtonY_Down; 
	} 

	public ButtonLT_Class buttonLT_Class;
	[System.Serializable] 
	public class ButtonLT_Class{
		public UnityEvent ButtonLT, ButtonLT_Up,  ButtonLT_Down; 
	} 

	public ButtonLB_Class buttonLB_Class;
	[System.Serializable] 
	public class ButtonLB_Class{
		public UnityEvent ButtonLB, ButtonLB_Up,  ButtonLB_Down; 
	} 

	public ButtonRT_Class buttonRT_Class;
	[System.Serializable] 
	public class ButtonRT_Class{
		public UnityEvent ButtonRT, ButtonRT_Up,  ButtonRT_Down; 
	} 

	public ButtonRB_Class buttonRB_Class;
	[System.Serializable] 
	public class ButtonRB_Class{
		public UnityEvent ButtonRB, ButtonRB_Up,  ButtonRB_Down; 
	} 

	public ButtonBACK_Class buttonBACK_Class;
	[System.Serializable] 
	public class ButtonBACK_Class{
		public UnityEvent ButtonBACK, ButtonBACK_Up,  ButtonBACK_Down; 
	} 

	public ButtonSTART_Class buttonSTART_Class;
	[System.Serializable] 
	public class ButtonSTART_Class{
		public UnityEvent ButtonSTART, ButtonSTART_Up,  ButtonSTART_Down; 
	} 

	public StickLeftPush_Class stickLeft_Class;
	[System.Serializable] 
	public class StickLeftPush_Class{
		public UnityEvent StickLeftPush, StickLeftPush_Up,  StickLeftPush_Down; 
		public UnityEvent_float_float StickLeft; // 左スティックの倒した x, y の量
	} 

	public StickRightPush_Class stickRight_Class;
	[System.Serializable] 
	public class StickRightPush_Class{
		public UnityEvent StickRightPush, StickRightPush_Up, StickRightPush_Down; 
		public UnityEvent_float_float StickRight; // 右スティックの倒した x, y の量
	} 

	// 引数を持つUnityEventは継承したものでないと使えないらしい。なので継承したクラス。
	// public UnityEvent_float_float DirectionPad; 
	[System.Serializable]
	public class UnityEvent_float_float : UnityEvent<float, float>{}
}

