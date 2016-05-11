using UnityEngine;
using System.Collections;

public class RotateToMouse : MonoBehaviour {

    void Update()
    {
    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    Plane plane = new Plane(Vector3.up, Vector3.zero);
    float distance;

        if (plane.Raycast(ray, out distance))
        {
            Vector3 point = ray.GetPoint(distance);
            Vector3 adjustedHeightPoint = new Vector3(point.x, transform.position.y, point.z);
            transform.LookAt(adjustedHeightPoint);
        }
    }
}
