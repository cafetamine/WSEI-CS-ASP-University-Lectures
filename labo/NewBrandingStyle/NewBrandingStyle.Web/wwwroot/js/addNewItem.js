(function () {
    const alertElement = document.getElementById("success-alert");
    const formElement = document.forms[0];

    const addNewItem = async () => await fetch('api/item', {
                method: 'POST',
                headers: {'Content-Type': 'application/json'},
                body: JSON.stringify({
                    name: formElement['Name'].value,
                    description: formElement['Description'].value,
                    isVisible: formElement['IsVisible'][0].checked
                })
        })
        .then(response => {
            if (response.ok) {
                alertElement.style = 'display: block';
            }
            return response;
        })
        .then(response => response.json())
        .catch(console.error);

    window.addEventListener('load', () => {
        formElement.addEventListener('submit', event => {
            event.preventDefault();
            addNewItem().then(() => console.log(`added successfully`))
        });
    });
}) ();
