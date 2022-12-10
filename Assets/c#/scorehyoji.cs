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
        scoretext.text = "���ꂽ�����S�̐��F" + scoreCs.apoint.ToString() +
                          "\n���ꂽ�I�����W�̐��F" + scoreCs.opoint.ToString() +
                          "\n�S�~���ɓ��ꂽ�����ʕ��̐��F" + scoreCs.gomipoint.ToString() +
                          "\n���Ƃ����ʕ��̐��F" + scoreCs.fallpoint.ToString() +
                          "\n�ԈႦ���ʕ��̐��F" + scoreCs.falsepoint.ToString();

        pointtext.text = "���v�F" + kekka + "pt";
    }
}
