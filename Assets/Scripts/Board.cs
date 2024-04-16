using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Board : MonoBehaviour
{
    public GameObject card;

    void Start()
    {
        int[] arr = { 0, 0, 1, 1, 2, 2, 3, 3, 4, 4, 5, 5 };
        arr = arr.OrderBy(x => Random.Range(0, arr.Length)).ToArray();

        for (int i = 0; i < 12; i++)
        {
            GameObject go =  Instantiate(card, this.transform);
            float x = (i % 3) * 1.6f - 1.6f;
            float y = (i / 3) * 1.6f - 3.5f;

            go.transform.position = new Vector2(x, y);
            go.GetComponent<Card>().Setting(arr[i]);
        }

        GameManager.instance.cardCount = arr.Length;
    }
}
