import * as CONSTANTS from "./constants";
import apiActions from "../api/api-actions";
import Album from "./album";
import album from "./album";

export default {
    DisplayAlbums,
    AddAlbum
}





export function DisplayAlbums(data, artists) {
    console.log("show ablums with artists" +artists);
    return `
    
    <section class='addOwner'>
    <label><strong>Name:</strong></label>
    <input type='text' id='AlbumName' placeholder='Enter a name for our owner' />
   
    <div class="custom-select" style="width:200px;">
    <select id="ArtistId">
    ${artists.map(artist => {
        return `
                <option  value=${artist.id}>${artist.name}</option>
        `
    })}
    </select>
  </div>
   
   
   
   
    <button id='btnAddAlbum'>Add Album</button>
</section>
    
    
    <ol>
   
    ${data.map(album => {
        return `<li>
            <h3>${album.title}</h3>
            <button id="btnEditAlbum">Edit</button>
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
 

export function AddAlbum(){
    
       const AddNewAlbum = document.getElementById("btnAddAlbum");
     
 AddNewAlbum.addEventListener("click",function(){ console.log("Add album kick");

const newAlbum ={
    title: document.getElementById("AlbumName").value,
    artistId: document.getElementById("ArtistId").value

}
apiActions.postRequest(CONSTANTS.albumURL, newAlbum, data => {
    CONSTANTS.Title.innerText = "Album Details";
    CONSTANTS.Content.innerHTML = album.DisplayAlbum(data);
    //Owner.SetupEditButton();
});



});}
       /*
export function SetupAddOwner(){
    const btnAddOwner = document.getElementById("btnAddOwner");
    btnAddOwner.addEventListener("click", function (){
        //console.log('add owner functionality goes here...');
        const newOwner = {
            Name: document.getElementById("ownerName").value
        }

        apiActions.postRequest(CONSTANTS.OwnerAPIURL, newOwner, data => {
            CONSTANTS.Title.innerText = "Owner Details";
            CONSTANTS.Content.innerHTML = Owner.DisplayOwner(data);
            Owner.SetupEditButton();
        });

        // fetch('https://localhost:44326/api/owners', {
        //     method: "POST",
        //     headers: {
        //         "Content-Type" : "application/json"
        //     },
        //     body: JSON.stringify(newOwner)
        // })
        // .then(response => response.json())
        // .then(data => {
        //     CONSTANTS.Title.innerText = "Owner Details";
        //     CONSTANTS.Content.innerHTML = Owner.DisplayOwner(data);
        //     Owner.SetupEditButton();
        // })
        // .catch(err => console.log(err));

    });
}


       */