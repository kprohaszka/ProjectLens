import * as React from 'react';
import Box from '@mui/material/Box';
import ImageList from '@mui/material/ImageList';
import ImageListItem from '@mui/material/ImageListItem';
import { useState, useEffect } from 'react';
import axios from "axios";



export default function DiscoverView() {

    const [error, setError] = useState(null);
    const [isLoaded, setIsLoaded] = useState(false);
    const [pictures, setPictures] = useState([]);

    useEffect(() => {
        fetch("/api/pictures")
            .then(response => response.json())
            .then((result) => {
                console.log(result)
                setIsLoaded(true);
                setPictures(result);
            },
                (error) => {
                    setIsLoaded(true);
                    setError(error);
                }
            )
    },
        [])

    if (error) {
        return <div>Error: {error.message}</div>;
    } else if (!isLoaded) {
        return <div>Loading...</div>;
    } else {

        return (

            <div class='images-center'>
                {pictures.map((item) => (
                    <article class="image-container">
                        <img class="image-img"
                            src={`${item.route}?w=248&fit=crop&auto=format`}
                            srcset={`${item.route}?w=248&fit=crop&auto=format&dpr=2 2x`}
                            alt={item.title}
                            loading="lazy" />
                    </article>
                ))}
            </div>
        )
    }
}


