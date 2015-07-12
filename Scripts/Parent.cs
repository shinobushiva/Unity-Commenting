﻿using UnityEngine;
using System.Collections;

public class Parent : MonoBehaviour {

	public bool Move = false;
	public bool Destroyo = false;
	public bool Comment = false;
	public bool Rotater = false;
	public bool Scaler = false;
    public Sprite MySp;

	public void SetInActive(){
		gameObject.SetActive (false);
		if(GetComponent<NetworkView>())
            GetComponent<NetworkView>().RPC("SetInActiveRPC", RPCMode.Others);
		}

	[RPC]
	void SetInActiveRPC(){
		gameObject.SetActive (false);
	}
}
