using System;

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

    public class Carrot : Vegetable
    {
        public Carrot(decimal basePrice) : base(basePrice) { }

        public override decimal Price => BasePrice;
        public override string GetInfo() => $"Морква - Ціна: {Price:C}";
    }

    public class Tomato : Vegetable
    {
        public Tomato(decimal basePrice) : base(basePrice) { }

        public override decimal Price => BasePrice;
        public override string GetInfo() => $"Помідор - Ціна: {Price:C}";
    }

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
