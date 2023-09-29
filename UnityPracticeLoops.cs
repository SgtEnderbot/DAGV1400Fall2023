using UnityEngine;
using System.Collections;

public class ForLoop : MonoBehaviour
{
    int numEnemies = 3;
    bool shouldContinue = false;
    string[] strings = new string[3];
    
    void Start ()
    {
        //A for loop, as used in the examples.
        for(int i = 0; i < numEnemies; i++)
        {
            Debug.Log("Creating enemy number: " + i);
        }


        //A while loop, as used in the examples.
        while(cupsInTheSink > 0)
        {
            Debug.Log ("I've washed a cup!");
            cupsInTheSink--;
        }

        
        //A do-while loop, as used in the examples.
        do
        {
            print ("Hello World");
            
        }
        while(shouldContinue == true);


        //A foreach loop, as used in the examples.
        strings[0] = "First string";
        strings[1] = "Second string";
        strings[2] = "Third string";
        
        foreach(string item in strings)
        {
            print (item);
        }
    }
}