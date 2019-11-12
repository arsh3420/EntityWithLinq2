using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLayer
{
    public class DAL
    {
        public static List<CustomerRegestration> GetAllCustomers()
        {
            List<CustomerRegestration> lst = null;
            using (HotelBookingsEntities db = new HotelBookingsEntities())
            {
                lst = (from u in db.CustomerRegestrations select u).ToList();
            }
            return lst;
        }

        public static List<Customeraddress> GetAllAddress()
        {
            List<Customeraddress> lst = null;
            using (HotelBookingsEntities db = new HotelBookingsEntities())
            {
                lst = (from u in db.Customeraddresses select u).ToList();
                return lst;
            }

        }

        public static List<checkout> GetAllBooked()
        {
            using (HotelBookingsEntities db = new HotelBookingsEntities())
            {
                var lst1 = (from u in db.checkouts select u).ToList();
                return lst1;
            }

        }

        public static void InsertAddress(Customeraddress insertadd)
        {
            using (HotelBookingsEntities db = new HotelBookingsEntities())
            {
                db.Customeraddresses.Add(insertadd);
                db.SaveChanges();
            }
        }

        public static int UpdateRoomDetails(Room insertCusreg)
        {
            using (HotelBookingsEntities db = new HotelBookingsEntities())
            {
                //Lembda expression
                Room c = db.Rooms.SingleOrDefault(x => x.Room_id == insertCusreg.Room_id);
                c.Roomno = insertCusreg.Roomno;
                c.Beds = insertCusreg.Beds;
                c.Floor = insertCusreg.Floor;
                c.Type = insertCusreg.Type;
                db.SaveChanges();
                return insertCusreg.Room_id;
            }
        }

        public static List<CustomerRegestration> GetCustomerDetails(string selectedValue)
        {
            List<CustomerRegestration> lst = null;
            using (HotelBookingsEntities db = new HotelBookingsEntities())
            {
                lst = (from u in db.CustomerRegestrations where u.CustomerID.ToString() == selectedValue select u).ToList();
            }
            return lst;
        }

        public static void DeleteRoom(object selectedValue)
        {
            using (HotelBookingsEntities db = new HotelBookingsEntities())
            {
                Room c = db.Rooms.SingleOrDefault(x => x.Room_id.ToString().Trim() == selectedValue.ToString().Trim());
                if (c != null)
                {
                    db.Rooms.Remove(c);
                    db.SaveChanges();
                }

            }
        }

        public static List<Room> GetRoomDetails(string id)
        {
            List<Room> lst = null;
            using (HotelBookingsEntities db = new HotelBookingsEntities())
            {
                lst = (from u in db.Rooms where u.Room_id.ToString() == id select u).ToList();
            }
            return lst;
        }

        public static void InsertRoomDetails(Room Roomsdetails)
        {
            using (HotelBookingsEntities db = new HotelBookingsEntities())
            {
                db.Rooms.Add(Roomsdetails);
                db.SaveChanges();
            }
        }

        public static List<Login> GetDataTable(string username, string password)
        {
            try
            {
                List<Login> lst = null;
                using (HotelBookingsEntities db = new HotelBookingsEntities())
                {
                   lst = (from u in db.Logins where u.username == username && u.password==password select u).ToList();
                    return lst;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static List<Room> GetAllRooms()
        {
            List<Room> lst = null;
            using (HotelBookingsEntities db = new HotelBookingsEntities())
            {
                lst = (from u in db.Rooms select u).ToList();
            }
            return lst;
        }

        public static void InsertRoomsBooked(checkout checkoutdetails)
        {
            using (HotelBookingsEntities db = new HotelBookingsEntities())
            {
                db.checkouts.Add(checkoutdetails);
                db.SaveChanges();
            }
        }

        public static int SaveCusRegistration(CustomerRegestration insertCusreg)
        {
            using (HotelBookingsEntities db = new HotelBookingsEntities())
            {
                db.CustomerRegestrations.Add(insertCusreg);
                db.SaveChanges();
                return insertCusreg.CustomerID;
            }
        }

        public static int UpdateCusRegistration(CustomerRegestration insertCusreg)
        {
            using (HotelBookingsEntities db = new HotelBookingsEntities())
            {
                //Lembda expression

                CustomerRegestration c = db.CustomerRegestrations.SingleOrDefault(x => x.CustomerID == insertCusreg.CustomerID);
                c.FirstNAME = insertCusreg.FirstNAME;
                c.LastNAME = insertCusreg.LastNAME;
                c.EMAILID = insertCusreg.EMAILID;
                c.PHONE = insertCusreg.PHONE;
                db.SaveChanges();
                return insertCusreg.CustomerID;
            }
        }

        public static void DeleteRecord(string insertCusreg)
        {
            using (HotelBookingsEntities db = new HotelBookingsEntities())
            {
                CustomerRegestration c = db.CustomerRegestrations.SingleOrDefault(x => x.CustomerID.ToString().Trim() == insertCusreg.Trim());
                if (c != null)
                {
                    db.CustomerRegestrations.Remove(c);
                    db.SaveChanges();
                }
                
            }
        }

       
    }
}
