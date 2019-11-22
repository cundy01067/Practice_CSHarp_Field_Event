using UnityEngine;

public class GGGGGG : MonoBehaviour
{
    [Header("移動速度") , Range(0 , 999)]
    public float Speed = 10.0F;
    [Header("跳躍高度") , Range(0 , 999)]
    public int Jump = 200;
    [Header("對話內容")]
    public string Talk = "咕咕咕~~";
    [Header("是否取得雞蛋")]
    public bool Egg;



    private void Start()
    {
        print("遊戲開始");
    }


    private void Update()
    {
        print("咕咕咕~~");
    }
}
