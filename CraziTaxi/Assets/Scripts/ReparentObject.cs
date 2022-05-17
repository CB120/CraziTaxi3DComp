using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReparentObject : MonoBehaviour
{
    public Vector3 posOffset;
    public Vector3 rotOffset;
    bool hasJoint = false;

    private void OnTriggerEnter(Collider other)
    {
        if (!hasJoint)
        {
            gameObject.AddComponent<FixedJoint>();
            gameObject.GetComponent<FixedJoint>().connectedBody = other.gameObject.GetComponent<Rigidbody>();
            hasJoint = true;
            Debug.Log("added joint");
        }
    }
}
