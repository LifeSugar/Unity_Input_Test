using UnityEngine;
using UnityEngine.UI;
using IT;

public class XboxControllerFullTest : MonoBehaviour
{
    public Text displayText;  // UI显示的Text对象
    private const float threshold = 0.5f;  // 阈值，用于判断DPad和扳机键是否按下

    private bool isLTPressed = false;  // LT按键状态
    private bool isRTPressed = false;  // RT按键状态

    // DPad按键状态（仅适用于Windows平台）
    private bool isDPadUpPressed = false;
    private bool isDPadDownPressed = false;
    private bool isDPadLeftPressed = false;
    private bool isDPadRightPressed = false;

    private void Awake()
    {
        // 检测是否有手柄连接
        if (Input.GetJoystickNames().Length > 0 && !string.IsNullOrEmpty(Input.GetJoystickNames()[0]))
        {
            Debug.Log("Controller connected: " + Input.GetJoystickNames()[0]);
            displayText.text = "Controller connected: " + Input.GetJoystickNames()[0];
        }
        else
        {
            Debug.Log("No controller connected");
            displayText.text = "No controller connected";
        }
    }

    private void Update()
    {
        string inputLog = "";  // 用于记录手柄输入的字符串

        // 检查所有按键的输入
        if (Input.GetButtonDown(StaticStrings.A)) inputLog += "A Pressed\n";
        if (Input.GetButtonDown(StaticStrings.B)) inputLog += "B Pressed\n";
        if (Input.GetButtonDown(StaticStrings.X)) inputLog += "X Pressed\n";
        if (Input.GetButtonDown(StaticStrings.Y)) inputLog += "Y Pressed\n";
        if (Input.GetButtonDown(StaticStrings.LB)) inputLog += "LB Pressed\n";
        if (Input.GetButtonDown(StaticStrings.RB)) inputLog += "RB Pressed\n";
        if (Input.GetButtonDown(StaticStrings.L)) inputLog += "L Pressed\n";
        if (Input.GetButtonDown(StaticStrings.R)) inputLog += "R Pressed\n";
        if (Input.GetButtonDown(StaticStrings.View)) inputLog += "View Pressed\n";
        if (Input.GetButtonDown(StaticStrings.Menu)) inputLog += "Menu Pressed\n";

#if UNITY_STANDALONE_WIN
        // Windows平台的DPad使用两个轴来判断方向
        float dpadHorizontal = Input.GetAxis(StaticStrings.DPadHorizontal);
        float dpadVertical = Input.GetAxis(StaticStrings.DPadVertical);

        // 检查DPad上方向
        if (dpadVertical > threshold && !isDPadUpPressed)
        {
            inputLog += "DPad Up Pressed\n";
            isDPadUpPressed = true;
        }
        else if (dpadVertical <= threshold && isDPadUpPressed)
        {
            isDPadUpPressed = false;  // 重置状态
        }

        // 检查DPad下方向
        if (dpadVertical < -threshold && !isDPadDownPressed)
        {
            inputLog += "DPad Down Pressed\n";
            isDPadDownPressed = true;
        }
        else if (dpadVertical >= -threshold && isDPadDownPressed)
        {
            isDPadDownPressed = false;  // 重置状态
        }

        // 检查DPad左方向
        if (dpadHorizontal < -threshold && !isDPadLeftPressed)
        {
            inputLog += "DPad Left Pressed\n";
            isDPadLeftPressed = true;
        }
        else if (dpadHorizontal >= -threshold && isDPadLeftPressed)
        {
            isDPadLeftPressed = false;  // 重置状态
        }

        // 检查DPad右方向
        if (dpadHorizontal > threshold && !isDPadRightPressed)
        {
            inputLog += "DPad Right Pressed\n";
            isDPadRightPressed = true;
        }
        else if (dpadHorizontal <= threshold && isDPadRightPressed)
        {
            isDPadRightPressed = false;  // 重置状态
        }
#elif UNITY_STANDALONE_OSX
        // Mac平台的DPad使用四个单独的按钮
        if (Input.GetButtonDown(StaticStrings.DPadUp)) inputLog += "DPad Up Pressed\n";
        if (Input.GetButtonDown(StaticStrings.DPadDown)) inputLog += "DPad Down Pressed\n";
        if (Input.GetButtonDown(StaticStrings.DPadLeft)) inputLog += "DPad Left Pressed\n";
        if (Input.GetButtonDown(StaticStrings.DPadRight)) inputLog += "DPad Right Pressed\n";
#endif

        // 检查LT和RT是否“按下”
        float ltValue = Input.GetAxis(StaticStrings.LT);
        float rtValue = Input.GetAxis(StaticStrings.RT);

        // LT按键处理：按下时显示一次"LT Pressed"
        if (ltValue > threshold && !isLTPressed)
        {
            inputLog += "LT Pressed\n";
            isLTPressed = true;
        }
        else if (ltValue <= threshold && isLTPressed)
        {
            isLTPressed = false;  // 重置状态
        }

        // RT按键处理：按下时显示一次"RT Pressed"
        if (rtValue > threshold && !isRTPressed)
        {
            inputLog += "RT Pressed\n";
            isRTPressed = true;
        }
        else if (rtValue <= threshold && isRTPressed)
        {
            isRTPressed = false;  // 重置状态
        }

        // 检查T键是否按下以显示左右摇杆的值
        if (Input.GetKeyDown(KeyCode.T))
        {
            // 读取左右摇杆的值
            float leftStickH = Input.GetAxis(StaticStrings.Horizontal);
            float leftStickV = Input.GetAxis(StaticStrings.Vertical);
            float rightStickH = Input.GetAxis(StaticStrings.RightHorizontal);
            float rightStickV = Input.GetAxis(StaticStrings.RightVertical);

            inputLog += $"Left Stick - Horizontal: {leftStickH}, Vertical: {leftStickV}\n";
            inputLog += $"Right Stick - Horizontal: {rightStickH}, Vertical: {rightStickV}\n";
        }

        // 显示并输出到Console
        if (!string.IsNullOrEmpty(inputLog))
        {
            displayText.text = inputLog;  // 显示到UI
            Debug.Log(inputLog);  // 输出到Console
        }
    }
}