using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resize : MonoBehaviour
{
    // Start is called before the first frame update


    Vector3 minScale;
    public Vector3 maxScale;
    private Vector3 currentSize;
    public bool repeatable;
    public float speed = 2f;
    public float duaration = 5f;

    IEnumerator Start()
    {
        minScale = transform.localScale;
        currentSize = maxScale;
        yield return RepeatLerp(minScale, maxScale, duaration);
    }

    public IEnumerator RepeatLerp(Vector3 a, Vector3 b, float time)
    {
        float i = 0.0f;
        float rate = (1.0f / time) * speed;
        while (i < 1.0f)
        {
            i += Time.deltaTime * rate;
            transform.localScale = Vector3.Lerp(a, b, i);
            yield return null;
        }
    }

    // Resizear 

    public void changeSize(string tagName)
    {
        currentSize = transform.localScale;
        float changeAmount;
        Debug.Log(tagName);
        if (tagName == "plane") {
            changeAmount = .07f;
        } else if (tagName == "meat") {
            changeAmount = .03f;
        } else if (tagName == "car") {
            changeAmount = .05f;
        } else {
            changeAmount = .02f;
        }
        currentSize.x -= changeAmount;
        currentSize.y -= changeAmount;
        currentSize.z -= changeAmount;

        transform.localScale = currentSize;
    }
}