﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapCreat : MonoBehaviour {

	public GameObject cube;

	int input_tate=9;	//マップ縦
	int input_yoko=9;	//マップ横	フィールドで入れられたらいいね

	float xPos=0;
	float yPos=0;

	int[,] array_MapList = new int[9,9];	//マップ配列

	// Use this for initialization
	void Start () {
		
		for (int i = 0; i<input_yoko; i++) {
			for (int j=0; j<input_tate; j++) {
				GameObject.Instantiate (cube, new Vector2 (xPos, yPos), new Quaternion ());
				yPos += cube.transform.localScale.y;
			}
			yPos = 0;
			xPos += cube.transform.localScale.x;
		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
