var currentList = {};

function createShoppingList() {
    currentList.name = $("#shoppingListName").val();
    currentList.items = new Array();

    //Web Service Call

    $("#shoppingListTitle").html(currentList.name);
    $("#shoppingListItems").empty();

    $("#createListDiv").hide();
    $("#shoppingListDiv").show();
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
    $("#item_" + index).addClass("checked");
}

$(document).ready(function () {
    console.info("ready")
});