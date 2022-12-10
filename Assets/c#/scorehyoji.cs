using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scorehyoji : MonoBehaviour
{
    public GameObject score;
    public Score scoreCs;

    public float apoint;
    public float opoint;
    public float falsepoint;
    public float fallpoint;
    public float gomipoint;

    private float kekka;

    public Text scoretext;
    public Text pointtext;

    // Start is called before the first frame update
    void Start()
    {
        score = GameObject.Find("Score");
        scoreCs = score.GetComponent<Score>();


        kekka =scoreCs.apoint + scoreCs.opoint + scoreCs.gomipoint - scoreCs.falsepoint - scoreCs.fallpoint * 2;
    }

    // Update is called once per frame
    void Update()
    {
        scoretext.text = "入れたリンゴの数：" + scoreCs.apoint.ToString() +
                          "\n入れたオレンジの数：" + scoreCs.opoint.ToString() +
                          "\nゴミ箱に入れた悪い果物の数：" + scoreCs.gomipoint.ToString() +
                          "\n落とした果物の数：" + scoreCs.fallpoint.ToString() +
                          "\n間違えた果物の数：" + scoreCs.falsepoint.ToString();

        pointtext.text = "合計：" + kekka + "pt";
    }
}
