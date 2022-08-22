using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TierApp.Controllers
{
    public class CustomerController : ApiController
    {
        [Route("api/customer/profile/{id}")]
        [HttpGet]
        public HttpResponseMessage profile(int id)
        {
            var data = Customerservice.myprofile(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/customer/order/{id}")]
        [HttpGet]
        public HttpResponseMessage order(int id)
        {
            var data = Customerservice.myorder(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/customer/order/delete/{id}/{id1}")]
        [HttpGet]
        public HttpResponseMessage Order(int id,int id1)
        {
            var data = Customerservice.orderdelete(id,id1);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/customer/order/add/{id}/{id1}")]
        [HttpGet]
        public HttpResponseMessage AddProduct(int id, int id1)
        {
            var data = Customerservice.AddtoOrder(id, id1);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
    }
}
