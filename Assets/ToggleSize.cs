using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleSize : MonoBehaviour
{
    public Resize other;

    void OnMouseDown()
    {   

        other.changeSize();
    }
}
