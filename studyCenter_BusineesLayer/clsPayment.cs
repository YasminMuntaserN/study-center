using StudyCenter_DAL_;
using StudyCenter_DataAccessLayer.Global_classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyCenter_BL_
{

    public class clsPayment
    {
        public enum enMode { AddNew = 0, Update = 1 };

        public enMode Mode { get; set; } = enMode.AddNew;

        public int? PaymentID { get; set; }
        public int? PersonID { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public int? GroupID { get; set; }

        public clsPayment()
        {
            PaymentID = null;
            PersonID = null;
            Amount = 0.0m;
            PaymentDate = DateTime.Now;
            GroupID = null;

            Mode = enMode.AddNew;
        }

        private clsPayment(int paymentID, int? personID, decimal amount, DateTime paymentDate, int? groupID)
        {
            PaymentID = paymentID;
            PersonID = personID;
            Amount = amount;
            PaymentDate = paymentDate;
            GroupID = groupID;

            Mode = enMode.Update;
        }

        private bool _Add()
        {
            PaymentID = clsPaymentData.Add(PersonID, Amount, PaymentDate, GroupID);
            return PaymentID.HasValue;
        }

        private bool _Update()
            => clsPaymentData.Update(PaymentID, PersonID, Amount, PaymentDate, GroupID);

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_Add())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return _Update();
            }

            return false;
        }

        public static clsPayment Find(int? paymentID)
        {
            int? personID = null;
            decimal? amount = null;
            DateTime? paymentDate = null;
            int? groupID = null;

            bool isFound = clsPaymentData.GetInfoByID(paymentID, ref personID, ref amount, ref paymentDate, ref groupID);

            return isFound ? new clsPayment(paymentID.Value, personID, amount.Value, paymentDate.Value, groupID) : null;
        }

        public static bool Delete(int? paymentID)
            => clsPaymentData.Delete(paymentID);

        public static bool Exists(int? paymentID)
            => clsPaymentData.Exists(paymentID);

        public static DataTable All()
            => clsPaymentData.All();

        public static DataTable GetPaymentsByPersonID(int? personID)
            => clsPaymentData.GetPaymentsByPersonID(personID);

        public static DataTable GetPaymentsByGroupID(int? groupID)
            => clsPaymentData.GetPaymentsByGroupID(groupID);
    }

}
