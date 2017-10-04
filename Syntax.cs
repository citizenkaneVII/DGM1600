//Syntax Assignment and conventions

/*When coding, syntax is important because it helps everyone involved be able to read and understand the code.
With out this, programing because difficult to do. */

/*First off are comments.  Comments are small descriptions of what the following block of code does.

And example of this is: */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RunGame : MonoBehaviour {

	public Toggle toggle;
    public float health = 100;

    // Update is called once per frame
    void Update () {
		if (toggle.isOn)
		{
			print("Play Game");
		} else {
			print("Can't Play.");
		}

		health -= 0.01f;
	}
}

/* the text in green including the words you are currently reading right now are comments.  They are seperate from
the code, and help us to know what the code does.

Two ways of declaring code is (//) and (/*)
 
 
 The first // will reserve one line for comments.  Upon pressing the enter/return key, the line will end
 and code will be written.*/

