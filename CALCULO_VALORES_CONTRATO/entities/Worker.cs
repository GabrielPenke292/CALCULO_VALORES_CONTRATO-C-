using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CALCULO_VALORES_CONTRATO.entities.enums;

namespace CALCULO_VALORES_CONTRATO.entities
{
    internal class Worker
    {
        private string name;
        private WorkerLevel level;
        private double baseSalary;
        private Department department;
        private List<HourContract> contracts = new List<HourContract>();

        // getters and setters
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public WorkerLevel Level
        {
            get { return level; }
            set { level = value; }
        }

        public double BaseSalary
        {
            get { return baseSalary; }
            set { baseSalary = value; }
        }

        public Department Department
        {
            get { return department; }
            set { department = value; }
        }

        public List<HourContract> Contracts
        {
            get { return contracts; }
        }

        // constructors
        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            this.name = name;
            this.level = level;
            this.baseSalary = baseSalary;
            this.department = department;
        }

        // methods
        public void addContract(HourContract contract)
        {
            contracts.Add(contract);
        }

        public void removeContract(HourContract contract)
        {
            contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double sum = baseSalary;
            
            foreach (HourContract contract in Contracts)
            {
                DateTime contractDate = contract.Date;
                
                if (contractDate.Year == year && contractDate.Month == month)
                {
                    sum += contract.totalValue();
                }
            }
            return sum;
        }
    }
}
