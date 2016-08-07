using UnityEngine;
using System.Collections;

public class ReturnBackToPos : MonoBehaviour
{
    public Rigidbody2D CurrentGameObject;
    public float coef;
    private Vector3 delta;
    private Vector3 originalPos;
    private Vector3 force;
	void Start ()
	{
	    originalPos = CurrentGameObject.transform.position;
	}
	void Update ()
	{
        delta = originalPos - CurrentGameObject.transform.position;
	    force = coef * delta * delta.magnitude; //k*x^2
	    if (originalPos != CurrentGameObject.transform.position)
	    {
	        CurrentGameObject.AddForce(force);
	    }
	}
}
