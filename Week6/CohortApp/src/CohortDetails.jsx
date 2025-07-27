// CohortDetails.jsx
import React from 'react';
import styles from './CohortDetails.module.css'; // CSS Module import

const CohortDetails = (props) => {
  return (
    <div className={styles.box}>
      <h3 style={{ color: props.status === "ongoing" ? "green" : "blue" }}>
        {props.name}
      </h3>
      <dl>
        <dt>Status</dt>
        <dd>{props.status}</dd>
        <dt>Duration</dt>
        <dd>{props.duration}</dd>
      </dl>
    </div>
  );
};

export default CohortDetails;
