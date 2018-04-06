using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class S2Finish : MonoBehaviour {
	public InputField i;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void check()
	{
		string x = i.text.ToLower();

		if (x == "his pa" || x == "pa") {
			SceneManager.LoadScene ("W");
		} else {
			SceneManager.LoadScene ("L");
		}
	}
}
