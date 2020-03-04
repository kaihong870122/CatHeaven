using UnityEngine;
using System.Collections;

public class Camera : MonoBehaviour
{
    public  Transform tran;
    new Transform transform;
    public float speed = 0.1f;

    private void Start()
    {
        transform = GetComponent<Transform>();
        Screen.SetResolution(1280, 720, false);
    }

    private void Update()
    {
        Vector3 followPos = new Vector3(tran.position.x + speed, tran.position.y + speed , transform.position.z);
        transform.position = followPos;

    }


}
