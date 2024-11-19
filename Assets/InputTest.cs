using UnityEngine;
using UnityEngine.UI;  // 引用UI命名空间
using IT;

public class PS4ControllerTest : MonoBehaviour
{
    public Text inputText;  // 用于显示输入信息的Text组件

    // 用于跟踪D-Pad的上一次状态
    private float lastDPadHorizontal = 0f;
    private float lastDPadVertical = 0f;
    public bool isWindows = StaticStrings.isWindows;

    public string rv = StaticStrings.RightVertical;
    public string rh = StaticStrings.RightHorizontal;

    // 用于累积显示的信息
    private string displayText = "";

    void Update()
    {
        // 清空displayText
        displayText = "";

        // 测试左摇杆输入
        float horizontal = Input.GetAxis(StaticStrings.Horizontal);
        float vertical = Input.GetAxis(StaticStrings.Vertical);
        if (Mathf.Abs(horizontal) > 0.1f || Mathf.Abs(vertical) > 0.1f)
        {
            displayText += "左摇杆 - 水平: " + horizontal + ", 垂直: " + vertical + "\n";
        }

        // 测试右摇杆输入
        float rightHorizontal = Input.GetAxis(StaticStrings.RightHorizontal);
        float rightVertical = Input.GetAxis(StaticStrings.RightVertical);
        if (Mathf.Abs(rightHorizontal) > 0.1f || Mathf.Abs(rightVertical) > 0.1f)
        {
            displayText += "右摇杆 - 水平: " + rightHorizontal + ", 垂直: " + rightVertical + "\n";
        }

        // 测试按钮输入
        if (Input.GetButtonDown(StaticStrings.A))
        {
            displayText += "按下了按钮 A\n";
        }
        if (Input.GetButtonDown(StaticStrings.B))
        {
            displayText += "按下了按钮 B\n";
        }
        if (Input.GetButtonDown(StaticStrings.X))
        {
            displayText += "按下了按钮 X\n";
        }
        if (Input.GetButtonDown(StaticStrings.Y))
        {
            displayText += "按下了按钮 Y\n";
        }

        // 测试肩键和扳机键输入（将LT和RT作为按钮处理）
        if (Input.GetButtonDown(StaticStrings.LB))
        {
            displayText += "按下了按钮 LB\n";
        }
        if (Input.GetButtonDown(StaticStrings.RB))
        {
            displayText += "按下了按钮 RB\n";
        }
        if (Input.GetButtonDown(StaticStrings.LT))
        {
            displayText += "按下了按钮 LT\n";
        }
        if (Input.GetButtonDown(StaticStrings.RT))
        {
            displayText += "按下了按钮 RT\n";
        }

        // 测试D-Pad输入（视为四个独立的按钮）
        float dpadHorizontal = Input.GetAxis(StaticStrings.DPadHorizontal);
        float dpadVertical = Input.GetAxis(StaticStrings.DPadVertical);

        // D-Pad Left
        if (dpadHorizontal < -0.5f && lastDPadHorizontal >= -0.5f)
        {
            displayText += "按下了D-Pad Left\n";
        }
        // D-Pad Right
        if (dpadHorizontal > 0.5f && lastDPadHorizontal <= 0.5f)
        {
            displayText += "按下了D-Pad Right\n";
        }
        // D-Pad Up
        if (dpadVertical > 0.5f && lastDPadVertical <= 0.5f)
        {
            displayText += "按下了D-Pad Up\n";
        }
        // D-Pad Down
        if (dpadVertical < -0.5f && lastDPadVertical >= -0.5f)
        {
            displayText += "按下了D-Pad Down\n";
        }

        // 更新上一次的D-Pad状态
        lastDPadHorizontal = dpadHorizontal;
        lastDPadVertical = dpadVertical;

        // 测试菜单和视图按钮
        if (Input.GetButtonDown(StaticStrings.Menu))
        {
            displayText += "按下了Menu按钮\n";
        }
        if (Input.GetButtonDown(StaticStrings.View))
        {
            displayText += "按下了View按钮\n";
        }

        // 测试摇杆按下（L3和R3）
        if (Input.GetButtonDown(StaticStrings.L))
        {
            displayText += "按下了左摇杆按钮 (L3)\n";
        }
        if (Input.GetButtonDown(StaticStrings.R))
        {
            displayText += "按下了右摇杆按钮 (R3)\n";
        }

        // 更新Text组件的文本
        if (inputText != null)
        {
            if (displayText == "")
            {
                
            }
            else
            {
                inputText.text = displayText;
            }
        }
    }
}