import * as CONSTANTS from "./constants";
import apiActions from "../api/api-actions";

export default {
    DisplayArtists
}

export function DisplayArtists(data) {
    return `<ol>
    ${data.map(artist => {
        return `<li>${artist.name}</li>`;
    }).join('')}
    </ol>`
}