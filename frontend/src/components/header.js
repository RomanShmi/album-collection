import Artists from "../components/Artists";
import Albums from "../components/Albums";
import Songs from "../components/Songs";
import Reviews from "../components/Reviews";
import * as CONSTANTS from "../components/constants";
import apiActions from "../api/api-actions";
import Album from"../components/album";
import artist from "./artist";


export default {
   SetupNavBar,
   SetupHeaderEventListeners
}

export function SetupNavBar(){
   return`
   <ul>
      <li id="navHome">Home</li>
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

function SetupHome(){
   const btnHome = document.getElementById("navHome");
   btnHome.addEventListener("click", function(){
       CONSTANTS.Title.innerText = "Home";
       CONSTANTS.Content.innerHTML = "<p>Welcome back home...</p>";
   });
}



function SetupArtists(){
   const buttonArtist = document.getElementById("navArtists");
   buttonArtist.addEventListener(
     "click", () => {
     apiActions.getRequest(CONSTANTS.artistURL, data => {
      CONSTANTS.Content.innerHTML = Artists.DisplayArtists(data);
    
   Artists.AddArtist();
           Artists.SetupDeleteButton();
         Artists.SetupEditButton();
         Artists.SetupDetailButton();
   })}
  
   
  
     );
      
   }    



 function SetupSongs(){
   
      const buttonSongs = document.getElementById("navSongs");
      buttonSongs.addEventListener(
        "click", () => {
        apiActions.getRequest(CONSTANTS.songURL, data => {
         CONSTANTS.Content.innerHTML = Songs.DisplaySongs(data);
         // Artists.SetupAddArtist();
        })}
      );
 }


 function SetupAlbums(){
  
      const buttonAlbums = document.getElementById("navAlbums");
      buttonAlbums.addEventListener(
        "click", () => {
        apiActions.getRequest(CONSTANTS.albumURL, data => {
         CONSTANTS.Content.innerHTML = Albums.DisplayAlbums(data);
         CONSTANTS.GetAllArtists();
          Albums.AddAlbum();
         Albums.SetupDeleteButton();
         Albums.SetupEditButton();
        Albums.SetupDetailButton();
        })}
      );
 }

 function SetupReviews(){
  
 const buttonReviews = document.getElementById("navReviews");
      buttonReviews.addEventListener(
        "click", () => {
        apiActions.getRequest(CONSTANTS.reviewURL, data => {
         CONSTANTS.Content.innerHTML = Reviews.DisplayReviews(data);
         // Artists.SetupAddArtist();
        })}
      );
 }


