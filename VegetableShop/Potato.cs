namespace VegetableShopApp
{
    public class Potato : Vegetable
    {
        public decimal Count { get; }

        public Potato(decimal basePrice, decimal count) : base(basePrice)
        {
            Count = count;
        }

        public override decimal Price => BasePrice * Count;

        public override string GetInfo() => $"Картопля - {Count} кг - Ціна: {Price:C}";
    }
}
