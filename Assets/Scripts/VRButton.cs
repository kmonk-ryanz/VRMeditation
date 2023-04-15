using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class VRButton : MonoBehaviour
{
    //Button is set inactive after release determined by time 
    public float deadTime = 1.0f;
    //Locks down button during its set dead time
    private bool _deadTimeActive;
    
    public UnityEvent onPress;
    public UnityEvent onRelease;

    //Checks to see if the collider has the Button tag and sets the OnPress event
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Button") && !_deadTimeActive)
        {
            onPress?.Invoke();
            Debug.Log("Pressed I am!");
        }
    }

    //Checks to see if the collider has the Button tag and sets the OnRelease event
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Button") && !_deadTimeActive)
        {
            onRelease?.Invoke();
            Debug.Log("Released I am!");
            StartCoroutine(WaitForDeadTime());
        }
    }

    //Locks down button activity until deadTime has passed and then reactivates button activity
    private IEnumerator WaitForDeadTime()
    {
        _deadTimeActive = true;
        yield return new WaitForSeconds(deadTime);
        _deadTimeActive = false;
    }
}