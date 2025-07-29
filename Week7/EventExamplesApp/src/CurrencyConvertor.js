import React, { useState } from 'react';

function CurrencyConvertor() {
  const [amount, setAmount] = useState('');
  const [currency, setCurrency] = useState('');

  const handleSubmit = (event) => {
    event.preventDefault();

    let result = 0;

    if (currency.toLowerCase() === 'euro') {
      result = parseFloat(amount) * 80; // e.g. ₹1 = €0.0125 → 1/0.0125 = 80
    } else {
      alert("Only 'Euro' supported now.");
      return;
    }

    alert(`Converting to  ${currency} Amount is ${result}`);
  };

  return (
    <div>
      <h2 style={{ color: 'green' }}>Currency Convertor!!!</h2>
      <form onSubmit={handleSubmit}>
        <label>
          Amount:
          <input
            type="number"
            value={amount}
            onChange={(e) => setAmount(e.target.value)}
          />
        </label>
        <br />
        <label>
          Currency:
          <input
            type="text"
            value={currency}
            onChange={(e) => setCurrency(e.target.value)}
          />
        </label>
        <br />
        <button type="submit">Submit</button>
      </form>
    </div>
  );
}

export default CurrencyConvertor;

