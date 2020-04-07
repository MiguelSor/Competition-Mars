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
                ShareSkill ShareSkillPage = new ShareSkill();
                //Test Share Skill Page, Enter Share Skill Method
                ShareSkillPage.EnterShareSkill();
            }

            [Test,Order(2)]
            public void EditShareSkill()
            {
                ManageListings EditShareSkillPage = new ManageListings();
                //Test Share Skill Page, Enter Edit Share Skill Method
                EditShareSkillPage.EditShareSkill();
            }

            [Test,Order(3)]
            public void DeleteShareSkill()
            {

            }


        }
    }
}