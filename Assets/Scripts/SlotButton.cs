using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SlotButton : MonoBehaviour
{ 
    private RandomAssets randomassetsScript;
    private RaycastHit2D hit;

    public Sprite NormalButSprite;
    public Sprite EnterButSprite;

    // Start is called before the first frame update
    void Start()
    {
        if (randomassetsScript == null) { randomassetsScript = Object.FindObjectOfType<RandomAssets>(); }
    }

    // Update is called once per frame
    void Update()
    {
        hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

        ExitSlotButton();
    }
    
    public void EnterSlotButton()
    {
        if (hit.collider != null && hit.collider.tag == "Button")
        {
            this.transform.GetComponent<SpriteRenderer>().sprite = EnterButSprite;
            randomassetsScript.RandomBox();
        }

    }

    public void ExitSlotButton()
    {
        if (Input.GetMouseButtonUp(0))
        {
            this.transform.GetComponent<SpriteRenderer>().sprite = NormalButSprite;
        }
    }

}
