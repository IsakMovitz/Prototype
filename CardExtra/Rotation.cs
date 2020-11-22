using UnityEngine;

public class Rotation : MonoBehaviour
{
    public Quaternion targetRotation;
    public float smooth = 3;
 
    void Start()
    {
        targetRotation = transform.rotation;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            targetRotation = Quaternion.AngleAxis(180, transform.forward) * transform.rotation;
        }

        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, smooth * Time.deltaTime);
    }

}
