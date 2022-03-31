using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectButton : MonoBehaviour
{

    public Content content;
    Text title;
    GameManager gameman;

    // Start is called before the first frame update
    void Start()
    {
        gameman = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
        title = GetComponentInChildren<Text>();
        title.text = content.title;
    }

    public void OnButtonClick(int id)
    {
        gameman.AnimationTrigger(id);
    }
}
