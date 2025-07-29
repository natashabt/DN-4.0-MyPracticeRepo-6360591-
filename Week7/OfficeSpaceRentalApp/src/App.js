import React from 'react';

function App() {
  const office = {
    name: 'DBS',
    rent: 50000,
    address: 'Chennai',
    image: 'https://images.unsplash.com/photo-1570129477492-45c003edd2be' // or any image you like
  };

  const rentStyle = {
    color: office.rent < 60000 ? 'red' : 'green',
    fontWeight: 'bold'
  };

  const headingStyle = {
    textAlign: 'center',
    fontFamily: 'Arial',
    marginTop: '20px'
  };

  const containerStyle = {
    textAlign: 'center',
    fontFamily: 'Arial',
    marginTop: '30px'
  };

  return (
    <div style={containerStyle}>
      <h1 style={headingStyle}>Office Space , at Affordable Range</h1>

      <img
        src={office.image}
        alt="Office"
        width="300"
        height="200"
        style={{ borderRadius: '8px' }}
      />

      <h2 style={{ marginTop: '20px' }}>Name: {office.name}</h2>

      <p style={rentStyle}>Rent: Rs. {office.rent}</p>

      <p><strong>Address:</strong> {office.address}</p>
    </div>
  );
}

export default App;


