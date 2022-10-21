import React, { Component, useEffect, useState } from 'react';
import axios from 'axios';


function Threat(){
    const [posts, setPosts] = useState(null);
    
    function loadData(){
        axios.get("https://localhost:7256/api/post").then((response)=>{
            setPosts(response.data)
        })
    }
    useEffect(()=>{
        loadData();
    },[]);
    return posts ? ( 
        <div>
            {posts.map(m=>{
                <h1 key={m.id}>m.threat</h1>
            })}
        <table className='table table-striped' aria-labelledby="tabelLabel">
        <thead>
            <tr>
                <th>Title</th>
                <th>Threat</th>
                <th>Body</th>
                <th>Category</th>
            </tr>
        </thead> 
        <tbody>
           { posts.map(m => (
                <tr key={m.id}>
                    <td>{m.title}</td>
                    <td>{m.threat}</td>
                    <td>{m.body}</td>
                    <td>{m.category}</td>
                </tr>
            ))}        
    </tbody>
</table></div>): "Loading";
}
export default Threat;