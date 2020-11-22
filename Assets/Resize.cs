using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resize : MonoBehaviour
{
    // Start is called before the first frame update

    Vector3 temp;

    Vector3 pos;

    private void Start()
    {
        temp = transform.localScale;
        pos = transform.localPosition;
    }
    
    // Resizear 

    public void changeSize()
    {
        temp.x -= 0.5f;
        temp.y -= 0.5f;
        temp.z -= 0.5f;
        transform.localScale = temp;
        pos.y -= 0.5f;
        transform.localPosition = pos;
        Debug.Log("Hi there");
    }
}
