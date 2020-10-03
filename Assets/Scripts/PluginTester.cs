using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;


public class PluginTester : MonoBehaviour
{

    private const string DLL_NAME = "GameEnginesWeek4";

    [StructLayout(LayoutKind.Sequential)]
    struct Vector3D
    {
            public float x;
            public float y;
            public float z;
    }


    [DllImport(DLL_NAME)]
    private static extern int GetID();

    [DllImport(DLL_NAME)]
    private static extern void SetID(int id);


    [DllImport(DLL_NAME)]
    private static extern Vector3D GetPosition();

    [DllImport(DLL_NAME)]
    private static extern void SetPosition(float x, float y, float z);

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            SetID(420);
            Debug.Log(GetID());

            SetPosition(3.4f, 5.7f, 9.7f);
            Debug.Log(GetPosition().x);
            Debug.Log(GetPosition().y);
            Debug.Log(GetPosition().z);

           

        }
    }
}
