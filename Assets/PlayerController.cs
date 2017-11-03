using UnityEngine;
using UnityEngine.UI;
using System.Collections;
// using inbe_da;

public class PlayerController : MonoBehaviour {

	public float bullerCreatePosGap;
	public GameObject purefab_bullet;

	public void Attack(){
		Debug.Log("攻撃しました");
		var bullet = Instantiate( purefab_bullet );
		bullet.gameObject.SetActive( true );
		bullet.transform.position = new Vector3( transform.position.x,
		                                         transform.position.y + bullerCreatePosGap,
												 transform.position.z );
	}

	public void Move( float x, float y ){
		transform.position = new Vector3( transform.position.x + x,
		                            	  transform.position.y + y,
										  transform.position.z );
		
	}

	public void Death(){
		Debug.Log("死にました");
	}




}