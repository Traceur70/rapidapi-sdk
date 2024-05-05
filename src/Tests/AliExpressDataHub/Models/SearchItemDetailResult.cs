using System.Text.Json.Serialization;
using T70.Tests.AliExpressDataHub.Models;

namespace RapidApiSdk.AliExpressDataHub.Models;


[JsonSourceGenerationOptions(WriteIndented = false, PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase )]
[JsonSerializable(typeof(SearchResult))]
public partial class SearchItemDetailResultJsonContext : JsonSerializerContext
{
}

public class SearchItemDetailResult
{
    public Item? Item { get; set; }

    public SearchItemDetailResultSettings? Settings { get; set; }
    public SearchItemDetailResultReviews? Reviews { get; set; }
    public SearchItemDetailResultDelivery? Delivery { get; set; }
    public SearchItemDetailResultService[]? Service { get; set; }
    public SearchItemDetailResultSeller? Seller { get; set; }
        


}

public class SearchItemDetailResultSeller
{
    public int SellerId { get; set; }
    public string? StoreTitle { get; set; }
    public int StoreId { get; set; }
    public int CompanyId { get; set; }
    public string? StoreUrl { get; set; }
    public string? StoreImage { get; set; }
    public string? StoreRating { get; set; }
}

public class SearchItemDetailResultService
{
    public string? Title { get; set; }
    public string? Desc { get; set; }
    public string? Icon { get; set; }
}

public class SearchItemDetailResultDelivery
{
    public string? ShippingFrom { get; set; }
    public string? ShippingFromCode { get; set; }
    public string? ShippingTo { get; set; }
    public string? ShippingToCode { get; set; }
    public int ShippingOutDays { get; set; }
    public SearchItemDetailResultDeliveryShipping[]? ShippingList { get; set; }
    public SearchItemDetailResultDeliveryPackageDetail? PackageDetail { get; set; }

}

public class SearchItemDetailResultDeliveryPackageDetail
{
    public double Weight { get; set; }
    public double Length { get; set; }
    public double Height { get; set; }
    public double Width { get; set; }
}

public class SearchItemDetailResultDeliveryShipping
{
    public string? ShippingFrom { get; set; }
    public string? ShippingFromCode { get; set; }
    public string? ShippingTo { get; set; }
    public string? ShippingToCode { get; set; }
    public string? ShippingFee { get; set; }
    public string? ShippingCompany { get; set; }
    public int ShippingTime { get; set; }
    public string? EstimateDeliveryDate { get; set; }
    public bool TrackingAvailable { get; set; }
    public string[]? Note { get; set; }
}

public class SearchItemDetailResultReviews
{
    public int Count { get; set; }
    public string? AverageStarRate { get; set; }
}


public class SearchItemDetailResultSettings
{
    public string? Locale { get; set; }
    public string? Currency { get; set; }
    public string? Country { get; set; }
    public string? ItemId { get; set; }
}

public class SearchResult
{
    public SearchItemDetailResult? Result {  get; set; }

    public static readonly string Json = @"{
  ""result"": {
    ""status"": {
      ""code"": 200,
      ""data"": ""success"",
      ""executionTime"": ""0.86"",
      ""requestTime"": ""2023-11-03 19:31:40"",
      ""requestId"": ""194983ecf52c614e8d81392b4d4ce233"",
      ""endpoint"": ""item_detail"",
      ""apiVersion"": ""3.2.4"",
      ""functionsVersion"": ""3.0.8"",
      ""la"": ""0.03"",
      ""pmu"": 758864,
      ""mu"": 733160
    },
    ""settings"": {
      ""locale"": ""en_US"",
      ""currency"": ""USD"",
      ""country"": ""US"",
      ""itemId"": ""3256804591426248""
    },
    ""item"": {
      ""available"": false,
      ""itemId"": ""3256804591426248"",
      ""title"": ""Professional S6S Mini GPS Drone RC Toy 4K HD Dual Camera 5G WIFI FPV Brushless Folding Quadcopter Remote Control Helicopter Toys"",
      ""catId"": 200001411,
      ""sales"": ""0"",
      ""wishCount"": 9,
      ""itemUrl"": ""//www.aliexpress.com/item/3256804591426248.html"",
      ""images"": [
        ""//ae01.alicdn.com/kf/Sfee7f6b87f1340f2a81086a4ec233d90a/Professional-S6S-Mini-GPS-Drone-RC-Toy-4K-HD-Dual-Camera-5G-WIFI-FPV-Brushless-Folding.jpg"",
        ""//ae01.alicdn.com/kf/Sbe068f55f1a14941b55ee14245eac0ff3/Professional-S6S-Mini-GPS-Drone-RC-Toy-4K-HD-Dual-Camera-5G-WIFI-FPV-Brushless-Folding.jpg"",
        ""//ae01.alicdn.com/kf/Sd6526101f9cf4ad0a74b4a65ba3e4f45Q/Professional-S6S-Mini-GPS-Drone-RC-Toy-4K-HD-Dual-Camera-5G-WIFI-FPV-Brushless-Folding.jpg"",
        ""//ae01.alicdn.com/kf/Sb72230d5e19341b88347b154d0e2acdf9/Professional-S6S-Mini-GPS-Drone-RC-Toy-4K-HD-Dual-Camera-5G-WIFI-FPV-Brushless-Folding.jpg"",
        ""//ae01.alicdn.com/kf/S346d691665c145789af9ceab14f668c4g/Professional-S6S-Mini-GPS-Drone-RC-Toy-4K-HD-Dual-Camera-5G-WIFI-FPV-Brushless-Folding.jpg"",
        ""//ae01.alicdn.com/kf/S23b0dd0c43ea4a80aaa8856f159602c1T/Professional-S6S-Mini-GPS-Drone-RC-Toy-4K-HD-Dual-Camera-5G-WIFI-FPV-Brushless-Folding.jpg""
      ],
      ""video"": {
        ""id"": 1100089492329,
        ""thumbnail"": ""//ae01.alicdn.com/kf/Sfee7f6b87f1340f2a81086a4ec233d90a/Professional-S6S-Mini-GPS-Drone-RC-Toy-4K-HD-Dual-Camera-5G-WIFI-FPV-Brushless-Folding.jpg_960x960.jpg"",
        ""url"": ""//video.aliexpress-media.com/play/u/ae_sg_item/3538245607/p/1/e/6/t/10301/1100089492329.mp4""
      },
      ""properties"": {
        ""cut"": ""Video Capture Resolution / Indoor/Outdoor Use / Model Number / Controller Mode / Flight Time / Control Channels / Controller Battery / Charging Time / Power Source / Remote Distance / Remote Control / Package Includes / Material / Brand Name / Aerial Photography / Origin / Recommend Age / Type / Features"",
        ""list"": [
          {
            ""name"": ""Video Capture Resolution"",
            ""value"": ""1080p FHD,Other""
          },
          {
            ""name"": ""Indoor/Outdoor Use"",
            ""value"": ""Outdoor""
          },
          {
            ""name"": ""Model Number"",
            ""value"": ""Mini S6s""
          },
          {
            ""name"": ""Controller Mode"",
            ""value"": ""MODE2""
          },
          {
            ""name"": ""Flight Time"",
            ""value"": ""25mins""
          },
          {
            ""name"": ""Control Channels"",
            ""value"": ""4 Channels""
          },
          {
            ""name"": ""Controller Battery"",
            ""value"": ""1600mah""
          },
          {
            ""name"": ""Charging Time"",
            ""value"": ""120mins""
          },
          {
            ""name"": ""Power Source"",
            ""value"": ""Electric""
          },
          {
            ""name"": ""Remote Distance"",
            ""value"": ""1500m""
          },
          {
            ""name"": ""Remote Control"",
            ""value"": ""Yes""
          },
          {
            ""name"": ""Package Includes"",
            ""value"": ""Batteries,Operating Instructions,Remote Controller,USB Cable""
          },
          {
            ""name"": ""Material"",
            ""value"": ""Metal,Plastic""
          },
          {
            ""name"": ""Brand Name"",
            ""value"": ""JIKEFUN""
          },
          {
            ""name"": ""Aerial Photography"",
            ""value"": ""Yes""
          },
          {
            ""name"": ""Origin"",
            ""value"": ""Mainland China""
          },
          {
            ""name"": ""Recommend Age"",
            ""value"": ""12+y,14+y""
          },
          {
            ""name"": ""Type"",
            ""value"": ""HELICOPTER""
          },
          {
            ""name"": ""Features"",
            ""value"": ""App-Controlled""
          }
        ]
      },
      ""description"": {
        ""images"": [
          ""//ae01.alicdn.com/kf/Sa9d3135beb2940c6a0285ddcaf104ddbd.jpg"",
          ""//ae01.alicdn.com/kf/Sd561cabfc8864eba9ab26803dfca3dc8i.jpg"",
          ""//ae01.alicdn.com/kf/S0c2c7e43e29a416b81c7e5894f9991cfO.jpg"",
          ""//ae01.alicdn.com/kf/Sf62100d6879e456fae7a481d68b5c963F.jpg"",
          ""//ae01.alicdn.com/kf/S99f2942a464e4be797d2026942ec2ded0.jpg"",
          ""//ae01.alicdn.com/kf/Sc4ee9e492c2b47629ea20bf41c80e7ceR.jpg"",
          ""//ae01.alicdn.com/kf/Sd7fcc8cc3cc048afa98735ad8c15c8c5q.jpg"",
          ""//ae01.alicdn.com/kf/S29d0e45c637346ac9a0f66b05246b009P.jpg"",
          ""//ae01.alicdn.com/kf/S3704c2501d7b42cd9dd421f28ac18260X.jpg"",
          ""//ae01.alicdn.com/kf/Sfc6255bc13994671ad3f61c8ed0b9557M.jpg"",
          ""//ae01.alicdn.com/kf/Sb08f3d0416f4411b887cb46f2bdd3d93c.jpg"",
          ""//ae01.alicdn.com/kf/Sb02f87e26d89475ba948742191e609561.jpg"",
          ""//ae01.alicdn.com/kf/Sf4341ae6c1444cab9c8fc16305cfea53K.jpg"",
          ""//ae01.alicdn.com/kf/Sd0915da1ee9841b79539cb3a58b24a9fz.jpg"",
          ""//ae01.alicdn.com/kf/S4367238ed76a45c2ac278c37f42c1d43Y.jpg"",
          ""//ae01.alicdn.com/kf/S03d92861bb954c8a994c9e7eb5f18afav.jpg"",
          ""//ae01.alicdn.com/kf/S5043fec95b9249a899b908c7daaf53b8t.jpg"",
          ""//ae01.alicdn.com/kf/Se7b86de411cb4fd482a99de1fc2d4d47Y.jpg"",
          ""//ae01.alicdn.com/kf/S89ee9271ceee4a99ae8ee5ef224b3393c.jpg"",
          ""//ae01.alicdn.com/kf/Sa91e2cfe90624aa8bcc766920a73a0fcN.jpg""
        ]
      },
      ""sku"": {
        ""def"": {
          ""quantity"": 408,
          ""price"": ""95.49 - 126.09"",
          ""promotionPrice"": null,
          ""unit"": ""piece"",
          ""isBulk"": false
        },
        ""base"": [
          {
            ""skuId"": ""12000030447669032"",
            ""propMap"": ""14:10"",
            ""price"": 95.49,
            ""promotionPrice"": null,
            ""quantity"": 4,
            ""ext"": ""5YS2wDzqqgfJkvBFaMYCwbv-xzHP80XBwaVVTSaB3zO2tKfhQx3_vjxadpXF63nNF1laNsZnTh3X2-5l33h0hlQSrF7O6XAsj7ycIwg9GuWVbHBnm8lxVGH5RUET8egR5FGdXyyDslNG197_kAB-nTVWqhHFqdpn69mwQ5W82_LAIQ2vAX7ViwfdPT6R1A5h""
          },
          {
            ""skuId"": ""12000030447669033"",
            ""propMap"": ""14:691"",
            ""price"": 112.37,
            ""promotionPrice"": null,
            ""quantity"": 100,
            ""ext"": ""72V5z-4G6Wrg559NEY_R4ezy6Rpo6OprBSU_1VsMUjL5NKY4D_IWVFaxiQVXvKI5utuyQxrtsqttJOO003WrCBY6L9ajlUwc5oyy-j3xS3Cm_Lm7fe9vNPEHo3OWwmMfyW3kgt3hpgdFbx9CXfcXekofNjwqi2PPfU3TgfHNaGyhlSVPiTCqy9qcamMSQoF3""
          },
          {
            ""skuId"": ""12000030447669034"",
            ""propMap"": ""14:173"",
            ""price"": 126.09,
            ""promotionPrice"": null,
            ""quantity"": 99,
            ""ext"": ""gI6lHqiLW-VDSLrGPr4TVe0AQOeG1rRGQsC_GXNUru70TF3FBBNJawt3pZtiwWH1PjhzS1-pQ96suxhbPzYEAJNqxmiZDuqGt1-Os6_XpUDt67MgmwFxNNkvu0twcZf0TVKkrUbaIchtujYu3X-G0Qh6QPnPE-8OYcGqskYiXD7sC9AaxHr3pQjSuYWs7LV8""
          },
          {
            ""skuId"": ""12000030447669029"",
            ""propMap"": ""14:29"",
            ""price"": 95.49,
            ""promotionPrice"": null,
            ""quantity"": 5,
            ""ext"": ""Kq0tUfVVsrNMoRvWslojo_zj7H-nngPipCjkGOnP9-pLjosmF_xM9Ly9XGsH7xc9zLXCL6oRZOdvr7pPDf6Xf7_IiN94wf8ZX0kbPNEfy4M59pCl5p2SbfDwB2M7vUUJesrOfFGYqCKXlCp3aPIzWtIfjm7YxOZTDb3Rtyva-oLheEzUTIfke16H9DXZpTgo""
          },
          {
            ""skuId"": ""12000030447669030"",
            ""propMap"": ""14:193"",
            ""price"": 112.37,
            ""promotionPrice"": null,
            ""quantity"": 100,
            ""ext"": ""Xclo0DAyXh3j_OV9htznrjo0hnEWgcv7eF1I7Nm_IPkCcR0e2sF-aCC17qxZ6m3NIT4v6lq7QXCXVXX0WVc4qR-Qp0F3qMJssZaLbsFVhgJKbMUVQxQ7004_hy8zrJlmd8bG_37-Po01Z59yE0X-5ZjEqzr6JJm8_ILQ1EXdm-teKWuDVRX1NkMIpRt9sR9c""
          },
          {
            ""skuId"": ""12000030447669031"",
            ""propMap"": ""14:175"",
            ""price"": 126.09,
            ""promotionPrice"": null,
            ""quantity"": 100,
            ""ext"": ""LgDy115Hldb2601ba4-G7tHL0l8xb64PvbUzAa8964XC0gVWw-6HucNV89NH_DPY5ajrpFxwmE6z4BHXzcLT_Si4bG2p8oDp0SlHhxPC2NzT4xTZTGUsM4D8dTEs8rIx34MhEYZeLfqyo6fl35bQIsmu7AfTDwxt_LIboF65s6aXL78GvKhCtbHBFadGO8Re""
          }
        ],
        ""props"": [
          {
            ""pid"": 14,
            ""name"": ""Color"",
            ""values"": [
              {
                ""vid"": 29,
                ""name"": ""White 1Bat"",
                ""image"": ""//ae01.alicdn.com/kf/S6207377445554539a04e65d0b81db0a6u/Professional-S6S-Mini-GPS-Drone-RC-Toy-4K-HD-Dual-Camera-5G-WIFI-FPV-Brushless-Folding.jpg"",
                ""propTips"": ""White 1Bat""
              },
              {
                ""vid"": 193,
                ""name"": ""White 2Bats"",
                ""image"": ""//ae01.alicdn.com/kf/Saa332b1b14ea495fa4c886a35e42c756j/Professional-S6S-Mini-GPS-Drone-RC-Toy-4K-HD-Dual-Camera-5G-WIFI-FPV-Brushless-Folding.jpg"",
                ""propTips"": ""White 2Bats""
              },
              {
                ""vid"": 175,
                ""name"": ""White 3Bats"",
                ""image"": ""//ae01.alicdn.com/kf/S28fd5ab89ceb45e895376e4804801296v/Professional-S6S-Mini-GPS-Drone-RC-Toy-4K-HD-Dual-Camera-5G-WIFI-FPV-Brushless-Folding.jpg"",
                ""propTips"": ""White 3Bats""
              },
              {
                ""vid"": 10,
                ""name"": ""Orange 1Bat"",
                ""image"": ""//ae01.alicdn.com/kf/S2b8fc354c4104546969e650085b9ca8fk/Professional-S6S-Mini-GPS-Drone-RC-Toy-4K-HD-Dual-Camera-5G-WIFI-FPV-Brushless-Folding.jpg"",
                ""propTips"": ""Orange 1Bat""
              },
              {
                ""vid"": 691,
                ""name"": ""Orange 2Bats"",
                ""image"": ""//ae01.alicdn.com/kf/S3da45642cca4433e89bf8616b2fa825bl/Professional-S6S-Mini-GPS-Drone-RC-Toy-4K-HD-Dual-Camera-5G-WIFI-FPV-Brushless-Folding.jpg"",
                ""propTips"": ""Orange 2Bats""
              },
              {
                ""vid"": 173,
                ""name"": ""Orange 3Bats"",
                ""image"": ""//ae01.alicdn.com/kf/S0b454495bef642c4a674f4a90f2c2907Z/Professional-S6S-Mini-GPS-Drone-RC-Toy-4K-HD-Dual-Camera-5G-WIFI-FPV-Brushless-Folding.jpg"",
                ""propTips"": ""Orange 3Bats""
              }
            ]
          }
        ]
      }
    },
    ""reviews"": {
      ""count"": 0,
      ""averageStarRate"": ""0.0""
    },
    ""delivery"": {
      ""shippingFrom"": ""China"",
      ""shippingFromCode"": ""CN"",
      ""shippingTo"": ""United States"",
      ""shippingToCode"": ""US"",
      ""shippingOutDays"": 4,
      ""shippingList"": [
        {
          ""shippingFrom"": ""China"",
          ""shippingFromCode"": ""CN"",
          ""shippingTo"": ""United States"",
          ""shippingToCode"": ""US"",
          ""shippingFee"": ""0"",
          ""shippingCompany"": ""Seller's Shipping Method"",
          ""shippingTime"": 60,
          ""estimateDeliveryDate"": ""2024-01-07"",
          ""trackingAvailable"": false,
          ""note"": [
            ""Free Shipping"",
            ""Estimated delivery on Jan 07"",
            ""From China to United States via Seller's Shipping Method""
          ]
        },
        {
          ""shippingFrom"": ""China"",
          ""shippingFromCode"": ""CN"",
          ""shippingTo"": ""United States"",
          ""shippingToCode"": ""US"",
          ""shippingFee"": ""1.47"",
          ""shippingCompany"": ""AliExpress Standard Shipping"",
          ""shippingTime"": 60,
          ""estimateDeliveryDate"": ""2023-11-27"",
          ""trackingAvailable"": true,
          ""note"": [
            ""Shipping: $1.47"",
            ""Estimated delivery between  Nov 21 - Nov 27 "",
            ""From China to United States via AliExpress Standard Shipping""
          ]
        }
      ],
      ""packageDetail"": {
        ""weight"": 0.6,
        ""length"": 18,
        ""height"": 7,
        ""width"": 22
      }
    },
    ""service"": [
      {
        ""title"": ""Buyer protection"",
        ""desc"": ""Get a refund if the item arrives late or not as described. "",
        ""icon"": null
      }
    ],
    ""seller"": {
      ""sellerId"": 231651707,
      ""storeTitle"": ""JiKeFun Global Toys Store"",
      ""storeId"": 1102051418,
      ""companyId"": 240956532,
      ""storeUrl"": ""//www.aliexpress.com/store/1102051418"",
      ""storeImage"": ""//ae01.alicdn.com/kf/S0a5ca20f9b0549f8934f52bc8700c43aw.jpg"",
      ""storeRating"": ""89.2""
    }
  }
}";
}
