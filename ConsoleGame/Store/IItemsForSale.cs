namespace ConsoleGame {
    public interface IItemsForSale {
        int ItemId { get; set; }
        string Name { get; set; }
        string Status { get; set; }
        string Description { get; }
        int Price { get; set; }
        string Currency { get; set; }
        int Rating { get; set; }
        void Execute();
    }
}