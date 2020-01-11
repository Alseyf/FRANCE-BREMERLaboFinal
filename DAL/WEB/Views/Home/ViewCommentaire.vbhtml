@ModelType IEnumerable(Of DTO.CommentDTO)
@Code
    ViewData("Title") = "View"
End Code

<h2>View</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.Content)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Rate)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.avatar)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Date)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Content)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Rate)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.avatar)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Date)
        </td>
        <td>
            @*@Html.ActionLink("Edit", "Edit", New With {.id = item.PrimaryKey}) |
            @Html.ActionLink("Details", "Details", New With {.id = item.PrimaryKey}) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.PrimaryKey})*@
        </td>
    </tr>
Next



</table>



<form method="post" action="PostComment">
    Content: <input type="text" name="cont"><br>
    Rate: <input type="text" name="rat"><br>
    Avatar: <input type="text" name="avat"><br>
    <br>
    <input type="submit" value="Valider" class="btn btn-primary" />
</form>
