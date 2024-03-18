namespace PlannerAppV2.Shared
{
    public partial class MainLayout
    {
        public bool _drawerOpen = true;

        public void DrawerToggle()
        {
            _drawerOpen = !_drawerOpen;
        }
    }
}
