import * as CONSTANTS from "./constants";
import apiActions from "../api/api-actions";


export default {
    DisplayArtists,
    AddArtist
}

export function DisplayArtists(data) {
 
    return `
 
 
    <label><strong>Name:</strong></label>
    <input type='text' id='ArtistName' placeholder='Enter a name ' />
 
    <button id='btnAddArtist'>Add Artist</button>
    <ol>
    ${data.map(artist => {
        return `<li>${artist.name}
        </li>`;
    }).join('')}
    </ol>`
}
   


export function AddArtist(){
    
    const AddNewArtist = document.getElementById("btnAddArtist");
  
AddNewArtist.addEventListener("click",function(){ console.log("Add artist kick");

const newArtist ={
 name: document.getElementById("ArtistName").value
 
}

apiActions.postRequest(CONSTANTS.artistURL, newArtist, artists => {
    console.log(artists);
    // artists.length()
 CONSTANTS.Title.innerText = `Artist    is added`;
 CONSTANTS.Content.innerHTML =DisplayArtists(artists);
 //Owner.SetupEditButton();
});



});}