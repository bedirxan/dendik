﻿using Appodeal.Unity.Editor;
using UnityEditor;
using UnityEditor.Callbacks;
using UnityEngine;

namespace AppodealAds.Unity.Editor
{
    public class AppodealPostProcess : MonoBehaviour
    {
        [PostProcessBuild(100)]
        public static void OnPostProcessBuild(BuildTarget target, string path)
        {
            if (target.ToString() == "iOS" || target.ToString() == "iPhone")
            {
                iOSPostprocessUtils.PrepareProject(path);
            }
        }
    }
}