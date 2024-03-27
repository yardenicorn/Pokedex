using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject UI;
    GameCanvasUI gameCanvasUI;

    // Start is called before the first frame update
    void Start()
    {
        gameCanvasUI = UI.GetComponent<GameCanvasUI>();
        if (gameCanvasUI == null) { Debug.Log("No UI object In UI Object"); }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
