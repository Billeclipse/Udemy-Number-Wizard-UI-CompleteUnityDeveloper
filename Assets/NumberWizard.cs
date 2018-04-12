using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {
	
	int max ,min, guess;
	public int MAXGUESSESALLOWED = 5;
	public Text text;

	// Use this for initialization
	void Start () {
		StartGame();
	}
		
	void StartGame(){
		max = 1000;
		min = 1;
		guess= 500;
		NextGuess();
	}
	
	public void GuessHigher(){
		min = guess;
		NextGuess();	
	}
	
	public void GuessLower(){
		max = guess;
		NextGuess();
	}
	
	void NextGuess(){
		guess = Random.Range(min,max+1);
		text.text = guess.ToString();
		MAXGUESSESALLOWED--;
		if(MAXGUESSESALLOWED <= 0){
			Application.LoadLevel("Win");		
		}
	}
}
