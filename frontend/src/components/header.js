import Artists from "../components/Artists";
import * as CONSTANTS from "../components/constants";
import apiActions from "../api/api-actions";
export default {
   SetupNavBar,
   SetupHeaderEventListeners
}

export function SetupNavBar(){
   return`
   <ul>
      <li id="navHome>Home</li>
      <li id="navArtists">Artists</li>
      <li id="navSongs">Songs</li>
      <li id="navAlbums">Albums</li>
      <li id="navReviews">Reviews</li>
   </ul>
   `;
}

export function SetupHeaderEventListeners(){
   SetupArtists();
   SetupSongs();
   SetupAlbums();
   SetupReviews();
   SetupHome();
}





function SetupArtists(){
   const buttonArtist = document.getElementById("navArtists");
   buttonArtist.addEventListener(
     "click", () => {
     apiActions.getRequest(CONSTANTS.artistURL, data => {
      CONSTANTS.Content.innerHTML = Artists.DisplayArtists(data);
      // Artists.SetupAddArtist();
     })}
   );
      
      

};

// function SetupSongs(){

// };

// function SetupAlbums(){

// };

// function SetupReviews(){

// };

// function SetupHome(){

// };
