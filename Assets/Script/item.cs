using System.Collections;
using UnityEngine;

public class item : MonoBehaviour {

	void OnTriggerEnter(Collider hit){
		if(hit.CompareTag("Player")) {
			Destroy(gameObject);
		}
	}

}
