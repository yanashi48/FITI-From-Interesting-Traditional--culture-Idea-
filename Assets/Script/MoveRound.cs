using UnityEngine;
using System.Collections;
public class MoveRound : MonoBehaviour
{
    float stopTime;//��ͣʱ��
    float moveTime;//�ƶ�ʱ��
    float vel_x, vel_y, vel_z;//�ٶ�
    /// <summary>
    /// �����С���н���
    /// </summary>
    float maxPos_x = 18;
    float maxPos_y = 0;
    float minPos_x = -18;
    float minPos_y = -10;
    float timeCounter1;//�ƶ��ļ�ʱ��
    float timeCounter2;//��ͣ�ļ�ʱ��
    void Start()
    {
        Change();
    }
    // Update is called once per frame
    void Update()
    {
        timeCounter1 += Time.deltaTime;
        //����ƶ��ļ�ʱ��С���ƶ�ʱ�䣬������ƶ���������ͣ��ʱ���ۼӣ�����ͣ��ʱ��������ͣʱ��ʱ������
        if (timeCounter1 < moveTime)
        {
            transform.Translate(vel_x, vel_y, 0, Space.Self);
        }
        else
        {
            timeCounter2 += Time.deltaTime;
            if (timeCounter2 > stopTime)
            {
                Change();
                timeCounter1 = 0;
                timeCounter2 = 0;
            }
        }
        Check();
    }
    //�Բ�����ֵ
    void Change()
    {
        stopTime = Random.Range(1, 5);
        moveTime = Random.Range(1, 20);
        vel_x = (float)0.001 * Random.Range(1, 10);
        vel_y = (float)0.001 * Random.Range(1, 10);
    }
    //�ж��Ƿ�ﵽ�߽磬�ﵽ�߽����ٶȸ�Ϊ����
    void Check()
    {
        //�������Ԥ��Ľ���λ��ֵ�������ٶȷ���������ǰ������λ�õ�������ٽ�ߵ�λ��ֵ
        if (transform.localPosition.x > maxPos_x)
        {
            vel_x = -vel_x;
            transform.localPosition = new Vector3(maxPos_x, transform.localPosition.y, 0);
        }
        if (transform.localPosition.x < minPos_x)
        {
            vel_x = -vel_x;
            transform.localPosition = new Vector3(minPos_x, transform.localPosition.y, 0);
        }
        if (transform.localPosition.y > maxPos_y)
        {
            vel_y = -vel_y;
            transform.localPosition = new Vector3(transform.localPosition.x, maxPos_y, 0);
        }
        if (transform.localPosition.y < minPos_y)
        {
            vel_y = -vel_y;
            transform.localPosition = new Vector3(transform.localPosition.x, minPos_y, 0);
        }
    }


}
