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

    private void OnMouseDrag()�@�@//�h���b�O�֌W�̃v���O����
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
        transform.Translate(new Vector3(fruitsSpeed, 0, 0) * Time.deltaTime);  //�ʕ��̈ړ����x

        if (this.transform.position.x > maxF)       //���̃}�X�ɗ����������
        {
            Destroy(this.gameObject);
        }

        if (Input.GetMouseButtonDown(0))  //�h���b�O����Ɋւ���v���O����
        {
            this.screenPoint = Camera.main.WorldToScreenPoint(transform.position);
            this.offset = transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
        }

        if (timerCs.time >= 0)
        {
            if (Input.GetMouseButtonUp(0))
            {
                if (abox == true)  //���������ɓ��ꂽ
                {
                    Destroy(this.gameObject);
                    scoreCs.falsepoint++;
                }

                if (obox == true)  //�Ԉ�������ɓ��ꂽ
                {
                    Destroy(this.gameObject);
                    scoreCs.opoint++;
                }

                if (gomi == true)
                {
                    Destroy(this.gameObject);
                    scoreCs.falsepoint++;
                }

                if (haikei == true)                        //���̏ꏊ�ɗ��Ƃ���
                {
                    Destroy(this.gameObject);
                    scoreCs.fallpoint++;
                }
            }
        }
            
    }
}