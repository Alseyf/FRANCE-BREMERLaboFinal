@ModelType IEnumerable(Of DTO.FullActorDTO)
@Code
    ViewData("Title") = "VueActeurs"
End Code


    @*<style type="text/css">
        .container > * {
            position: absolute;
        }

        .container, .crop {
            height: 70px;
        }

        .crop {
            overflow: hidden;
        }
    </style>*@

<table class="table">
    <tr>
        @*<th>
                @Html.DisplayNameFor(Function(model) model.Name)
            </th>*@
        <th></th>
    </tr>

    @For Each item In Model

        @<tr>

            <td>
                @Html.DisplayFor(Function(modelItem) item.Name)
            </td>
            <td>
                    @*@<div class="container">
                        <img src="https://i.stack.imgur.com/yiT2y.png" />
                        <!-- the width could be calculated either at server or client side, or define in css -->
                        <div class="crop" style="width: 180px">
                            <img src="https://i.stack.imgur.com/oTi9e.png" />
                        </div>
                    </div>*@

                @Html.ActionLink("Details", "ViewMoreDetails", New With {.id = item.idActor}) |

            </td>
            <td>
                @Html.ActionLink("Commentaires", "ViewCommentaire", New With {.id = item.idActor}) |    


            </td>
        </tr>
    Next

</table>
@Html.ActionLink("Moins", "VueActeurs", New With {.inc = 1}) |
@Html.ActionLink("Plus", "VueActeurs", New With {.inc = 0}) |


