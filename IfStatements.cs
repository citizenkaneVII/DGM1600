/*Here is another example of else if statements working in a program. */



using UnityEngine;
using System.Collections;

public class NumberWizards : MonoBehaviour {

	// Use this for initialization
	int max;
	int min;
	int guess;
	
	
	void Start () {
		StartGame ();
		
	}
	
	void StartGame (){
		max = 1000;
		min = 1;
		guess = 500;
		max = max + 1;
		
		print ("========================");
		print ("Welcome to Number Wizard");
		print ("Pick a number in your head, but don't tell me!");
		
		print ("The highest number you can pick is 1000");
		print ("The lowest number you can pick is " + min);
		
		print ("Is the number higher or lower than " + guess + "?");
		print ("Up = higher, Down = lower, Enter = equal");
	}
	
	
	
	// Update is called once per frame
	void Update (){ 
		if(Input.GetKeyDown(KeyCode.UpArrow)) {
			print("Up arrow pressed");
			min = guess;
			NextGuess();
		}else if(Input.GetKeyDown(KeyCode.DownArrow)) {
				print("Down arrow pressed");
				max = guess;
				NextGuess ();
		}else if(Input.GetKeyDown(KeyCode.Return)) {
			print("I won!");
			StartGame ();
			
		}
	}
	
	void NextGuess(){
		guess = (max + min) /2;
		print ("Higher or lower than " + guess);
	}
}