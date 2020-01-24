<!-- Exemplo de View usando DropDownList com uma lista estática -->
@ModelType PartyInvites.PartyInvites.Models.GuestResponse

@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>RsvpForm</title>
</head>
<body>
    @Using Html.BeginForm()
        @<text>
        
            <p>Your Name: @Html.TextBoxFor(Function(m) m.Name)</p>
            <p>Your Phone: @Html.TextBoxFor(Function(m) m.Phone)</p>
            <p>Your Email: @Html.TextBoxFor(Function(m) m.Email)</p>
            <p>Will you attend?
               @Html.DropDownListFor(Function(m) m.WillAttend, New List(Of SelectListItem) From {
                                                                                New SelectListItem() With {.Text = "Yes, I'll attend", .Value = Boolean.TrueString},
                                                                                New SelectListItem() With {.Text = "No, I can't come", .Value = Boolean.FalseString}}, "Choose an option")
            </p>
            <input type="submit" value="Submit RSVP"/>
        
        </text>
    End Using
</body>
</html>
