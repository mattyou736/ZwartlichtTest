using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] buttons;
    public Animator anim;
    public GameObject allContent;
    public GameObject contentArea;

    private void Start()
    {
        foreach (var button in buttons)
        {
            GameObject button_ = Instantiate(button);
            button_.transform.SetParent(contentArea.transform);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
    public void AnimationTrigger(int animNumber)
    {
        if(animNumber == 1)
        {
            anim.SetBool("anim-1", true);
            anim.SetBool("anim-2", false);
            anim.SetBool("anim-3", false);
        }
        else if(animNumber == 2)
        {
            anim.SetBool("anim-1", false);
            anim.SetBool("anim-2", true);
            anim.SetBool("anim-3", false);
        }
        else
        {
            anim.SetBool("anim-1", false);
            anim.SetBool("anim-2", false);
            anim.SetBool("anim-3", true);
        }
        allContent.SetActive(false);
    }

    public void Reactivate()
    {
        allContent.SetActive(true);
    }
}
