using UnityEngine;
using UnityEngine.UI;


public class ShowTime : MonoBehaviour 
{
    public Text info;
    
	void Update ()
	{
        //info.text = counter.ToString();

        info.text = "unscaledTime:\t" + Time.unscaledTime.ToString("F0") + "\n"
                    + "unscaledDeltaTime:\t" + Time.unscaledDeltaTime.ToString() + "\n"
                    + "deltaTime:\t" + Time.deltaTime.ToString();
        transform.Rotate(Vector3.up, 6 * Time.deltaTime);
    }
}