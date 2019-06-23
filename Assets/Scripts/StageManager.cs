using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BotejinUtil;

public class StageManager : MonoBehaviour
{
    [SerializeField]
    private Player Player;
    private Cell[] stage;

    // Start is called before the first frame update
    void Start()
    {
        Cell[] testMap = {
            new Cell(new Vector2(0, 0)),
            new Cell(new Vector2(1, 0)),
            new Cell(new Vector2(2, 0)),
            new Cell(new Vector2(3, 0)),
            new Cell(new Vector2(3, 1)),
            new Cell(new Vector2(3, 2)),
            new Cell(new Vector2(3, 3)),
            new Cell(new Vector2(4, 0)),
            new Cell(new Vector2(4, 1)),
            new Cell(new Vector2(4, 2)),
            new Cell(new Vector2(4, 3)),
            new Cell(new Vector2(5, 0)),
            new Cell(new Vector2(5, 3)),
            new Cell(new Vector2(6, 0))
        };
        testMap[12].Color = BColor.GREEN;
        testMap[12].IsGoal = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
