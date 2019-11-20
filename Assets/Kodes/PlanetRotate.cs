using UnityEngine;

public class PlanetRotate : MonoBehaviour 
{
    [SerializeField]
    private float Rotspeed = 10f;

    [System.Obsolete]
    private void OnMouseDrag()
    {
        float Xrot = Input.GetAxis("Mouse X") * Rotspeed * Mathf.Deg2Rad;
        float Yrot = Input.GetAxis("Mouse Y") * Rotspeed * Mathf.Deg2Rad;

        transform.RotateAround(Vector3.up, -Xrot);
        transform.RotateAround(Vector3.right, Yrot);
    }

}
