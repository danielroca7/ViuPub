using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;

public class StateChangeButton : MonoBehaviour 
{
    public enum sceneName // Enum names of scenes
    {
        Intro,
        Register,
		Home,
		Options,
		Play
    }

    public sceneName scene; // Scene enum public variable

    public void ChangeScene ()
    {
		if(Application.levelCount >= (int)scene)
        	Application.LoadLevel((int)scene);
    }
}
