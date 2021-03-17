using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPatternDp_Hands_On3
{
    abstract class PackageBuilder
    {
        protected Product product;
        public Product Product
        {
            get { return product; }
        }
        public abstract void BuildSweet();
        public abstract void BuildSavory();
       

    }
    class ChildBuilder : PackageBuilder

    {
        //private Product product = new Product();

        //public override void BuildSweet()
        //{
        //    product.Add("2 sweets");
        //}

        //public override void BuildSavory()
        //{
        //    product.Add("1 savory,");
        //}

        //public override Product GetResult()
        //{
        //    return product;
        //}

        public ChildBuilder()
        {
            product = new Product("Child");
        }
        public override void BuildSweet()
        {
            product["sweets"] = "2";
        }
        public override void BuildSavory()
        {
            product["savory"] = "1";
        }
    }

    /// <summary>

    /// The 'ConcreteBuilder2' class

    /// </summary>

    class AdultBuilder : PackageBuilder

    {
        //private Product product = new Product();

        //public override void BuildSweet()
        //{
        //    product.Add("2 sweets,");
        //}

        //public override void BuildSavory()
        //{
        //    product.Add("2 savories");
        //}

        //public override Product GetResult()
        //{
        //    return product;
        //}



        public AdultBuilder()
        {
            product = new Product("Child");
        }
        public override void BuildSweet()
        {
            product["sweets"] = "2";
        }
        public override void BuildSavory()
        {
            product["savory"] = "2";
        }
    }


}
