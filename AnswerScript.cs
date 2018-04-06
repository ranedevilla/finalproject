using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerScript : MonoBehaviour {
	public string AnswerLetter = "a";
	GameManager gameManager;
	// Use this for initialization
	void Start () {
		gameManager = FindObjectOfType<GameManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void PassAnswer()
	{
		gameManager.QuestionOne(AnswerLetter);
	}
}
