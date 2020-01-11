@ModelType IEnumerable(Of DTO.FilmDTO)
@Code
    ViewData("Title") = "VueMoreInfo"
End Code


<h2>ViewMoreDetails</h2>

<div>
    <h4>FullActorDTO</h4>
    <hr />
    <table>

        @For Each item In Model
        @<tr>
            <td>
                @Html.DisplayFor(Function(modelItem) item.Title)
            </td>
            <td  >
                <img src=@item.Posterpath alt="Pas d'image" />
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.Runtime)   |         
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.ReleaseDate)
            </td>
        </tr>
        Next

    </table>
</div>
<p>
    @*@Html.ActionLink("Edit", "Edit", New With {.id = Model.PrimaryKey}) |*@
    @Html.ActionLink("Back to List", "Index")
</p>
