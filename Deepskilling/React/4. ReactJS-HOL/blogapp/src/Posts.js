import React from "react";
import Post from "./Post";

class Posts extends React.Component {

    constructor(props) {
        super(props);

        this.state = {
            posts: []
        };
    }

    loadPosts() {
    fetch("https://jsonplaceholder.typicode.com/posts")
        .then(response => response.json())
        .then(data => {
            this.setState({
                posts: data
            });
        });
    }

    componentDidMount() {
    this.loadPosts();
    }

    render() {
    return (
        <div>
            <h1>Blog Posts</h1>

            {
                this.state.posts.map(post => (
                    <div key={post.id}>
                        <h3>{post.title}</h3>
                        <p>{post.body}</p>
                        <hr />
                    </div>
                ))
            }
        </div>
    );
}
    
componentDidCatch(error) {
    alert(error);
}
}



export default Posts;