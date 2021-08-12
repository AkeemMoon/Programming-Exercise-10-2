using System;
using static System.Console;
using System.Globalization;
class PhotoDemo
{
   static void Main()
   {
      Photo basePhoto = new Photo();
      Photo customPhoto = new Photo();
      MattedPhoto mattedPhoto = new MattedPhoto();
      FramedPhoto framedPhoto = new FramedPhoto();
      basePhoto.Width = 8;
      basePhoto.Height = 10;
      customPhoto.Width = 8;
      customPhoto.Height = 9;
      mattedPhoto.Width = 10;
      mattedPhoto.Height = 12;
      mattedPhoto.Color = "white";
      framedPhoto.Width = 8;
      framedPhoto.Height = 10;
      framedPhoto.Material = "silver";
      framedPhoto.Style = "modern";
      WriteLine(basePhoto.ToString());
      WriteLine(customPhoto.ToString());
      WriteLine(mattedPhoto.ToString());
      WriteLine(framedPhoto.ToString());
   }
}
   class Photo
   {
     private double width = 0;
     private double height = 0;
     protected double price;
     private const double WIDTHONE = 8;
     private const double HEIGHTONE = 10;
     private const double PRICEONE = 3.99;
     private const double WIDTHTWO = 10;
     private const double HEIGHTTWO = 12;
     private const double PRICETWO = 5.99;
     private const double OTHERPRICE = 9.99;
     public double Width
     {
       get
       {
         return width;
       }
       set
       {
         width = value;
         SetPrice(0);
       }
     }
     public double Height
     {
       get
       {
         return height;
       }
       set
       {
         height = value;
         SetPrice(0);
       }
     }
     public double Price
     {
       get
       {
         return price;
       }
     }
     protected void SetPrice(double premium)
     {
       if(Width == WIDTHONE && Height == HEIGHTONE)
       price = PRICEONE;
       else
       if(Width == WIDTHTWO && Height == HEIGHTTWO)
       price = PRICETWO;
       else
       price = OTHERPRICE;
       price += premium;
     }
     public override string ToString()
     {
       return(GetType() + " " + Width + "X" + Height + "  Price: " + Price.ToString("C", CultureInfo.GetCultureInfo("en-US")));
     }
   }
   class MattedPhoto : Photo
   {
     public const double PREMIUM = 10;
     public string Color {get; set;}
     public override string ToString()
     {
       SetPrice(PREMIUM);
       return(GetType() + "   " + Color + " matting " + Width + " X " + Height + " Price: " + Price.ToString("C", CultureInfo.GetCultureInfo("en-US")));
     }

   }
   class FramedPhoto : Photo
   {
     public const double PREMIUM = 25;
     public string Material {get; set;}
     public string Style {get; set;}
     public override string ToString()
     {
       SetPrice(PREMIUM);
       return(GetType() + "  " + Style + "," + Material + " frame." + Width + " X " + Height + " Price: " + Price.ToString("C", CultureInfo.GetCultureInfo("en-US")));
     }

   }

