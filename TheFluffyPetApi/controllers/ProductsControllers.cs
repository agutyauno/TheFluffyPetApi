using Microsoft.AspNetCore.Mvc;
using TheFluffyPetApi.models;

namespace TheFluffyPetApi.controllers
{
    [ApiController]
    [Route("api/Products")]
    public class ProductsControllers : ControllerBase
    {
        static readonly List<Product> products = [];

        public ProductsControllers()
        {
            AddProduct(new Product
            {
                ProductId = "p001",
                Name = "Cat Food",
                Brand = "ncc",
                Description = "High-quality cat food.",
                ImageUrl = [
                    "https://paddy.vn/cdn/shop/files/do-choi-meo-cattyman-thu-bong-luoi.png?v=1694500545",
                    "https://cdn.shopify.com/s/files/1/0624/1746/9697/files/12355_800x_d3c0cba8-31d1-47f3-a284-7d81d2ad6e0f_600x600.webp?v=1671510632",
                    "https://cdn.chiaki.vn/unsafe/0x960/left/top/smart/filters:quality(70)/https://chiaki.vn/upload/news/content/2021/01/thuc-an-cho-meo-me-o-kitten-ocean-fish-jpg-1609987233-07012021094033.jpg",
                    "https://www.phukienthucungdep.com/upload/product/normal/thuc-an-cho-meo-con1.jpg",
                    "https://haitau.vn/wp-content/uploads/2023/06/image3-min-5.jpg"
                ],
                Discount = 0,
                Category = "food",
                Variants = [
                    new Variant
                    {
                        VariantId = "p001v01",
                        Name = "Small",
                        Price = 99000,
                        StockQuantity = 100
                    },
                    new Variant
                    {
                        VariantId = "p001v02",
                        Name = "Large",
                        Price = 66000,
                        StockQuantity = 50
                    }
                ]
            });
            AddProduct(new Product
            {
                ProductId = "p002",
                Name = "dog Food",
                Brand = "ncct",
                Description = "High-quality dog food.",
                ImageUrl = [
                    "https://paddy.vn/cdn/shop/files/do-choi-meo-cattyman-thu-bong-luoi.png?v=1694500545",
                    "https://cdn.shopify.com/s/files/1/0624/1746/9697/files/12355_800x_d3c0cba8-31d1-47f3-a284-7d81d2ad6e0f_600x600.webp?v=1671510632",
                    "https://cdn.chiaki.vn/unsafe/0x960/left/top/smart/filters:quality(70)/https://chiaki.vn/upload/news/content/2021/01/thuc-an-cho-meo-me-o-kitten-ocean-fish-jpg-1609987233-07012021094033.jpg",
                    "https://www.phukienthucungdep.com/upload/product/normal/thuc-an-cho-meo-con1.jpg",
                    "https://haitau.vn/wp-content/uploads/2023/06/image3-min-5.jpg"
                ],
                Discount = 0,
                Category = "food",
                Variants = [
                    new Variant
                    {
                        VariantId = "p002v01",
                        Name = "Small",
                        Price = 100000,
                        StockQuantity = 100
                    },
                    new Variant
                    {
                        VariantId = "p002v02",
                        Name = "Large",
                        Price = 150000,
                        StockQuantity = 50
                    }
                ]
            });
            AddProduct(new Product
            {
                ProductId = "p003",
                Name = "Cat Litter Box",
                Brand = "PawPaw",
                Description = "Large capacity cat litter box with hood",
                ImageUrl = [
        "https://cdn.pixabay.com/photo/2020/05/06/12/01/cat-5137747_1280.jpg",
        "https://cdn.pixabay.com/photo/2019/11/07/08/40/cat-4608266_1280.jpg",
        "https://cdn.pixabay.com/photo/2020/03/31/16/17/cat-4988451_1280.jpg"
    ],
                Discount = 10,
                Category = "accessories",
                Variants = [
        new Variant
        {
            VariantId = "p003v01",
            Name = "Blue",
            Price = 450000,
            StockQuantity = 30
        },
        new Variant
        {
            VariantId = "p003v02",
            Name = "Pink",
            Price = 450000,
            StockQuantity = 25
        }
    ]
            });

            AddProduct(new Product
            {
                ProductId = "p004",
                Name = "Pet Carrier",
                Brand = "PetGo",
                Description = "Comfortable and durable pet carrier for cats and small dogs",
                ImageUrl = [
                    "https://cdn.pixabay.com/photo/2018/10/05/12/09/animal-carrier-3725659_1280.jpg",
        "https://cdn.pixabay.com/photo/2019/11/18/00/38/cat-4633534_1280.jpg",
        "https://cdn.pixabay.com/photo/2020/03/31/16/17/cat-4988451_1280.jpg"
                ],
                Discount = 15,
                Category = "accessories",
                Variants = [
                    new Variant
        {
            VariantId = "p004v01",
            Name = "Small",
            Price = 550000,
            StockQuantity = 20
        },
        new Variant
        {
            VariantId = "p004v02",
            Name = "Medium",
            Price = 750000,
            StockQuantity = 15
        }
                ]
            });

            AddProduct(new Product
            {
                ProductId = "p005",
                Name = "Pet Grooming Kit",
                Brand = "PawCare",
                Description = "Complete grooming kit for cats and dogs",
                ImageUrl = [
                    "https://cdn.pixabay.com/photo/2016/11/22/19/41/cat-1850013_1280.jpg",
        "https://cdn.pixabay.com/photo/2017/08/07/11/40/cat-2603300_1280.jpg",
        "https://cdn.pixabay.com/photo/2018/03/31/06/31/dog-3277416_1280.jpg"
                ],
                Discount = 5,
                Category = "grooming",
                Variants = [
                    new Variant
        {
            VariantId = "p005v01",
            Name = "Basic Kit",
            Price = 350000,
            StockQuantity = 40
        },
        new Variant
        {
            VariantId = "p005v02",
            Name = "Professional Kit",
            Price = 850000,
            StockQuantity = 20
        }
                ]
            });
            AddProduct(new Product
            {
                ProductId = "p006",
                Name = "Cat Scratching Post",
                Brand = "PawZone",
                Description = "Multi-level cat tree with scratching posts and perches",
                ImageUrl = [
        "https://cdn.pixabay.com/photo/2018/07/21/01/34/cat-3551554_1280.jpg",
        "https://cdn.pixabay.com/photo/2019/11/08/11/56/cat-4611189_1280.jpg",
        "https://cdn.pixabay.com/photo/2020/03/31/16/17/cat-4988451_1280.jpg"
    ],
                Discount = 20,
                Category = "furniture",
                Variants = [
        new Variant
        {
            VariantId = "p006v01",
            Name = "Standard",
            Price = 1200000,
            StockQuantity = 15
        },
        new Variant
        {
            VariantId = "p006v02",
            Name = "Deluxe",
            Price = 2500000,
            StockQuantity = 10
        }
    ]
            });

            AddProduct(new Product
            {
                ProductId = "p007",
                Name = "Interactive Pet Toy",
                Brand = "PetFun",
                Description = "Electronic interactive toy for pets with moving features",
                ImageUrl = [
                    "https://cdn.pixabay.com/photo/2017/07/25/01/22/cat-2536662_1280.jpg",
        "https://cdn.pixabay.com/photo/2016/11/29/01/10/adorable-1866475_1280.jpg",
        "https://cdn.pixabay.com/photo/2017/08/07/11/40/cat-2603300_1280.jpg"
                ],
                Discount = 0,
                Category = "toys",
                Variants = [
                    new Variant
        {
            VariantId = "p007v01",
            Name = "Mouse Chase",
            Price = 450000,
            StockQuantity = 30
        },
        new Variant
        {
            VariantId = "p007v02",
            Name = "Bird Flutter",
            Price = 500000,
            StockQuantity = 25
        }
                ]
            });

            AddProduct(new Product
            {
                ProductId = "p008",
                Name = "Pet Bed",
                Brand = "ComfortPet",
                Description = "Soft and cozy bed for cats and small dogs",
                ImageUrl = [
                    "https://cdn.pixabay.com/photo/2017/08/07/11/40/cat-2603300_1280.jpg",
        "https://cdn.pixabay.com/photo/2018/07/21/01/34/cat-3551554_1280.jpg",
        "https://cdn.pixabay.com/photo/2019/11/08/11/56/cat-4611189_1280.jpg"
                ],
                Discount = 15,
                Category = "furniture",
                Variants = [
                    new Variant
        {
            VariantId = "p008v01",
            Name = "Small",
            Price = 350000,
            StockQuantity = 25
        },
        new Variant
        {
            VariantId = "p008v02",
            Name = "Large",
            Price = 550000,
            StockQuantity = 20
        }
                ]
            });

            AddProduct(new Product
            {
                ProductId = "p009",
                Name = "Pet Shampoo",
                Brand = "PetClean",
                Description = "Gentle and moisturizing pet shampoo",
                ImageUrl = [
                    "https://cdn.pixabay.com/photo/2016/11/22/19/41/cat-1850013_1280.jpg",
        "https://cdn.pixabay.com/photo/2017/08/07/11/40/cat-2603300_1280.jpg",
        "https://cdn.pixabay.com/photo/2018/03/31/06/31/dog-3277416_1280.jpg"
                ],
                Discount = 5,
                Category = "grooming",
                Variants = [
                    new Variant
        {
            VariantId = "p009v01",
            Name = "Regular",
            Price = 180000,
            StockQuantity = 50
        },
        new Variant
        {
            VariantId = "p009v02",
            Name = "Sensitive Skin",
            Price = 250000,
            StockQuantity = 30
        }
                ]
            });

            AddProduct(new Product
            {
                ProductId = "p010",
                Name = "Automatic Pet Feeder",
                Brand = "SmartPet",
                Description = "Programmable automatic pet food dispenser",
                ImageUrl = [
                    "https://cdn.pixabay.com/photo/2020/05/06/12/01/cat-5137747_1280.jpg",
        "https://cdn.pixabay.com/photo/2019/11/07/08/40/cat-4608266_1280.jpg",
        "https://cdn.pixabay.com/photo/2020/03/31/16/17/cat-4988451_1280.jpg"
                ],
                Discount = 8,
                Category = "accessories",
                Variants = [
                    new Variant
        {
            VariantId = "p010v01",
            Name = "Basic",
            Price = 850000,
            StockQuantity = 15
        },
        new Variant
        {
            VariantId = "p010v02",
            Name = "Smart WiFi",
            Price = 1500000,
            StockQuantity = 10
        }
                ]
            });
            AddProduct(new Product
            {
                ProductId = "p011",
                Name = "Premium Pet Bowl Set",
                Brand = "LuxPet",
                Description = "Elevated ceramic bowl set with anti-slip base and spill-proof design",
                ImageUrl = [
        "https://cdn.pixabay.com/photo/2017/11/12/13/37/cat-food-2942751_1280.jpg",
        "https://cdn.pixabay.com/photo/2018/03/31/06/31/dog-3277416_1280.jpg",
        "https://cdn.pixabay.com/photo/2016/12/13/05/15/puppy-1903313_1280.jpg",
        "https://cdn.pixabay.com/photo/2019/08/19/07/45/pets-4415649_1280.jpg",
        "https://cdn.pixabay.com/photo/2017/07/25/01/22/cat-2536662_1280.jpg"
    ],
                Discount = 15,
                Category = "accessories",
                Variants = [
        new Variant { VariantId = "p011v01", Name = "Single Bowl", Price = 280000, StockQuantity = 30 },
        new Variant { VariantId = "p011v02", Name = "Double Bowl", Price = 450000, StockQuantity = 25 }
    ]
            });

            AddProduct(new Product
            {
                ProductId = "p012",
                Name = "Smart Pet Camera",
                Brand = "TechPet",
                Description = "HD camera with two-way audio, treat dispenser and laser play function",
                ImageUrl = [
                    "https://cdn.pixabay.com/photo/2016/11/29/01/10/security-camera-1866586_1280.jpg",
        "https://cdn.pixabay.com/photo/2017/08/07/11/40/cat-2603300_1280.jpg",
        "https://cdn.pixabay.com/photo/2018/03/31/06/31/dog-3277416_1280.jpg",
        "https://cdn.pixabay.com/photo/2020/05/06/12/01/cat-5137747_1280.jpg",
        "https://cdn.pixabay.com/photo/2019/11/07/08/40/cat-4608266_1280.jpg"
                ],
                Discount = 5,
                Category = "electronics",
                Variants = [
                    new Variant { VariantId = "p012v01", Name = "Basic HD", Price = 1200000, StockQuantity = 15 },
        new Variant { VariantId = "p012v02", Name = "Pro 4K", Price = 2500000, StockQuantity = 10 }
                ]
            });

            AddProduct(new Product
            {
                ProductId = "p013",
                Name = "Pet Training Kit",
                Brand = "BehavePet",
                Description = "Complete training kit with clicker, treats pouch, and training guide",
                ImageUrl = [
                    "https://cdn.pixabay.com/photo/2019/07/14/16/29/pet-4337963_1280.jpg",
        "https://cdn.pixabay.com/photo/2016/11/22/19/41/cat-1850013_1280.jpg",
        "https://cdn.pixabay.com/photo/2017/08/07/11/40/cat-2603300_1280.jpg",
        "https://cdn.pixabay.com/photo/2018/03/31/06/31/dog-3277416_1280.jpg",
        "https://cdn.pixabay.com/photo/2020/03/31/16/17/cat-4988451_1280.jpg"
                ],
                Discount = 20,
                Category = "training",
                Variants = [
                    new Variant { VariantId = "p013v01", Name = "Starter Kit", Price = 450000, StockQuantity = 25 },
        new Variant { VariantId = "p013v02", Name = "Professional Kit", Price = 850000, StockQuantity = 15 }
                ]
            });

            AddProduct(new Product
            {
                ProductId = "p014",
                Name = "Luxury Pet Carrier Backpack",
                Brand = "PetVoyage",
                Description = "Ventilated pet backpack with bubble window and airline approved",
                ImageUrl = [
                    "https://cdn.pixabay.com/photo/2018/10/05/12/09/animal-carrier-3725659_1280.jpg",
        "https://cdn.pixabay.com/photo/2019/11/18/00/38/cat-4633534_1280.jpg",
        "https://cdn.pixabay.com/photo/2020/03/31/16/17/cat-4988451_1280.jpg",
        "https://cdn.pixabay.com/photo/2017/07/25/01/22/cat-2536662_1280.jpg",
        "https://cdn.pixabay.com/photo/2016/11/29/01/10/adorable-1866475_1280.jpg"
                ],
                Discount = 10,
                Category = "travel",
                Variants = [
                    new Variant { VariantId = "p014v01", Name = "Standard", Price = 890000, StockQuantity = 20 },
        new Variant { VariantId = "p014v02", Name = "Premium", Price = 1500000, StockQuantity = 15 }
                ]
            });

            AddProduct(new Product
            {
                ProductId = "p015",
                Name = "Multi-Function Pet Grooming Station",
                Brand = "GroomMaster",
                Description = "Foldable grooming station with storage, adjustable arm and non-slip surface",
                ImageUrl = [
                    "https://cdn.pixabay.com/photo/2016/11/22/19/41/cat-1850013_1280.jpg",
        "https://cdn.pixabay.com/photo/2017/08/07/11/40/cat-2603300_1280.jpg",
        "https://cdn.pixabay.com/photo/2018/03/31/06/31/dog-3277416_1280.jpg",
        "https://cdn.pixabay.com/photo/2019/11/07/08/40/cat-4608266_1280.jpg",
        "https://cdn.pixabay.com/photo/2020/05/06/12/01/cat-5137747_1280.jpg"
                ],
                Discount = 12,
                Category = "grooming",
                Variants = [
                    new Variant { VariantId = "p015v01", Name = "Compact", Price = 1800000, StockQuantity = 12 },
        new Variant { VariantId = "p015v02", Name = "Professional", Price = 3500000, StockQuantity = 8 }
                ]
            });
            AddProduct(new Product
            {
                ProductId = "p016",
                Name = "Pet Dental Care Set",
                Brand = "DentaPet",
                Description = "Complete dental hygiene kit for pets including toothbrush, toothpaste, and dental treats",
                ImageUrl = [
        "https://cdn.pixabay.com/photo/2016/01/05/17/51/dog-1123016_1280.jpg",
        "https://cdn.pixabay.com/photo/2018/03/31/06/31/dog-3277416_1280.jpg",
        "https://cdn.pixabay.com/photo/2015/06/08/15/02/pug-802006_1280.jpg",
        "https://cdn.pixabay.com/photo/2016/12/13/05/15/puppy-1903313_1280.jpg",
        "https://cdn.pixabay.com/photo/2019/08/19/07/45/pets-4415649_1280.jpg"
    ],
                Discount = 15,
                Category = "healthcare",
                Variants = [
        new Variant { VariantId = "p016v01", Name = "Basic Care", Price = 250000, StockQuantity = 40 },
        new Variant { VariantId = "p016v02", Name = "Premium Care", Price = 450000, StockQuantity = 25 }
    ]
            });

            AddProduct(new Product
            {
                ProductId = "p017",
                Name = "Pet Cooling Mat",
                Brand = "CoolPet",
                Description = "Self-cooling mat for pets, perfect for hot summer days",
                ImageUrl = [
                    "https://cdn.pixabay.com/photo/2017/08/07/11/40/cat-2603300_1280.jpg",
        "https://cdn.pixabay.com/photo/2018/07/21/01/34/cat-3551554_1280.jpg",
        "https://cdn.pixabay.com/photo/2019/11/08/11/56/cat-4611189_1280.jpg",
        "https://cdn.pixabay.com/photo/2016/11/29/01/10/adorable-1866475_1280.jpg",
        "https://cdn.pixabay.com/photo/2017/07/25/01/22/cat-2536662_1280.jpg"
                ],
                Discount = 8,
                Category = "accessories",
                Variants = [
                    new Variant { VariantId = "p017v01", Name = "Small (50x40cm)", Price = 350000, StockQuantity = 30 },
        new Variant { VariantId = "p017v02", Name = "Large (90x60cm)", Price = 650000, StockQuantity = 20 }
                ]
            });

            AddProduct(new Product
            {
                ProductId = "p018",
                Name = "Pet GPS Tracker",
                Brand = "SafePet",
                Description = "Real-time GPS tracker with app monitoring and geofencing",
                ImageUrl = [
                    "https://cdn.pixabay.com/photo/2016/11/29/01/10/security-1866475_1280.jpg",
        "https://cdn.pixabay.com/photo/2017/02/20/18/03/cat-2083492_1280.jpg",
        "https://cdn.pixabay.com/photo/2015/11/16/14/43/cat-1045782_1280.jpg",
        "https://cdn.pixabay.com/photo/2017/11/14/13/06/kitty-2948404_1280.jpg",
        "https://cdn.pixabay.com/photo/2019/11/08/11/56/cat-4611189_1280.jpg"
                ],
                Discount = 10,
                Category = "electronics",
                Variants = [
                    new Variant { VariantId = "p018v01", Name = "Basic Tracker", Price = 890000, StockQuantity = 25 },
        new Variant { VariantId = "p018v02", Name = "Pro Tracker", Price = 1490000, StockQuantity = 15 }
                ]
            });

            AddProduct(new Product
            {
                ProductId = "p019",
                Name = "Pet First Aid Kit",
                Brand = "PetCare",
                Description = "Comprehensive first aid kit specially designed for pets",
                ImageUrl = [
                    "https://cdn.pixabay.com/photo/2017/08/07/11/40/cat-2603300_1280.jpg",
        "https://cdn.pixabay.com/photo/2018/03/31/06/31/dog-3277416_1280.jpg",
        "https://cdn.pixabay.com/photo/2019/07/14/16/29/pet-4337963_1280.jpg",
        "https://cdn.pixabay.com/photo/2016/11/22/19/41/cat-1850013_1280.jpg",
        "https://cdn.pixabay.com/photo/2020/03/31/16/17/cat-4988451_1280.jpg"
                ],
                Discount = 5,
                Category = "healthcare",
                Variants = [
                    new Variant { VariantId = "p019v01", Name = "Basic Kit", Price = 450000, StockQuantity = 35 },
        new Variant { VariantId = "p019v02", Name = "Emergency Kit", Price = 850000, StockQuantity = 20 }
                ]
            });

            AddProduct(new Product
            {
                ProductId = "p020",
                Name = "Pet Vitamin Complex",
                Brand = "VitaPet",
                Description = "Complete vitamin and mineral supplement for pets",
                ImageUrl = [
                    "https://cdn.pixabay.com/photo/2016/11/22/19/41/cat-1850013_1280.jpg",
        "https://cdn.pixabay.com/photo/2017/08/07/11/40/cat-2603300_1280.jpg",
        "https://cdn.pixabay.com/photo/2018/03/31/06/31/dog-3277416_1280.jpg",
        "https://cdn.pixabay.com/photo/2019/11/07/08/40/cat-4608266_1280.jpg",
        "https://cdn.pixabay.com/photo/2020/05/06/12/01/cat-5137747_1280.jpg"
                ],
                Discount = 12,
                Category = "healthcare",
                Variants = [
                    new Variant { VariantId = "p020v01", Name = "60 Tablets", Price = 380000, StockQuantity = 45 },
        new Variant { VariantId = "p020v02", Name = "120 Tablets", Price = 680000, StockQuantity = 30 }
                ]
            });
            AddProduct(new Product
            {
                ProductId = "p021",
                Name = "Pet Water Fountain",
                Brand = "AquaPet",
                Description = "Ultra-quiet pet water fountain with filtration system",
                ImageUrl = [
        "https://cdn.pixabay.com/photo/2017/11/14/13/06/kitty-2948404_1280.jpg",
        "https://cdn.pixabay.com/photo/2019/05/08/21/21/cat-4189697_1280.jpg",
        "https://cdn.pixabay.com/photo/2018/03/27/17/25/cat-3266673_1280.jpg",
        "https://cdn.pixabay.com/photo/2020/03/31/16/17/cat-4988451_1280.jpg",
        "https://cdn.pixabay.com/photo/2019/11/08/11/56/cat-4611189_1280.jpg"
    ],
                Discount = 15,
                Category = "accessories",
                Variants = [
        new Variant { VariantId = "p021v01", Name = "2L Capacity", Price = 750000, StockQuantity = 25 },
        new Variant { VariantId = "p021v02", Name = "4L Capacity", Price = 1200000, StockQuantity = 20 }
    ]
            });

            AddProduct(new Product
            {
                ProductId = "p022",
                Name = "Pet Travel Set",
                Brand = "TravelPet",
                Description = "Complete travel kit including portable bowls, blanket, and waste bags",
                ImageUrl = [
                    "https://cdn.pixabay.com/photo/2019/08/19/07/45/pets-4415649_1280.jpg",
        "https://cdn.pixabay.com/photo/2018/10/05/12/09/animal-carrier-3725659_1280.jpg",
        "https://cdn.pixabay.com/photo/2017/07/25/01/22/cat-2536662_1280.jpg",
        "https://cdn.pixabay.com/photo/2016/11/29/01/10/adorable-1866475_1280.jpg",
        "https://cdn.pixabay.com/photo/2015/11/16/14/43/cat-1045782_1280.jpg"
                ],
                Discount = 20,
                Category = "travel",
                Variants = [
                    new Variant { VariantId = "p022v01", Name = "Basic Set", Price = 550000, StockQuantity = 30 },
        new Variant { VariantId = "p022v02", Name = "Premium Set", Price = 890000, StockQuantity = 20 }
                ]
            });

            AddProduct(new Product
            {
                ProductId = "p023",
                Name = "Smart Pet Door",
                Brand = "TechHome",
                Description = "Microchip-activated pet door with weather-resistant seal",
                ImageUrl = [
                    "https://cdn.pixabay.com/photo/2016/11/29/01/10/security-camera-1866586_1280.jpg",
        "https://cdn.pixabay.com/photo/2017/02/20/18/03/cat-2083492_1280.jpg",
        "https://cdn.pixabay.com/photo/2019/11/08/11/56/cat-4611189_1280.jpg",
        "https://cdn.pixabay.com/photo/2018/07/21/01/34/cat-3551554_1280.jpg",
        "https://cdn.pixabay.com/photo/2017/11/14/13/06/kitty-2948404_1280.jpg"
                ],
                Discount = 8,
                Category = "electronics",
                Variants = [
                    new Variant { VariantId = "p023v01", Name = "Small", Price = 2500000, StockQuantity = 15 },
        new Variant { VariantId = "p023v02", Name = "Large", Price = 3500000, StockQuantity = 10 }
                ]
            });

            AddProduct(new Product
            {
                ProductId = "p024",
                Name = "Pet Massage Brush",
                Brand = "PetRelax",
                Description = "Electric massage brush with interchangeable heads for grooming and relaxation",
                ImageUrl = [
                    "https://cdn.pixabay.com/photo/2016/11/22/19/41/cat-1850013_1280.jpg",
        "https://cdn.pixabay.com/photo/2017/08/07/11/40/cat-2603300_1280.jpg",
        "https://cdn.pixabay.com/photo/2019/07/14/16/29/pet-4337963_1280.jpg",
        "https://cdn.pixabay.com/photo/2018/03/31/06/31/dog-3277416_1280.jpg",
        "https://cdn.pixabay.com/photo/2020/03/31/16/17/cat-4988451_1280.jpg"
                ],
                Discount = 10,
                Category = "grooming",
                Variants = [
                    new Variant { VariantId = "p024v01", Name = "Standard", Price = 450000, StockQuantity = 35 },
        new Variant { VariantId = "p024v02", Name = "Professional", Price = 850000, StockQuantity = 25 }
                ]
            });

            AddProduct(new Product
            {
                ProductId = "p025",
                Name = "Pet Anxiety Relief Set",
                Brand = "CalmPet",
                Description = "Natural anxiety relief kit including calming treats, spray and comfort toy",
                ImageUrl = [
                    "https://cdn.pixabay.com/photo/2017/07/25/01/22/cat-2536662_1280.jpg",
        "https://cdn.pixabay.com/photo/2016/11/29/01/10/adorable-1866475_1280.jpg",
        "https://cdn.pixabay.com/photo/2019/11/08/11/56/cat-4611189_1280.jpg",
        "https://cdn.pixabay.com/photo/2018/03/27/17/25/cat-3266673_1280.jpg",
        "https://cdn.pixabay.com/photo/2020/05/06/12/01/cat-5137747_1280.jpg"
                ],
                Discount = 15,
                Category = "healthcare",
                Variants = [
                    new Variant { VariantId = "p025v01", Name = "Starter Kit", Price = 650000, StockQuantity = 30 },
        new Variant { VariantId = "p025v02", Name = "Complete Kit", Price = 1200000, StockQuantity = 20 }
                ]
            });
            AddProduct(new Product
            {
                ProductId = "p026",
                Name = "Pet Training Pad",
                Brand = "CleanPet",
                Description = "Super absorbent training pads with attractant and quick-dry surface",
                ImageUrl = [
        "https://cdn.pixabay.com/photo/2016/11/21/12/31/dog-1845107_1280.jpg",
        "https://cdn.pixabay.com/photo/2019/08/19/07/45/pets-4415649_1280.jpg",
        "https://cdn.pixabay.com/photo/2016/11/22/19/41/puppy-1850276_1280.jpg",
        "https://cdn.pixabay.com/photo/2017/08/07/11/40/dog-2603317_1280.jpg",
        "https://cdn.pixabay.com/photo/2018/03/31/06/31/dog-3277416_1280.jpg"
    ],
                Discount = 25,
                Category = "training",
                Variants = [
        new Variant { VariantId = "p026v01", Name = "30 Pads Pack", Price = 180000, StockQuantity = 50 },
        new Variant { VariantId = "p026v02", Name = "100 Pads Pack", Price = 520000, StockQuantity = 30 }
    ]
            });

            AddProduct(new Product
            {
                ProductId = "p027",
                Name = "Interactive Laser Toy",
                Brand = "PlayPet",
                Description = "Automatic rotating laser toy with multiple patterns and timer",
                ImageUrl = [
                    "https://cdn.pixabay.com/photo/2017/07/25/01/22/cat-2536662_1280.jpg",
        "https://cdn.pixabay.com/photo/2018/01/28/12/37/cat-3113422_1280.jpg",
        "https://cdn.pixabay.com/photo/2015/03/27/13/16/cat-694730_1280.jpg",
        "https://cdn.pixabay.com/photo/2016/03/28/12/35/cat-1285634_1280.jpg",
        "https://cdn.pixabay.com/photo/2015/11/16/14/43/cat-1045782_1280.jpg"
                ],
                Discount = 18,
                Category = "toys",
                Variants = [
                    new Variant { VariantId = "p027v01", Name = "Basic Model", Price = 320000, StockQuantity = 40 },
        new Variant { VariantId = "p027v02", Name = "Advanced Model", Price = 580000, StockQuantity = 25 }
                ]
            });

            AddProduct(new Product
            {
                ProductId = "p028",
                Name = "Pet Stroller",
                Brand = "ComfortRide",
                Description = "Foldable pet stroller with storage basket and weather cover",
                ImageUrl = [
                    "https://cdn.pixabay.com/photo/2019/11/18/00/38/cat-4633534_1280.jpg",
        "https://cdn.pixabay.com/photo/2018/10/05/12/09/animal-carrier-3725659_1280.jpg",
        "https://cdn.pixabay.com/photo/2017/07/25/01/22/cat-2536662_1280.jpg",
        "https://cdn.pixabay.com/photo/2019/08/19/07/45/pets-4415649_1280.jpg",
        "https://cdn.pixabay.com/photo/2016/11/22/19/41/cat-1850013_1280.jpg"
                ],
                Discount = 12,
                Category = "travel",
                Variants = [
                    new Variant { VariantId = "p028v01", Name = "Standard", Price = 1200000, StockQuantity = 15 },
        new Variant { VariantId = "p028v02", Name = "Deluxe", Price = 1800000, StockQuantity = 10 }
                ]
            });

            AddProduct(new Product
            {
                ProductId = "p029",
                Name = "Pet Memory Foam Bed",
                Brand = "DreamPet",
                Description = "Orthopedic memory foam bed with removable washable cover",
                ImageUrl = [
                    "https://cdn.pixabay.com/photo/2017/08/07/11/40/cat-2603300_1280.jpg",
        "https://cdn.pixabay.com/photo/2018/07/21/01/34/cat-3551554_1280.jpg",
        "https://cdn.pixabay.com/photo/2016/11/29/01/10/adorable-1866475_1280.jpg",
        "https://cdn.pixabay.com/photo/2015/11/16/14/43/cat-1045782_1280.jpg",
        "https://cdn.pixabay.com/photo/2019/11/08/11/56/cat-4611189_1280.jpg"
                ],
                Discount = 15,
                Category = "furniture",
                Variants = [
                    new Variant { VariantId = "p029v01", Name = "Medium (60x45cm)", Price = 880000, StockQuantity = 20 },
        new Variant { VariantId = "p029v02", Name = "Large (90x70cm)", Price = 1350000, StockQuantity = 15 }
                ]
            });

            AddProduct(new Product
            {
                ProductId = "p030",
                Name = "Smart Pet Food Scale",
                Brand = "PetTech",
                Description = "Digital food scale with nutrition calculator and meal planning app",
                ImageUrl = [
                    "https://cdn.pixabay.com/photo/2016/11/22/19/41/cat-1850013_1280.jpg",
        "https://cdn.pixabay.com/photo/2017/11/14/13/06/kitty-2948404_1280.jpg",
        "https://cdn.pixabay.com/photo/2019/05/08/21/21/cat-4189697_1280.jpg",
        "https://cdn.pixabay.com/photo/2018/03/27/17/25/cat-3266673_1280.jpg",
        "https://cdn.pixabay.com/photo/2020/03/31/16/17/cat-4988451_1280.jpg"
                ],
                Discount = 10,
                Category = "electronics",
                Variants = [
                    new Variant { VariantId = "p030v01", Name = "Basic Scale", Price = 450000, StockQuantity = 25 },
        new Variant { VariantId = "p030v02", Name = "Smart Scale", Price = 850000, StockQuantity = 20 }
                ]
            });
        }

        [HttpGet]
        public IActionResult GetAllProducts([FromQuery] int? limit)
        {
            if (limit.HasValue && limit.Value > 0)
            {
                return Ok(products.Take(limit.Value));
            }
            return Ok(products);
        }

        [HttpGet("{id}")]
        public IActionResult GetProduct(string id)
        {
            Product? product = products.FirstOrDefault(p => p.ProductId == id);
            if (product == null)
            {
                return NotFound($"Product with id {id} not found.");
            }
            return Ok(product);
        }

        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            if (products.Any(p => p.ProductId == product.ProductId))
            {
                return Conflict($"Product with id {product.ProductId} already exists.");
            }

            products.Add(product);
            return CreatedAtAction(nameof(GetProduct), new { id = product.ProductId }, product);
        }
    }
}