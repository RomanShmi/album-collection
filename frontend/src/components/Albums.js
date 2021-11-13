import * as CONSTANTS from "./constants";
import apiActions from "../api/api-actions";

export default {
    DisplayAlbums
}

export function DisplayAlbums(data) {
    return `<ol>
    ${data.map(album => {
        return `<li>${album.title}</li>`;
    }).join('')}
    </ol>`
}