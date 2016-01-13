using System;
using UnityEngine;

public delegate void EventHandler();

public class EventDispatcher : MonoBehaviour 
{
	void Start ()
	{
        EventDispatcher dispatcher = 
            GameObject.Find("Main Camera").GetComponent<EventDispatcher>();
        //dispatcher
	}

    void CallMeMaybe()
    {
        Debug.Log("here's my number");
    }

	void Update ()
	{
	
	}
}