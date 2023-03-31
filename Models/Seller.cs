namespace SaleProject.Models
{
    public class Seller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public int? DepartmentId { get; set; }
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();

        public Seller() { }

        public Seller(string name, string email, DateTime birthDate, double baseSalary, Department department)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddSales(SalesRecord salesRecords)
        {
            Sales.Add(salesRecords);
        }
        public void RemoveSales(SalesRecord salesRecords)
        {
            Sales.Remove(salesRecords);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sales.Where(sRecord => sRecord.Date >= initial && sRecord.Date <= final).Sum(sRecord => sRecord.Amount);
        }
    }
}
