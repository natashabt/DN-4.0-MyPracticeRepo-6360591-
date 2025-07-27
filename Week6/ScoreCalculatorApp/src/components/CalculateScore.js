import React from 'react';

function CalculateScore() {
  // Student details
  const name = "Shrinkhala Kumari";
  const school = "KIIT";
  const total = 450;
  const goal = 500;

  // Average calculate karo
  const average = (total / goal) * 100;

  // Style banate hain
  const containerStyle = {
    textAlign: "center",
    padding: "20px",
    marginTop: "50px",
    backgroundColor: "#f5f5f5",
    borderRadius: "10px",
    width: "60%",
    margin: "auto"
  };

  const headingStyle = {
    color: "darkblue",
    fontFamily: "Arial"
  };

  const detailStyle = {
    fontSize: "18px",
    marginTop: "10px"
  };

  // Component ka return (output)
  return (
    <div style={containerStyle}>
      <h2 style={headingStyle}>Student Score Calculator</h2>
      <p style={detailStyle}><strong>Name:</strong> {name}</p>
      <p style={detailStyle}><strong>School:</strong> {school}</p>
      <p style={detailStyle}><strong>Total Marks:</strong> {total}</p>
      <p style={detailStyle}><strong>Goal Marks:</strong> {goal}</p>
      <p style={detailStyle}><strong>Average Score:</strong> {average.toFixed(2)}%</p>
    </div>
  );
}

export default CalculateScore;
