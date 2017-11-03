using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DeleteAreaSc : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D other){
		Destroy( other.gameObject );
	}

}