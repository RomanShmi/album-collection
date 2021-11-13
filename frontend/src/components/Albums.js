import * as CONSTANTS from "./constants";
import apiActions from "../api/api-actions";
import Album from "../components/album";
export default {
    DisplayAlbums
}

export function DisplayAlbums(data) {
    return `<ol>
    ${data.map(album => {
        return `<li> ${Album.DisplayAlbum(album)}</li>`; 

    }).join('')}
    </ol>`
}