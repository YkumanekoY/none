﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FadeController : MonoBehaviour {

	public static int scene = 0;
	
	float fadeSpeed = 0.02f;        //透明度が変わるスピードを管理
	float red, green, blue, alfa;   //パネルの色、不透明度を管理

	public static bool isFadeOut = false;  //フェードアウト処理の開始、完了を管理するフラグ
	public static bool isFadeIn = false;

	Image fadeImage;                //透明度を変更するパネルのイメージ

	void Start () {
		fadeImage = GetComponent<Image> ();
		red = fadeImage.color.r;
		green = fadeImage.color.g;
		blue = fadeImage.color.b;
		alfa = fadeImage.color.a;
	}

	void Update () {
		if (isFadeOut) {
			StartFadeOut (scene);
		} else if (isFadeIn) {
			StartFadeIn ();
		}
	}

	public void StartFadeOut(int d){
		fadeImage.enabled = true;  // a)パネルの表示をオンにする
		alfa += fadeSpeed;         // b)不透明度を徐々にあげる
		SetAlpha ();               // c)変更した透明度をパネルに反映する

		if(alfa >= 1){             // d)完全に不透明になったら処理を抜ける
			isFadeOut = false;

			if (d == 1) 
				SceneManager.LoadScene("PlayerSerect");
			if (d == 4)
				SceneManager.LoadScene("GameOver");
		}
	}

	public void StartFadeIn(){
		fadeImage.enabled = true;  // a)パネルの表示をオンにする
		alfa -= fadeSpeed;         // b)不透明度を徐々に下げる
		SetAlpha (); 				// c)変更した透明度をパネルに反映する
		//Debug.Log(alfa);
		if(alfa <= 0){             // d)完全に透明になったら処理を抜ける
			isFadeIn = false;
		}
	}

	void SetAlpha(){
		fadeImage.color = new Color(red, green, blue, alfa);
	}
}
