using System.Collections.Generic;
using UnityEngine;

public partial class LevelScrolling : MonoBehaviour {

    public float ScrollingSpeed;
    public GameObject Prefab;
    public List<SpriteSequence> SpriteSequences = new List<SpriteSequence>();
    
    public Sprite ReferenceSprite;
    public int SortingOrder;

    private Transform _lineTransform;
    private bool _isCharged = false;

    private void Awake() {
        _lineTransform = GetComponent<Transform>();
    }

    private void Start() {
        float xSize = ReferenceSprite.bounds.size.x;
        int count = 0;
        foreach(SpriteSequence spriteSequence in SpriteSequences) {
            for (int i = 0; i < spriteSequence.Number; i++) {
                Vector3 position = transform.position - new Vector3(count * xSize, 0, 0);
                SpriteRenderer spriteRenderer = Instantiate(Prefab, position, Quaternion.identity, transform).GetComponent<SpriteRenderer>();
                spriteRenderer.sprite = spriteSequence.Sprite;
                spriteRenderer.sortingOrder = SortingOrder;
                count++;
            }
        }
        Invoke("Scroller", 2f);
    }

    private void FixedUpdate() {
        if (_isCharged)
        {
            _lineTransform.Translate(ScrollingSpeed, 0, 0);
        }
    }

    private void Scroller() {
        _isCharged = true;
    }
}