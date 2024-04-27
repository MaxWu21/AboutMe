fetch('http://localhost:5273/api/MyInfo')
    .then(response => response.json())
    .then(data => {
        const myInfo = data.message;
        console.log(myInfo);
        const infoContainer = document.getElementById('info-container');
        infoContainer.innerHTML = myInfo;
    })
    .catch(error => {
        console.error('Error fetching data: ', error);
    });