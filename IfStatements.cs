using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*"If statements" inform our program what to do based on what conditions we're presented with.
 */

public class ifStatement : MonoBehaviour {

	public Text input;

	public bool canPlayGame = false;
	public string password = "G@am3Pl@y";

	void Update () {
		if(input.text == password) {
			print("You know the password.");
			canPlayGame = true;
		} 
        else {
			print("The password is incorrect.");
		}

		if(canPlayGame) {
			print("Playing Game");
		}	
        else {
			print("Can't Play Yet, Enter a Correct Password.");
		}
	}
}