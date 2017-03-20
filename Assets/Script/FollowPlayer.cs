﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {

	public Transform target;  //（プロパティセットされた）ターゲットへの参照
	private Vector3 offset;   // 相対座標

	// Use this for initialization
	void Start () {
		// 自分自身とtargetとの相対距離を求める
		offset = GetComponent<Transform> ().position - target.position;
	}

	// Update is called once per frame
	void Update () {
		// 自分の座標にtargetの座標を代入する
		GetComponent<Transform> ().position = target.position + offset;	
	}
}
