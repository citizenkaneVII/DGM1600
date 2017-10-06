/*So you know how we have variables? */

int x = 12;

//Let's say we have a bunch of those.  They're all the same type, but there's alot of them.

string grades = "5";
string grades = "7";
string grades = "3";

//Instead of dealing with making a bunch of these, we can make an array.

string[] grades = {"5", "7", "3"};

//An array is a fixed number of elements or a particular type.  All of these can have different values.

public Color[] colors = {Color.red, Color.blue, Color.black, Color.yellow};

//When declairing an array, it's important to define wether it's public or private.

public int[] hight = {3, 4, 4, 7, 2};

//Public will allow you to see the array in the inspector.
//The following is an array that can be adjusted in the inspector.

public int[] myIntArray = new int [5];
void start (){
    myIntArray[0] = 63;
    myIntArray[1] = 72;
    myIntArray[2] = 81;
    myIntArray[3] = 90;
    myIntArray[4] = 99;
}

/*Any items in the inspector can be adjusted, including how many elements are in the array and how many.
To do that is not hard coding./* */

private string[] batPeeps = {"Alfred", "Robin", "Oracle", "Nightwing", "Catwoman", "Comm. Gordon", "Lucius Fox"};

//It is important to name our array.  For instance, the following will bring up an error.

public string[] = {"Aang", "Katara", "Sokka", "Toph", "Zuko", "Suki"};

//Instead, it should be like this:

public string[] teamAvatar= {"Aang", "Katara", "Sokka", "Toph", "Zuko", "Suki"};



