var currentList = {};


function showShoppingList() {
    $("#shoppingListTitle").html(currentList.name);
    $("#shoppingListItems").empty();

    $("#createListDiv").hide();
    $("#shoppingListDiv").show();
}


function createShoppingList() {
    currentList.name = $("#shoppingListName").val();
    currentList.items = new Array();

    //Web Service Call

    showShoppingList();

}



function addItem() {
    var newItem = {};
    newItem.name = $("#newItemName").val();
    currentList.items.push(newItem);
    console.info(currentList);

    drawItems();
}

function drawItems() {
    var $list = $("#shoppingListItems").empty();

    for (var i = 0; i < currentList.items.length; i++) {
        var currentItem = currentList.items[i];
        var $li = $("<li>").html(currentItem.name)
            .attr("id", "item_" + i);
        var $deleteBtn =
            $("<button onClick= 'deleteItem(" + i + ")'>D</button>").appendTo($li);
        var $checkBtn =
            $("<button onClick=  'checkItem(" + i + ")'>C</button>").appendTo($li);

        $li.appendTo($list);

    }

}

function deleteItem(index) {
    currentList.items.splice(index, 1)
    drawItems();
}

function checkItem(index) {
    if ($("#item_" + index).hasClass("checked")) {
        $("#item_" + index).removeClass("checked");
    }
    else {
        $("#item_" + index).addClass("checked");
    }
}

function getShoppingListById(id) {
    console.info(id);

    currentList.name = "Mock Shopping List";
    currentList.items = [
        { name: "Milk" },
        { name: "Bread" },
        { name: "Cookies" },
        { name: "Beer" }
    ];

    showShoppingList();
    drawItems();
}

$(document).ready(function () {
    console.info("ready")

    var pageUrl = window.location.href;
    var idIndex = pageUrl.indexOf("?id=");

    if (idIndex != -1) {
        getShoppingListById(pageUrl.substring(idIndex + 4));
    }
    //console.info(pageUrl);
});