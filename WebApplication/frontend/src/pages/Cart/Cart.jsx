import React, { useContext, useState } from 'react';
import './Cart.css';
import { StoreContext } from '../../context/StoreContext';

const Cart = () => {
  const { cartItems, food_list, removeFromCart, getTotalCartAmount, clearCart } = useContext(StoreContext);

  const [formData, setFormData] = useState({
    firstName: '',
    lastName: '',
    email: '',
    street: '',
    address: '',
    phone: ''
  });

  const [isOrderPlaced, setIsOrderPlaced] = useState(false);

  const [orderTotal, setOrderTotal] = useState(0);

  const handleInputChange = (e) => {
    const { name, value } = e.target;
    setFormData({
      ...formData,
      [name]: value
    });
  };

  const validateForm = () => {
    const { firstName, lastName, email, street, address, phone } = formData;
    if (!firstName || !lastName || !email || !street || !address || !phone) {
      alert('Please fill out all the delivery information fields.');
      return false;
    }
    return true;
  };

  const handleProceedToPayment = async () => {
    if (validateForm()) {
    
      const subtotal = getTotalCartAmount();
      const deliveryFee = subtotal === 0 ? 0 : 400;
      const total = subtotal + deliveryFee;

      const orderData = {
        ...formData,
        subtotal,
        deliveryFee,
        total,
        items: food_list
          .filter(item => cartItems[item._id] > 0)
          .map(item => ({
            title: item.name,
            quantity: cartItems[item._id],
            price: item.price
          }))
      };

      try {
        const response = await fetch('http://localhost:5160/save-order', {
          method: 'POST',
          headers: {
            'Content-Type': 'application/json',
          },
          body: JSON.stringify(orderData),
        });
        const data = await response.json();
        if (response.ok) {
          alert('Order placed successfully!');
          setIsOrderPlaced(true);
          setOrderTotal(total);
          clearCart();
        } else {
          alert('Failed to place order. Please try again.');
        }
      } catch (error) {
        console.error('Error:', error);
        alert('An error occurred. Please try again.');
      }
    }
  };

  if (isOrderPlaced) {
    return (
      <div className="order-summary">
        <h2>Order Summary</h2>
        <div className="summary-details">
          <h3>Delivery Information</h3>
          <p><strong>Name:</strong> {formData.firstName} {formData.lastName}</p>
          <p><strong>Email:</strong> {formData.email}</p>
          <p><strong>Street:</strong> {formData.street}</p>
          <p><strong>Address:</strong> {formData.address}</p>
          <p><strong>Phone:</strong> {formData.phone}</p>
        </div>
        <div className="summary-details">
          <h3>Order Details</h3>
          <p><strong>Subtotal:</strong> Rs. {orderTotal - 400}.00</p>
          <p><strong>Delivery Fee:</strong> Rs. 400.00</p>
          <p><strong>Total:</strong> Rs. {orderTotal}.00</p>
        </div>
        <button onClick={() => setIsOrderPlaced(false)}>Place Another Order</button>
      </div>
    );
  }

  return (
    <div className='cart'>
      <div className="cart-items">
        <div className="cart-items-title">
          <p>Items</p>
          <p>Title</p>
          <p>Price</p>
          <p>Quantity</p>
          <p>Total</p>
          <p>Remove</p>
        </div>
        <br />
        <hr />
        {food_list.map((item, index) => {
          if (cartItems[item._id] > 0) {
            return (
              <div key={index} className='cart-items-title cart-items-item'>
                <img src={item.image} alt="" />
                <p>{item.name}</p>
                <p>Rs. {item.price}.00</p>
                <p>{cartItems[item._id]}</p>
                <p>Rs. {item.price * cartItems[item._id]}.00</p>
                <p onClick={() => removeFromCart(item._id)} className='cross'>x</p>
              </div>
            );
          }
          return null;
        })}
      </div>

      <form className='place-order'>
        <div className="place-order-left">
          <p className="title">Delivery Information</p>
          <div className="multi-fields">
            <input type="text" placeholder='First name' name="firstName" value={formData.firstName} onChange={handleInputChange} />
            <input type="text" placeholder='Last name' name="lastName" value={formData.lastName} onChange={handleInputChange} />
          </div>
          <input type="text" placeholder='Email address' name="email" value={formData.email} onChange={handleInputChange} />
          <input type="text" placeholder='Street' name="street" value={formData.street} onChange={handleInputChange} />
          <div className="multi-fields">
            <input type="text" placeholder='Address' name="address" value={formData.address} onChange={handleInputChange} />
          </div>
          <input type="text" placeholder='Phone' name="phone" value={formData.phone} onChange={handleInputChange} />
        </div>

        <div className="place-order-right">
          <div className="cart-total">
            <h2>Cart Totals</h2>
            <div>
              <div className="cart-total-details">
                <p>Subtotal</p>
                <p>Rs. {getTotalCartAmount()}.00</p>
              </div>
              <hr />
              <div className="cart-total-details">
                <p>Delivery Fee</p>
                <p>Rs. {getTotalCartAmount() === 0 ? 0 : 400}.00</p>
              </div>
              <hr />
              <div className="cart-total-details">
                <b>Total</b>
                <b>Rs. {getTotalCartAmount() === 0 ? 0 : getTotalCartAmount() + 400}.00</b>
              </div>
            </div>
            <button type="button" onClick={handleProceedToPayment}>PAY NOW</button>
          </div>
        </div>
      </form>
    </div>
  );
};

export default Cart;