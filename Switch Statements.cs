/*Switch statements are the alternative to if/then statements.  Similar to how arrays work as an alternate to
typing out individual variables, switch statements allow us to make a lot of steamlined code that accomplishes
our needs but cutting out extra fat.

A standard if then situation would look like this:*/

public class IfStatements : MonoBehaviour
{
    float coffeeTemperature = 85.0f;
    float hotLimitTemperature = 70.0f;
    float coldLimitTemperature = 40.0f;

    void Update ()
    {
        if(Input.GetKeyDown(KeyCode.Space))
            TemperatureTest();      
        coffeeTemperature -= Time.deltaTime * 5f;
    }  
    void TemperatureTest ()
    {
        if(coffeeTemperature > hotLimitTemperature)
        {
            print("Coffee is too hot.");
        }
        else if(coffeeTemperature < coldLimitTemperature)
        {
            print("Coffee is too cold.");
        }
        else
        {
            print("Coffee is just right.");
        }
    }
}

//Where as a switch statement will go more like this:

public class ConversationScript : MonoBehaviour 
{
    public int intelligence = 5;  
    void Greet()
    {
        switch (intelligence)
        {
        case 5:
            print ("Why hello there good sir! Let me teach you about Trigonometry!");
            break;
        case 4:
            print ("Hello and good day!");
            break;
        case 3:
            print ("Whadya want?");
            break;
        case 2:
            print ("Grog SMASH!");
            break;
        case 1:
            print ("Ulg, glib, Pblblblblb");
            break;
        default:
            print ("Incorrect intelligence level.");
            break;
        }
    }
}
/*As we can see here, switch statements give our methods choices based on conditions, just like if statements,
but the final result is cleaner.  If case 5 happens, do this.  If case 3 happens, do that.  It's simple and clear. */

//The method syntax is summed up here:

switch(expression) {
   case constant-expression  :
      statement(s);
      break; 
   case constant-expression  :
      statement(s);
      break;
   default : 
   statement(s);
}

/*Cases are presented.  With those cases are methods that will run once said case's conditions are met.  Each
switch includes a break to end the method.  A default condition is provided at the end so the program won't crash
in the case that no other condition is met.  This is like the else statement in if statement methods.

Here are some other examples.*/

 string value = "turnip";
        // ... Switch on the string.
        switch (value)
        {
            case "lettuce":
                Console.WriteLine("LETTUCE");
                break;
            case "squash":
                Console.WriteLine("SQUASH");
                break;
            case "turnip":
                Console.WriteLine("TURNIP");
                break;
        }

        