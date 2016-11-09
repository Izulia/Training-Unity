#pragma strict

function BUTTON_START () {
    Application.LoadLevel("Niveaux/niveau1");
}

function BUTTON_LEAVE () {
    Application.Quit();
}

function BUTTON_MENU () {
    Application.LoadLevel("Menu");
}