using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Titlestart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnClick()
    {
        SceneManager.LoadScene("Main");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
