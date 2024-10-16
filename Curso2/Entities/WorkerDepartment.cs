using Curso2.Entities.Enums;

namespace Curso2.Entities
{
	public class WorkerDepartment
	{
		public Departaments Department { get; set; }
		public string Name { get; set; }
		public WorkerLevel Level { get; set; }
		public double BaseSalary { get; set; }
		public List<HourContract> Contracts { get; set; } = new List<HourContract>();

		public WorkerDepartment() { }
		public WorkerDepartment(Departaments department, string name, WorkerLevel level, double baseSalary)
		{
			Department = department;
			Name = name;
			Level = level;
			BaseSalary = baseSalary;
		}

		public void addContract(HourContract contract)
		{
			Contracts.Add(contract);
		}
		public void removeContract(HourContract contract)
		{
			Contracts.Remove(contract);
		}
		public double Income(int Year, int Month)
		{
			double sum = BaseSalary;
			foreach (HourContract contract in Contracts)
			{
				if (contract.Date.Year == Year && contract.Date.Month == Month)
				{
					sum += contract.totalValue();
				}
				
			}
			return sum;
		}

	}
}
