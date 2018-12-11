using System;
using System.Collections.Generic;
using Homework.ConsoleApp;
using Xunit;
using System.Linq;
using FluentAssertions;

namespace Homework.Test
{
    public class Test
    {
        [Fact]
        public void TestGetAllProducts()
        {
            var sut = new Homework09();
            var result = sut.GetAllProducts();
            var products = GetProducts();
            result.Should().BeEquivalentTo(products);
        }

        [Theory]
        [MemberData(nameof(GetProductForAddToCart))]
        public void TestAddProductToCart(string productKey, Product expectProduct)
        {
            var sut = new Homework09();
            var products = sut.GetAllProducts();
            var product = products.FirstOrDefault(it => it.SKU == productKey);
            product.Should().BeEquivalentTo(expectProduct);
        }

        [Theory]
        [MemberData(nameof(GetProductsInCart))]
        public void TestGetProductsInCart(List<string> productKeys, List<Product> expectProducts)
        {
            var sut = new Homework09();
            var products = sut.GetAllProducts();
            foreach (var key in productKeys)
            {
                var product = products.FirstOrDefault(it => it.SKU == key);
                sut.AddProductToCart(product);
            }
            var productsInCart = sut.GetProductsInCart();
            productsInCart.Should().BeEquivalentTo(expectProducts);
        }

        private IEnumerable<Product> GetProducts()
        {
            var products = new List<Product>{
                new Product {
                    SKU = "p01", Name = "iPad Pro 11-inch", Price = 23900
                },
                new Product {
                    SKU = "p02", Name = "Apple Watch Series 4", Price = 14400
                },
                new Product {
                    SKU = "p03", Name = "MacBook Pro with Touch Bar", Price = 47900
                },
                new Product {
                    SKU = "p04", Name = "Apple TV 4K", Price = 8500
                },
                new Product {
                    SKU = "p05", Name = "iPhone XS", Price = 39900
                },
                new Product {
                    SKU = "p06", Name = "iPhone XS Max", Price = 43900
                },
                new Product {
                    SKU = "p07", Name = "iPhone XR", Price = 29900
                },
                new Product {
                    SKU = "p08", Name = "MacBook Air 13-inch", Price = 42900
                },
                new Product {
                    SKU = "p09", Name = "Mac Mini 2018", Price = 27900
                },
            };
            return products;
        }

        public static IEnumerable<object[]> GetProductForAddToCart = new List<object[]>
        {
            new object[] {
                "p01",
                new Product {
                    SKU = "p01", Name = "iPad Pro 11-inch", Price = 23900
                }
            },
            new object[] {
                "p02",
                new Product {
                    SKU = "p02", Name = "Apple Watch Series 4", Price = 14400
                }
            },
            new object[] {
                "p03",
                new Product {
                    SKU = "p03", Name = "MacBook Pro with Touch Bar", Price = 47900
                }
            },
            new object[] {
                "p04",
                new Product {
                    SKU = "p04", Name = "Apple TV 4K", Price = 8500
                }
            },
            new object[] {
                "p05",
                new Product {
                    SKU = "p05", Name = "iPhone XS", Price = 39900
                }
            },
            new object[] {
                "p06",
                new Product {
                    SKU = "p06", Name = "iPhone XS Max", Price = 43900
                }
            },
            new object[] {
                "p07",
                new Product {
                    SKU = "p07", Name = "iPhone XR", Price = 29900
                }
            },
            new object[] {
                "p08",
                new Product {
                    SKU = "p08", Name = "MacBook Air 13-inch", Price = 42900
                }
            },
            new object[] {
                "p09",
                new Product {
                    SKU = "p09", Name = "Mac Mini 2018", Price = 27900
                }
            }
        };

        public static IEnumerable<object[]> GetProductsInCart = new List<object[]>
        {
            new object[] {
                new List<string>{
                "p01"
                },
                new List<Product> {
                    new Product {
                        SKU = "p01", Name = "iPad Pro 11-inch", Price = 23900
                    }
                }
            },
            new object[] {
                new List<string>{
                "p01","p02"
                },
                new List<Product> {
                    new Product {
                        SKU = "p01", Name = "iPad Pro 11-inch", Price = 23900
                    },
                    new Product {
                        SKU = "p02", Name = "Apple Watch Series 4", Price = 14400
                    }
                }
            },
            new object[] {
                new List<string>{
                "p01","p02","p03"
                },
                new List<Product> {
                    new Product {
                        SKU = "p01", Name = "iPad Pro 11-inch", Price = 23900
                    },
                    new Product {
                        SKU = "p02", Name = "Apple Watch Series 4", Price = 14400
                    },
                    new Product {
                        SKU = "p03", Name = "MacBook Pro with Touch Bar", Price = 47900
                    }
                }
            },
            new object[] {
                new List<string>{
                "p09","p08","p07","p01"
                },
                new List<Product> {
                    new Product {
                        SKU = "p09", Name = "Mac Mini 2018", Price = 27900
                    },
                    new Product {
                        SKU = "p08", Name = "MacBook Air 13-inch", Price = 42900
                    },
                    new Product {
                        SKU = "p07", Name = "iPhone XR", Price = 29900
                    },
                    new Product {
                        SKU = "p01", Name = "iPad Pro 11-inch", Price = 23900
                    },
                }
            },
        };
    }
}