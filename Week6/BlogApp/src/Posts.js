// Posts.js
import React from 'react';
import Post from './Post';

class Posts extends React.Component {
  constructor(props) {
    super(props);
    this.state = {
      posts: [],
      hasError: false
    };
  }

  // 🔁 Step 6: Fetch API call karne ke liye method
  loadPosts = () => {
    fetch('https://jsonplaceholder.typicode.com/posts')
      .then(res => res.json())
      .then(data => {
        this.setState({ posts: data });
      })
      .catch(error => {
        console.error("Error fetching posts:", error);
        this.setState({ hasError: true });
      });
  };

  // ✅ Step 7: componentDidMount
  componentDidMount() {
    this.loadPosts();
  }

  // ❗ Step 9: componentDidCatch
  componentDidCatch(error, info) {
    alert("An error occurred in Posts component.");
  }

  // 🖼️ Step 8: Render
  render() {
    if (this.state.hasError) {
      return <p style={{ color: 'red' }}>Something went wrong!</p>;
    }

    return (
      <div>
        <h1>Blog Posts</h1>
        {this.state.posts.map(post => (
          <Post key={post.id} title={post.title} body={post.body} />
        ))}
      </div>
    );
  }
}

export default Posts;
