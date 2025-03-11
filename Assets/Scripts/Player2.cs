using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    [SerializeField] private float _forwardSpeed = 1.0f;
    [SerializeField] private float _turnSpeed = 1.0f;
    
    // movement
    private void Update ()
    {
        float translation = Input.GetAxis("P2_Vertical") * _forwardSpeed * Time.deltaTime;
        float rotation = Input.GetAxis("P2_Horizontal") * _turnSpeed * Time.deltaTime;

        transform.Translate(0, 0, translation);
        transform.Rotate(0, rotation, 0);
    }
}