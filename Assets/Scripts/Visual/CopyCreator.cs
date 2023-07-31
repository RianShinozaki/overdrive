using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

public class CopyCreator : MonoBehaviour {
    [AssetsOnly]
    public GameObject SpritePrefab;
    SpriteRenderer[] copies;
    SpriteRenderer original;
    public bool visual;

    //Hee hee funny look up table
    Vector2 getOffset(int ID){
        switch(ID){
            case 0:
            return new Vector2(-1f, 1f);
            case 1:
            return new Vector2(0f, 1f);
            case 2: 
            return new Vector2(1f, 1f);
            case 3:
            return new Vector2(-1f, 0f);
            case 4:
            return new Vector2(1f, 0f);
            case 5:
            return new Vector2(-1f, -1f);
            case 6:
            return new Vector2(0f, -1f);
            case 7:
            return new Vector2(1f, -1f);
        }
        return Vector2.zero;
    }

    private void Awake() {
        original = GetComponent<SpriteRenderer>();
        if (!original) original = GetComponentInChildren<SpriteRenderer>();
        copies = new SpriteRenderer[8];

        Vector2 playfield = Playfield.Instance.PlayfieldSize;

        for(int i = 0; i < copies.Length; i++){
            copies[i] = Instantiate(SpritePrefab, (Vector2)transform.position + (getOffset(i) * playfield), Quaternion.identity, transform).GetComponentInChildren<SpriteRenderer>();
            copies[i].sortingOrder = original.sortingOrder;
            copies[i].sortingLayerID = original.sortingLayerID;
            if (!visual)
                copies[i].enabled = false;
        }
    }

    private void Update() {
        for(int i = 0; i < copies.Length; i++) {
            copies[i].sprite = original.sprite;
            copies[i].transform.position = (Vector2)transform.position + (getOffset(i) * Playfield.Instance.PlayfieldSize);
            copies[i].transform.rotation = transform.rotation;
            copies[i].color = original.color;
        }
    }
}