namespace VegetableShopApp
{
    public abstract class Vegetable
    {
        protected decimal BasePrice;

        public Vegetable(decimal basePrice)
        {
            BasePrice = basePrice;
        }

        public abstract decimal Price { get; }
        public abstract string GetInfo();
    }
}