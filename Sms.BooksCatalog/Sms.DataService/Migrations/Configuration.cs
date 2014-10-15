namespace Sms.DataService.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.IO;
    using System.Linq;
    using Sms.DataService.DataAccessLayer;
    using Sms.DL.Entities;

    internal sealed class Configuration : DbMigrationsConfiguration<DatabaseContext>
    {
        public Configuration()
        {
            //��������� ������������, ����� ������ ����, ����� ������
            AutomaticMigrationsEnabled = true;
        }

        /// <summary>
        /// Seed ����� ����� ���������� ��� ������ ���������� ����
        /// </summary>
        /// <param name="context"></param>
        protected override void Seed(DatabaseContext context)
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

            context.Books.AddOrUpdate(book1, book2, book3);//��� �� ����� ��������� � ���� ��������

            var catalog1 = new Catalog { Books = new List<Book>() { book1, book2 }, CatalogName = "����������������" };
            var catalog2 = new Catalog { Books = new List<Book>() { book3 }, CatalogName = "����������� (� �� ������)" };
            var catalog3 = new Catalog { Books = new List<Book>() { book1, book2, book3 }, CatalogName = "��� �����" };

            context.Catalogs.AddOrUpdate(catalog1, catalog2, catalog3); //��� �� ����� ��������� � ���� ��������
        }
    }
}
