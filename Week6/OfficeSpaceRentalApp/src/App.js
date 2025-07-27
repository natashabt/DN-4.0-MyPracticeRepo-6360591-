import React from "react";
import ListofPlayers from "./components/ListofPlayers";
import IndianPlayers from "./components/IndianPlayers";

function App() {
  const flag = false; // 🔁 Change this to false to test the second screen

  return (
    <div className="App" style={{ margin: "20px" }}>
      <h1>{flag ? "List of Players" : "When Flag=false"}</h1>
      {flag ? <ListofPlayers /> : <IndianPlayers />}
    </div>
  );
}

export default App;

