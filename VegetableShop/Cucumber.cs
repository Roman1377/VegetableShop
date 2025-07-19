namespace VegetableShopApp
{
    public class Cucumber : Vegetable
    {
        public decimal Count { get; }

        public Cucumber(decimal basePrice, decimal count) : base(basePrice)
        {
            Count = count;
        }

        public override decimal Price => BasePrice * Count;

        public override string GetInfo() => $"Огірок - {Count} кг - Ціна: {Price:C}";
    }
}