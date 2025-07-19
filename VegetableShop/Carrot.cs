namespace VegetableShopApp
{
    public class Carrot : Vegetable
    {
        public Carrot(decimal basePrice) : base(basePrice) { }

        public override decimal Price => BasePrice;

        public override string GetInfo() => $"Морква - Ціна: {Price:C}";
    }
}