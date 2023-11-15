using Microsoft.AspNetCore.Components;

namespace BlazorServerTuto.Pages
{
    public class MagicNumberBase : ComponentBase
    {
        protected const int borderMin = 0;
        protected const int borderMax = 20;
        protected const int nbLivesMax = 5;

        protected override void OnInitialized()
        {
            ReinitGame();
            base.OnInitialized();
        }

        protected void ReinitGame()
        {
            Random random = new();
            magicNumber = random.Next(borderMin, borderMax+1);
            nbRemainingLives = nbLivesMax;
            gameWon = null;
        }

        protected int guess;
        protected int nbRemainingLives;
        private int magicNumber;
        protected bool? gameWon;

        protected void TestGuess()
        {
            if (guess == magicNumber) gameWon = true;
            else
            {
                 if (--nbRemainingLives == 0) gameWon = false;
            }
        }
    }
}