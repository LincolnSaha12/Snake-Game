using UnityEngine;

public class foodscpt : MonoBehaviour
{
    public BoxCollider2D gridarea;

    private void Start()
    {
        randomizedposition();
    }

    private void randomizedposition()
    {
        Bounds bounds = this.gridarea.bounds;

        float x = Random.Range(bounds.min.x, bounds.max.x);
        float y = Random.Range(bounds.min.y, bounds.max.y);

        this.transform.position = new Vector3(Mathf.Round(x), Mathf.Round(y), 0.0f);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            randomizedposition();
        }

    }
}
