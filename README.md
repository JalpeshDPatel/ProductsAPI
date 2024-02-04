# ProductsAPI
------------STEP 1------------
for DataBase I have used MSSQL
create a Database,table and insert a data given below

CREATE DATABASE YourDatabaseName;

CREATE TABLE productsDB (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(MAX),
    Description NVARCHAR(MAX),
    Price FLOAT NOT NULL
);

INSERT INTO productsDB (Name, Description, Price) VALUES
    ('Saree', 'Elegant traditional Indian attire', 1499.99),
    ('Spices Box', 'Assorted spices for Indian cuisine', 349.99),
    ('Taj Mahal Replica', 'Miniature model of the iconic Taj Mahal', 799.99),
    ('Ayurvedic Oil', 'Natural Ayurvedic oil for wellness', 99.99),
    ('Handwoven Carpet', 'Traditional handcrafted carpet', 1999.99),
    ('Chai Masala', 'Blend of spices for authentic Indian tea', 49.99),
    ('Yoga Mat', 'High-quality yoga mat for fitness enthusiasts', 899.99),
    ('Bollywood DVD Collection', 'Classic Bollywood movie set', 299.99),
    ('Cotton Kurta', 'Comfortable casual Indian wear', 599.99),
    ('Ganesha Statue', 'Hindu deity Lord Ganesha sculpture', 499.99),
    ('Kumkum Box', 'Traditional container for Kumkum (vermilion)', 79.99),
    ('Biryani Spice Mix', 'Special blend for delicious Biryani', 29.99),
    ('Tabla Set', 'Musical instrument for Indian classical music', 1599.99),
    ('Hand-painted Silk Scarf', 'Artistically crafted silk scarf', 799.99),
    ('Rangoli Stencils', 'Stencils for creating colorful Rangoli patterns', 39.99),
    ('Henna Kit', 'Complete kit for beautiful henna designs', 129.99),
    ('Bamboo Flute', 'Traditional bamboo flute for music lovers', 349.99),
    ('Indian Cookbook', 'Authentic recipes for Indian dishes', 19.99),
    ('Kumkum Saree', 'Saree with intricate Kumkum patterns', 1699.99),
    ('Brass Pooja Thali', 'Traditional plate for religious rituals', 249.99)

------------STEP 2------------

 replace the connection string with your connection string in appsetting.json file

"ConnectionStrings": {
    "ProductsConnectionString": "------------------------------------------------------------"
  }

------------STEP 3------------

good to go with Backend setup

now you can build the solution and run the application
