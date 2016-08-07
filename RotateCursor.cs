using UnityEngine;
using System.Collections;

public class RotateCursor : MonoBehaviour
{
    [Range(0.1f, 20f)] public float speed;
    public Transform target;
    private float coef = 0;
    public float maxcoef;
    private Vector3 zAxis = new Vector3(0,0,1);
    void Update () {
        if (Input.GetKey(KeyCode.Q))
        {
            if (coef < maxcoef)
            {
                coef += 0.05f;
            }
            transform.RotateAround(target.position, zAxis, coef*speed);
        }
        if (Input.GetKey(KeyCode.E))
        {
            if (coef < maxcoef)
            {
                coef += 0.05f;
            }
            transform.RotateAround(target.position, zAxis, coef*(-speed));
        }
        else if (Input.GetKey(KeyCode.Q) == false && Input.GetKey(KeyCode.E) == false)
        {
            coef = 0;
        }
    }
}
