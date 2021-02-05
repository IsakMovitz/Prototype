using UnityEngine;
using System.Collections;

public class DestroyObject : MonoBehaviour
{


    void OnMouseDown()
    {
        gameObject.SetActive(false);
    }
}