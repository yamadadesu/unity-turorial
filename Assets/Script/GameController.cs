using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	public UnityEngine.UI.Text scoreLabel;
	public GameObject WinnerLabelObject;

	void Update () {
		int count = GameObject.FindGameObjectsWithTag ("item").Length;
		scoreLabel.text = count.ToString ();

		if (count == 0) {
			WinnerLabelObject.SetActive (true);
		}
	}
}
