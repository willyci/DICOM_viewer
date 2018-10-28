﻿using HoloToolkit.Unity.InputModule.Utilities.Interactions;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Position : MonoBehaviour {

	Vector3 origPosition;
	Quaternion origRotation;
	Vector3 origScale;

	public GameObject skel;
	public GameObject lockText;

	// Use this for initialization
	void Start () {
		origPosition = gameObject.transform.localPosition;
		origRotation = gameObject.transform.localRotation;
		origScale = gameObject.transform.localScale;
	}

	public void Reset()
	{
		gameObject.transform.localPosition = origPosition;
		gameObject.transform.localRotation = origRotation;
		gameObject.transform.localScale = origScale;
	}

	public void Save() {
		origPosition = gameObject.transform.localPosition;
		origRotation = gameObject.transform.localRotation;
		origScale = gameObject.transform.localScale;
	}

	public void Lock() {
		if (lockText.GetComponent<Text>().text == "Lock")
		{
			lockText.GetComponent<Text>().text = "Unlock";
			skel.GetComponent<TwoHandManipulatable>().enabled = false;
		}
		else {
			lockText.GetComponent<Text>().text = "Lock";
			skel.GetComponent<TwoHandManipulatable>().enabled = true;
		}
		
	}

	// Update is called once per frame
	void Update () {
		
	}
}