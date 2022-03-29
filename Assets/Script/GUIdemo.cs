using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIdemo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GUI.Label(new Rect(10, 10, 100, 50), "Hellow,GUI");
    }

    private void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 100,50), "Hellow,GUI");
        GUI.Button(new Rect(10, 60, 100,50), "LoginButton");
    }
}
