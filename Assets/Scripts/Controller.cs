using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    [SerializeField]
    private Renderer[] cursors = new Renderer[4];

    private void Start()
    {
        cursors[0].material.color = Color.gray;
        cursors[1].material.color = Color.gray;
        cursors[2].material.color = Color.gray;
        cursors[3].material.color = Color.gray;
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            cursors[0].material.color = Color.white;
            cursors[1].material.color = Color.gray;
            cursors[2].material.color = Color.gray;
            cursors[3].material.color = Color.gray;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            cursors[1].material.color = Color.white;
            cursors[0].material.color = Color.gray;
            cursors[2].material.color = Color.gray;
            cursors[3].material.color = Color.gray;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            cursors[2].material.color = Color.white;
            cursors[1].material.color = Color.gray;
            cursors[0].material.color = Color.gray;
            cursors[3].material.color = Color.gray;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            cursors[3].material.color = Color.white;
            cursors[1].material.color = Color.gray;
            cursors[2].material.color = Color.gray;
            cursors[0].material.color = Color.gray;
        }
    }
    public static IEnumerator isPressed()
    {
        if (Notes._distance >= 0f && Notes._distance <= 0.4f && Notes._dest.GetComponentInParent<Renderer>().material.color == Color.white)
        {
            GameManager.Scoring(200f);
            Destroy(GameObject.FindGameObjectWithTag("note"));
            Notes._dest.GetComponentInParent<Renderer>().material.color = Color.green;
            yield return new WaitForSeconds(0.2f);
            Notes._dest.GetComponentInParent<Renderer>().material.color = Color.white;
        }
        else 
        { 
            GameManager.Scoring(100f);
            Notes._dest.GetComponentInParent<Renderer>().material.color = Color.red;
        }
        yield return new WaitForSeconds(0.2f);
        Notes._dest.GetComponentInParent<Renderer>().material.color = Color.white;

    }
}
