using Application.Interfaces;
using HotelManagement.DBContext;

namespace ClassLibrary1
{
    public class MenuServices : IMenuServices
    {

        private readonly HositalManagementDbContext _dbContext;
        public MenuServices(HositalManagementDbContext dbContext) 
        {
            _dbContext = dbContext;
        }

        public void DeleteMenuDetails()
        {
            throw new NotImplementedException();
        }

        public List< MenuDetailsResponse> GetMenuItems()
        {
            // Dummy data for demonstration purposes
           var GetDetails= from t in _dbContext.Orders
                           select new MenuDetailsResponse
                           {
                               id = t.MenuId,
                               name = t.TableId.ToString()
                           };
            return GetDetails.ToList();
        }

        public MenuDetailsRequest PostMenuItems()
        {
            throw new NotImplementedException();
        }

        public MenuDetailsRequest UpdateMenuItems()
        {
            throw new NotImplementedException();
        }
    }
}
