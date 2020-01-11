@Code
    ViewData("Title") = "About"


End Code

<h2>@ViewData("Title").</h2>
<h3>@ViewData("Message")</h3>

<h3>
    @ViewData("test")[1]
</h3>





    @*<ul>
            @For (Int() i = 0 ; i++ ; i<10)
            {
                <li>@ViewData("test")[i]</li>
            }
        </ul>*@


    <p>Use this area To provide additional information.</p>
