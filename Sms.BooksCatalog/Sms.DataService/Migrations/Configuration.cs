namespace Sms.DataService.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.IO;
    using System.Linq;
    using Sms.DL.Entities;

    internal sealed class Configuration : DbMigrationsConfiguration<Sms.DataService.DataAccessLayer.DatabaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Sms.DataService.DataAccessLayer.DatabaseContext context)
        {
                string booksImageDataServicePath = @"D:\Bitbucket\redberry\Sms.BooksCatalog\Sms.DataService\";
                var book1 = new Book
                {
                    Author = "������ �.�",
                    Title = "�������������� ���������� ��� ��������",
                    Description = "��� �� �����, ��� ������ �������� � ������ ������ ����� � �����, �� �� ������ �������� ����� �� ����� �� �������� ��� �����!",
                    ProductionDate = new DateTime(1955, 1, 1),
                    Url = @"\\nash\server\knigi_dla_gikkoff\it-intro.djvu",
                    BookImage = File.ReadAllBytes(booksImageDataServicePath + @"___images\b1.jpg")
                };

                var book2 = new Book
                {
                    Author = "������ �.�",
                    Title = "�������� �� �����",
                    Description = "������� ������ ��� ���������. ����� ����� �����. ��� ��� ��� ��� ������, �������� ����������� ����� ��������� ��� ��� ����� ������!",
                    ProductionDate = new DateTime(1965, 1, 1),
                    Url = @"\\nash\server\knigi_dla_gikkoff\kruto.djvu",
                    BookImage = File.ReadAllBytes(booksImageDataServicePath + @"___images\b2.jpg")
                };

                var book3 = new Book
                {
                    Author = "������� �.�, ������ �.�",
                    Title = "�������� �� ����� - 2",
                    Description = "������ ����� �����������!! ������� ������ ��� ���������. ����� ����� �����. ��� ��� ��� ��� ������, �������� ����������� ����� ��������� ��� ��� ����� ������!",
                    ProductionDate = new DateTime(1965, 1, 1),
                    Url = @"\\nash\server\knigi_dla_gikkoff\kruto-2.djvu",
                    BookImage = File.ReadAllBytes(booksImageDataServicePath + @"___images\b2.jpg")
                };

                context.Books.Add(book1);
                context.Books.Add(book2);
                context.Books.Add(book3);
                context.SaveChanges();

                var catalog1 = new Catalog { Books = new List<Book>() { book1, book2 }, CatalogName = "����������������" };
                var catalog2 = new Catalog { Books = new List<Book>() { book3 }, CatalogName = "����������� (� �� ������)" };
                var catalog3 = new Catalog { Books = new List<Book>() { book1, book2, book3 }, CatalogName = "��� �����" };

                context.Catalogs.Add(catalog1);
                context.Catalogs.Add(catalog2);
                context.Catalogs.Add(catalog3);

                context.SaveChanges();
            
        }
    }
}
