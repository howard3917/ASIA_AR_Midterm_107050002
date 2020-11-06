using UnityEditor;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class GameManager : MonoBehaviour
{
    [Header("男")] 
    public Transform male;
    [Header("女")]
    public Transform female;
    [Header("虛擬搖桿")]
    public FloatingJoystick joystick;
    [Header("旋轉速度"),Range(0.1f, 20f)]
    public float turn = 1.5f;
    [Header("縮放"), Range(0f, 5f)]
    public float size = 0.3f;

    private void Start()
    {
        print("開始事件");

    }


    private void Update()
    {
        print("更新事件");
        print ("joystick Vertical");

        male.Rotate(0, joystick.Horizontal* turn, 0);
        female.Rotate(0, joystick.Horizontal * turn, 0);

        male.localScale =new Vector3(1, 1, 1) * joystick.Vertical;

        female.localScale = new Vector3(1, 1, 1) * joystick.Vertical;
    }



}
