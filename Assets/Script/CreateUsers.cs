using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Script.Bilibili;
using BilibiliUtilities.Live;

public class CreateUsers : MonoBehaviour
{
    public GameObject myPrefab;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (bilibili.mh.New_User_flag == 1)
        {
            Create_Prefab(bilibili.mh.Username);
            bilibili.mh.New_User_flag = 0;
        }
    }

    public void Create_Prefab(string name)
    {

        GameObject bullet = Instantiate(myPrefab);
        bullet.transform.position = new Vector3(2f, 0, 0);
        bullet.name = name;
   
    }
}
