// Create a repository object that handles products
ProductRepository repo = new ProductRepository();

// Add some products to the repository
repo.Add(new Product("Laptop", 999.99));
repo.Add(new Product("Mouse", 19.99));
repo.Add(new Product("Keyboard", 29.99));

// Print the number of products in the repository
Console.WriteLine("Number of products: {0}", repo.Count());

// Remove all the products from the repository
repo.RemoveAll();

// Print the number of products in the repository again
Console.WriteLine("Number of products: {0}", repo.Count());
