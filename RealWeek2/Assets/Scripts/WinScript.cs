using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class WinScript : MonoBehaviour
{
    public Transform player;
    public Transform goal;
    private float winDistance = 1.5f;

    private bool hasWon = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    { 
    }

    // Update is called once per frame
    void Update()
    {
        if (hasWon) return;
        float distance = Vector3.Distance(player.position, goal.position);

        if (distance <= winDistance)
        {
            hasWon = true;
            WinGame();
        }
    }
   void WinGame()
        {
            Debug.Log("You Win!");

        }
    }
