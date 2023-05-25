namespace BlazingPizza.Client
{
    public class OrderState
    {
        public bool ShowingConfigureDialog { get; private set; }

        public Pizza ConfiguringPizza { get; private set; }

        public Order Order { get; private set; } = new Order();
    }
}
