import * as CONSTANTS from "./constants";
import apiActions from "../api/api-actions";
 
var Artist = null;
 
export default {
    DisplayArtist,
    EditArtist,
    SetupEditButton
}
 
function DisplayArtist(artist){
    console.log(artist);
    Artist = artist;
       
    return `
        <h3>${artist.title}</h3>
        <button id="btnEditArtist">Edit</button>
        <ul>
            ${artist.albums.map(album => {
                return `
                    <li>
                        ${album.title}
                    </li>
                `
            }).join('')}
        </ul>
    `
}
 
export function EditArtist(artist){
    return `
        <input type="hidden" value="${artist.id}" id="Artist_id" />
        <input type="text" value="${artist.name}" id="Artist_name" />
        <h4>Albums</h4>
        ${artist.albums.map(album => {
            return `
                <input type="text" value="${album.title}" name="Album_title" id="${album.id}" />
            `
        }).join('')}
        <button id="btnSaveArtist">Update</button>
    `;
}
 
export function SetupSaveButton(){
    let btnSave = document.getElementById("btnSaveArtist");
    btnSave.addEventListener("click", function(){
        let ArtistId = document.getElementById("Artist_id").value;
        let ArtistName = document.getElementById("Artist_name").value;
 
        const editArtist = {
            Id: ArtistId,
            Name: ArtistName
        }
 
        apiActions.putRequest(CONSTANTS.artistURL, ArtistId, editArtist, data => {
            CONSTANTS.Content.innerHTML = DisplayArtist(data);
            SetupEditButton();
        });
 
        // fetch('https://localhost:44326/api/Artist/' + ArtistId, {
        //     method: "PUT",
        //     headers: {
        //         "Content-Type" : "application/json"
        //     },
        //     body: JSON.stringify(editArtist)
        // })
        // .then(response => response.json())
        // .then(data => {
        //     CONSTANTS.Content.innerHTML = DisplayArtist(data);
        //     SetupEditButton();
        // });
 
    });
}
 
export function SetupEditButton(){
    let btnEdit = document.getElementById("btnEditArtist");
    btnEdit.addEventListener("click", function(){
        CONSTANTS.Content.innerHTML = EditArtist(Artist);
        SetupSaveButton();
    });
}
