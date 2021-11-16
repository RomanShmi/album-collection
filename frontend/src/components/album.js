import * as CONSTANTS from "./constants";
import apiActions from "../api/api-actions";

var Album = null;

export default {
    DisplayAlbum,
   }

function DisplayAlbum(album){
    console.log("hhhhhhhhhhhhhhhhhhhhhhhhhhhhhh");
   // Album = album;
    if(album.reviews == null){
        album.reviews = [];
    }
 
    return `
        <h3>${album.title}</h3>
        <button id="btnEditAlbum">Edit</button>
    
        <ul>
    ${album.artist}
        ${album.reviews.map(reviev => {
                return `
                    <li>
                        ${reviev.reviewContent}

                    </li>
                `
            }).join('')}
        </ul>
    `
 //  SetupEditButton();
}

