import * as CONSTANTS from "./constants";
import apiActions from "../api/api-actions";

var Album = null;

export default {
    DisplayAlbum,
    EditAlbum,
    SetupSaveButton

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
        <button id="btnDeleteAlbum">Delete</button>
        <ul>
    
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

export function EditAlbum(album){
    console.log("gggggggggggggggggggggggggg");
    return `
        <input type="hidden" value="${album.id}" id="Album_id" />
        <input type="text" value="${album.title}" id="Album_name" />
        <h4>Todo Name</h4>
        ${album.reviews.map(reviev => {
          return `
               <input type="text" value="${reviev.reviewContent}" name="Album_todos" id="${reviev.name}" />
            `
        }).join('')}
        <button id="btnSaveAlbum">Update</button>
    `;
}




export function SetupSaveButton(){
    let btnSave = document.getElementById("btnSaveAlbum");
    btnSave.addEventListener("click", function(){
        let AlbumId = document.getElementById("Album_id").value;
        let AlbumName = document.getElementById("Album_name").value;

        const editAlbum = {
            Id: AlbumId,
            Name: AlbumName
        }


        apiActions.putRequest(CONSTANTS.albumURL, albumId, editAlbum, data => {
            CONSTANTS.Content.innerHTML = DisplayAlbum(data);
            SetupEditButton();
        });

        // fetch('https://localhost:44326/api/Albums/' + AlbumId, {
        //     method: "PUT",
        //     headers: {
        //         "Content-Type" : "application/json"
        //     },
        //     body: JSON.stringify(editAlbum)
        // })
        // .then(response => response.json())
        // .then(data => {
        //     CONSTANTS.Content.innerHTML = DisplayAlbum(data);
        //     SetupEditButton();
        // });


    });
}

 export function SetupEditButton(){
  
     let btnEdit = document.getElementById("btnEditAlbum");
    btnEdit.addEventListener("click", function(){
    
         console.log("edit botton click"); 


        
         CONSTANTS.Content.innerHTML =EditAlbum(album);
     console.log("edit botton click"); 
       SetupSaveButton();
    });
 }