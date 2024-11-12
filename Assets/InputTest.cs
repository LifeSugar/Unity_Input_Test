using UnityEngine;
using UnityEngine.UI;

public class XboxControllerFullTest : MonoBehaviour
{
    public Text displayText;  // UI显示的Text对象
    private const float threshold = 0.5f;  // 阈值，用于判断DPad和扳机键是否按下

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
        if (Input.GetButtonDown("A"))
        {
            inputLog += "A Pressed\n";
        }
        if (Input.GetButtonDown("B"))
        {
            inputLog += "B Pressed\n";
        }
        if (Input.GetButtonDown("X"))
        {
            inputLog += "X Pressed\n";
        }
        if (Input.GetButtonDown("Y"))
        {
            inputLog += "Y Pressed\n";
        }
        if (Input.GetButtonDown("LB"))
        {
            inputLog += "LB Pressed\n";
        }
        if (Input.GetButtonDown("RB"))
        {
            inputLog += "RB Pressed\n";
        }
        if (Input.GetButtonDown("L"))
        {
            inputLog += "L Pressed\n";
        }
        if (Input.GetButtonDown("R"))
        {
            inputLog += "R Pressed\n";
        }
        if (Input.GetButtonDown("View"))
        {
            inputLog += "View Pressed\n";
        }
        if (Input.GetButtonDown("Menu"))
        {
            inputLog += "Menu Pressed\n";
        }

        // 检查DPad是否“按下”
        float dpadHorizontal = Input.GetAxis("DPadHorizontal");
        float dpadVertical = Input.GetAxis("DPadVertical");
        if (Mathf.Abs(dpadHorizontal) > threshold)
        {
            inputLog += "DPad Horizontal Pressed\n";
        }
        if (Mathf.Abs(dpadVertical) > threshold)
        {
            inputLog += "DPad Vertical Pressed\n";
        }

        // 检查LT和RT是否“按下”
        float ltValue = Input.GetAxis("LT");
        float rtValue = Input.GetAxis("RT");
        if (ltValue > threshold)
        {
            inputLog += "LT Pressed\n";
        }
        if (rtValue > threshold)
        {
            inputLog += "RT Pressed\n";
        }

        // 检查T键是否按下以显示左右摇杆的值
        if (Input.GetKeyDown(KeyCode.T))
        {
            // 读取左右摇杆的值
            float leftStickH = Input.GetAxis("Horizontal");
            float leftStickV = Input.GetAxis("Vertical");
            float rightStickH = Input.GetAxis("RightHorizontal");
            float rightStickV = Input.GetAxis("RightVertical");

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
