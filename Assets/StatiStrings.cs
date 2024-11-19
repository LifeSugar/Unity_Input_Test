using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IT
{
    public static class StaticStrings
    {
        // 通用的输入名称
        public static string DPadVertical = isWindows ? "DPadVertical" : "DPadVerticalW";
        public static string DPadHorizontal = isWindows ? "DPadHorizontal" : "DPadHorizontalW";
        public static string Vertical = "Vertical";
        public static string Horizontal = "Horizontal";
        public static string B = "B";
        public static string A = "A";
        public static string X = "X";
        public static string Y = "Y";
        public static string RT = "RT";
        public static string LT = "LT";
        public static string RB = "RB";
        public static string LB = "LB";
        public static string L = "L";
        public static string R = "R";
        public static string RightVertical = isWindows ? "RightVertical" : "RightVerticalW";
        public static string RightHorizontal = isWindows ? "RightHorizontal" : "RightHorizontalW";

        public static string View = "View";
        public static string Menu = "Menu";

        public static bool isWindows = (Application.platform == RuntimePlatform.WindowsPlayer ||
                                        Application.platform == RuntimePlatform.WindowsEditor);
    }
}