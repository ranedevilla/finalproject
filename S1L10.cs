using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class S1L10 : MonoBehaviour {
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
		string x = i.text.ToLower();
		if (x == "taxi driver" || x == "driver" || x == "cabbie") {
			SceneManager.LoadScene ("S1L10");
		} else {
			t.SetActive (true);
		}
	}
}
