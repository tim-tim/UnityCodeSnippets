using UnityEngine;

public class test : MonoBehaviour 
{
    System.Timers.Timer LeTimer;
    int BoomDown = 10;
    void Start()
    {
        //Initialize timer with 1 second intervals
        LeTimer = new System.Timers.Timer(1000);
        LeTimer.Elapsed +=
            //This function decreases BoomDown every second
            (object sender, System.Timers.ElapsedEventArgs e) => BoomDown--;
    }

    void Update()
    {
        //When BoomDown reaches 0, BOOM!
        if (BoomDown <= 0)
        {
            Debug.Log("Boom!");
        }
            
    }
}