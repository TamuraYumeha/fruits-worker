using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class Score : MonoBehaviour
{
    public float apoint;
    public float opoint;
    public float falsepoint;
    public float fallpoint;
    public float gomipoint;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if(SceneManager.GetActiveScene().name == "Start")�@//start�Ɉړ��Bawake�֐��ł�����ł�
        {
            apoint = 0;
            opoint = 0;
            falsepoint = 0;
            fallpoint = 0;
            gomipoint = 0;
        }
    }
}
