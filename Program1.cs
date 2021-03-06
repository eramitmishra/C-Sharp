﻿using System;
namespace ConsoleApplication
{
    public class Program1
    {
        //public static void Main(string[] args)
        void Maiaan(string args)
        {
            try
            {
                string AllRoomDescription = string.Empty;
                string TotalRoom = string.Empty;
                string rooms = "2-2-5-9|1-3-9-10-8|2-1-7|2-0";
                var arrRoomSpliter = rooms.Split(new Char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                TotalRoom = arrRoomSpliter.Length.ToString();
                AllRoomDescription = string.Format("Total Room : {0} \n", TotalRoom);
                int roomCount = 0;
                foreach (string room in arrRoomSpliter)
                {
                    roomCount++;
                    string[] paxarr = room.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
                    string Adult = paxarr[0];

                    AllRoomDescription += string.Format("\nRoom {0}\n Total Adult {1}", roomCount, Adult);

                    if (!Equals(paxarr[1], "0"))
                    {
                        string Childs = string.Empty;
                        int ChildAgeIndex = 0;

                        AllRoomDescription += string.Format("\n Total number of Childs {0} \n",paxarr[1]);
                        for (int i = 1; i <= Convert.ToInt32(paxarr[1]); i++)
                        {
                            ChildAgeIndex = 1 + i;
                            Childs = paxarr[ChildAgeIndex];
                            AllRoomDescription += string.Format("\nChild {0} and his age {1}", i, Childs);
                        }
                    }

                }

                Console.WriteLine("Hello World!");

                Console.WriteLine(AllRoomDescription);
            }
            catch (System.Exception ex)
            {

                throw;
            }
        }
    }
}
