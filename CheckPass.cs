using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CheckPass : MonoBehaviour {
	public InputField i;
	public GameObject t;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void check()
	{
		if (i.text == "RACHEL") {
			SceneManager.LoadScene ("S1L6");
		} else {
			t.SetActive (true);
		}
	}
}
