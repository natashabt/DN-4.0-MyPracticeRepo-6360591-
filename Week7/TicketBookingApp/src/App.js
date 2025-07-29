// src/App.js
import React, { useState } from "react";

function App() {
  const [isLoggedIn, setIsLoggedIn] = useState(false);

  const handleLogin = () => {
    setIsLoggedIn(true); // Login ho gaya
  };

  const handleLogout = () => {
    setIsLoggedIn(false); // Logout ho gaya
  };

  let content;

  if (isLoggedIn) {
    content = (
      <div>
        <h2>🎫 Welcome User</h2>
        <p>You can now book your flight tickets!</p>
        <button onClick={handleLogout}>Logout</button>
      </div>
    );
  } else {
    content = (
      <div>
        <h2>🛫 Welcome Guest</h2>
        <p>Here are the available flight details.</p>
        <button onClick={handleLogin}>Login</button>
      </div>
    );
  }

  return (
    <div style={{ textAlign: "center", marginTop: "40px" }}>
      <h1>✈️ Ticket Booking App</h1>
      {content}
    </div>
  );
}

export default App;

