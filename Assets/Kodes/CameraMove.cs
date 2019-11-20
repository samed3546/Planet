using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public Vector3[] Points; // 20 birimlik konumlar
    private int Index = 0; // mevcutkonum id

    [SerializeField]
    private float speed = 2f; // konumlar arası geçiş hızı
    void Update()
    {
        Vector3 CurrentPos = Points[Index];

        if (Input.GetKeyUp(KeyCode.D))
        {
            if (Index < Points.Length - 1)
            {
                Index++;
            }
        }

        if (Input.GetKeyUp(KeyCode.A))
        {
            if (Index > 0)
            {
                Index--;
            }
        }
        transform.position = Vector3.Lerp(transform.position, CurrentPos, speed * Time.deltaTime);
    }
}
