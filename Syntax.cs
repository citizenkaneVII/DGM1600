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
 and code will be written.  Example:*/


    // Update is called once per frame
    void Update () {
		if (toggle.isOn)
		{
			print("Play Game");
		} else {
			print("Can't Play.");
		}

    }

/* If we need more then a line to describe a line of code, we use /* .  This allows us to write as many words,
or even paragraphs about the functions that follow.   They always have a closing symbol, as seen at the end of this
paragraph.*/


/* Indentation is also important in syntax because it helps keep our code organized.*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandardMove : MonoBehaviour {

	// Use this for initialization
	public float speed = 3;
	CharacterController cc;
	void Start () {
		cc = GetComponent<CharacterController>();
		InputsCharacter.StandardInput += Move;
	}
	
	void Move (KeyCode _i, Vector3 _v) {
		if (Input.GetKey(_i))
		{
			cc.Move(_v*speed*Time.deltaTime);
		}
	}
}

/*In the example above, the first lines of code are at the left of the page.  When we have methods contained
within a function, we indent them to make it easier for others to know where the function begins and ends */

public class InputsCharacter : InputsStandard {

	// Use this for initialization
	void Update () {
		StandardInput(KeyCode.LeftArrow, Vector3.left);
		StandardInput(KeyCode.RightArrow, Vector3.right);
	}

}

/* Any functions of functions of functions will of course be treated the same. */