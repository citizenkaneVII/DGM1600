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

public class InputsStandard : MonoBehaviour {

	public static Action<KeyCode, Vector3> StandardInput;

	void Update () {
		StandardInput(KeyCode.UpArrow, Vector3.up);
		StandardInput(KeyCode.DownArrow, Vector3.down);
		StandardInput(KeyCode.LeftArrow, Vector3.forward);
		StandardInput(KeyCode.RightArrow, Vector3.back);
	}
}

/* Usually, the closing braces will be on a line just below the final line of the function, lined up with the
opening of the function.  This lets us know that there is no more code beyond that applies to this specific
function. 

On occasion, alternate forms of syntax can be used, but rarely is that needed.  The following is a list of objects
I created for a text based adventure.  I will admit that there are better ways of accomplishing what I did here.*/

// Update is called once per frame
	void Update () {
		print (myState);
		if (myState == States.cell) 				{state_cell ();} 
		else if (myState == States.sheets_0)		{state_sheets_0();} 
		else if (myState == States.lock_0) 			{state_lock_0();}
		else if (myState == States.mirror)			{state_mirror ();}
		else if (myState == States.cell_mirror)		{state_cell_mirror ();}
		else if (myState == States.sheets_1)		{state_sheets_1 ();}
		else if (myState == States.lock_1)			{state_lock_1 ();}
		else if (myState == States.freedom)			{state_freedom ();}
		else if (myState == States.corridor_0)		{state_corridor_0 ();}
		else if (myState == States.corridor_1)		{state_corridor_1 ();}	
		else if (myState == States.corridor_2)		{state_corridor_2 ();}	
		else if (myState == States.corridor_3)		{state_corridor_3 ();}	
		else if (myState == States.stairs_0)		{state_stairs_0 ();}	
	
		else if (myState == States.stairs_2)		{state_stairs_2 ();}	
		else if (myState == States.floor)			{state_floor ();}		
		else if (myState == States.closet_door)		{state_closet_door ();}	
		else if (myState == States.in_closet)		{state_in_closet ();}	
		else if (myState == States.courtyard)		{state_courtyard ();}	
		}

/*Instead of normal syntax, I opted to use something different to help me keep track of which statements led to
which states. */

/*Another important thing in syntax is the dot operator. */

public class InputsCharacter : InputsStandard {

	// Use this for initialization
	void Update () {
		StandardInput(KeyCode.LeftArrow, Vector3.left);
		StandardInput(KeyCode.RightArrow, Vector3.right);
	}

}

/* The dot operator is used when we call upon something in a directory.  In the example above, LeftArrow
is a part of KeyCode. In the example below, in order to get to x in the directory, we need to go through a path
of information.  Log is found in Debug.  The two are seperated by a period.  x is found in position which is found
in transform.
*/

using UnityEngine;
using System.Collections;

public class BasicSyntax : MonoBehaviour
{
    void Start ()
    {
        Debug.Log(transform.position.x);
        
        if(transform.position.y <= 5f)
        {
            Debug.Log ("I'm about to hit the ground!");
        }
    }
}



