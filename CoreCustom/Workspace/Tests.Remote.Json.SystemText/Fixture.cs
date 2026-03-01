namespace Tests.Workspace.Remote
{
    public class Fixture : Tests.Workspace.Fixture
    {
        public Fixture()
        {
            this.Factory = new TestWebApplicationFactory();
        }

        public TestWebApplicationFactory Factory { get; }

        public override void Dispose()
        {
            this.Factory.Dispose();
            base.Dispose();
        }
    }
}
