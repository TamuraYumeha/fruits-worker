using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float time;
    private float minute;
    private float second;
    public Text timertext;
    public Text clicktext;
    public Text endtext;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        minute = (int)time / 60;
        second = (int)time % 60;

        timertext.text = minute.ToString() + ":" + second.ToString("00");

        if(time <= 0)
        {
            timertext.text = "0:00";
            Time.timeScale = 0;
            endtext.text = "しゅ～りょ～";
            clicktext.text = "左クリックでリザルト画面へ";

            if(Input.GetMouseButtonDown(0))
            {
                SceneManager.LoadScene("Result");
                Time.timeScale = 1;
            }
        }
        
    }
}
