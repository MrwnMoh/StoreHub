using StoreHub_Data.Classes.Cart;
using StoreHub_Data.Classes.Order;
using StoreHub_DTOs.Cart;
using StoreHub_DTOs.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreHub_Business.Order
{
    public class clsOrder
    {


        public async static  Task<int> PlaceOrder(DTO_OrderPlace order)
        {

            try
            {
                var res = await OrderData.PlaceOrder(order);

                return res;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public async static Task<DTO_MyOrdersResponse> ViewMyOrders(DTO_OrderViewMyRequest request)
        {

            var orders = await OrderData.ViewMyOrders(request);

            return orders;
        }


        public async static Task<DTO_OrderDetails> GetOrdersDetails(int orderId)
        {
            var order = await OrderData.GetOrdersDetails(orderId);

            return order;
        }

        public static async Task<bool> CancelOrder(int orderId)
        {
            return await OrderData.CancelOrder(orderId);
        }
        public static async Task<bool> ChangeOrderStatus(DTO_OrderChangeStatus requst)
        {
            return await OrderData.ChangeOrderStatus(requst);
        }

    }
}
