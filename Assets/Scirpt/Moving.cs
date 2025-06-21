using UnityEngine;

public class Moving : MonoBehaviour
{
    [SerializeField] private Transform ponitA;
    [SerializeField] private Transform ponitB;
    [SerializeField] private float speed = 2f;
    private Vector3 target;
    private Transform player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        target = ponitA.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
        if (Vector3.Distance(transform.position, target) < 0.1f)
        {
            if (target == ponitA.position)
            {
                target = ponitB.position;

            }
            else
            {
                target = ponitA.position;
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.transform.SetParent(transform);
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            collision.transform.SetParent(null);
        }

    }

}
