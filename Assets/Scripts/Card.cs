using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    public int idx = 0;

    public GameObject front;
    public GameObject back;

    public Animator anim;

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


    public void OpenCard()
    {
        anim.SetBool("isOpen", true);
        front.SetActive(true);
        back.SetActive(false);
    }

    //카드 닫기 함수
    void CloseCardInvoke()
    {
        //카드 닫을 때마다 색상 변경
        backImage.color = new Color(backImage.color.r - 0.1f, backImage.color.g - 0.1f, backImage.color.b - 0.1f);
    }
}
