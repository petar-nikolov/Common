namespace CMS.UI
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public void PlaceOrder()
        {

            // -- If this is a new customer, create the customer record --
            // Determine whether the customer is an existing customer.
            // If not, validate entered customer information
            // If not valid, notify the user.
            // If valid,
            // Utilise repo to setup Customer
            // Set stored procedure parameters with the customer data.
            // Call the save stored procedure.

            // -- Create the order for the customer. --
            // For each item ordered,
            // Validate the entered information.
            // If not valid, notify the user.
            // If valid,
            // Utilise repo to setup order
            // Set stored procedure parameters with the order data.
            // Call the save stored procedure.

            // -- Order the items from inventory --
            // For each item ordered,
            // Locate the item in inventory.
            // If no longer available, notify the user.
            // If any items are back ordered and
            // the customer does not want split orders,
            // notify the user.
            // If the item is available,
            // Decrement the quantity remaining.
            // Utilise repo to process items
            // Set stored procedure parameters with the inventory data.
            // Call the save stored procedure.

            // -- Process the payment --
            // If credit card, 
            // process the credit card payment.
            // If PayPal, 
            // process the PayPal payment.
            // If there is a payment problem, notify the user.
            // Utilise repo to retrieve payment data
            // Set stored procedure parameters with the payment data.
            // Call the save stored procedure.

            //Send an email receipt:
            //If the user requested a receipt
            //Get the customer data
            //Ensure a valid email is provided
            //If no valid email, prompt Customer for valid email
            //Utilise repo to retrieve the Customer data
            //Send email

        }
    }
}
