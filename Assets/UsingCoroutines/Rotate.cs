using UnityEngine;
using UnityEngine.UI;

public class Rotate : MonoBehaviour 
{
    System.Timers.Timer timer;
    int counter = 5;
    

	void Start ()
    {
        timer = new System.Timers.Timer(1000);
        timer.Elapsed +=
            (object sender, System.Timers.ElapsedEventArgs e) => counter--;
	
	}

	void Update ()
    {
        if (counter <= 0)
            Debug.Log("Time is out!");

        
	}
}