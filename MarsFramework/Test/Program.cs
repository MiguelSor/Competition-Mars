using MarsFramework.Pages;
using NUnit.Framework;

namespace MarsFramework
{
    public class Program
    {
        [TestFixture]
        [Category("Sprint1")]
        class User : Global.Base
        {

            [Test,Order(1)]
            public void EnterShareSkill()
            {
                //Create an instance of Share Skill Method from ShareSkill.cs
                ShareSkill ShareSkillPage = new ShareSkill();
                //Test Share Skill method
                ShareSkillPage.EnterShareSkill();
            }

            [Test,Order(2)]
            public void EditShareSkill()
            {
                //Create an instance of Edit Share Skill Method from ManageListings.cs
                ManageListings EditShareSkillListing = new ManageListings();
                //Test EditShareSkill method
                EditShareSkillListing.EditShareSkill();
            }

            [Test,Order(3)]
            public void DeleteShareSkill()
            {
                //Create an instance of Delete Share Skill Method from ManageListings.cs
                ManageListings DeleteShareSkillListing = new ManageListings();
                //Test DeleteShareSkill method
                DeleteShareSkillListing.DeleteShareSkill();
            }


        }
    }
}