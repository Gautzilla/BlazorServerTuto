using Microsoft.AspNetCore.Components;

namespace BlazorServerTuto.Pages
{
    public class CounterBase : ComponentBase
    {
        protected int currentCount = 0;

        [Parameter]
        public int Value { get => currentCount; set => currentCount = value; }

        protected void IncrementCount()
        {
            currentCount++;
        }
    }
}