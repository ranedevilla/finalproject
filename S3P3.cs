using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class S3P3 : MonoBehaviour {
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
		if (x == "disappearance" || x == "gone" || x == "missing decoy" || x == "missing") {
			SceneManager.LoadScene ("S3P3");
		} else {
			t.SetActive (true);
		}
	}
}
