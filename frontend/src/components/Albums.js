import * as CONSTANTS from "./constants";
import apiActions from "../api/api-actions";
import Album from "./album";

export default {
    DisplayAlbums,
    SetupEditButton
}

export function DisplayAlbums(data) {
    return `<ol>
    <button id="btnAddbutton">add album</button> 
    ${data.map(album => {
        return `<li>
            <h3>${album.title}</h3>
            <button name="btnEditAlbum">Edit</button>
            <button name="btnDeleteAlbum">Delete</button>
            <ul>
        
            ${album.reviews.map(reviev => {
                    return `
                        <li>
                            ${reviev.reviewContent}
                        </li>
                    `
                }).join('')}
            </ul>
        </li>`; 

    }).join('')}
    </ol>`
}

export function SetupEditButton(){
    console.log('put in your event listener code for album details...');
    let btnEdit = document.getElementById("btnEditAlbum");
   btnEdit.addEventListener("click", function(){
    
 


        
         CONSTANTS.Content.innerHTML =EditAlbum(album);

    Album.SetupSaveButton();
})};