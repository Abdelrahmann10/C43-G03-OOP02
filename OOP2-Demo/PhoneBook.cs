using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_Demo
{
    internal class PhoneBook
    {
        #region Attributes
        string[] Names;
        long[] Numbers;
        int size;
        #endregion
        public int Size //Read only Prop
        {
            get { return size; }
        }
        public PhoneBook(int _size)
        {
            size = _size;
            Names = new string[size];
            Numbers = new long[size];
        }
        public void AddPerson(int Position, string Name, int Number)
        {
            if (Names is not null && Numbers is not null)
            {
                if (Position >= 0 && Position < size)
                {
                    Names[Position] = Name;
                    Numbers[Position] = Number;
                }
            }
        }
        #region Encapsulation
        //Getter
        public long GetNumber(string Name)
        {
            if (Names is not null && Numbers is not null)
            {
                for (int i = 0; i < Name.Length; i++)
                {
                    if (Name == Names[i])
                        return Numbers[i];
                }
            }
            return -1;

        }
        public void SetNumbers(string Name, long NewNumber)
        {
            if (Names is not null && Numbers is not null)
            {
                for (int i = 0; i < Name.Length; i++)
                {
                    if (Name == Names[i])

                      Numbers[i] = NewNumber;
                }
            }
        }

        //Indexer
        public long this[string Name]
        {
            get
            {
                if (Names is not null && Numbers is not null)
                {
                    for (int i = 0; i < Name.Length; i++)
                    {
                        if (Name == Names[i])
                            return Numbers[i];
                    }
                }
                return -1;
            }
            set
            {
                if (Names is not null && Numbers is not null)
                {
                    for (int i = 0; i < Name.Length; i++)
                    {
                        if (Name == Names[i])
                            Numbers[i] = NewNumber;
                    }
                }
            }
        }

        #endregion
    }
}
