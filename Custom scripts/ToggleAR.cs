using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleAR : MonoBehaviour
{
    public GameObject parent;
    public Resize humanObject;
    private bool isActive = true;
    private bool firstLoad = true;
    private void Start() {
        parent = GameObject.Find("Card");
        isActive = ToggleObjects(isActive);
        //HideObjects();
    }
    private void OnMouseDown() {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            GameObject thePlayer = GameObject.Find("Card");
            Rotation playerScript = thePlayer.GetComponent<Rotation>();
            if (playerScript.frontSideVisible)
            {
                isActive = ToggleObjects(isActive);

            }
        }
    }

    private bool ToggleObjects(bool state)
    {
        Transform render = parent.GetComponentInChildren<Transform>(true);
        state = state ? false : true;
        foreach (Transform child in render) {
            child.gameObject.SetActive(state);
        }Debug.Log((Material)Resources.Load("Green", typeof(Material)));
        gameObject.GetComponent<MeshRenderer>().material = (Material) Resources.Load(state ? "Green" : "Red", typeof(Material));
        if (!state && !firstLoad)
        {
            humanObject.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
        }
        firstLoad = false;
        return state;
    }

    public void HideObjects()
    {
        Transform render = parent.GetComponentInChildren<Transform>(true);
        foreach (Transform child in render) {
            child.gameObject.SetActive(false);
        }
        humanObject.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
        gameObject.GetComponent<MeshRenderer>().material = (Material)Resources.Load("Red", typeof(Material));
        isActive = false;
    }
}
