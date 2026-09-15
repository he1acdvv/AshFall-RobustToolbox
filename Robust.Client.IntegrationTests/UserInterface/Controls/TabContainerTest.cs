using NUnit.Framework;
using Robust.Client.UserInterface;
using Robust.Client.UserInterface.Controls;
using Robust.Shared.IoC;
using Robust.Shared.Maths;

namespace Robust.UnitTesting.Client.UserInterface.Controls;

[TestFixture]
[TestOf(typeof(TabContainer))]
public sealed class TabContainerTest : RobustUnitTest
{
    public override UnitTestProject Project => UnitTestProject.Client;

    [OneTimeSetUp]
    public void Setup()
    {
        IoCManager.Resolve<IUserInterfaceManagerInternal>().InitializeTesting();
    }

    [Test]
    public void TestLayoutSmallerThanTabHeader()
    {
        var tabContainer = new TabContainer();
        var child = new Control();
        tabContainer.AddChild(child);
        tabContainer.SetTabTitle(0, "Tab title");

        Assert.DoesNotThrow(() => tabContainer.Arrange(new UIBox2(0, 0, 1, 1)));
    }
}
