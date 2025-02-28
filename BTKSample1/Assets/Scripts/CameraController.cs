using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform playerTransform;
    public Vector3 offset;

    void Start()
    {
        
    }
    void Update()
    {
        this.transform.position = playerTransform.position+offset;
    }
}
