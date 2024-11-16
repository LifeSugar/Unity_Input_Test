using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IT
{
   

    public static class StaticStrings
    {
        // 通用的输入名称
#if UNITY_STANDALONE_WIN
    public static string DPadVertical = "DPadVertical";
    public static string DPadHorizontal = "DPadHorizontal";
    public static string DPadLeft = "DPadHorizontal"; // Windows上DPad左右为Horizontal轴
    public static string DPadRight = "DPadHorizontal"; // Windows上DPad左右为Horizontal轴
    public static string DPadUp = "DPadVertical"; // Windows上DPad上下为Vertical轴
    public static string DPadDown = "DPadVertical"; // Windows上DPad上下为Vertical轴

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
    public static string RightVertical = "RightVertical";
    public static string RightHorizontal = "RightHorizontal";

    public static string View = "View";
    public static string Menu = "Menu";

#elif UNITY_STANDALONE_OSX
    public static string DPadVertical = "DPadVerticalM";
    public static string DPadHorizontal = "DPadHorizontalM";
    public static string DPadLeft = "DPadLeftM"; // Mac上DPad左右为独立按钮
    public static string DPadRight = "DPadRightM"; // Mac上DPad左右为独立按钮
    public static string DPadUp = "DPadUpM"; // Mac上DPad上下为独立按钮
    public static string DPadDown = "DPadDownM"; // Mac上DPad上下为独立按钮

    public static string Vertical = "VerticalM";
    public static string Horizontal = "HorizontalM";
    public static string B = "BM";
    public static string A = "AM";
    public static string X = "XM";
    public static string Y = "YM";
    public static string RT = "RTM";
    public static string LT = "LTM";
    public static string RB = "RBM";
    public static string LB = "LBM";
    public static string L = "LM";
    public static string R = "RM";
    public static string RightVertical = "RightVerticalM";
    public static string RightHorizontal = "RightHorizontalM";

    public static string View = "ViewM";
    public static string Menu = "MenuM";

#else
    // 默认情况（其他平台可以根据需求修改）
    public static string DPadVertical = "DPadVertical";
    public static string DPadHorizontal = "DPadHorizontal";
    public static string DPadLeft = "DPadHorizontal";
    public static string DPadRight = "DPadHorizontal";
    public static string DPadUp = "DPadVertical";
    public static string DPadDown = "DPadVertical";

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
    public static string RightVertical = "RightVertical";
    public static string RightHorizontal = "RightHorizontal";

    public static string View = "View";
    public static string Menu = "Menu";
#endif
    }
}