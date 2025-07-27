import React from 'react';

function CourseDetails() {
  const courses = [
    { name: 'Angular', date: '4/5/2021' },
    { name: 'React', date: '6/3/20201' }
  ];

  return (
    <div className="column">
      <h2>Course Details</h2>
      {courses.map((course, idx) => (
        <div key={idx}>
          <strong>{course.name}</strong><br />
          <span>{course.date}</span><br /><br />
        </div>
      ))}
    </div>
  );
}

export default CourseDetails;

