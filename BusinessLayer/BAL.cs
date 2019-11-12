using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseLayer;

namespace BusinessLayer
{
    public class BAL
    {
        public static List<CustomerRegestration> GetAllCustomers()
        {
            return DAL.GetAllCustomers();
        }

        public static int InsertRegister(CustomerRegestration insertCusreg)
        {
            return DAL.SaveCusRegistration(insertCusreg);
        }

        public static int UpdateStudentDetails(CustomerRegestration insertCusreg)
        {
            return DAL.UpdateCusRegistration(insertCusreg);
        }

        public static List<Room> GetAllRooms()
        {
            return DAL.GetAllRooms();
        }

        public static void InsertRoomsBooked(checkout checkoutdetails)
        {
            DAL.InsertRoomsBooked(checkoutdetails);
        }

        public static List<Customeraddress> GetAlladdress()
        {
            return DAL.GetAllAddress();
        }

        public static List<checkout> GetAllBooked()
        {
            return DAL.GetAllBooked();
        }

        public static void InsertAddress(Customeraddress insertcusadd)
        {
            DAL.InsertAddress(insertcusadd);
        }

        public static int UpdateRoomDetails(Room insertreg)
        {
            return DAL.UpdateRoomDetails(insertreg);
        }

        public static List<CustomerRegestration> GetUser(string id)
        {
            return DAL.GetCustomerDetails(id);
        }

        public static void DeleteRecord(string selectedValue)
        {
            DAL.DeleteRecord(selectedValue);
        }

        public static void InsertRoomDetails(Room Roomsdetails)
        {
            DAL.InsertRoomDetails(Roomsdetails);
        }

        public static List<Room> getRoomDetails(string id)
        {
            return DAL.GetRoomDetails(id);
        }

        public static List<Login> GetDataTable(string username, string password)
        {
          return DAL.GetDataTable(username,password);
        }

        public static void DeleteRoom(object selectedValue)
        {
            DAL.DeleteRoom(selectedValue);
        }
    }
}
