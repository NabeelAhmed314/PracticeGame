using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastScript : MonoBehaviour
{
    void Update()
    {
        Debug.Log("Update");
        Debug.DrawLine(transform.position, new Vector3(5,5,0),Color.green,0.2f); 
    }
}
