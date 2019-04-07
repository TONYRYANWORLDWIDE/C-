var currentList = {};

function createShoppingList() {
    currentList.name = $("#shoppingListName").val();

    //Web Service Call

    $("#shoppingListTitle").html(currentList.name);
    $("#shoppingListItems").empty();

    $("#createListDiv").hide();
    $("#shoppingListDiv").show();




}


$(document).ready(function () {
    console.info("ready")
});