using UnityEngine;
using UnityEngine.Rendering;

public class piecesScript : MonoBehaviour
{
    public PuzzleManager puzzleManager;
    private Vector3 RightPosition;
    public bool InRightPosition;
    public bool Selected;


    // Start is called before the first frame update
    void Start()
    {
        RightPosition = transform.position;
        transform.position = new Vector3(Random.Range(-200f, 300f), Random.Range(250f, -200f), 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, RightPosition) < 20f)
        {
            if (!Selected)
            {
                if (InRightPosition == false)
                {
                    transform.position = RightPosition;
                    InRightPosition = true;
                    GetComponent<SortingGroup>().sortingOrder = 0;
                    GetComponent<BoxCollider2D>().enabled = false;
                    puzzleManager.CheckAllPieces();
                }
            }
        }
    }
}
