import React from 'react';

function BlogDetails() {
  const blogs = [
    {
      title: 'React Learning',
      author: 'Stephen Biz',
      content: 'Welcome to learning React!'
    },
    {
      title: 'Installation',
      author: 'Schewzdenier',
      content: 'You can install React from npm.'
    }
  ];

  return (
    <div className="column">
      <h2>Blog Details</h2>
      {blogs.map((blog, idx) => (
        <div key={idx}>
          <strong>{blog.title}</strong><br />
          <em>{blog.author}</em><br />
          <p>{blog.content}</p>
        </div>
      ))}
    </div>
  );
}

export default BlogDetails;

