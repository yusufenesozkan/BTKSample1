using Unity.VisualScripting;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    void Update()
    {
        this.transform.Rotate(0,0,180f*Time.deltaTime);
    }
    
}
