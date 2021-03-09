using UnityEngine;

[ExecuteInEditMode]
public class TextMeshFaceToCamera : MonoBehaviour
{
    void Update()
    {
        if(Camera.current)
            transform.rotation = Quaternion.LookRotation(transform.position - Camera.current.transform.position);
    }
}