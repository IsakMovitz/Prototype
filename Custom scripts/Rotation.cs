using UnityEngine;
using UnityEngine.SceneManagement;

public class Rotation : MonoBehaviour
{
    public Quaternion targetRotation;
    public ToggleAR toggle;
    public float smooth = 3;
    public bool frontSideVisible = true;

    void Start()
    {
        targetRotation = transform.rotation;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            targetRotation = Quaternion.AngleAxis(180, Vector3.forward) * transform.rotation;
            toggle.HideObjects();
            frontSideVisible = frontSideVisible ? false : true;
        }
        if (Input.GetKeyDown(KeyCode.R))
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit(); 

    transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, smooth * Time.deltaTime);
    }

}