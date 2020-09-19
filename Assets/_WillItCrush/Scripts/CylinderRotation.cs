using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderRotation : MonoBehaviour
{
    public GameObject RightCylinder,LeftCylinder;
    public static float speed = 50f;
    public static float cylinderRotSpeed=100f;
    float rot;
    void Update()
    {
        rot = Time.deltaTime * speed;
        CylinderRotationFunc();
    }
    public void CylinderRotationFunc()
    {        
        LeftCylinder.transform.Rotate(new Vector3(0, -rot, 0), cylinderRotSpeed * Time.deltaTime);
        RightCylinder.transform.Rotate(new Vector3(0, rot, 0), cylinderRotSpeed * Time.deltaTime);
    }
   
}
