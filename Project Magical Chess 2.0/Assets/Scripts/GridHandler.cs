using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class GridHandler : MonoBehaviour
{
    //WE WILL STORE STUFF HERE.
    public static GridHandler instance;

    [Header("TILEMAPS")]
    [SerializeField] public Tilemap groundMap;
    [SerializeField] public Tilemap highlighterMap;
    [SerializeField] public Tilemap attackerMap;
    [SerializeField] public Tilemap moveMap;
    [SerializeField] public Tilemap wallMap;

    [Header("TILEBASES")]
    [SerializeField] public TileBase highlighterTile;
    [SerializeField] public TileBase canAttackTile;
    [SerializeField] public TileBase cannotAttackTile;
    [SerializeField] public TileBase moveTile;


    private void Awake()
    {
        instance = this;
    }
    


}
