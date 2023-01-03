using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace fdddfdfs.Leaderboard
{
    public class Tester : MonoBehaviour
    {
        [SerializeField] private LeaderboardController _leaderboardController;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.O))
            {
                _leaderboardController.ChangeLeaderboardActive("Leaders");
            }
            else if (Input.GetKeyDown(KeyCode.A))
            {
                _leaderboardController.UploadResult(Random.Range(0, 100));
            }
        }
    }
}