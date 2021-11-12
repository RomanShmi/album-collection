import header from "../components/header";
import * as CONSTANTS from "../components/constants";

const headerElement = document.getElementById("navbar");

export default() => {
   SetupHeader();
   SetupHome();
   SetupFooter();
}

function SetupHeader(){
   headerElement.innerHTML = H.SetupNavBar();
   H.SetupHeaderEventListeners();
}

function SetupHome(){
   CONSTANTS.Title.innerText = "Welcome";
   CONSTANTS.Content.innerHTML = "<p>Fink Ployd's Music Collection & Review Site</p>";
}

function SetupFooter(){
   footerElement.innerHTML = F.SetupNavBar();
   F.SetupFooterEventListeners();
}