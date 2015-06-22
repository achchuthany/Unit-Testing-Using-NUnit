using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LibraryOperations
{
    public class Member
    {
        public int MemberID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int MaxiumBookCanBorrow { get; set; }
        public int Age { get; set; }
    }

    public interface IMemberManager
    {
        Member GetMember(int MemberID);
    }

   

    public class LibaryCore
    {
        private readonly IMemberManager _memberManager;
        public LibaryCore(IMemberManager memberanager)
        {
            this._memberManager = memberanager;
        }
        public double CalculateMemberShipCost(int MemberID)
        {
            double memberShipCost = 0;
            Member member = _memberManager.GetMember(MemberID);
            memberShipCost = 10 + member.MaxiumBookCanBorrow * 0.5;
            return memberShipCost;
        }

    }
}
