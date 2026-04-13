using UnityEngine;

public class ScoringZone : MonoBehaviour
{
    public GameManager gameManager;
    public bool isLeftSide;
private void OnTriggerEnter2D(Collider2D collision)
{
    Debug.Log("Something entered the trigger");

    if (collision.GetComponent<Ball>() != null)
    {
        Debug.Log("Ball entered scoring zone!");

        if (isLeftSide)
        {
            gameManager.Player2Scores();
        }
        else
        {
            gameManager.Player1Scores();
        }
    }
}
}