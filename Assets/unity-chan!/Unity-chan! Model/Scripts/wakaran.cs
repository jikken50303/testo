using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class wakaran : MonoBehaviour
{
    // 確認用GameObject
    public SpriteRenderer A;
    public SpriteRenderer B;
    public SpriteRenderer IndexR;
    public SpriteRenderer MiddleR;
    public TextMesh StickR;
    public SpriteRenderer X;
    public SpriteRenderer Y;
    public SpriteRenderer IndexL;
    public SpriteRenderer MiddleL;
    public TextMesh StickL;
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        // ボタン状態取得
        CheckButton(OVRInput.RawButton.A, OVRInput.RawTouch.A, A);
        CheckButton(OVRInput.RawButton.B, OVRInput.RawTouch.B, B);
        CheckButton(OVRInput.RawButton.X, OVRInput.RawTouch.X, X);
        CheckButton(OVRInput.RawButton.Y, OVRInput.RawTouch.Y, Y);
        CheckButton(OVRInput.RawButton.RIndexTrigger, OVRInput.RawTouch.RIndexTrigger, IndexR);
        CheckButton(OVRInput.RawButton.LIndexTrigger, OVRInput.RawTouch.LIndexTrigger, IndexL);
        CheckButton(OVRInput.RawButton.RHandTrigger, MiddleR);
        CheckButton(OVRInput.RawButton.LHandTrigger, MiddleL);
        // アナログスティック値取得
        Vector2 vectorR = OVRInput.Get(OVRInput.RawAxis2D.RThumbstick);
        Vector2 vectorL = OVRInput.Get(OVRInput.RawAxis2D.LThumbstick);
        StickR.text = string.Format("({0:0.00},{1:0.00})", vectorR.x, vectorR.y);
        StickL.text = string.Format("({0:0.00},{1:0.00})", vectorL.x, vectorL.y);
    }
    private void CheckButton(OVRInput.RawButton button, OVRInput.RawTouch touch, SpriteRenderer spRender)
    {
        if (OVRInput.Get(button))
        {
            // ボタンを押しているとき
            spRender.color = Color.red;
        }
        else if (OVRInput.Get(touch))
        {
            // ボタンをタッチしているとき
            spRender.color = Color.yellow;
        }
        else
        {
            // ボタンを押してもタッチもしていないとき
            spRender.color = Color.white;
        }
    }
    private void CheckButton(OVRInput.RawButton button, SpriteRenderer spRender)
    {
        if (OVRInput.Get(button))
        {
            // ボタンを押しているとき
            spRender.color = Color.red;
        }
        else
        {
            // ボタンを押していないとき
            spRender.color = Color.white;
        }
    }
}