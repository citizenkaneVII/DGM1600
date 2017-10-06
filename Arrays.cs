/*So you know how we have variables? */

int x = 12;

//Let's say we have a bunch of those.  They're all the same type, but there's alot of them.

string grades = "5";
string grades = "7";
string grades = "3";

//Instead of dealing with making a bunch of these, we can make an array.

string[] grades = {"5", "7", "3"};

//An array is a fixed number of elements or a particular type.  All of these can have different values.

Color[] colors = {Color.red, Color.blue, Color.black, Color.yellow};

//When declairing an array, it's important to define wether it's public or private.

public int[] hight = {3, 4, 4, 7, 2};

//Public will allow you to see the array in the inspector.


int[] myIntArray = new int [5];
void start (){
    myIntArray[0] = 63;
    myIntArray[1] = 72;
    myIntArray[2] = 81;
    myIntArray[3] = 90;
    myIntArray[4] = 99;
}


string[] batPeeps = {"Alfred", "Robin", "Oracle", "Nightwing", "Catwoman", "Gordon",}
