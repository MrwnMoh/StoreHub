using StoreHub_Data.Classes.Order;
using StoreHub_Data.Classes.Seller;
using StoreHub_DTOs.Order;
using StoreHub_DTOs.Reviews;
using StoreHub_DTOs.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreHub_Business.Seller
{
    public class clsSeller
    {

        public static async Task<int> CreateSotre(DTO_SellerCreateStoreRequest request)
        {
            return await clsSellerData.CreateStore(request);
        }

        public static async Task<int> CreateProduct(DTO_SellerCreateNewProduct request)
        {
            return await clsSellerData.CreateProduct(request);
        }
        public static async Task<bool> EditProduct(DTO_SellerEditProduct request)
        {
            return await clsSellerData.EditProduct(request);
        }

        public static async Task<DTO_SellerGetStoreSammary> FirstStore(int personId)
        {
            return await clsSellerData.FirstStore(personId);
        }


        public static async Task<DTO_MyOrdersResponse> StoreOrders(DTO_SellerStoreOrdersRequest request)
        {
            return await clsSellerData.StoreOrders(request);
        }




        public static async Task<DTO_SellerGetStoreSammary> LoadStoreByStoreID(int storeId)
        {
            return await clsSellerData.LoadStoreByStoreID(storeId);
        }

        public static async Task<List<DTO_SellerStoreNameAndId>> LoadStoresNameAndId(int personId)
        {
            return await clsSellerData.LoadStoresNameAndId(personId);
        }


        public static async Task<DTO_OrderDetails> GetOrdersDetailsForStore(DTO_SellerGetOrderDetailsForStore req)
        {
            return await clsSellerData.GetOrdersDetailsForStore(req);
        }

        public static async Task<DTO_ReviewViewResponse> GetReviewsByStoreId(DTO_ReviewViewRequest req)
        {
            return await clsSellerData.GetReviewsByStoreId(req);
        }




    }
}
