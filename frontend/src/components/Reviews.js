import * as CONSTANTS from "./constants";
import apiActions from "../api/api-actions";

export default {
    DisplayReviews
}

export function DisplayReviews(data) {
    return `<ol>
    ${data.map(review => {
        return `<li>${review.reviewContent}</li>`;
    }).join('')}
    </ol>`
}