﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Next : MonoBehaviour {
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		StartCoroutine(LoadAfterAnim());
	}

	public IEnumerator LoadAfterAnim()
	{
		yield return new WaitForSeconds(2f);
		SceneManager.LoadScene("S1L1");
	}
}
