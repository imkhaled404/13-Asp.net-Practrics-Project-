using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using AuthorizeNet.Api.Contracts.V1;
using dotnet_ECommerce.Models;
using dotnet_ECommerce.Models.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace dotnet_ECommerce.Pages.Checkout
{
    /// <summary>
    /// Inherits from PageModel class and brings in dependencies including UserManager, IEmailSender interface, and IShop interface
    /// Create a CheckoutInput class and set getter and setter
    /// </summary>
    public class IndexModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IEmailSender _emailSender;
        private readonly IShop _shop;
        private readonly IPayment _paymnet;
        private readonly IOrder _order;

        /// <summary>
        /// Constructor to take UserManager, IEmailSender, IShop, IPayment, and IOrder interfaces to enable the checkout process
        /// </summary>
        /// <param name="userManager"></param>
        /// <param name="emailSender"></param>
        /// <param name="shop"></param>
        /// <param name="payment"></param>
        /// <param name="order"></param>
        public IndexModel(UserManager<ApplicationUser> userManager, IEmailSender emailSender, IShop shop, IPayment payment, IOrder order)
        {
            _userManager = userManager;
            _emailSender = emailSender;
            _shop = shop;
            _paymnet = payment;
            _order = order;
        }

        /// <summary>
        /// Bind the Input object that contains all the required information for checkout to the property
        /// </summary>
        [BindProperty]
        public CheckoutInput Input { get; set; }

        public void OnGet()
        {
        }

        /// <summary>
        /// This post operation uses UserManager to get the current signed in user
        /// Set a variable to store the total costs of all items in the cart
        /// Set variables to store email contents for an order summary email that is to be sent out to a user after they check out
        /// After the email is sent out, redirect the user to receipt page
        /// </summary>
        /// <returns>If the ckeckout process is successful, redirect to the receipt page. Otherwise, returns to the same page</returns>
        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                ApplicationUser user = await _userManager.GetUserAsync(User);

                Order order = new Order
                {
                    UserID = user.Id,
                    FirstName = Input.FirstName,
                    LastName = Input.LastName,
                    Address = Input.Address,
                    Address2 = Input.Address2,
                    City = Input.City,
                    State = Input.State,
                    Zip = Input.Zip,
                    CreditCard = Input.CreditCard.ToString(),
                    Timestamp = DateTime.Now.ToString()
                };

                await _order.SaveOrderAsync(order);

                order = await _order.GetLatestOrderForUserAsync(user.Id);

                IEnumerable<CartItems> cartItems = await _shop.GetCartItemsByUserIdAsync(user.Id);
                IList<OrderItems> orderItems = new List<OrderItems>();
                decimal total = 0;

                foreach (var cartItem in cartItems)
                {
                    OrderItems orderItem = new OrderItems
                    {
                        OrderID = order.ID,
                        ProductID = cartItem.ProductID,
                        Quantity = cartItem.Quantity
                    };
                    orderItems.Add(orderItem);
                    total += cartItem.Product.Price * cartItem.Quantity;
                }

                double finalCost = Decimal.ToDouble(total) * 1.1;
                foreach (var item in orderItems)
                {
                    await _order.SaveOrderItemAsync(item);
                }

                string creditCardNumber;
                string creditCardExpiration;

                string cardType = Input.CreditCard.ToString();
                switch (cardType)
                {
                    case "0":
                        creditCardNumber = "4111111111111111";
                        creditCardExpiration = "0723";
                        break;
                    case "1":
                        creditCardNumber = "5424000000000015";
                        creditCardExpiration = "0922";
                        break;
                    case "2":
                        creditCardNumber = "370000000000002";
                        creditCardExpiration = "1222";
                        break;
                    default:
                        creditCardNumber = "4111111111111111";
                        creditCardExpiration = "0723";
                        break;
                }

                var creditCard = new creditCardType
                {
                    cardNumber = creditCardNumber,
                    expirationDate = creditCardExpiration
                };

                var billingAdress = new customerAddressType
                {
                    firstName = Input.FirstName,
                    lastName = Input.LastName,
                    address = Input.Address + Input.Address2,
                    city = Input.City,
                    state = Input.State,
                    zip = Input.Zip
                };

                if (_paymnet.Run(finalCost, creditCard, billingAdress))
                {
                    string subject = "Purhcase Summary From Tiny Plants!";
                    string message =
                        $"<p>Hello {user.FirstName} {user.LastName},</p>" +
                        $"<p>&nbsp;</p>" +
                        $"<p>Below is your recent purchase summary</p>" +
                        $"<p>Total: ${ finalCost.ToString("F")}\n</p>" + "<a href=\"https://dotnet-ecommerce-tiny-plants.azurewebsites.net\">Click here to shop more!<a>";

                    await _emailSender.SendEmailAsync(user.Email, subject, message);
                    await _shop.RemoveCartItemsAsync(cartItems);

                    return Redirect("/Checkout/Receipt");
                }
            }
            return Page();
        }

        public class CheckoutInput
        {
            [Display(Name = "Purchased Date:")]
            public DateTime Date { get; set; }

            [Required]
            [Display(Name = "First Name:")]
            public string FirstName { get; set; }

            [Required]
            [Display(Name = "Last Name:")]
            public string LastName { get; set; }

            [Required]
            public string Address { get; set; }

            [Display(Name = "Address 2:")]
            public string Address2 { get; set; }

            [Required]
            public string City { get; set; }

            [Required]
            public string State { get; set; }

            [Required]
            [DataType(DataType.PostalCode)]
            [Compare("Zip", ErrorMessage = "The is an invalid zip code")]
            public string Zip { get; set; }

            [Required]
            public CreditCard CreditCard { get; set; }
        }

        public enum CreditCard
        {
            Visa = 0,
            Mastercard,
            [Display(Name = "Amenrican Express")]
            AmericanExpress
        }
    }
}
