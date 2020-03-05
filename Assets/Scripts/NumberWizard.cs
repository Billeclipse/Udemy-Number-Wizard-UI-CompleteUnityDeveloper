using UnityEngine;
using System.Collections;
using TMPro;

public class NumberWizard : MonoBehaviour {

	[SerializeField] int max;
	[SerializeField] int min;
	[SerializeField] TextMeshProUGUI titleText;
	[SerializeField] TextMeshProUGUI guessText;
	int guess;

	// Use this for initialization
	void Start () {
		titleText.text = "Think of a number between " + min.ToString() + " and " + max.ToString();
		Guessing();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow)){
			min = guess + 1;
			Guessing();
		}
		else if (Input.GetKeyDown(KeyCode.DownArrow)){
			max = guess - 1;
			Guessing();
		}
	}

	public void OnPressHigher()
	{
		min = guess + 1;
		Guessing();
	}

	public void OnPressLower()
	{
		max = guess - 1;
		Guessing();
	}

	void Guessing(){
		guess = Random.Range(min, max + 1);
		guessText.text = guess.ToString();
	}
}
