using System;
namespace myRetail_StephanieRatanas.Models
{
    
    public class FinalObjectModel
    {
       
        public FinalProduct finalProduct { get; set; }

        public string _id { get; set; }

    }

    public class FinalProduct
    {

        public finalItem finalItem { get; set; }
    }

    public class finalItem
    {
        
        public string finalProduct_Id { get; set; }

        public FinalProduct_decription finalProduct_description { get; set; }

    }

    public class FinalProduct_decription
    {

        public string finalTitle { get; set; }

        public decimal finalPrice { get; set; }
    }
}
