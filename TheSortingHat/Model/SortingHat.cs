using System;

namespace TheSortingHat.Model
{
    internal class SortingHat
    {
        private SchoolCollege _college;

        public SortingHat()
        {
            College = Sort();
        }

        internal SchoolCollege College
        {
            get
            {
                return _college;
            }

            set
            {
                _college = value;
            }
        }

        public SchoolCollege Sort()
        {
            Random rnd = new Random();
            switch (rnd.Next(0, 4))
            {
                case 0:
                    return SchoolCollege.Gryffindor;
                case 1:
                    return SchoolCollege.Hufflepuff;
                case 2:
                    return SchoolCollege.Ravenclaw;
                case 3:
                    return SchoolCollege.Slytherin;
                default:
                    return SchoolCollege.Gryffindor;
            }
        }

        public override string ToString()
        {
            return $"You will go to: {College}!";
        }
    }

    enum SchoolCollege
    {
        Gryffindor,
        Hufflepuff,
        Ravenclaw,
        Slytherin
    }
}
