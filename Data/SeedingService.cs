using SaleProject.Models;
using SaleProject.Models.Enums;

namespace SaleProject.Data
{
    public class SeedingService
    {
        public SaleProjectContext _context;

        public SeedingService(SaleProjectContext context)
        {
            _context = context;
        }

        public void SeedPopulateDataBase()
        {
            if (_context.Department.Any() || _context.Seller.Any() || _context.SalesRecords.Any())
            {
                return; // DB has been seeded.
            }

            Department departmentFirst = new Department(0, "Computers");
            Department departmentSecond = new Department(0, "Eletronics");
            Department departmentThird = new Department(0, "Fashion");
            Department departmentFourthy = new Department(0, "Books");

            Seller sellerOne = new Seller(0, "Bob Brown", "bob@gmail.com", new DateTime(1998, 4, 21), 1000.0, departmentFirst);
            Seller sellerTwo = new Seller(0, "Alex Pink", "bob@gmail.com", new DateTime(1997, 3, 4), 3000.0, departmentSecond);
            Seller sellerThree = new Seller(0, "Maria Green", "maria@gmail.com", new DateTime(1979, 12, 31), 3500.0, departmentSecond);
            Seller sellerFour = new Seller(0, "Alex Grey", "alex@gmail.com", new DateTime(1988, 1, 15), 2200.0, departmentFirst);
            Seller sellerFive = new Seller(0, "Martha Red", "martha@gmail.com", new DateTime(1993, 11, 30), 3000.0, departmentFourthy);
            Seller sellerSix = new Seller(0, "Donald Blue", "donald@gmail.com", new DateTime(2000, 1, 9), 4000.0, departmentThird);

            SalesRecord r1 = new SalesRecord(0, new DateTime(2018, 09, 25), 11000.0, SaleStatus.Billed, sellerOne);
            SalesRecord r2 = new SalesRecord(0, new DateTime(2018, 09, 4), 7000.0, SaleStatus.Billed, sellerFive);
            SalesRecord r3 = new SalesRecord(0, new DateTime(2018, 09, 13), 4000.0, SaleStatus.Canceled, sellerFour);
            SalesRecord r4 = new SalesRecord(0, new DateTime(2018, 09, 1), 8000.0, SaleStatus.Billed, sellerOne);
            SalesRecord r5 = new SalesRecord(0, new DateTime(2018, 09, 21), 3000.0, SaleStatus.Billed, sellerThree);
            SalesRecord r6 = new SalesRecord(0, new DateTime(2018, 09, 15), 2000.0, SaleStatus.Billed, sellerOne);
            SalesRecord r7 = new SalesRecord(0, new DateTime(2018, 09, 28), 13000.0, SaleStatus.Billed, sellerTwo);
            SalesRecord r8 = new SalesRecord(0, new DateTime(2018, 09, 11), 4000.0, SaleStatus.Billed, sellerFour);
            SalesRecord r9 = new SalesRecord(0, new DateTime(2018, 09, 14), 11000.0, SaleStatus.Pending, sellerSix);
            SalesRecord r10 = new SalesRecord(0, new DateTime(2018, 09, 7), 9000.0, SaleStatus.Billed, sellerSix);
            SalesRecord r11 = new SalesRecord(0, new DateTime(2018, 09, 13), 6000.0, SaleStatus.Billed, sellerTwo);
            SalesRecord r12 = new SalesRecord(0, new DateTime(2018, 09, 25), 7000.0, SaleStatus.Pending, sellerThree);
            SalesRecord r13 = new SalesRecord(0, new DateTime(2018, 09, 29), 10000.0, SaleStatus.Billed, sellerFour);
            SalesRecord r14 = new SalesRecord(0, new DateTime(2018, 09, 4), 3000.0, SaleStatus.Billed, sellerFive);
            SalesRecord r15 = new SalesRecord(0, new DateTime(2018, 09, 12), 4000.0, SaleStatus.Billed, sellerOne);
            SalesRecord r16 = new SalesRecord(0, new DateTime(2018, 10, 5), 2000.0, SaleStatus.Billed, sellerFour);
            SalesRecord r17 = new SalesRecord(0, new DateTime(2018, 10, 1), 12000.0, SaleStatus.Billed, sellerOne);
            SalesRecord r18 = new SalesRecord(0, new DateTime(2018, 10, 24), 6000.0, SaleStatus.Billed, sellerThree);
            SalesRecord r19 = new SalesRecord(0, new DateTime(2018, 10, 22), 8000.0, SaleStatus.Billed, sellerFive);
            SalesRecord r20 = new SalesRecord(0, new DateTime(2018, 10, 15), 8000.0, SaleStatus.Billed, sellerSix);
            SalesRecord r21 = new SalesRecord(0, new DateTime(2018, 10, 17), 9000.0, SaleStatus.Billed, sellerTwo);
            SalesRecord r22 = new SalesRecord(0, new DateTime(2018, 10, 24), 4000.0, SaleStatus.Billed, sellerFour);
            SalesRecord r23 = new SalesRecord(0, new DateTime(2018, 10, 19), 11000.0, SaleStatus.Canceled, sellerTwo);
            SalesRecord r24 = new SalesRecord(0, new DateTime(2018, 10, 12), 8000.0, SaleStatus.Billed, sellerFive);
            SalesRecord r25 = new SalesRecord(0, new DateTime(2018, 10, 31), 7000.0, SaleStatus.Billed, sellerThree);
            SalesRecord r26 = new SalesRecord(0, new DateTime(2018, 10, 6), 5000.0, SaleStatus.Billed, sellerFour);
            SalesRecord r27 = new SalesRecord(0, new DateTime(2018, 10, 13), 9000.0, SaleStatus.Pending, sellerOne);
            SalesRecord r28 = new SalesRecord(0, new DateTime(2018, 10, 7), 4000.0, SaleStatus.Billed, sellerThree);
            SalesRecord r29 = new SalesRecord(0, new DateTime(2018, 10, 23), 12000.0, SaleStatus.Billed, sellerFive);
            SalesRecord r30 = new SalesRecord(0, new DateTime(2018, 10, 12), 5000.0, SaleStatus.Billed, sellerTwo);

            _context.Department.AddRange(departmentFirst, departmentSecond, departmentThird, departmentFourthy);
            _context.Seller.AddRange(sellerOne, sellerTwo, sellerThree, sellerFour, sellerFive, sellerSix);
            _context.SalesRecords.AddRange(
                r1, r2, r3, r4, r5, r6, r7, r8, r9, r10,
                r11, r12, r13, r14, r15, r16, r17, r18, r19, r20,
                r21, r22, r23, r24, r25, r26, r27, r28, r29, r30
                );

            _context.SaveChanges();
        }
    }
}
