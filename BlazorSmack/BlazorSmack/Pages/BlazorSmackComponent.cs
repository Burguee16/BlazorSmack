using BlazorSmack.Models;

namespace BlazorSmack.Pages
{
    public partial class BlazorSmackComponent
    {
        int score = 0;
        int currentTime = 10;
        int hitPosition = 0;
        string message = "";
        int gameSpeed = 1000;
        bool isGameRunning = true;

        public List<SquareModel> Squares { get; set; } =
            new List<SquareModel>();
        
        public BlazorSmackComponent()
        {
            for(int i = 0; i < 9; i++)
            {
                Squares.Add(new SquareModel { Id = i });
            }
        }
    }
}
