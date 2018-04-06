using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class S3Start : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		StartCoroutine(LoadAfterAnim());
	}
	public IEnumerator LoadAfterAnim()
	{
		yield return new WaitForSeconds(10f);
		SceneManager.LoadScene("S3Intro");
	}
}
