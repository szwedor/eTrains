using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using DomainModel.Models;

namespace Services
{
    public class AdminPanel
    {
        private List<ConnectionDefinition> _connections;
        private DateTime _dt;
        private User _user;

        public AdminPanel() { }
        public List<Station> DepartureStations()
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                return uow.StationsRepository.Find(p => p.DepartureNo > 0 && p.IsArchival==false).ToList();
            }
        }
        public List<Station> ArrivalStations()
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                return uow.StationsRepository.Find(p => p.ArrivalNo > 0 && p.IsArchival == false).ToList();
            }
        }
        public List<Station> DepartureStationsForAddConn()
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                return uow.StationsRepository.Find(p => p.DepartureNo >= 0 && p.IsArchival == false).ToList();
            }
        }
        public List<Station> ArrivalStationsForAddConn()
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                return uow.StationsRepository.Find(p => p.ArrivalNo >= 0 && p.IsArchival == false).ToList();
            }
        }
        public List<Train> DepartureTrains()
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                return uow.TrainsRepository.Find(p=>p.Id>=1).ToList();
            }
        }
        public List<ConnectionDefinition> FindConnection(Station departure, Station arrival, DateTime date)
        {

            DayOfWeek dow = date.DayOfWeek;
            _dt = date;
            DateTime time = new DateTime(2016, 1, 1, date.Hour, date.Minute, 0);
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                _connections = unitOfWork.ConnectionsRepository.Find(p => p.IsArchival != true &&
                         p.Departure.Id == departure.Id && p.Arrival.Id == arrival.Id && p.DepartureTime.Hour >= time.Hour && p.DepartureTime.Minute > time.Minute && p.DepartureTime.DayOfWeek == dow, "Departure", "Arrival").ToList();
            }
            return _connections;
        }
        public User FindUser(string login)
        {
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                _user = new User();
                var x = unitOfWork.UsersRepository.Find(p => p.FirstName == login).ToList();
                if (x.Count == 0)
                { return null; }

                else _user = unitOfWork.UsersRepository.Find(p => p.FirstName == login).First();
            }
            return _user;
        }
        public bool ValidateUser(User passager, string pass)
        {
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                string hashpass;
                var x = unitOfWork.UsersRepository.Get(passager.Id);
                using (var sha = new System.Security.Cryptography.SHA256Managed())
                {
                    byte[] textData = System.Text.Encoding.UTF8.GetBytes(pass);
                    byte[] hash = sha.ComputeHash(textData);
                    hashpass = BitConverter.ToString(hash).Replace("-", String.Empty);
                }
                if (x.PassWord == hashpass)
                {
                    return true;
                }
                return false;

            }
        }
        public void AddStation(Station a)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                uow.StationsRepository.Add(a);
                uow.EndTransaction();
            }

        }
        public void AddConnection(Station a, Station b, Train t, DateTime ar, DateTime dp, int price)
        {
            ConnectionDefinition connection = new ConnectionDefinition()
            {
                Arrival = a,
                Departure = b,
                WeekDay = ar.DayOfWeek,
                ArrivalTime = ar,
                DepartureTime = dp,
                Name = b.Name + " " + a.Name,
                Train = t,
                Price = price,
                AvailableSeatNo = t.SeatNo
            };
            a.ArrivalNo++;
            b.DepartureNo++;
            using (UnitOfWork uow = new UnitOfWork())
            {
                uow.StationsRepository.Atached(connection.Arrival);
                uow.StationsRepository.Atached(connection.Departure);
                uow.TrainsRepository.Atached(connection.Train);
                uow.Supress(connection.Arrival);
                uow.Supress(connection.Departure);
                uow.Supress(connection.Train);
                uow.ConnectionsRepository.Add(connection);
                uow.EndTransaction();
                uow.Dispose();
            }
        }
        public bool EditStation(string a,string newname)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var oldstation= uow.StationsRepository.Find(p => p.Name == a).ToList();
                if (oldstation.Count == 0) return false;
                
                var oldconnd = uow.ConnectionsRepository.Find(p => p.Departure.Id == oldstation.ElementAt(0).Id || p.Arrival.Id==oldstation.ElementAt(0).Id).ToList();
                foreach(var item in oldconnd)
                {
                    StringBuilder newconnName = new StringBuilder();
                    newconnName.Append(item.Name);
                    newconnName.Replace(oldstation.ElementAt(0).Name, newname);
                    item.Name = newconnName.ToString();
                }
                oldstation.ElementAt(0).Name = newname;
                uow.EndTransaction();
            }

            return true;
        }
        public bool EditTrain(string t, string newname,int newplacecount)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var oldtrain = uow.TrainsRepository.Find(p => p.Name == t).ToList();
                if (oldtrain.Count == 0) return false;
                oldtrain.ElementAt(0).Name = newname;
                if(newplacecount!=0)
                {
                    oldtrain.ElementAt(0).SeatNo = newplacecount;
                }
                uow.EndTransaction();
            }
            return true;
        }
        public bool EditConnection(ConnectionDefinition conn,DateTime dt, int h, int m, int price)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var oldconn = uow.ConnectionsRepository.Get(conn.Id);
                if(price !=int.MaxValue)
                {
                    oldconn.Price = price;
                }
                if (dt==new DateTime(1970,1,1)) return true;
                if (h == int.MaxValue) h = oldconn.DepartureTime.Hour;
                if (m == int.MaxValue) m = oldconn.DepartureTime.Minute;
                if (dt == new DateTime(1970, 2, 2)) dt = oldconn.DepartureTime.Date;

                oldconn.DepartureTime = new DateTime(dt.Year, dt.Month, dt.Day, h, m, 0);
                oldconn.WeekDay = oldconn.DepartureTime.DayOfWeek;
                uow.EndTransaction();
                return true;
            }
        }

        public void DeleteStation(Station a)
        {
            using(UnitOfWork uow=new UnitOfWork())
            {
                var listconn=uow.ConnectionsRepository.Find(p => p.Name.Contains(a.Name)).ToList();
                foreach(var elem in listconn)
                {
                    elem.IsArchival = true;
                }
                uow.EndTransaction();
            }
        }
        public void DeleteConnection(Station a, Station b, Train t, DateTime ar, DateTime dp)
        {
            
            using (UnitOfWork uow = new UnitOfWork())
            {
                var con = uow.ConnectionsRepository.Find(p => p.Name== a.Name + " " + b.Name 
                                && p.DepartureTime.DayOfWeek==dp.DayOfWeek 
                                && p.DepartureTime.Hour==dp.Hour 
                                && p.DepartureTime.Minute==dp.Minute).ToList() ;
                var ca = uow.StationsRepository.Find(p => p.Name == a.Name).ToList();
                var cb = uow.StationsRepository.Find(p => p.Name == b.Name).ToList();
                if(con.Count>0)
                {
                    ca.ElementAt(0).ArrivalNo--;
                    cb.ElementAt(0).DepartureNo--;
                    con.ElementAt(0).IsArchival = true;
                }
                uow.EndTransaction();
            }
        }
    }
}
