using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngine
{
    /// <summary>
    /// Payment Dto, which has all dto related to processing
    /// </summary>
    public class PaymentDetailsDto
    {
        public ProductEnum ProductType { get; set; }
        public ProductDto ProductDto { get; set; }
        public CustomerDto CustomerDto { get; set; }
        public MembershipDto MembershipDto { get; set; }
        public AgentDto AgentDto { get; set; }
    }

    /// <summary>
    /// Product related properties
    /// </summary>
    public class ProductDto
    {
        public int ProductId { get; set; }
        public int Price { get; set; }
    }

    /// <summary>
    /// Customer related properties
    /// </summary>
    public class CustomerDto
    {
        public string CustomerName { get; set; }
        public int CustomerId { get; set; }
        public string CustomerEmail { get; set; }
    }

    /// <summary>
    /// Membership related properties
    /// </summary>
    public class MembershipDto 
    {
        public int MembershipId { get; set; }
        public string MembershipName { get; set; }
    }

    /// <summary>
    /// Agent related properties
    /// </summary>
    public class AgentDto
    {
        public int AgentId { get; set; }
        public string AgentName { get; set; }
    }

   
}
