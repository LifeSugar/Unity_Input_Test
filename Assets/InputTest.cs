using UnityEngine;
using IT;

public class PS4ControllerTest : MonoBehaviour
{
    // 用于跟踪D-Pad的上一次状态
    private float lastDPadHorizontal = 0f;
    private float lastDPadVertical = 0f;

    void Update()
    {
        // 测试左摇杆输入
        float horizontal = Input.GetAxis(StaticStrings.Horizontal);
        float vertical = Input.GetAxis(StaticStrings.Vertical);
        if (Mathf.Abs(horizontal) > 0.1f || Mathf.Abs(vertical) > 0.1f)
        {
            Debug.Log("左摇杆 - 水平: " + horizontal + ", 垂直: " + vertical);
        }

        // 测试右摇杆输入
        float rightHorizontal = Input.GetAxis(StaticStrings.RightHorizontal);
        float rightVertical = Input.GetAxis(StaticStrings.RightVertical);
        if (Mathf.Abs(rightHorizontal) > 0.1f || Mathf.Abs(rightVertical) > 0.1f)
        {
            Debug.Log("右摇杆 - 水平: " + rightHorizontal + ", 垂直: " + rightVertical);
        }

        // 测试按钮输入
        if (Input.GetButtonDown(StaticStrings.A))
        {
            Debug.Log("按下了按钮 A");
        }
        if (Input.GetButtonDown(StaticStrings.B))
        {
            Debug.Log("按下了按钮 B");
        }
        if (Input.GetButtonDown(StaticStrings.X))
        {
            Debug.Log("按下了按钮 X");
        }
        if (Input.GetButtonDown(StaticStrings.Y))
        {
            Debug.Log("按下了按钮 Y");
        }

        // 测试肩键和扳机键输入（将LT和RT作为按钮处理）
        if (Input.GetButtonDown(StaticStrings.LB))
        {
            Debug.Log("按下了按钮 LB");
        }
        if (Input.GetButtonDown(StaticStrings.RB))
        {
            Debug.Log("按下了按钮 RB");
        }
        if (Input.GetButtonDown(StaticStrings.LT))
        {
            Debug.Log("按下了按钮 LT");
        }
        if (Input.GetButtonDown(StaticStrings.RT))
        {
            Debug.Log("按下了按钮 RT");
        }

        // 测试D-Pad输入（视为四个独立的按钮）
        float dpadHorizontal = Input.GetAxis(StaticStrings.DPadHorizontal);
        float dpadVertical = Input.GetAxis(StaticStrings.DPadVertical);

        // D-Pad Left
        if (dpadHorizontal < -0.5f && lastDPadHorizontal >= -0.5f)
        {
            Debug.Log("按下了D-Pad Left");
        }
        // D-Pad Right
        if (dpadHorizontal > 0.5f && lastDPadHorizontal <= 0.5f)
        {
            Debug.Log("按下了D-Pad Right");
        }
        // D-Pad Up
        if (dpadVertical > 0.5f && lastDPadVertical <= 0.5f)
        {
            Debug.Log("按下了D-Pad Up");
        }
        // D-Pad Down
        if (dpadVertical < -0.5f && lastDPadVertical >= -0.5f)
        {
            Debug.Log("按下了D-Pad Down");
        }

        // 更新上一次的D-Pad状态
        lastDPadHorizontal = dpadHorizontal;
        lastDPadVertical = dpadVertical;

        // 测试菜单和视图按钮
        if (Input.GetButtonDown(StaticStrings.Menu))
        {
            Debug.Log("按下了Menu按钮");
        }
        if (Input.GetButtonDown(StaticStrings.View))
        {
            Debug.Log("按下了View按钮");
        }

        // 测试摇杆按下（L3和R3）
        if (Input.GetButtonDown(StaticStrings.L))
        {
            Debug.Log("按下了左摇杆按钮 (L3)");
        }
        if (Input.GetButtonDown(StaticStrings.R))
        {
            Debug.Log("按下了右摇杆按钮 (R3)");
        }
    }
}