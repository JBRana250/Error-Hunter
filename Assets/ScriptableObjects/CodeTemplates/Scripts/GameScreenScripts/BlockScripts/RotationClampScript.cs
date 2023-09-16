using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationClampScript : MonoBehaviour
{
    private Rigidbody2D m_Rigidbody;
    public float clampAngle;

    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody2D>();
        clampAngle = 45;
    }
    void Update()
    {
        // if object rotates past a certain point, freezes rotation.
        if(gameObject.transform.rotation.eulerAngles.z > (0+clampAngle) || gameObject.transform.rotation.eulerAngles.z < (0-clampAngle))
        {
            m_Rigidbody.constraints = RigidbodyConstraints2D.FreezeRotation;
        }
    }
}
