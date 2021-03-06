﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {

	private float PosX;
	private float PosZ;

	public GameObject town;

	// Use this for initialization
	void Start () {
		GameObject town = GameObject.FindGameObjectWithTag("town");
		Debug.Log (town);
	}
	
	// Update is called once per frame
	void Update () {

		PosX = this.gameObject.transform.position.x;
		PosZ = this.gameObject.transform.position.z;

		if (PosX == 5.0f&&PosZ==5.0f) {
			
			TownScript.Hp--;
			Destroy(this.gameObject);

		}else if(MapSet.stageArray[Mathf.FloorToInt(PosX),Mathf.FloorToInt(PosZ)]==1){
			Destroy (gameObject);
		}
		
	}
}
