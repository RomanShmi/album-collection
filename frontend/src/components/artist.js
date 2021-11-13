import * as CONSTANTS from "./constants";
import apiActions from "../api/api-actions";

var Owner = null;

export default {
    DisplayOwner,
    EditOwner,
    SetupEditButton
}

function DisplayOwner(owner){
    console.log(owner);
    Owner = owner;
    if(owner.todos == null){
        owner.todos = [];
    }
    
    return `
        <h3>${owner.name}</h3>
        <button id="btnEditOwner">Edit</button>
        <ul>
            ${owner.todos.map(todo => {
                return `
                    <li>
                        ${todo.title}
                    </li>
                `
            }).join('')}
        </ul>
    `

}

export function EditOwner(owner){
    return `
        <input type="hidden" value="${owner.id}" id="owner_id" />
        <input type="text" value="${owner.name}" id="owner_name" />
        <h4>Todo Name</h4>
        ${owner.todos.map(todo => {
            return `
                <input type="text" value="${todo.title}" name="owner_todos" id="${todo.id}" />
            `
        }).join('')}
        <button id="btnSaveOwner">Update</button>
    `;
}

export function SetupSaveButton(){
    let btnSave = document.getElementById("btnSaveOwner");
    btnSave.addEventListener("click", function(){
        let ownerId = document.getElementById("owner_id").value;
        let ownerName = document.getElementById("owner_name").value;

        const editOwner = {
            Id: ownerId,
            Name: ownerName
        }

        apiActions.putRequest(CONSTANTS.OwnerAPIURL, ownerId, editOwner, data => {
            CONSTANTS.Content.innerHTML = DisplayOwner(data);
            SetupEditButton();
        });

        // fetch('https://localhost:44326/api/owners/' + ownerId, {
        //     method: "PUT",
        //     headers: {
        //         "Content-Type" : "application/json"
        //     },
        //     body: JSON.stringify(editOwner)
        // })
        // .then(response => response.json())
        // .then(data => {
        //     CONSTANTS.Content.innerHTML = DisplayOwner(data);
        //     SetupEditButton();
        // });


    });
}

export function SetupEditButton(){
    let btnEdit = document.getElementById("btnEditOwner");
    btnEdit.addEventListener("click", function(){
        CONSTANTS.Content.innerHTML = EditOwner(Owner);
        SetupSaveButton();
    });
}