using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IT
{
    using UnityEngine;

    public static class StaticStrings
    {
        // 通用的输入名称
        public static string DPadVertical => IsMac ? "DPadVerticalM" : "DPadVertical";
        public static string DPadHorizontal => IsMac ? "DPadHorizontalM" : "DPadHorizontal";
        public static string DPadLeft => IsMac ? "DPadLeftM" : "DPadHorizontal";
        public static string DPadRight => IsMac ? "DPadRightM" : "DPadHorizontal";
        public static string DPadUp => IsMac ? "DPadUpM" : "DPadVertical";
        public static string DPadDown => IsMac ? "DPadDownM" : "DPadVertical";
    
        public static string Vertical => IsMac ? "VerticalM" : "Vertical";
        public static string Horizontal => IsMac ? "HorizontalM" : "Horizontal";
        public static string B => IsMac ? "BM" : "B";
        public static string A => IsMac ? "AM" : "A";
        public static string X => IsMac ? "XM" : "X";
        public static string Y => IsMac ? "YM" : "Y";
        public static string RT => IsMac ? "RTM" : "RT";
        public static string LT => IsMac ? "LTM" : "LT";
        public static string RB => IsMac ? "RBM" : "RB";
        public static string LB => IsMac ? "LBM" : "LB";
        public static string L => IsMac ? "LM" : "L";
        public static string R => IsMac ? "RM" : "R";
        public static string RightVertical => IsMac ? "RightVerticalM" : "RightVertical";
        public static string RightHorizontal => IsMac ? "RightHorizontalM" : "RightHorizontal";
    
        public static string View => IsMac ? "ViewM" : "View";
        public static string Menu => IsMac ? "MenuM" : "Menu";

        // 判断当前平台是否为Mac
        private static bool IsMac => Application.platform == RuntimePlatform.OSXPlayer || 
                                     Application.platform == RuntimePlatform.OSXEditor;
    }
}