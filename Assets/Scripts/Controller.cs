using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    [SerializeField]
    private Renderer[] cursors = new Renderer[4];

    private void Start()
    {
        cursors[0].material.SetColor("_EmissionColor", Color.gray);
        cursors[1].material.SetColor("_EmissionColor", Color.grey);
        cursors[2].material.SetColor("_EmissionColor", Color.grey);
        cursors[3].material.SetColor("_EmissionColor", Color.grey);
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            cursors[0].material.color = Color.white;
            cursors[0].material.SetColor("_EmissionColor", Color.white);
            cursors[1].material.SetColor("_EmissionColor", Color.grey);
            cursors[2].material.SetColor("_EmissionColor", Color.grey);
            cursors[3].material.SetColor("_EmissionColor", Color.grey);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            cursors[1].material.color = Color.white;
            cursors[1].material.SetColor("_EmissionColor", Color.white);
            cursors[0].material.SetColor("_EmissionColor", Color.grey);
            cursors[2].material.SetColor("_EmissionColor", Color.grey);
            cursors[3].material.SetColor("_EmissionColor", Color.grey);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            cursors[2].material.color = Color.white;
            cursors[2].material.SetColor("_EmissionColor", Color.white);
            cursors[1].material.SetColor("_EmissionColor", Color.grey);
            cursors[0].material.SetColor("_EmissionColor", Color.grey);
            cursors[3].material.SetColor("_EmissionColor", Color.grey);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            cursors[3].material.color = Color.white;
            cursors[3].material.SetColor("_EmissionColor", Color.white);
            cursors[1].material.SetColor("_EmissionColor", Color.grey);
            cursors[2].material.SetColor("_EmissionColor", Color.grey);
            cursors[0].material.SetColor("_EmissionColor", Color.grey);
        }
    }
    public static IEnumerator isPressed()
    {
        if (Notes._distance >= 0f && Notes._distance <= 0.1f && Notes._dest.GetComponentInParent<Renderer>().material.color == Color.white)
        {
            GameManager.Scoring(200f);
            Destroy(GameObject.FindGameObjectWithTag("note"));
            Notes._dest.GetComponentInParent<Renderer>().material.SetColor("_EmissionColor", Color.green);
            yield return new WaitForSeconds(0.2f);
            Notes._dest.GetComponentInParent<Renderer>().material.SetColor("_EmissionColor", Color.white);
        }
        else 
        { 
            GameManager.Scoring(100f);
            Notes._dest.GetComponentInParent<Renderer>().material.SetColor("_EmissionColor", Color.red);
        }
        yield return new WaitForSeconds(0.2f);
        Notes._dest.GetComponentInParent<Renderer>().material.SetColor("_EmissionColor", Color.white);

    }
}
