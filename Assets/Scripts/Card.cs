using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    int idx = 0;

    public SpriteRenderer frontImage;
    public SpriteRenderer backImage;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Setting(int num)
    {
        idx = num;
        frontImage.sprite = Resources.Load<Sprite>($"{idx}");
    }


    //카드 닫기 함수입니다.
    void CloseCardInvoke()
    {
        backImage.color = new Color(backImage.color.r - 0.1f, backImage.color.g - 0.1f, backImage.color.b - 0.1f);
    }
}
