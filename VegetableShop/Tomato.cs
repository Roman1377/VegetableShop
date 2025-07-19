namespace VegetableShopApp
{
    public class Tomato : Vegetable
    {
        public Tomato(decimal basePrice) : base(basePrice) { }

        public override decimal Price => BasePrice;

        public override string GetInfo() => $"Помідор - Ціна: {Price:C}";
    }
}