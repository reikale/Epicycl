using AutoMapper;
using Epicycl.DTOs;
using Epicycl.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using System.Web.Http;

namespace Epicycl.Controllers.Api
{
    [Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private DataContext _context;
        private readonly IMapper _mapper;
        public CustomersController(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET /api/customers
        [Microsoft.AspNetCore.Mvc.HttpGet]
        public IEnumerable<CustomerDto> GetCustomers()
        {
            return _context.Customers.ToList().Select(_mapper.Map<Customer, CustomerDto>);
        }

        // GET /api/customers/id
        [Microsoft.AspNetCore.Mvc.HttpGet("{id}")]
        public ActionResult GetCustomer(int id)
        {
            var customer = _context.Customers.SingleOrDefault(x => x.Id == id);
            if (customer == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<Customer, CustomerDto>(customer));
        }

        // POST /api/customers
        [Microsoft.AspNetCore.Mvc.HttpPost]
        public ActionResult CreateCustomer(CustomerDto customerDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var customer = _mapper.Map<CustomerDto, Customer>(customerDto);
            _context.Customers.Add(customer);
            _context.SaveChanges();

            customerDto.Id= customer.Id;

            return Created(new Uri(Request.GetEncodedUrl() + "/" + customer.Id), customerDto);
        }


        // PUT /api/customers/id
        [Microsoft.AspNetCore.Mvc.HttpPut("{id}")]
        public void UpdateCustomer(int id, CustomerDto customerDto)
        {
            if (!ModelState.IsValid)
            {
                throw new HttpResponseException(System.Net.HttpStatusCode.BadRequest);
            }
            var customerInDb = _context.Customers.SingleOrDefault(x =>x.Id == id);
            if (customerInDb == null)
            {
                throw new HttpResponseException(System.Net.HttpStatusCode.NotFound);
            }
            _mapper.Map(customerDto, customerInDb);
           
            _context.SaveChanges();
        }

        // DELETE /api/customers/id
        [Microsoft.AspNetCore.Mvc.HttpDelete("{id}")]
        public void DeleteCustomer(int id)
        {
            var customerInDb = _context.Customers.SingleOrDefault(x => x.Id == id);
            if (customerInDb == null)
            {
                throw new HttpResponseException(System.Net.HttpStatusCode.NotFound);
            }
            _context.Customers.Remove(customerInDb);
            _context.SaveChanges();
        }
    }
}
