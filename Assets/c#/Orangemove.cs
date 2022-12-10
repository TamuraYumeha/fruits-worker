using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orangemove : MonoBehaviour
{
    public float fruitsSpeed;
    public float maxF;

    private Vector3 screenPoint;
    private Vector3 offset;

    public GameObject score;
    public Score scoreCs;
    private bool abox;
    private bool obox;
    private bool con;
    private bool gomi;
    private bool haikei;

    public GameObject timer;
    public Timer timerCs;

    private int opoint;
    private int falsepoint;
    private int fallpoint;

    // Start is called before the first frame update
    void Start()
    {
        score = GameObject.Find("Score");
        scoreCs = score.GetComponent<Score>();

        timer = GameObject.Find("Timer");
        timerCs = timer.GetComponent<Timer>();
    }

    private void OnMouseDrag()　　//ドラッグ関係のプログラム
    {
        Vector3 currentScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        Vector3 currentPosition = Camera.main.ScreenToWorldPoint(currentScreenPoint) + this.offset;
        transform.position = currentPosition;
    }


    void OnTriggerStay2D(Collider2D collision)
    { 
        abox = false;
        obox = false;
        con = false;
        haikei = false;

        if (collision.gameObject.CompareTag("abox"))
        {
            abox = true;
        }

        if (collision.gameObject.CompareTag("obox"))
        {
            obox = true;
        }

        if (collision.gameObject.CompareTag("con"))
        {
            con = true;
        }

        if (collision.gameObject.CompareTag("gomibako"))
        {
            gomi = true;
        }

        if (collision.gameObject.CompareTag("haikei"))
        {
            haikei = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(fruitsSpeed, 0, 0) * Time.deltaTime);  //果物の移動速度

        if (this.transform.position.x > maxF)       //このマスに来たら消える
        {
            Destroy(this.gameObject);
        }

        if (Input.GetMouseButtonDown(0))  //ドラッグ操作に関するプログラム
        {
            this.screenPoint = Camera.main.WorldToScreenPoint(transform.position);
            this.offset = transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
        }

        if (timerCs.time >= 0)
        {
            if (Input.GetMouseButtonUp(0))
            {
                if (abox == true)  //正しい箱に入れた
                {
                    Destroy(this.gameObject);
                    scoreCs.falsepoint++;
                }

                if (obox == true)  //間違った箱に入れた
                {
                    Destroy(this.gameObject);
                    scoreCs.opoint++;
                }

                if (gomi == true)
                {
                    Destroy(this.gameObject);
                    scoreCs.falsepoint++;
                }

                if (haikei == true)                        //他の場所に落とした
                {
                    Destroy(this.gameObject);
                    scoreCs.fallpoint++;
                }
            }
        }
            
    }
}