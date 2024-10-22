import React from "react";
import Post from "./Post";

function ListPosts({ posts,onDelete }) {

  return (
    <div>
      <h3>Mevcut Postlar</h3>
      <div className="post-list">
        {posts.map((post, index) => {
          return <Post post={post} onDelete={onDelete} />;
        })}
      </div>
    </div>
  );
}

export default ListPosts;
